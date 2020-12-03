using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class SourceMasterForm : System.Windows.Forms.Form
    {
        MainForm Form;
        bool IsOkClose = false;

        public SourceMasterForm(MainForm RefForm)
        {
            InitializeComponent();
            if (Parameters.Source == "File") FileRadioButton.Checked = true;
            else StringRadioButton.Checked = true;
            SourceTextBox.Text = Parameters.SourceData;
            Form = RefForm;
        }

        private void OpenSourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
            DialogResult Result = NewOpenFileDialog.ShowDialog();
            if (Result.ToString() == "OK")
            {
                SourceTextBox.Text = NewOpenFileDialog.FileName;
            }
            else return;
        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameters.SourceData = SourceTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            IsOkClose = true;

            EncryptMasterForm NewEncryptMasterForm = new EncryptMasterForm(Form);
            NewEncryptMasterForm.Show();
            Close();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            IsOkClose = true;

            ContainerMasterForm NewContainerMasterForm = new ContainerMasterForm(Form);
            NewContainerMasterForm.Show();
            Close();
        }

        private void StringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.Source = "String";
            SourceTextBox.Text = "";
            OpenSourceButton.Enabled = false;
        }

        private void FileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.Source = "File";
            SourceTextBox.Text = "";
            OpenSourceButton.Enabled = true;
        }

        private void SourceMasterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsOkClose) Form.RefreshForm();
        }
    }
}
