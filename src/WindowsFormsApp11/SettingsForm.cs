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
    public partial class SettingsForm : System.Windows.Forms.Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            MasterCheckBox.Checked = Parameters.IsMasterCheckBoxChecked;
            WarningCheckBox.Checked = Parameters.IsWarningCheckBoxChecked;
            JPEGCoderButton.Enabled = false;
            if (Parameters.Coder == "BMP") BMPCoderButton.Checked = true;

        }

        private void MasterTextBox_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.IsMasterCheckBoxChecked = MasterCheckBox.Checked;
        }

        private void WarningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.IsWarningCheckBoxChecked = WarningCheckBox.Checked;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JPEGCoderButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BMPCoderButton_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.Coder = "BMP";
        }

        private void BMPParamsButton_Click(object sender, EventArgs e)
        {
            BMPParamsForm NewBMPParamsForm = new BMPParamsForm();
            NewBMPParamsForm.Show();
        }
    }
}
