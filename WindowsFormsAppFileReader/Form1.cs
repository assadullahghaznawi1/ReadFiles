using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadFilesCases;

namespace WindowsFormsAppFileReader
{
    public partial class FileReaderForm : Form
    {
        public FileReaderForm()
        {
            InitializeComponent();
            fileTypeComboBox.DataSource = Enum.GetValues(typeof(FileType));
            userRoleComboBox.DataSource = Enum.GetValues(typeof(Role));
            openFileDialog = new OpenFileDialog();
        }

        private Boolean IsEncrypted { get; set; }
        private FileType FileType { get; set; }
        private Role UserRole { get; set; }
        private Boolean IsRoleBased { get; set; }
        public OpenFileDialog openFileDialog { get; set; }
        private void isEncryptedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsEncrypted = isEncryptedCheckBox.Checked;
        }

        private void fileTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileType = (FileType)fileTypeComboBox.SelectedItem;
        }

        private void userRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserRole = (Role)userRoleComboBox.SelectedItem;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = FileType.ToString() + "|*." + FileType.ToString();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(FileType == FileType.Txt)
                {
                    try
                    {
                        EasyTextReader easyTextReader = new EasyTextReader(openFileDialog.FileName, IsEncrypted);
                        easyTextReader.UserRole = UserRole;
                        easyTextReader.IsRoleBased = IsRoleBased;

                        displayRichTextBox.Text = easyTextReader.ReadFile();
                    }catch(Exception exception)
                    {
                        displayRichTextBox.Text = exception.Message;
                    }
                }
                else if (FileType == FileType.Xml)
                {
                    try
                    {
                        EasyXmlReader easyXmlReader = new EasyXmlReader(openFileDialog.FileName, IsEncrypted);
                        easyXmlReader.UserRole = UserRole;
                        easyXmlReader.IsRoleBased = IsRoleBased;

                        displayRichTextBox.Text = easyXmlReader.ReadFile();
                    }
                    catch (Exception exception)
                    {
                        displayRichTextBox.Text = exception.Message;
                    }
                }
                else
                {
                    try
                    {
                        EasyJsonReader easyJsonReader = new EasyJsonReader(openFileDialog.FileName, IsEncrypted);
                        easyJsonReader.UserRole = UserRole;
                        easyJsonReader.IsRoleBased = IsRoleBased;

                        displayRichTextBox.Text = easyJsonReader.ReadFile();
                    }
                    catch (Exception exception)
                    {
                        displayRichTextBox.Text = exception.Message;
                    }
                }

            }
        }

        private void isRoleBasedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsRoleBased = isRoleBasedCheckBox.Checked;
        }
    }
}
