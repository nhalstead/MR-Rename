using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_MagicRename
{
    public partial class PreviewWindow : Form
    {
        private FileRename ParentWindow;

        public PreviewWindow(FileRename parent)
        {
            this.ParentWindow = parent;
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(List<FileChanges> files)
        {
            this.fileDisplay.Rows.Clear();
            this.fileDisplay.Refresh();

            foreach (FileChanges file in files.ToArray())
            {
                this.fileDisplay.Rows.Add(file.BeforeName, file.AfterName);
            }
            this.fileDisplay.Refresh();
            ParentWindow.setStatus("Showing Preview");
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            this.ParentWindow.ApplyRenameProcess();
        }
    }
}
