namespace WindowsFormsApp11
{
    partial class SourceMasterForm
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
            this.SourceLabel = new System.Windows.Forms.Label();
            this.OpenSourceButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileRadioButton = new System.Windows.Forms.RadioButton();
            this.StringRadioButton = new System.Windows.Forms.RadioButton();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(25, 64);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(58, 13);
            this.SourceLabel.TabIndex = 7;
            this.SourceLabel.Text = "Источник:";
            // 
            // OpenSourceButton
            // 
            this.OpenSourceButton.Location = new System.Drawing.Point(28, 106);
            this.OpenSourceButton.Name = "OpenSourceButton";
            this.OpenSourceButton.Size = new System.Drawing.Size(75, 23);
            this.OpenSourceButton.TabIndex = 1;
            this.OpenSourceButton.Text = "Выбрать";
            this.OpenSourceButton.UseVisualStyleBackColor = true;
            this.OpenSourceButton.Click += new System.EventHandler(this.OpenSourceButton_Click);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(28, 80);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(330, 20);
            this.SourceTextBox.TabIndex = 0;
            this.SourceTextBox.TextChanged += new System.EventHandler(this.SourceTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберите источник скрываемой информации. Файл или строку.";
            // 
            // FileRadioButton
            // 
            this.FileRadioButton.AutoSize = true;
            this.FileRadioButton.Location = new System.Drawing.Point(169, 142);
            this.FileRadioButton.Name = "FileRadioButton";
            this.FileRadioButton.Size = new System.Drawing.Size(127, 17);
            this.FileRadioButton.TabIndex = 3;
            this.FileRadioButton.TabStop = true;
            this.FileRadioButton.Text = "Использовать файл";
            this.FileRadioButton.UseVisualStyleBackColor = true;
            this.FileRadioButton.CheckedChanged += new System.EventHandler(this.FileRadioButton_CheckedChanged);
            // 
            // StringRadioButton
            // 
            this.StringRadioButton.AutoSize = true;
            this.StringRadioButton.Location = new System.Drawing.Point(28, 142);
            this.StringRadioButton.Name = "StringRadioButton";
            this.StringRadioButton.Size = new System.Drawing.Size(135, 17);
            this.StringRadioButton.TabIndex = 2;
            this.StringRadioButton.TabStop = true;
            this.StringRadioButton.Text = "Использовать строку";
            this.StringRadioButton.UseVisualStyleBackColor = true;
            this.StringRadioButton.CheckedChanged += new System.EventHandler(this.StringRadioButton_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(297, 176);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PrevButton.Location = new System.Drawing.Point(12, 176);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 4;
            this.PrevButton.Text = "Назад";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // SourceMasterForm
            // 
            this.AcceptButton = this.NextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.PrevButton;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.StringRadioButton);
            this.Controls.Add(this.FileRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.OpenSourceButton);
            this.Controls.Add(this.SourceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SourceMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор источника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SourceMasterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Button OpenSourceButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton FileRadioButton;
        private System.Windows.Forms.RadioButton StringRadioButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
    }
}