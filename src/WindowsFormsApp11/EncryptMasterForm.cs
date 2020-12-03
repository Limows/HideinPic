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
    public partial class EncryptMasterForm : Form
    {
        Form1 Form;
        bool IsOkClose = false;

        public EncryptMasterForm(Form1 RefForm)
        {
            InitializeComponent();
            EncryptCheckBox.Checked = Parameters.IsEncryptCheckBoxChecked;
            if (Parameters.IsEncryptCheckBoxChecked) PasswordTextBox.Enabled = true;
            else PasswordTextBox.Enabled = false;
            PasswordTextBox.Text = Parameters.Password;
            Form = RefForm;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameters.Password = PasswordTextBox.Text;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            IsOkClose = true;

            SourceMasterForm NewSourceMasterForm = new SourceMasterForm(Form);
            NewSourceMasterForm.Show();
            Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            IsOkClose = true;

            Form.SetForm();
            Close();
        }

        private void EncryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.IsEncryptCheckBoxChecked = EncryptCheckBox.Checked;
            PasswordTextBox.Text = "";
            if (Parameters.IsEncryptCheckBoxChecked) PasswordTextBox.Enabled = true;
            else PasswordTextBox.Enabled = false;
        }

        private void EncryptMasterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsOkClose) Form.RefreshForm();
        }
    }
}
