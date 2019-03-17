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
    public partial class EventLog : Form
    {
        private FileRename ParentWindow;

        public EventLog(FileRename parent)
        {
            this.ParentWindow = parent;
            InitializeComponent();
        }

        private void EventLog_Load(object sender, EventArgs e)
        {
            updateLogList();
        }

        private void updateLogList()
        {
            this.errDisplay.Rows.Clear();
            this.errDisplay.Refresh();

            foreach (string file in ParentWindow.errLog.ToArray())
            {
                this.errDisplay.Rows.Add(file);
            }
            this.errDisplay.Refresh();

            this.errDisplay.FirstDisplayedScrollingRowIndex = this.errDisplay.RowCount - 1;
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            updateLogList();
        }

        private void EventLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ParentWindow.CloseEventLog();
            e.Cancel = true;
        }
    }
}
