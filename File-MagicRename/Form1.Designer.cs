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
            this.selectFolder = new System.Windows.Forms.Button();
            this.previewWindowOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regexFind = new System.Windows.Forms.TextBox();
            this.outputReplacement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.preveiwInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.previewResult = new System.Windows.Forms.TextBox();
            this.dirSelected = new System.Windows.Forms.Label();
            this.renameProgress = new System.Windows.Forms.ProgressBar();
            this.renameProgressLable = new System.Windows.Forms.Label();
            this.includeSubDir = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(225, 50);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(114, 42);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // previewWindowOpen
            // 
            this.previewWindowOpen.Location = new System.Drawing.Point(225, 305);
            this.previewWindowOpen.Name = "previewWindowOpen";
            this.previewWindowOpen.Size = new System.Drawing.Size(114, 42);
            this.previewWindowOpen.TabIndex = 1;
            this.previewWindowOpen.Text = "Preview Changes";
            this.previewWindowOpen.UseVisualStyleBackColor = true;
            this.previewWindowOpen.Click += new System.EventHandler(this.previewWindowOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Folder with Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(26, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preview File Name Changes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rename Scheme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Find Files that Match";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rename to";
            // 
            // regexFind
            // 
            this.regexFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.regexFind.Location = new System.Drawing.Point(87, 178);
            this.regexFind.Name = "regexFind";
            this.regexFind.Size = new System.Drawing.Size(177, 21);
            this.regexFind.TabIndex = 8;
            this.regexFind.TextChanged += new System.EventHandler(this.regexFind_TextChanged);
            // 
            // outputReplacement
            // 
            this.outputReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.outputReplacement.Location = new System.Drawing.Point(313, 178);
            this.outputReplacement.Name = "outputReplacement";
            this.outputReplacement.Size = new System.Drawing.Size(164, 21);
            this.outputReplacement.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(270, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "--->";
            // 
            // preveiwInput
            // 
            this.preveiwInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.preveiwInput.Location = new System.Drawing.Point(87, 216);
            this.preveiwInput.Name = "preveiwInput";
            this.preveiwInput.Size = new System.Drawing.Size(177, 21);
            this.preveiwInput.TabIndex = 12;
            this.preveiwInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.preveiwInput_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(270, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "--->";
            // 
            // previewResult
            // 
            this.previewResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.previewResult.Location = new System.Drawing.Point(313, 217);
            this.previewResult.Name = "previewResult";
            this.previewResult.ReadOnly = true;
            this.previewResult.Size = new System.Drawing.Size(164, 21);
            this.previewResult.TabIndex = 14;
            // 
            // dirSelected
            // 
            this.dirSelected.AutoSize = true;
            this.dirSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dirSelected.Location = new System.Drawing.Point(39, 97);
            this.dirSelected.Name = "dirSelected";
            this.dirSelected.Size = new System.Drawing.Size(51, 15);
            this.dirSelected.TabIndex = 15;
            this.dirSelected.Text = "<None>";
            // 
            // renameProgress
            // 
            this.renameProgress.Location = new System.Drawing.Point(209, 365);
            this.renameProgress.Name = "renameProgress";
            this.renameProgress.Size = new System.Drawing.Size(178, 23);
            this.renameProgress.TabIndex = 16;
            // 
            // renameProgressLable
            // 
            this.renameProgressLable.AutoSize = true;
            this.renameProgressLable.Location = new System.Drawing.Point(177, 371);
            this.renameProgressLable.Name = "renameProgressLable";
            this.renameProgressLable.Size = new System.Drawing.Size(30, 13);
            this.renameProgressLable.TabIndex = 17;
            this.renameProgressLable.Text = "0 / 0";
            // 
            // includeSubDir
            // 
            this.includeSubDir.AutoSize = true;
            this.includeSubDir.Location = new System.Drawing.Point(355, 50);
            this.includeSubDir.Name = "includeSubDir";
            this.includeSubDir.Size = new System.Drawing.Size(104, 17);
            this.includeSubDir.TabIndex = 18;
            this.includeSubDir.Text = "Include Sub Dirs";
            this.includeSubDir.UseVisualStyleBackColor = true;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(150, 129);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Online Regex Tool";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FileRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 425);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.includeSubDir);
            this.Controls.Add(this.renameProgressLable);
            this.Controls.Add(this.renameProgress);
            this.Controls.Add(this.dirSelected);
            this.Controls.Add(this.previewResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.preveiwInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputReplacement);
            this.Controls.Add(this.regexFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewWindowOpen);
            this.Controls.Add(this.selectFolder);
            this.Name = "FileRename";
            this.Text = "File Rename Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button previewWindowOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regexFind;
        private System.Windows.Forms.TextBox outputReplacement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox preveiwInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox previewResult;
        private System.Windows.Forms.Label dirSelected;
        private System.Windows.Forms.ProgressBar renameProgress;
        private System.Windows.Forms.Label renameProgressLable;
        private System.Windows.Forms.CheckBox includeSubDir;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

