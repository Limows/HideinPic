namespace WindowsFormsApp11
{
    partial class OptionsForm
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
            this.FileRadioButton = new System.Windows.Forms.RadioButton();
            this.StringRadioButton = new System.Windows.Forms.RadioButton();
            this.EncryptCheckBox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileRadioButton
            // 
            this.FileRadioButton.AutoSize = true;
            this.FileRadioButton.Location = new System.Drawing.Point(72, 64);
            this.FileRadioButton.Name = "FileRadioButton";
            this.FileRadioButton.Size = new System.Drawing.Size(127, 17);
            this.FileRadioButton.TabIndex = 0;
            this.FileRadioButton.TabStop = true;
            this.FileRadioButton.Text = "Использовать файл";
            this.FileRadioButton.UseVisualStyleBackColor = true;
            this.FileRadioButton.CheckedChanged += new System.EventHandler(this.FileRadioButton_CheckedChanged);
            // 
            // StringRadioButton
            // 
            this.StringRadioButton.AutoSize = true;
            this.StringRadioButton.Location = new System.Drawing.Point(72, 41);
            this.StringRadioButton.Name = "StringRadioButton";
            this.StringRadioButton.Size = new System.Drawing.Size(98, 17);
            this.StringRadioButton.TabIndex = 1;
            this.StringRadioButton.TabStop = true;
            this.StringRadioButton.Text = "Ввести строку";
            this.StringRadioButton.UseVisualStyleBackColor = true;
            this.StringRadioButton.CheckedChanged += new System.EventHandler(this.StringRadioButton_CheckedChanged);
            // 
            // EncryptCheckBox
            // 
            this.EncryptCheckBox.AutoSize = true;
            this.EncryptCheckBox.Location = new System.Drawing.Point(72, 102);
            this.EncryptCheckBox.Name = "EncryptCheckBox";
            this.EncryptCheckBox.Size = new System.Drawing.Size(166, 17);
            this.EncryptCheckBox.TabIndex = 2;
            this.EncryptCheckBox.Text = "Использовать шифрование";
            this.EncryptCheckBox.UseVisualStyleBackColor = true;
            this.EncryptCheckBox.CheckedChanged += new System.EventHandler(this.EncryptCheckBox_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(95, 137);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 172);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EncryptCheckBox);
            this.Controls.Add(this.StringRadioButton);
            this.Controls.Add(this.FileRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Опции проекта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FileRadioButton;
        private System.Windows.Forms.RadioButton StringRadioButton;
        private System.Windows.Forms.CheckBox EncryptCheckBox;
        private System.Windows.Forms.Button OKButton;
    }
}