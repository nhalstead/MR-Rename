namespace File_MagicRename
{
    partial class FileRename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileRename));
            this.selectFolder = new System.Windows.Forms.Button();
            this.previewWindowOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regexFind = new System.Windows.Forms.TextBox();
            this.dirSelected = new System.Windows.Forms.Label();
            this.renameProgress = new System.Windows.Forms.ProgressBar();
            this.renameProgressLable = new System.Windows.Forms.Label();
            this.includeSubDir = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.Label();
            this.openEventLog = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.DataGridView();
            this.fullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outputName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputReplacement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(60, 45);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(114, 42);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // previewWindowOpen
            // 
            this.previewWindowOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewWindowOpen.Location = new System.Drawing.Point(566, 105);
            this.previewWindowOpen.Name = "previewWindowOpen";
            this.previewWindowOpen.Size = new System.Drawing.Size(92, 52);
            this.previewWindowOpen.TabIndex = 1;
            this.previewWindowOpen.Text = "Preview Changes";
            this.previewWindowOpen.UseVisualStyleBackColor = true;
            this.previewWindowOpen.Click += new System.EventHandler(this.previewWindowOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Folder with Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "REXEG";
            // 
            // regexFind
            // 
            this.regexFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regexFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.regexFind.Location = new System.Drawing.Point(100, 105);
            this.regexFind.Name = "regexFind";
            this.regexFind.Size = new System.Drawing.Size(450, 23);
            this.regexFind.TabIndex = 8;
            this.regexFind.TextChanged += new System.EventHandler(this.regexFind_TextChanged);
            // 
            // dirSelected
            // 
            this.dirSelected.AutoSize = true;
            this.dirSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dirSelected.Location = new System.Drawing.Point(192, 11);
            this.dirSelected.Name = "dirSelected";
            this.dirSelected.Size = new System.Drawing.Size(51, 15);
            this.dirSelected.TabIndex = 15;
            this.dirSelected.Text = "<None>";
            // 
            // renameProgress
            // 
            this.renameProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameProgress.Location = new System.Drawing.Point(47, 653);
            this.renameProgress.Name = "renameProgress";
            this.renameProgress.Size = new System.Drawing.Size(439, 23);
            this.renameProgress.TabIndex = 16;
            // 
            // renameProgressLable
            // 
            this.renameProgressLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameProgressLable.AutoSize = true;
            this.renameProgressLable.Location = new System.Drawing.Point(14, 659);
            this.renameProgressLable.Name = "renameProgressLable";
            this.renameProgressLable.Size = new System.Drawing.Size(30, 13);
            this.renameProgressLable.TabIndex = 17;
            this.renameProgressLable.Text = "0 / 0";
            // 
            // includeSubDir
            // 
            this.includeSubDir.AutoSize = true;
            this.includeSubDir.Location = new System.Drawing.Point(180, 59);
            this.includeSubDir.Name = "includeSubDir";
            this.includeSubDir.Size = new System.Drawing.Size(104, 17);
            this.includeSubDir.TabIndex = 18;
            this.includeSubDir.Text = "Include Sub Dirs";
            this.includeSubDir.UseVisualStyleBackColor = true;
            this.includeSubDir.CheckedChanged += new System.EventHandler(this.includeSubDir_CheckedChanged);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(11, 403);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(19, 13);
            this.status.TabIndex = 19;
            this.status.Text = "....";
            // 
            // openEventLog
            // 
            this.openEventLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openEventLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openEventLog.ForeColor = System.Drawing.SystemColors.Control;
            this.openEventLog.Location = new System.Drawing.Point(654, 671);
            this.openEventLog.Name = "openEventLog";
            this.openEventLog.Size = new System.Drawing.Size(20, 20);
            this.openEventLog.TabIndex = 21;
            this.openEventLog.UseVisualStyleBackColor = true;
            this.openEventLog.Click += new System.EventHandler(this.openEventLog_Click);
            // 
            // apply
            // 
            this.apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apply.Location = new System.Drawing.Point(513, 643);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(114, 35);
            this.apply.TabIndex = 22;
            this.apply.Text = "Apply Changes";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // fileList
            // 
            this.fileList.AllowUserToAddRows = false;
            this.fileList.AllowUserToDeleteRows = false;
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullPath,
            this.filename,
            this.detected,
            this.outputName});
            this.fileList.Location = new System.Drawing.Point(12, 166);
            this.fileList.Name = "fileList";
            this.fileList.ReadOnly = true;
            this.fileList.RowHeadersVisible = false;
            this.fileList.Size = new System.Drawing.Size(646, 471);
            this.fileList.TabIndex = 23;
            // 
            // fullPath
            // 
            this.fullPath.HeaderText = "Full Path";
            this.fullPath.Name = "fullPath";
            this.fullPath.ReadOnly = true;
            this.fullPath.Visible = false;
            // 
            // filename
            // 
            this.filename.HeaderText = "Filename";
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            this.filename.Width = 290;
            // 
            // detected
            // 
            this.detected.HeaderText = "Detected";
            this.detected.Name = "detected";
            this.detected.ReadOnly = true;
            this.detected.Width = 60;
            // 
            // outputName
            // 
            this.outputName.HeaderText = "Output Name";
            this.outputName.Name = "outputName";
            this.outputName.ReadOnly = true;
            this.outputName.Width = 290;
            // 
            // outputReplacement
            // 
            this.outputReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outputReplacement.Location = new System.Drawing.Point(100, 134);
            this.outputReplacement.Name = "outputReplacement";
            this.outputReplacement.Size = new System.Drawing.Size(450, 23);
            this.outputReplacement.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(17, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "REPLACE";
            // 
            // FileRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 688);
            this.Controls.Add(this.outputReplacement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.openEventLog);
            this.Controls.Add(this.status);
            this.Controls.Add(this.includeSubDir);
            this.Controls.Add(this.renameProgressLable);
            this.Controls.Add(this.renameProgress);
            this.Controls.Add(this.dirSelected);
            this.Controls.Add(this.regexFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewWindowOpen);
            this.Controls.Add(this.selectFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 464);
            this.Name = "FileRename";
            this.Text = "File Rename Tool";
            this.Load += new System.EventHandler(this.FileRename_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button previewWindowOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regexFind;
        private System.Windows.Forms.Label dirSelected;
        private System.Windows.Forms.ProgressBar renameProgress;
        private System.Windows.Forms.Label renameProgressLable;
        private System.Windows.Forms.CheckBox includeSubDir;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button openEventLog;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.DataGridView fileList;
        private System.Windows.Forms.TextBox outputReplacement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewCheckBoxColumn detected;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputName;
    }
}

