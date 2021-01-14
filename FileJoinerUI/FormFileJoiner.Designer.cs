
namespace FileJoinerUI
{
    partial class FormFileJoiner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LblFileJoinerTitle = new System.Windows.Forms.Label();
            this.lblFilesToJoin = new System.Windows.Forms.Label();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.checkBoxNewLines = new System.Windows.Forms.CheckBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.checkBoxAllTextFiles = new System.Windows.Forms.CheckBox();
            this.textBoxNewLines = new System.Windows.Forms.TextBox();
            this.labelNewLines = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblOutputFileName = new System.Windows.Forms.Label();
            this.textBoxOutputFileName = new System.Windows.Forms.TextBox();
            this.btnSetOuputFolder = new System.Windows.Forms.Button();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.btnClearFiles = new System.Windows.Forms.Button();
            this.btnFileUp = new System.Windows.Forms.Button();
            this.btnFileDown = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 17;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 65);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFiles.Size = new System.Drawing.Size(296, 395);
            this.listBoxFiles.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "File Joiner - Add Files";
            // 
            // LblFileJoinerTitle
            // 
            this.LblFileJoinerTitle.AutoSize = true;
            this.LblFileJoinerTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFileJoinerTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblFileJoinerTitle.Location = new System.Drawing.Point(12, 9);
            this.LblFileJoinerTitle.Name = "LblFileJoinerTitle";
            this.LblFileJoinerTitle.Size = new System.Drawing.Size(88, 21);
            this.LblFileJoinerTitle.TabIndex = 1;
            this.LblFileJoinerTitle.Text = "File Joiner";
            // 
            // lblFilesToJoin
            // 
            this.lblFilesToJoin.AutoSize = true;
            this.lblFilesToJoin.Location = new System.Drawing.Point(12, 42);
            this.lblFilesToJoin.Name = "lblFilesToJoin";
            this.lblFilesToJoin.Size = new System.Drawing.Size(99, 21);
            this.lblFilesToJoin.TabIndex = 2;
            this.lblFilesToJoin.Text = "Files to Join:";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFiles.Location = new System.Drawing.Point(7, 320);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(152, 42);
            this.btnAddFiles.TabIndex = 3;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(7, 366);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 44);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Selected Files";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // checkBoxNewLines
            // 
            this.checkBoxNewLines.AutoSize = true;
            this.checkBoxNewLines.Enabled = false;
            this.checkBoxNewLines.Location = new System.Drawing.Point(6, 46);
            this.checkBoxNewLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNewLines.Name = "checkBoxNewLines";
            this.checkBoxNewLines.Size = new System.Drawing.Size(234, 25);
            this.checkBoxNewLines.TabIndex = 5;
            this.checkBoxNewLines.Text = "Add a newline between files";
            this.checkBoxNewLines.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJoin.ForeColor = System.Drawing.Color.Blue;
            this.btnJoin.Location = new System.Drawing.Point(7, 224);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(152, 42);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "Join Files";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(12, 474);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(252, 21);
            this.linkLabelGitHub.TabIndex = 36;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/JoyfulReaper";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // checkBoxAllTextFiles
            // 
            this.checkBoxAllTextFiles.AutoSize = true;
            this.checkBoxAllTextFiles.Location = new System.Drawing.Point(6, 26);
            this.checkBoxAllTextFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllTextFiles.Name = "checkBoxAllTextFiles";
            this.checkBoxAllTextFiles.Size = new System.Drawing.Size(261, 25);
            this.checkBoxAllTextFiles.TabIndex = 37;
            this.checkBoxAllTextFiles.Text = "All of my files are plain text files";
            this.checkBoxAllTextFiles.UseVisualStyleBackColor = true;
            this.checkBoxAllTextFiles.CheckedChanged += new System.EventHandler(this.checkBoxAllTextFiles_CheckedChanged);
            // 
            // textBoxNewLines
            // 
            this.textBoxNewLines.Enabled = false;
            this.textBoxNewLines.Location = new System.Drawing.Point(203, 85);
            this.textBoxNewLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewLines.Name = "textBoxNewLines";
            this.textBoxNewLines.Size = new System.Drawing.Size(66, 29);
            this.textBoxNewLines.TabIndex = 38;
            this.textBoxNewLines.Text = "1";
            // 
            // labelNewLines
            // 
            this.labelNewLines.AutoSize = true;
            this.labelNewLines.Location = new System.Drawing.Point(7, 88);
            this.labelNewLines.Name = "labelNewLines";
            this.labelNewLines.Size = new System.Drawing.Size(186, 21);
            this.labelNewLines.TabIndex = 39;
            this.labelNewLines.Text = "NewLines between files:";
            // 
            // lblOutputFileName
            // 
            this.lblOutputFileName.AutoSize = true;
            this.lblOutputFileName.ForeColor = System.Drawing.Color.Blue;
            this.lblOutputFileName.Location = new System.Drawing.Point(7, 127);
            this.lblOutputFileName.Name = "lblOutputFileName";
            this.lblOutputFileName.Size = new System.Drawing.Size(129, 21);
            this.lblOutputFileName.TabIndex = 40;
            this.lblOutputFileName.Text = "Ouput Filename:";
            // 
            // textBoxOutputFileName
            // 
            this.textBoxOutputFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOutputFileName.Location = new System.Drawing.Point(6, 167);
            this.textBoxOutputFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutputFileName.Name = "textBoxOutputFileName";
            this.textBoxOutputFileName.Size = new System.Drawing.Size(187, 25);
            this.textBoxOutputFileName.TabIndex = 41;
            this.textBoxOutputFileName.Text = "output.file";
            // 
            // btnSetOuputFolder
            // 
            this.btnSetOuputFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetOuputFolder.Location = new System.Drawing.Point(7, 271);
            this.btnSetOuputFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetOuputFolder.Name = "btnSetOuputFolder";
            this.btnSetOuputFolder.Size = new System.Drawing.Size(152, 42);
            this.btnSetOuputFolder.TabIndex = 42;
            this.btnSetOuputFolder.Text = "Set Output Folder";
            this.btnSetOuputFolder.UseVisualStyleBackColor = true;
            this.btnSetOuputFolder.Click += new System.EventHandler(this.btnSetOuputFolder_Click);
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutputFolder.ForeColor = System.Drawing.Color.Blue;
            this.lblOutputFolder.Location = new System.Drawing.Point(6, 148);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(51, 17);
            this.lblOutputFolder.TabIndex = 43;
            this.lblOutputFolder.Text = "{folder}";
            // 
            // btnClearFiles
            // 
            this.btnClearFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFiles.Location = new System.Drawing.Point(6, 414);
            this.btnClearFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearFiles.Name = "btnClearFiles";
            this.btnClearFiles.Size = new System.Drawing.Size(152, 42);
            this.btnClearFiles.TabIndex = 44;
            this.btnClearFiles.Text = "Remove all files";
            this.btnClearFiles.UseVisualStyleBackColor = true;
            this.btnClearFiles.Click += new System.EventHandler(this.btnClearFiles_Click);
            // 
            // btnFileUp
            // 
            this.btnFileUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFileUp.Location = new System.Drawing.Point(314, 220);
            this.btnFileUp.Name = "btnFileUp";
            this.btnFileUp.Size = new System.Drawing.Size(35, 29);
            this.btnFileUp.TabIndex = 45;
            this.btnFileUp.Text = "Λ";
            this.btnFileUp.UseVisualStyleBackColor = true;
            this.btnFileUp.Click += new System.EventHandler(this.btnFileUp_Click);
            // 
            // btnFileDown
            // 
            this.btnFileDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFileDown.Location = new System.Drawing.Point(314, 255);
            this.btnFileDown.Name = "btnFileDown";
            this.btnFileDown.Size = new System.Drawing.Size(35, 29);
            this.btnFileDown.TabIndex = 46;
            this.btnFileDown.Text = "V";
            this.btnFileDown.UseVisualStyleBackColor = true;
            this.btnFileDown.Click += new System.EventHandler(this.btnFileDown_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.checkBoxAllTextFiles);
            this.groupBox.Controls.Add(this.btnAddFiles);
            this.groupBox.Controls.Add(this.btnRemove);
            this.groupBox.Controls.Add(this.btnClearFiles);
            this.groupBox.Controls.Add(this.checkBoxNewLines);
            this.groupBox.Controls.Add(this.lblOutputFolder);
            this.groupBox.Controls.Add(this.btnJoin);
            this.groupBox.Controls.Add(this.btnSetOuputFolder);
            this.groupBox.Controls.Add(this.textBoxNewLines);
            this.groupBox.Controls.Add(this.textBoxOutputFileName);
            this.groupBox.Controls.Add(this.labelNewLines);
            this.groupBox.Controls.Add(this.lblOutputFileName);
            this.groupBox.Location = new System.Drawing.Point(367, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(570, 460);
            this.groupBox.TabIndex = 47;
            this.groupBox.TabStop = false;
            // 
            // FormFileJoiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 504);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnFileDown);
            this.Controls.Add(this.btnFileUp);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.lblFilesToJoin);
            this.Controls.Add(this.LblFileJoinerTitle);
            this.Controls.Add(this.listBoxFiles);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "FormFileJoiner";
            this.Text = "File Joiner";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label LblFileJoinerTitle;
        private System.Windows.Forms.Label lblFilesToJoin;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox checkBoxNewLines;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.CheckBox checkBoxAllTextFiles;
        private System.Windows.Forms.TextBox textBoxNewLines;
        private System.Windows.Forms.Label labelNewLines;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblOutputFileName;
        private System.Windows.Forms.TextBox textBoxOutputFileName;
        private System.Windows.Forms.Button btnSetOuputFolder;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.Button btnClearFiles;
        private System.Windows.Forms.Button btnFileUp;
        private System.Windows.Forms.Button btnFileDown;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

