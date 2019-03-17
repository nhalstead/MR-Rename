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
        private PreviewWindow pre;
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
        }

        public string getDir() {
            if (this.resultDialog == DialogResult.OK && !string.IsNullOrWhiteSpace(this.selctFolder.SelectedPath))
            {
                return this.selctFolder.SelectedPath;
            }
            return "";
        }

        /**
         * Truncate String to a set Length.
         * This has been modified to add `...` if it was
         *  adjusted in length.
         * @link https://stackoverflow.com/a/2776689/5779200
         */
        public string Truncate(string value, int maxLength) {
            if (string.IsNullOrEmpty(value)) return value;
            string t = value.Length <= maxLength ? value : value.Substring(0, maxLength);
            if (value.Length != t.Length) t += "...";
            return t;
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

        private void preveiwInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            // Check to see if the Regex is Valid.
            if (VerifyRegEx(regexFind.Text) != true)
            {
                previewResult.Text = "<Invalid Regex Match>";
                return;
            }
            else { previewResult.Text = ""; }

            // Check to see if the Input String is Matching the Regex
            Match m = Regex.Match(preveiwInput.Text, regexFind.Text);
            if (m.Success != true)
            {
                previewResult.Text = "<No Regex Match>";
                return;
            }
            else { previewResult.Text = ""; }


            // Apply the Regex Rename Part, This is the Part 2 of the Rename
            previewResult.Text = m.Groups.Count.ToString();
            previewResult.Text = Regex.Replace(preveiwInput.Text, regexFind.Text, outputReplacement.Text);
        }

        private void loadFiles()
        {
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

        private List<FileChanges> getDataList()
        {
            List<FileChanges> t = new List<FileChanges>();
            string root = this.getDir();

            foreach (string file in files.ToArray())
            {
                // Skip if the File does not Match the Rename Input
                Match m = Regex.Match(file, regexFind.Text);
                if (m.Success != true) continue;

                FileChanges row = new FileChanges();

                row.RootDir = root + "\\";
                row.Before = file;
                row.BeforeName = Path.GetFileName(file);
                string fileNew = Regex.Replace(row.BeforeName, this.regexFind.Text, this.outputReplacement.Text);

                row.After = row.Before.Replace(row.BeforeName, "") + fileNew;
                row.AfterName = fileNew;

                t.Add(row);
            }

            return t;
        }

        private void previewWindowOpen_Click(object sender, EventArgs e)
        {
            if (this.getDir() == "")
            {
                this.setStatus("Please Select a Directory");
                return;
            }

            // Populate the Database of File Names and Paths for Processing
            this.loadFiles();

            if(this.pre != null)
            {
                // The window is open, Bring to Front/Top Most
                this.pre.BringToFront();
                this.pre.LoadData(this.getDataList());
            }
            else
            {
                // Window is Not Open, Create it and Open it.
                this.pre = new PreviewWindow(this);
                this.pre.BringToFront();
                this.pre.Show();
                this.pre.LoadData(this.getDataList());
            }
        }

        public void ClosePreveiw() {
            this.setStatus("Closed Preview Window");
            this.pre.Hide();
            this.pre.Dispose();
            this.pre = null;
        }

        public void ApplyRenameProcess()
        {
            this.ClosePreveiw();

            foreach(FileChanges file in this.getDataList().ToArray())
            {

                this.setStatus("Renaming " + file.BeforeName + " to " + file.AfterName);

                if (File.Exists(file.Before) == false)
                {
                    this.errLog.Add("Skip due to the File does not exist since the last file scan!");
                    continue;
                }

                if (file.Before == file.After)
                {
                    this.errLog.Add("Skip due to the Names being the Same!");
                    continue;
                }

                try
                {
                    // Catch for Failed to Move file.
                    File.Move(file.Before, file.After);
                }
                catch (Exception e)
                {
                    failedToMove++;
                    this.errLog.Add("Can not Move file, It may be in use!");
                    this.errLog.Add("    " + file.Before);
                }
                
            }
            this.setStatus("Completed the Rename Process");

            MessageBox.Show("Files have been Renamed. Process is Done!");
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
