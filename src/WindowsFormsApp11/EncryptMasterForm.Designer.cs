namespace WindowsFormsApp11
{
    partial class EncryptMasterForm
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptCheckBox = new System.Windows.Forms.CheckBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(25, 64);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(101, 13);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Парольная фраза:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(28, 80);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(330, 20);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите пароль для шифрования, если требуется.";
            // 
            // EncryptCheckBox
            // 
            this.EncryptCheckBox.AutoSize = true;
            this.EncryptCheckBox.Location = new System.Drawing.Point(28, 142);
            this.EncryptCheckBox.Name = "EncryptCheckBox";
            this.EncryptCheckBox.Size = new System.Drawing.Size(166, 17);
            this.EncryptCheckBox.TabIndex = 0;
            this.EncryptCheckBox.Text = "Использовать шифрование";
            this.EncryptCheckBox.UseVisualStyleBackColor = true;
            this.EncryptCheckBox.CheckedChanged += new System.EventHandler(this.EncryptCheckBox_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(297, 176);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Готово";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PrevButton.Location = new System.Drawing.Point(12, 176);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 3;
            this.PrevButton.Text = "Назад";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // EncryptMasterForm
            // 
            this.AcceptButton = this.NextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.PrevButton;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.EncryptCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EncryptMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EncryptMasterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox EncryptCheckBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
    }
}