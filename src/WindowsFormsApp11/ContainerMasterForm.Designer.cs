namespace WindowsFormsApp11
{
    partial class ContainerMasterForm
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
            this.OpenContainerButton = new System.Windows.Forms.Button();
            this.ContainerLabel = new System.Windows.Forms.Label();
            this.ContainerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenContainerButton
            // 
            this.OpenContainerButton.Location = new System.Drawing.Point(28, 106);
            this.OpenContainerButton.Name = "OpenContainerButton";
            this.OpenContainerButton.Size = new System.Drawing.Size(75, 23);
            this.OpenContainerButton.TabIndex = 13;
            this.OpenContainerButton.Text = "Выбрать";
            this.OpenContainerButton.UseVisualStyleBackColor = true;
            this.OpenContainerButton.Click += new System.EventHandler(this.OpenContainerButton_Click);
            // 
            // ContainerLabel
            // 
            this.ContainerLabel.AutoSize = true;
            this.ContainerLabel.Location = new System.Drawing.Point(25, 64);
            this.ContainerLabel.Name = "ContainerLabel";
            this.ContainerLabel.Size = new System.Drawing.Size(64, 13);
            this.ContainerLabel.TabIndex = 12;
            this.ContainerLabel.Text = "Контейнер:";
            // 
            // ContainerTextBox
            // 
            this.ContainerTextBox.Location = new System.Drawing.Point(28, 80);
            this.ContainerTextBox.Name = "ContainerTextBox";
            this.ContainerTextBox.Size = new System.Drawing.Size(330, 20);
            this.ContainerTextBox.TabIndex = 11;
            this.ContainerTextBox.TextChanged += new System.EventHandler(this.ContainerTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберите файл, котором будет сокрыта информация.";
            // 
            // PrevButton
            // 
            this.PrevButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PrevButton.Location = new System.Drawing.Point(12, 176);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 15;
            this.PrevButton.Text = "Назад";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(297, 176);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 16;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ContainerMasterForm
            // 
            this.AcceptButton = this.NextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.PrevButton;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenContainerButton);
            this.Controls.Add(this.ContainerLabel);
            this.Controls.Add(this.ContainerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ContainerMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор контейнера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContainerMasterForm_FormClosed);
            this.Load += new System.EventHandler(this.ContainerMasterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenContainerButton;
        private System.Windows.Forms.Label ContainerLabel;
        private System.Windows.Forms.TextBox ContainerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
    }
}