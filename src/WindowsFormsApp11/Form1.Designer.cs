namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииПроектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SourceLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ContainerLabel = new System.Windows.Forms.Label();
            this.MainFormTabs = new System.Windows.Forms.TabControl();
            this.ExportTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.OpenContainerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainerTextBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenSourceButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.ImportTab = new System.Windows.Forms.TabPage();
            this.OpenContainerButton2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ContainerTextBox2 = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OpenSourceButton2 = new System.Windows.Forms.Button();
            this.SourceTextBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.MainFormTabs.SuspendLayout();
            this.ExportTab.SuspendLayout();
            this.ImportTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПроектToolStripMenuItem,
            this.сохранитьПроектToolStripMenuItem,
            this.загрузитьПроектToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйПроектToolStripMenuItem
            // 
            this.новыйПроектToolStripMenuItem.Name = "новыйПроектToolStripMenuItem";
            this.новыйПроектToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.новыйПроектToolStripMenuItem.Text = "Новый проект";
            this.новыйПроектToolStripMenuItem.Click += new System.EventHandler(this.новыйПроектToolStripMenuItem_Click);
            // 
            // сохранитьПроектToolStripMenuItem
            // 
            this.сохранитьПроектToolStripMenuItem.Name = "сохранитьПроектToolStripMenuItem";
            this.сохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.сохранитьПроектToolStripMenuItem.Text = "Сохранить проект";
            this.сохранитьПроектToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПроектToolStripMenuItem_Click);
            // 
            // загрузитьПроектToolStripMenuItem
            // 
            this.загрузитьПроектToolStripMenuItem.Name = "загрузитьПроектToolStripMenuItem";
            this.загрузитьПроектToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.загрузитьПроектToolStripMenuItem.Text = "Загрузить проект";
            this.загрузитьПроектToolStripMenuItem.Click += new System.EventHandler(this.загрузитьПроектToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общиеToolStripMenuItem,
            this.опцииПроектаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // общиеToolStripMenuItem
            // 
            this.общиеToolStripMenuItem.Name = "общиеToolStripMenuItem";
            this.общиеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.общиеToolStripMenuItem.Text = "Общие";
            this.общиеToolStripMenuItem.Click += new System.EventHandler(this.общиеToolStripMenuItem_Click);
            // 
            // опцииПроектаToolStripMenuItem
            // 
            this.опцииПроектаToolStripMenuItem.Name = "опцииПроектаToolStripMenuItem";
            this.опцииПроектаToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опцииПроектаToolStripMenuItem.Text = "Опции проекта";
            this.опцииПроектаToolStripMenuItem.Click += new System.EventHandler(this.опцииПроектаToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(64, 97);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(51, 13);
            this.SourceLabel.TabIndex = 4;
            this.SourceLabel.Text = "Данные:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(64, 263);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(101, 13);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Парольная фраза:";
            // 
            // ContainerLabel
            // 
            this.ContainerLabel.AutoSize = true;
            this.ContainerLabel.Location = new System.Drawing.Point(64, 181);
            this.ContainerLabel.Name = "ContainerLabel";
            this.ContainerLabel.Size = new System.Drawing.Size(64, 13);
            this.ContainerLabel.TabIndex = 9;
            this.ContainerLabel.Text = "Контейнер:";
            // 
            // MainFormTabs
            // 
            this.MainFormTabs.Controls.Add(this.ExportTab);
            this.MainFormTabs.Controls.Add(this.ImportTab);
            this.MainFormTabs.Location = new System.Drawing.Point(0, 27);
            this.MainFormTabs.Name = "MainFormTabs";
            this.MainFormTabs.SelectedIndex = 0;
            this.MainFormTabs.Size = new System.Drawing.Size(648, 423);
            this.MainFormTabs.TabIndex = 11;
            this.MainFormTabs.SelectedIndexChanged += new System.EventHandler(this.MainFormTabs_SelectedIndexChanged);
            this.MainFormTabs.TabIndexChanged += new System.EventHandler(this.MainFormTabs_TabIndexChanged);
            // 
            // ExportTab
            // 
            this.ExportTab.Controls.Add(this.label4);
            this.ExportTab.Controls.Add(this.ConfirmTextBox);
            this.ExportTab.Controls.Add(this.OpenContainerButton);
            this.ExportTab.Controls.Add(this.label1);
            this.ExportTab.Controls.Add(this.ContainerTextBox);
            this.ExportTab.Controls.Add(this.ExportButton);
            this.ExportTab.Controls.Add(this.label2);
            this.ExportTab.Controls.Add(this.PasswordTextBox);
            this.ExportTab.Controls.Add(this.label3);
            this.ExportTab.Controls.Add(this.OpenSourceButton);
            this.ExportTab.Controls.Add(this.SourceTextBox);
            this.ExportTab.Location = new System.Drawing.Point(4, 22);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExportTab.Size = new System.Drawing.Size(640, 397);
            this.ExportTab.TabIndex = 0;
            this.ExportTab.Text = "Скрыть";
            this.ExportTab.UseVisualStyleBackColor = true;
            this.ExportTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Подтверждение:";
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Location = new System.Drawing.Point(63, 274);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.PasswordChar = '*';
            this.ConfirmTextBox.Size = new System.Drawing.Size(421, 20);
            this.ConfirmTextBox.TabIndex = 20;
            this.ConfirmTextBox.TextChanged += new System.EventHandler(this.ConfirmTextBox_TextChanged);
            // 
            // OpenContainerButton
            // 
            this.OpenContainerButton.Location = new System.Drawing.Point(505, 131);
            this.OpenContainerButton.Name = "OpenContainerButton";
            this.OpenContainerButton.Size = new System.Drawing.Size(75, 23);
            this.OpenContainerButton.TabIndex = 15;
            this.OpenContainerButton.Text = "Выбрать";
            this.OpenContainerButton.UseVisualStyleBackColor = true;
            this.OpenContainerButton.Click += new System.EventHandler(this.OpenContainerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Контейнер:";
            // 
            // ContainerTextBox
            // 
            this.ContainerTextBox.Location = new System.Drawing.Point(64, 134);
            this.ContainerTextBox.Name = "ContainerTextBox";
            this.ContainerTextBox.Size = new System.Drawing.Size(421, 20);
            this.ContainerTextBox.TabIndex = 13;
            this.ContainerTextBox.TextChanged += new System.EventHandler(this.ContainerTextBox_TextChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(64, 324);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 18;
            this.ExportButton.Text = "Скрыть";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Парольная фраза:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(64, 204);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(421, 20);
            this.PasswordTextBox.TabIndex = 17;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Данные:";
            // 
            // OpenSourceButton
            // 
            this.OpenSourceButton.Location = new System.Drawing.Point(505, 57);
            this.OpenSourceButton.Name = "OpenSourceButton";
            this.OpenSourceButton.Size = new System.Drawing.Size(75, 23);
            this.OpenSourceButton.TabIndex = 12;
            this.OpenSourceButton.Text = "Выбрать";
            this.OpenSourceButton.UseVisualStyleBackColor = true;
            this.OpenSourceButton.Click += new System.EventHandler(this.OpenSourceButton_Click);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(64, 59);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(421, 20);
            this.SourceTextBox.TabIndex = 11;
            this.SourceTextBox.TextChanged += new System.EventHandler(this.SourceTextBox_TextChanged);
            // 
            // ImportTab
            // 
            this.ImportTab.Controls.Add(this.OpenContainerButton2);
            this.ImportTab.Controls.Add(this.label6);
            this.ImportTab.Controls.Add(this.ContainerTextBox2);
            this.ImportTab.Controls.Add(this.ImportButton);
            this.ImportTab.Controls.Add(this.label7);
            this.ImportTab.Controls.Add(this.PasswordTextBox2);
            this.ImportTab.Controls.Add(this.label8);
            this.ImportTab.Controls.Add(this.OpenSourceButton2);
            this.ImportTab.Controls.Add(this.SourceTextBox2);
            this.ImportTab.Location = new System.Drawing.Point(4, 22);
            this.ImportTab.Name = "ImportTab";
            this.ImportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportTab.Size = new System.Drawing.Size(640, 397);
            this.ImportTab.TabIndex = 1;
            this.ImportTab.Text = "Извлечь";
            this.ImportTab.UseVisualStyleBackColor = true;
            this.ImportTab.Click += new System.EventHandler(this.ImportTab_Click);
            // 
            // OpenContainerButton2
            // 
            this.OpenContainerButton2.Location = new System.Drawing.Point(505, 131);
            this.OpenContainerButton2.Name = "OpenContainerButton2";
            this.OpenContainerButton2.Size = new System.Drawing.Size(75, 23);
            this.OpenContainerButton2.TabIndex = 26;
            this.OpenContainerButton2.Text = "Выбрать";
            this.OpenContainerButton2.UseVisualStyleBackColor = true;
            this.OpenContainerButton2.Click += new System.EventHandler(this.OpenContainerButton2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Контейнер:";
            // 
            // ContainerTextBox2
            // 
            this.ContainerTextBox2.Location = new System.Drawing.Point(64, 134);
            this.ContainerTextBox2.Name = "ContainerTextBox2";
            this.ContainerTextBox2.Size = new System.Drawing.Size(421, 20);
            this.ContainerTextBox2.TabIndex = 24;
            this.ContainerTextBox2.TextChanged += new System.EventHandler(this.ContainerTextBox2_TextChanged);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(64, 324);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 29;
            this.ImportButton.Text = "Извлечь";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Парольная фраза:";
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.Location = new System.Drawing.Point(64, 204);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.PasswordChar = '*';
            this.PasswordTextBox2.Size = new System.Drawing.Size(421, 20);
            this.PasswordTextBox2.TabIndex = 28;
            this.PasswordTextBox2.TextChanged += new System.EventHandler(this.PasswordTextBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Данные:";
            // 
            // OpenSourceButton2
            // 
            this.OpenSourceButton2.Location = new System.Drawing.Point(505, 57);
            this.OpenSourceButton2.Name = "OpenSourceButton2";
            this.OpenSourceButton2.Size = new System.Drawing.Size(75, 23);
            this.OpenSourceButton2.TabIndex = 23;
            this.OpenSourceButton2.Text = "Выбрать";
            this.OpenSourceButton2.UseVisualStyleBackColor = true;
            this.OpenSourceButton2.Click += new System.EventHandler(this.OpenSourceButton2_Click);
            // 
            // SourceTextBox2
            // 
            this.SourceTextBox2.Location = new System.Drawing.Point(64, 59);
            this.SourceTextBox2.Name = "SourceTextBox2";
            this.SourceTextBox2.Size = new System.Drawing.Size(421, 20);
            this.SourceTextBox2.TabIndex = 22;
            this.SourceTextBox2.TextChanged += new System.EventHandler(this.SourceTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.MainFormTabs);
            this.Controls.Add(this.ContainerLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HideinPic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainFormTabs.ResumeLayout(false);
            this.ExportTab.ResumeLayout(false);
            this.ExportTab.PerformLayout();
            this.ImportTab.ResumeLayout(false);
            this.ImportTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem опцииПроектаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ContainerLabel;
        private System.Windows.Forms.TabControl MainFormTabs;
        private System.Windows.Forms.TabPage ExportTab;
        private System.Windows.Forms.TabPage ImportTab;
        private System.Windows.Forms.Button OpenContainerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContainerTextBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OpenSourceButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.Button OpenContainerButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ContainerTextBox2;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OpenSourceButton2;
        private System.Windows.Forms.TextBox SourceTextBox2;
    }
}

