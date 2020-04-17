namespace WindowsFormsAppFileReader
{
    partial class FileReaderForm
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.displayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.isEncryptedCheckBox = new System.Windows.Forms.CheckBox();
            this.fileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isRoleBasedCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(0, 18);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // displayRichTextBox
            // 
            this.displayRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayRichTextBox.Location = new System.Drawing.Point(12, 59);
            this.displayRichTextBox.Name = "displayRichTextBox";
            this.displayRichTextBox.Size = new System.Drawing.Size(770, 465);
            this.displayRichTextBox.TabIndex = 1;
            this.displayRichTextBox.Text = "";
            // 
            // isEncryptedCheckBox
            // 
            this.isEncryptedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isEncryptedCheckBox.AutoSize = true;
            this.isEncryptedCheckBox.Location = new System.Drawing.Point(97, 20);
            this.isEncryptedCheckBox.Name = "isEncryptedCheckBox";
            this.isEncryptedCheckBox.Size = new System.Drawing.Size(85, 17);
            this.isEncryptedCheckBox.TabIndex = 2;
            this.isEncryptedCheckBox.Text = "Is Encrypted";
            this.isEncryptedCheckBox.UseVisualStyleBackColor = true;
            this.isEncryptedCheckBox.CheckedChanged += new System.EventHandler(this.isEncryptedCheckBox_CheckedChanged);
            // 
            // fileTypeComboBox
            // 
            this.fileTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fileTypeComboBox.FormattingEnabled = true;
            this.fileTypeComboBox.Location = new System.Drawing.Point(214, 18);
            this.fileTypeComboBox.Name = "fileTypeComboBox";
            this.fileTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fileTypeComboBox.TabIndex = 3;
            this.fileTypeComboBox.Text = "File Type";
            this.fileTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fileTypeComboBox_SelectedIndexChanged);
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(380, 18);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.userRoleComboBox.TabIndex = 4;
            this.userRoleComboBox.Text = "User Role";
            this.userRoleComboBox.SelectedIndexChanged += new System.EventHandler(this.userRoleComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isRoleBasedCheckBox);
            this.groupBox1.Controls.Add(this.openFileButton);
            this.groupBox1.Controls.Add(this.userRoleComboBox);
            this.groupBox1.Controls.Add(this.isEncryptedCheckBox);
            this.groupBox1.Controls.Add(this.fileTypeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 41);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // isRoleBasedCheckBox
            // 
            this.isRoleBasedCheckBox.AutoSize = true;
            this.isRoleBasedCheckBox.Location = new System.Drawing.Point(548, 18);
            this.isRoleBasedCheckBox.Name = "isRoleBasedCheckBox";
            this.isRoleBasedCheckBox.Size = new System.Drawing.Size(92, 17);
            this.isRoleBasedCheckBox.TabIndex = 5;
            this.isRoleBasedCheckBox.Text = "Is Role Based";
            this.isRoleBasedCheckBox.UseVisualStyleBackColor = true;
            this.isRoleBasedCheckBox.CheckedChanged += new System.EventHandler(this.isRoleBasedCheckBox_CheckedChanged);
            // 
            // FileReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayRichTextBox);
            this.MinimumSize = new System.Drawing.Size(813, 572);
            this.Name = "FileReaderForm";
            this.Text = "File Reader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.RichTextBox displayRichTextBox;
        private System.Windows.Forms.CheckBox isEncryptedCheckBox;
        private System.Windows.Forms.ComboBox fileTypeComboBox;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isRoleBasedCheckBox;
    }
}

