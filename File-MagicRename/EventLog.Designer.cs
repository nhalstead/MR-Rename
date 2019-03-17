namespace File_MagicRename
{
    partial class EventLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.errDisplay = new System.Windows.Forms.DataGridView();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // errDisplay
            // 
            this.errDisplay.AllowUserToAddRows = false;
            this.errDisplay.AllowUserToDeleteRows = false;
            this.errDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filename});
            this.errDisplay.Location = new System.Drawing.Point(12, 12);
            this.errDisplay.MultiSelect = false;
            this.errDisplay.Name = "errDisplay";
            this.errDisplay.ReadOnly = true;
            this.errDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.errDisplay.RowHeadersVisible = false;
            this.errDisplay.Size = new System.Drawing.Size(600, 489);
            this.errDisplay.TabIndex = 1;
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Log Message";
            this.Filename.MinimumWidth = 596;
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            this.Filename.Width = 596;
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(12, 507);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(114, 42);
            this.selectFolder.TabIndex = 3;
            this.selectFolder.Text = "Reload Log";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // EventLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.errDisplay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 600);
            this.Name = "EventLog";
            this.ShowIcon = false;
            this.Text = "EventLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventLog_FormClosing);
            this.Load += new System.EventHandler(this.EventLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView errDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.Button selectFolder;
    }
}