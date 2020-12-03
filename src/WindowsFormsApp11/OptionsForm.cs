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
    public partial class OptionsForm : System.Windows.Forms.Form
    {
        MainForm Form;
        bool IsLoaded = false;

        public OptionsForm(MainForm RefForm)
        {
            InitializeComponent();
            EncryptCheckBox.Checked = Parameters.IsEncryptCheckBoxChecked;
            if (Parameters.Source == "File") FileRadioButton.Checked = true;
            else StringRadioButton.Checked = true;
            Form = RefForm;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
        }

        private void FileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.Source = "File";
            if (IsLoaded) Parameters.SourceData = "";
        }

        private void StringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.Source = "String";
            if (IsLoaded) Parameters.SourceData = "";
        }

        private void EncryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.IsEncryptCheckBoxChecked = EncryptCheckBox.Checked;
            if (IsLoaded) Parameters.Password = "";
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.SetForm(); 
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
