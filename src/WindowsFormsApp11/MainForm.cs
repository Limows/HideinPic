using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp11
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private static string ConfigPath = "Default.conf";
        private FileInfo ConfigFile = new FileInfo(ConfigPath);

        public MainForm()
        {
            InitializeComponent();
            if (!File.Exists(ConfigPath))
            {
                BinaryWriter Writer = new BinaryWriter(ConfigFile.Open(FileMode.Create));
                Writer.Write(true);
                Writer.Write(true);
                Writer.Write(true);
                Writer.Write(false);
                Writer.Write(false);
                Writer.Write(false);

                Writer.Dispose();
                Writer.Close();
            }
            LoadParameters();
            RefreshForm();
        }

        public void SetForm()
        {
            SourceTextBox.Text = Parameters.SourceData;
            ContainerTextBox.Text = Parameters.ContainerData;
            PasswordTextBox.Text = Parameters.Password;
            PasswordTextBox2.Text = Parameters.Password;
            ConfirmTextBox.Text = "";
            SourceTextBox2.Text = Parameters.DestinationData;
            ContainerTextBox2.Text = Parameters.ExportContainerData;
            SetControls();
        }

        private void LoadParameters()
        {
            BinaryReader Reader = new BinaryReader(ConfigFile.OpenRead());

            Parameters.IsWarningCheckBoxChecked = Reader.ReadBoolean();
            Parameters.IsMasterCheckBoxChecked = Reader.ReadBoolean();
            BMPParams.UseR = Reader.ReadBoolean();
            BMPParams.UseG = Reader.ReadBoolean();
            BMPParams.UseB = Reader.ReadBoolean();
            BMPParams.UseMultyple = Reader.ReadBoolean();

            Reader.Dispose();
            Reader.Close();
        }

        private void SaveParameters()
        {

            BinaryWriter Writer = new BinaryWriter(ConfigFile.Open(FileMode.Open));
            Writer.Write(Parameters.IsWarningCheckBoxChecked);
            Writer.Write(Parameters.IsMasterCheckBoxChecked);
            Writer.Write(BMPParams.UseR);
            Writer.Write(BMPParams.UseG);
            Writer.Write(BMPParams.UseB);
            Writer.Write(BMPParams.UseMultyple);

            Writer.Dispose();
            Writer.Close();
        }

        private void SaveProject()
        {
            SaveFileDialog NewSaveFileDialog = new SaveFileDialog();
            NewSaveFileDialog.AddExtension = true;
            NewSaveFileDialog.Filter = "Файл проекта (*.prj) | *.prj";
            DialogResult Result = NewSaveFileDialog.ShowDialog();
            if (Result.ToString() == "OK")
            {
                string Filename = NewSaveFileDialog.FileName;
                FileInfo ProjectFile = new FileInfo(Filename);
                BinaryWriter Writer;
                if (!File.Exists(Filename))
                {
                    Writer = new BinaryWriter(ProjectFile.Open(FileMode.Create));
                }
                else Writer = new BinaryWriter(ProjectFile.Open(FileMode.Open));

                Writer.Write(Parameters.IsEncryptCheckBoxChecked);
                Writer.Write(Parameters.Source);
                Writer.Write(Parameters.SourceData);
                Writer.Write(Parameters.ContainerData);
                Writer.Write(Parameters.Password);

                Writer.Dispose();
                Writer.Close();

            }
            else return;

        }

        private void LoadProject()
        {
            OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
            DialogResult Result = NewOpenFileDialog.ShowDialog();
            bool NoErrors = true;
            if (Result.ToString() == "OK")
            {
                string Filename = NewOpenFileDialog.FileName;
                FileInfo ProjectFile = new FileInfo(Filename);
                BinaryReader Reader = new BinaryReader(ProjectFile.OpenRead());

                try
                {
                    Parameters.IsEncryptCheckBoxChecked = Reader.ReadBoolean();
                    Parameters.Source = Reader.ReadString();
                    Parameters.SourceData = Reader.ReadString();
                    Parameters.ContainerData = Reader.ReadString();
                    Parameters.Password = Reader.ReadString();
                }
                catch
                {
                    NoErrors = false;
                }

                Reader.Dispose();
                Reader.Close();

                if (NoErrors)
                {
                    SetForm();
                }
                else MessageBox.Show("Файл проекта поврежден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
        }

        private void NewProject()
        {
            RefreshForm();
            if (Parameters.IsMasterCheckBoxChecked)
            {
                DialogMasterForm NewDialogMasterForm = new DialogMasterForm(this);
                NewDialogMasterForm.Show();
            }
        }

        public void RefreshForm()
        {
            SourceTextBox.Text = "";
            ContainerTextBox.Text = "";
            PasswordTextBox.Text = "";
            Parameters.IsEncryptCheckBoxChecked = false;
            Parameters.Source = "String";
            Parameters.SourceData = "";
            Parameters.ContainerData = "";
            Parameters.Password = "";
            Parameters.DestinationData = "";
            Parameters.Extension = "";
            Parameters.ExportContainerData = "";
            SetControls();
        }

        private void SetControls()
        {
            if (Parameters.Source == "String") OpenSourceButton.Enabled = false;
            else OpenSourceButton.Enabled = true;
            if (Parameters.IsEncryptCheckBoxChecked)
            {
                PasswordTextBox.Enabled = true;
                ConfirmTextBox.Enabled = true;
            }
            else
            {
                PasswordTextBox.Enabled = false;
                ConfirmTextBox.Enabled = false;
            }
        }

        private void общиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm NewSettingsForm = new SettingsForm();
            NewSettingsForm.ShowDialog();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void загрузитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void сохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void новыйПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void опцииПроектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm NewOptionsForm = new OptionsForm(this);
            NewOptionsForm.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameters.SourceData = SourceTextBox.Text;
        }

        private void ContainerTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameters.ContainerData = ContainerTextBox.Text;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameters.Password = PasswordTextBox.Text;
        }

        private void OpenSourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
            DialogResult Result = NewOpenFileDialog.ShowDialog();
            if (Result.ToString() == "OK")
            {   
                SourceTextBox.Text = NewOpenFileDialog.FileName;
            }
            else return;
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm NewAboutForm = new AboutForm();
            NewAboutForm.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            NewProject();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Сохранить изменения?", "Несохраненный проект", MessageBoxButtons.YesNoCancel);
            if (Result.ToString() == "Yes")
            {
                SaveProject();
            }
            else if (Result.ToString() == "Cancel") e.Cancel = true;

            SaveParameters();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Bitmap Container;
            byte[] EncryptedBytes;
            byte[] SourceBytes;
            string Filename;

            SaveFileDialog NewSaveContainerDialog = new SaveFileDialog();
            NewSaveContainerDialog.AddExtension = true;
            NewSaveContainerDialog.Filter = "Изображение (*.bmp) | *.bmp";

            if (Parameters.Source == "File")
            {
                FileInfo File;
                if (Parameters.SourceData != "")
                {
                    File = new FileInfo(Parameters.SourceData);
                }
                else
                {
                    File = null;
                    MessageBox.Show("Некорректный путь к файлу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (File.Exists)
                {
                    BinaryReader Reader = new BinaryReader(File.OpenRead());
                    SourceBytes = Reader.ReadBytes((int)File.Length);
                    Parameters.Extension = File.Extension;
                    Reader.Close();
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                SourceBytes = Encoding.Unicode.GetBytes(Parameters.SourceData);

            if (Parameters.IsEncryptCheckBoxChecked)
            {
                if (Parameters.Password != "")
                {
                    if (Parameters.Password == ConfirmTextBox.Text)
                    {
                        Encryption.GenerateKey(Parameters.Password);
                        EncryptedBytes = Encryption.RC2Encrypt(SourceBytes, 0, SourceBytes.Length);
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Пароль не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                EncryptedBytes = SourceBytes;

            Parameters.SourceSize = EncryptedBytes.Length;
            BMPCoder Coder = new BMPCoder(Parameters.SourceSize);
            Files.LoadBMP(out Container, Parameters.ContainerData);

            if (Container == null)
            {
                MessageBox.Show("Файл контейнера не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Parameters.SourceSize > Container.Width * Container.Height * 3 / 8 && Parameters.IsWarningCheckBoxChecked)
            {
                var DialogResult = MessageBox.Show("При данном размере файла возможно сильное искажение изображения. Продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.No)
                {
                    Container.Dispose();
                    return;
                }
            }

            try
            {
               Coder.Encoder(EncryptedBytes, ref Container);
            }
            catch (Exception Ex)
            {
                if (Ex.Message == "OverflowEx")
                    MessageBox.Show("Слишком большой размер данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Неопознанная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Container.Dispose();
                return;
            }

            DialogResult Result = NewSaveContainerDialog.ShowDialog();
            if (Result.ToString() == "OK")
                Filename = NewSaveContainerDialog.FileName;
            else return;

            Files.SaveBMP(Container, Filename);
            Files.SaveStegoKey(Filename);

            Parameters.Password = "";

            Container.Dispose();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void OpenSourceButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SelectedDir = new FolderBrowserDialog();
            SelectedDir.ShowNewFolderButton = true;
            DialogResult Result = SelectedDir.ShowDialog();
            if (Result == DialogResult.OK) SourceTextBox2.Text = SelectedDir.SelectedPath;
            else return;
        }

        private void OpenContainerButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
            DialogResult Result = NewOpenFileDialog.ShowDialog();
            if (Result.ToString() == "OK")
            {
                ContainerTextBox2.Text = NewOpenFileDialog.FileName;
            }
            else return;
        }

        private void ConfirmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            Bitmap Container;
            byte[] DecodedBytes;
            byte[] DecryptedBytes;
            string Extension = "";

            Files.LoadBMP(out Container, Parameters.ExportContainerData);
            try
            {
                Extension = Files.LoadStegoKey(Parameters.ExportContainerData);
            }
            catch(Exception Ex)
            {
                if (Ex.Message == "NotEncoded")
                    MessageBox.Show("Изображение не является контейнером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Файл контейнера не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
                
            }
            BMPCoder Coder = new BMPCoder(Parameters.SourceSize);
            DecodedBytes = Coder.Decoder(Container);

            if (Parameters.IsEncryptCheckBoxChecked)
            {
                if (Parameters.Password == "")
                {
                    MessageBox.Show("Содержимое зашифровано, введите пароль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DecryptedBytes = new byte[0];
                }
                else
                {
                    Encryption.GenerateKey(Parameters.Password);
                    DecryptedBytes = Encryption.RC2Decrypt(DecodedBytes, 0, DecodedBytes.Length);

                    if (DecryptedBytes == null)
                    {
                        MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DecryptedBytes = new byte[0];
                    }
                }
            }
            else
                DecryptedBytes = DecodedBytes;

            if (Parameters.Source == "File")
            {
                if (! Directory.Exists(Parameters.DestinationData))
                {
                    MessageBox.Show("Не задана папка для сохранения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Container.Dispose();
                    return;
                }
                else
                {
                    FileInfo File = new FileInfo(Parameters.DestinationData + "\\Decoded" + Extension);
                    BinaryWriter Writer = new BinaryWriter(File.Create());
                    Writer.Write(DecryptedBytes);
                    Writer.Close();
                }
            }
            else
                SourceTextBox2.Text = Encoding.Unicode.GetString(DecryptedBytes);

            Container.Dispose();
        }

        private void PasswordTextBox2_TextChanged(object sender, EventArgs e)
        {
            Parameters.Password = PasswordTextBox2.Text;
        }

        private void ContainerTextBox2_TextChanged(object sender, EventArgs e)
        {
            Parameters.ExportContainerData = ContainerTextBox2.Text;
        }

        private void SourceTextBox2_TextChanged(object sender, EventArgs e)
        {
            Parameters.DestinationData = SourceTextBox2.Text;
        }

        private void MainFormTabs_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void ImportTab_Click(object sender, EventArgs e)
        {

        }

        private void MainFormTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetForm();
        }
    }
}
