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
    public partial class ContainerMasterForm : Form
    {
        Form1 Form;
        bool IsOkClose = false;

        public ContainerMasterForm(Form1 RefForm)
        {
            InitializeComponent();
            ContainerTextBox.Text = Parameters.ContainerData;
            Form = RefForm;
        }

        private void ContainerMasterForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenContainerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
            DialogResult Result = NewOpenFileDialog.ShowDialog();
            if (Result.ToString() == "OK")
            {
                ContainerTextBox.Text = NewOpenFileDialog.FileName;
            }
            else return;
        }

        private void ContainerTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameters.ContainerData = ContainerTextBox.Text;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            IsOkClose = true;

            DialogMasterForm NewDialogMasterForm = new DialogMasterForm(Form);
            NewDialogMasterForm.Show();
            Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            IsOkClose = true;

            SourceMasterForm NewContainerMasterForm = new SourceMasterForm(Form);
            NewContainerMasterForm.Show();
            Close();
        }

        private void ContainerMasterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsOkClose) Form.RefreshForm();
        }
    }
}
