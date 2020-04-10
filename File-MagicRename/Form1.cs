using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK.Libraries.BetterFolderBrowserNS;

namespace File_MagicRename
{
    public partial class FileRename : Form
    {

        public BetterFolderBrowser selctFolder;
        public DialogResult resultDialog;
        private EventLog evt;
        private List<string> files = new List<string>();
        public int failedToMove;
        public List<string> errLog = new List<string>();

        public FileRename()
        {
            InitializeComponent();
            this.setStatus("");
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            this.errLog.Add("Open Folder Select Dialog");
            this.selctFolder = new BetterFolderBrowser();
            this.resultDialog = this.selctFolder.ShowDialog();

            this.errLog.Add("Folder Selected");
            this.errLog.Add("    " + this.getDir());
            this.dirSelected.Text = Truncate(this.getDir(), 64);
            this.loadFiles();
            this.renderFileToTable();
        }

        public string getDir() {
            if (this.resultDialog == DialogResult.OK && !string.IsNullOrWhiteSpace(this.selctFolder.SelectedPath))
            {
                return this.selctFolder.SelectedPath;
            }
            return "";
        }

        /**
         * Truncate String to a set Length from the left side.
         * 
         */
        public string Truncate(string value, int maxLength) {
            if (value.Length <= maxLength || string.IsNullOrEmpty(value)) return value;

            // String is longer than maxLength
            int startPosition = value.Length - maxLength;

            if(startPosition >= 4) startPosition = startPosition - 3;
            return "..." + value.Substring(startPosition, value.Length);
        }

        public static bool VerifyRegEx(string testPattern)
        {
            bool isValid = true;

            if ((testPattern != null) && (testPattern.Trim().Length > 0))
            {
                try
                {
                    Regex.Match("", testPattern);
                }
                catch (ArgumentException)
                {
                    // BAD PATTERN: Syntax error
                    isValid = false;
                }
            }
            else
            {
                //BAD PATTERN: Pattern is null or blank
                isValid = false;
            }

            return (isValid);
        }

        private void regexFind_TextChanged(object sender, EventArgs e)
        {
            if (regexFind.Text == "") {
                regexFind.BackColor = Color.Aqua;
            }
            else if(VerifyRegEx(regexFind.Text) == true)
            {
                regexFind.BackColor = Color.LightGreen;
            }
            else
            {
                regexFind.BackColor = Color.OrangeRed;
            }
        }
        
        public void setStatus(string stat)
        {
            this.errLog.Add("Setting Status: " + stat);
            this.status.Text = Truncate(stat, 128);
        }

        private void loadFiles()
        {
            if (string.IsNullOrEmpty(this.getDir())) return;
            this.files.Clear();

            SearchOption extra = SearchOption.TopDirectoryOnly;
            if(includeSubDir.Checked == true)
            {
                extra = SearchOption.AllDirectories;
            }

            this.setStatus("Getting all files in " + this.getDir());
            string[] filePaths = Directory.GetFiles(this.getDir(), "*", extra);

            this.setStatus("Sorting Filenames based on Regex");
            foreach (string file in filePaths)
            {
                this.files.Add(file);
            }
        }

        private void renderFileToTable()
        {
            Dictionary<string, string> regexList = getFileRegexName();

            this.fileList.Rows.Clear();
            foreach (string filePath in this.files)
            {
                int index = this.fileList.Rows.Add();
                DataGridViewRow row = (DataGridViewRow)this.fileList.Rows[index];
                row.Cells[0].Value = filePath;
                row.Cells[1].Value = Path.GetFileName(filePath);

                // Check to see if the File Regex Has the Filename in its list and has been changed.
                string newEntry = regexList[filePath];
                if (string.IsNullOrEmpty(newEntry) || newEntry == filePath) continue;

                row.Cells[1].Style.BackColor = Color.LightGreen;
                row.Cells[2].Style.BackColor = Color.LightGreen;
                row.Cells[3].Style.BackColor = Color.LightGreen;

                row.Cells[2].Value = true;
                row.Cells[3].Value = Path.GetFileName(newEntry);
            }

        }

        private Dictionary<string, string> getFileRegexName()
        {
            Dictionary<string, string> changes = new Dictionary<string, string>();

            foreach (string filePath in this.files)
            {
                string filename = Path.GetFileName(filePath);

                Match m = Regex.Match(filename, regexFind.Text);
                if (m.Success != true)
                {
                    changes.Add(filePath, "");
                    continue;
                }

                string fileNew = Regex.Replace(filename, this.regexFind.Text, this.outputReplacement.Text);
                string filePathNew = filePath.Replace(filename, "") + fileNew;

                changes.Add(filePath, filePathNew);
            }

            return changes;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.setStatus("Open Regex101 Example Link");
            Process.Start("https://regex101.com/r/E2Bazv/1");
        }

        private void FileRename_Load(object sender, EventArgs e)
        {

        }

        private void openEventLog_Click(object sender, EventArgs e)
        {
            this.setStatus("Open Event Log Window");
            if (this.evt != null)
            {
                // The window is open, Bring to Front/Top Most
                this.evt.BringToFront();
            }
            else
            {
                // Window is Not Open, Create it and Open it.
                this.evt = new EventLog(this);
                this.evt.BringToFront();
                this.evt.Show();
            }
        }

        public void CloseEventLog()
        {
            this.setStatus("Closed Event Log Window");
            this.evt.Hide();
            this.evt.Dispose();
            this.evt = null;
        }

        private void includeSubDir_CheckedChanged(object sender, EventArgs e)
        {
            this.loadFiles();
        }

        private void previewWindowOpen_Click(object sender, EventArgs e)
        {
            this.renderFileToTable();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> entries = this.getFileRegexName();
            this.renameProgress.Maximum = entries.Count();

            foreach (KeyValuePair<string, string> entry in entries)
            {
                this.renameProgress.Value = this.renameProgress.Value + 1;
                if (File.Exists(entry.Key) == false)
                {
                    this.errLog.Add("Skip due to the File does not exist since the last file scan!");
                    continue;
                }

                if (string.IsNullOrEmpty(entry.Value))
                {
                    this.errLog.Add("Skip due to the Names being the Same!");
                    continue;
                }

                try
                {
                    // Catch for Failed to Move file.
                    File.Move(entry.Key, entry.Value);
                }
                catch (Exception err)
                {
                    failedToMove++;
                    this.errLog.Add("Can not Move file, It may be in use!");
                    this.errLog.Add("    " + entry.Key);
                    this.errLog.Add("    " + err.Message);
                }

            }
            this.setStatus("Completed the Rename Process");

            MessageBox.Show("Files have been Renamed. Process is Done!");
        }
    }

    public class FileChanges
    {
        public string Before; // The Fill Filename before the Rename
        public string BeforeName; // Used to Show ONLY the Filename

        public string After; // The Full Filename after the Rename
        public string AfterName; // Used to Show ONLY the Filename

        public string RootDir; // Location to Trim off of the Filename
    }
}
