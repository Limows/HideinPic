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
    public partial class BMPParamsForm : System.Windows.Forms.Form
    {
        public BMPParamsForm()
        {
            InitializeComponent();
            UseRBox.Checked = BMPParams.UseR;
            UseGBox.Checked = BMPParams.UseG;
            UseBBox.Checked = BMPParams.UseB;
            //UseGBox.Enabled = false;
            UseMultyple.Checked = BMPParams.UseMultyple;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UseRBox_CheckedChanged(object sender, EventArgs e)
        {
            BMPParams.UseR = UseRBox.Checked;
        }

        private void UseGBox_CheckedChanged(object sender, EventArgs e)
        {
            BMPParams.UseG = UseGBox.Checked;
        }

        private void UseBBox_CheckedChanged(object sender, EventArgs e)
        {
            BMPParams.UseB = UseBBox.Checked;
        }

        private void UseMultyple_CheckedChanged(object sender, EventArgs e)
        {
            BMPParams.UseMultyple = UseMultyple.Checked;
        }
    }
}
