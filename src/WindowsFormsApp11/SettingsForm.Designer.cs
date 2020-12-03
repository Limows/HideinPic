namespace WindowsFormsApp11
{
    partial class SettingsForm
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
            this.MasterCheckBox = new System.Windows.Forms.CheckBox();
            this.WarningCheckBox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.BMPCoderButton = new System.Windows.Forms.RadioButton();
            this.JPEGCoderButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.JPEGParamsButton = new System.Windows.Forms.Button();
            this.BMPParamsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MasterCheckBox
            // 
            this.MasterCheckBox.AutoSize = true;
            this.MasterCheckBox.Location = new System.Drawing.Point(17, 35);
            this.MasterCheckBox.Name = "MasterCheckBox";
            this.MasterCheckBox.Size = new System.Drawing.Size(236, 17);
            this.MasterCheckBox.TabIndex = 0;
            this.MasterCheckBox.Text = "Запускать Мастер при создании проекта";
            this.MasterCheckBox.UseVisualStyleBackColor = true;
            this.MasterCheckBox.CheckedChanged += new System.EventHandler(this.MasterTextBox_CheckedChanged);
            // 
            // WarningCheckBox
            // 
            this.WarningCheckBox.AutoSize = true;
            this.WarningCheckBox.Location = new System.Drawing.Point(17, 58);
            this.WarningCheckBox.Name = "WarningCheckBox";
            this.WarningCheckBox.Size = new System.Drawing.Size(252, 17);
            this.WarningCheckBox.TabIndex = 1;
            this.WarningCheckBox.Text = "Предупреждать о переполнении контейнера";
            this.WarningCheckBox.UseVisualStyleBackColor = true;
            this.WarningCheckBox.CheckedChanged += new System.EventHandler(this.WarningCheckBox_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(97, 152);
            this.OKButton.Name = "OKButton";
            this.OKButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BMPCoderButton
            // 
            this.BMPCoderButton.AutoSize = true;
            this.BMPCoderButton.Location = new System.Drawing.Point(17, 104);
            this.BMPCoderButton.Name = "BMPCoderButton";
            this.BMPCoderButton.Size = new System.Drawing.Size(48, 17);
            this.BMPCoderButton.TabIndex = 3;
            this.BMPCoderButton.TabStop = true;
            this.BMPCoderButton.Text = "BMP";
            this.BMPCoderButton.UseVisualStyleBackColor = true;
            this.BMPCoderButton.CheckedChanged += new System.EventHandler(this.BMPCoderButton_CheckedChanged);
            // 
            // JPEGCoderButton
            // 
            this.JPEGCoderButton.AutoSize = true;
            this.JPEGCoderButton.Location = new System.Drawing.Point(17, 127);
            this.JPEGCoderButton.Name = "JPEGCoderButton";
            this.JPEGCoderButton.Size = new System.Drawing.Size(52, 17);
            this.JPEGCoderButton.TabIndex = 4;
            this.JPEGCoderButton.TabStop = true;
            this.JPEGCoderButton.Text = "JPEG";
            this.JPEGCoderButton.UseVisualStyleBackColor = true;
            this.JPEGCoderButton.CheckedChanged += new System.EventHandler(this.JPEGCoderButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вид кодера";
            // 
            // JPEGParamsButton
            // 
            this.JPEGParamsButton.Location = new System.Drawing.Point(189, 127);
            this.JPEGParamsButton.Name = "JPEGParamsButton";
            this.JPEGParamsButton.Size = new System.Drawing.Size(75, 23);
            this.JPEGParamsButton.TabIndex = 6;
            this.JPEGParamsButton.Text = "Параметры";
            this.JPEGParamsButton.UseVisualStyleBackColor = true;
            // 
            // BMPParamsButton
            // 
            this.BMPParamsButton.Location = new System.Drawing.Point(189, 104);
            this.BMPParamsButton.Name = "BMPParamsButton";
            this.BMPParamsButton.Size = new System.Drawing.Size(75, 23);
            this.BMPParamsButton.TabIndex = 7;
            this.BMPParamsButton.Text = "Параметры";
            this.BMPParamsButton.UseVisualStyleBackColor = true;
            this.BMPParamsButton.Click += new System.EventHandler(this.BMPParamsButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 187);
            this.Controls.Add(this.BMPParamsButton);
            this.Controls.Add(this.JPEGParamsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JPEGCoderButton);
            this.Controls.Add(this.BMPCoderButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.WarningCheckBox);
            this.Controls.Add(this.MasterCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Общие настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MasterCheckBox;
        private System.Windows.Forms.CheckBox WarningCheckBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.RadioButton BMPCoderButton;
        private System.Windows.Forms.RadioButton JPEGCoderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button JPEGParamsButton;
        private System.Windows.Forms.Button BMPParamsButton;
    }
}