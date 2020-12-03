namespace WindowsFormsApp11
{
    partial class BMPParamsForm
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
            this.UseRBox = new System.Windows.Forms.CheckBox();
            this.UseGBox = new System.Windows.Forms.CheckBox();
            this.UseBBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UseMultyple = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UseRBox
            // 
            this.UseRBox.AutoSize = true;
            this.UseRBox.Location = new System.Drawing.Point(12, 44);
            this.UseRBox.Name = "UseRBox";
            this.UseRBox.Size = new System.Drawing.Size(71, 17);
            this.UseRBox.TabIndex = 0;
            this.UseRBox.Text = "Красный";
            this.UseRBox.UseVisualStyleBackColor = true;
            this.UseRBox.CheckedChanged += new System.EventHandler(this.UseRBox_CheckedChanged);
            // 
            // UseGBox
            // 
            this.UseGBox.AutoSize = true;
            this.UseGBox.Location = new System.Drawing.Point(12, 67);
            this.UseGBox.Name = "UseGBox";
            this.UseGBox.Size = new System.Drawing.Size(71, 17);
            this.UseGBox.TabIndex = 1;
            this.UseGBox.Text = "Зеленый";
            this.UseGBox.UseVisualStyleBackColor = true;
            this.UseGBox.CheckedChanged += new System.EventHandler(this.UseGBox_CheckedChanged);
            // 
            // UseBBox
            // 
            this.UseBBox.AutoSize = true;
            this.UseBBox.Location = new System.Drawing.Point(12, 90);
            this.UseBBox.Name = "UseBBox";
            this.UseBBox.Size = new System.Drawing.Size(57, 17);
            this.UseBBox.TabIndex = 2;
            this.UseBBox.Text = "Синий";
            this.UseBBox.UseVisualStyleBackColor = true;
            this.UseBBox.CheckedChanged += new System.EventHandler(this.UseBBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор цветовых каналов";
            // 
            // UseMultyple
            // 
            this.UseMultyple.AutoSize = true;
            this.UseMultyple.Location = new System.Drawing.Point(12, 148);
            this.UseMultyple.Name = "UseMultyple";
            this.UseMultyple.Size = new System.Drawing.Size(206, 17);
            this.UseMultyple.TabIndex = 4;
            this.UseMultyple.Text = "Использовать несколько проходов";
            this.UseMultyple.UseVisualStyleBackColor = true;
            this.UseMultyple.CheckedChanged += new System.EventHandler(this.UseMultyple_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(70, 171);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BMPParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 206);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.UseMultyple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UseBBox);
            this.Controls.Add(this.UseGBox);
            this.Controls.Add(this.UseRBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BMPParamsForm";
            this.Text = "BMPParamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UseRBox;
        private System.Windows.Forms.CheckBox UseGBox;
        private System.Windows.Forms.CheckBox UseBBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox UseMultyple;
        private System.Windows.Forms.Button OKButton;
    }
}