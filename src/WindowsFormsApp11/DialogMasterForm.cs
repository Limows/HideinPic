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
    public partial class DialogMasterForm : Form
    {
        Form1 Form;
        bool IsOkClose = false;

        public DialogMasterForm(Form1 RefForm)
        {   
            InitializeComponent();
            Form = RefForm;
            UsingMasterCheckBox.Checked = Parameters.IsMasterCheckBoxChecked;
        }

        private void UsingMasterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.IsMasterCheckBoxChecked = UsingMasterCheckBox.Checked;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            IsOkClose = true;
            ContainerMasterForm NewContainerMasterForm = new ContainerMasterForm(Form);
            NewContainerMasterForm.Show();
            //NewContainerMasterForm.Location = new Point(this.Left, this.Top);
            Close();
        }

        private void DialogMasterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsOkClose) Form.RefreshForm();
        }
    }
}
