namespace File_MagicRename
{
    partial class PreviewWindow
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
            this.fileDisplay = new System.Windows.Forms.DataGridView();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // fileDisplay
            // 
            this.fileDisplay.AllowUserToAddRows = false;
            this.fileDisplay.AllowUserToDeleteRows = false;
            this.fileDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filename,
            this.newName});
            this.fileDisplay.Location = new System.Drawing.Point(12, 12);
            this.fileDisplay.MultiSelect = false;
            this.fileDisplay.Name = "fileDisplay";
            this.fileDisplay.ReadOnly = true;
            this.fileDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fileDisplay.RowHeadersVisible = false;
            this.fileDisplay.Size = new System.Drawing.Size(600, 489);
            this.fileDisplay.TabIndex = 0;
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Source Filename";
            this.Filename.MinimumWidth = 298;
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            this.Filename.Width = 298;
            // 
            // newName
            // 
            this.newName.HeaderText = "New Filename";
            this.newName.MinimumWidth = 298;
            this.newName.Name = "newName";
            this.newName.ReadOnly = true;
            this.newName.Width = 298;
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(12, 507);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(114, 42);
            this.selectFolder.TabIndex = 2;
            this.selectFolder.Text = "Apply Rename";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // PreviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.fileDisplay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 600);
            this.MinimumSize = new System.Drawing.Size(640, 600);
            this.Name = "PreviewWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preview Changes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreviewWindow_FormClosing);
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fileDisplay;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn newName;
    }
}