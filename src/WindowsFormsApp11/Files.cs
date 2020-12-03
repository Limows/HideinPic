using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp11
{
    class Files
    {
        public static void SaveBMP(Bitmap Container, string FileName)
        {
            Container.Save(FileName, ImageFormat.Bmp);
        }

        public static void LoadBMP(out Bitmap Container, string FileName)
        {
            try
            {
                using (Stream BMPStream = System.IO.File.Open(FileName, System.IO.FileMode.Open))
                {
                    Image Picture = Image.FromStream(BMPStream);

                    Container = new Bitmap(Picture);

                }
            }
            catch
            {
                Container = null;
            }
        }

        public static void SaveStegoKey(string FileName)
        {
            FileInfo File = new FileInfo(FileName);
            BinaryWriter Writer = new BinaryWriter(File.Open(FileMode.Append, FileAccess.Write));
            char[] Key = new char[256];
            int i = 0;

            foreach (char letter in Parameters.SourceSize.ToString())
            {
                Key[i] = letter;
                i++;
            }

            i = 16;

            Key[i] = (Parameters.IsEncryptCheckBoxChecked) ? '1' : '0';

            i++;

            Key[i] = (Parameters.Source == "File") ? '1' : '0';

            i++;

            Key[i] = (BMPParams.UseR) ? '1' : '0';

            i++;

            Key[i] = (BMPParams.UseG) ? '1' : '0';

            i++;

            Key[i] = (BMPParams.UseG) ? '1' : '0';

            i++;

            if (Parameters.Source == "String") Parameters.Extension = "";

            foreach (char letter in Parameters.Extension)
            {
                Key[i] = letter;
                i++;
            }

            byte[] KeyByte = Encoding.Default.GetBytes(Key);
            Writer.Write(KeyByte);
            Writer.Write(Parameters.IsEncryptCheckBoxChecked);
            Writer.Close();
            
        }

        public static void SaveParams(string FileName)
        {
            FileInfo File = new FileInfo(FileName);
            BinaryWriter Writer = new BinaryWriter(File.Open(FileMode.Append, FileAccess.Write));

            Writer.Write(Parameters.IsEncryptCheckBoxChecked);
            Writer.Close();
        }

        public static string LoadStegoKey(string FileName)
        {
            byte[] Key;
            string ParsedKey = "";
            FileInfo File = new FileInfo(FileName);
            BinaryReader Reader = new BinaryReader(File.OpenRead());
            Key = Reader.ReadBytes((int)File.Length - 257);
            Key = Reader.ReadBytes(256);
            Reader.Close();
            try
            {
                ParsedKey = StegoKeyParser(Key);
            }
            catch
            {
                throw new Exception("NotEncoded");
            }
            return ParsedKey;
        }

        static string StegoKeyParser(byte[] Key)
        {
            var re = new Regex("\0");
            string Expansion = "";
            byte[] Size = new byte[16];

            for (int i = 0; i < 16; i++)
                Size[i] = Key[i];

            Parameters.SourceSize = Convert.ToInt32(Encoding.Default.GetString(Size));

            Parameters.IsEncryptCheckBoxChecked = (Key[16] == '1') ? true : false;

            Parameters.Source = (Key[17] == '1') ? "File" : "String";

            BMPParams.UseR = (Key[18] == '1') ? true : false;

            BMPParams.UseG = (Key[19] == '1') ? true : false;

            BMPParams.UseB = (Key[20] == '1') ? true : false;

            for (int i = 21; i < 256; i++)
                Expansion += (char)Key[i];

            Expansion = re.Replace(Expansion, "");
            return Expansion;
        }

        public static bool LoadParams(string FileName)
        {
            byte[] IsEncryptCheckBoxChecked;
            FileInfo File = new FileInfo(FileName);
            BinaryReader Reader = new BinaryReader(File.OpenRead());
            IsEncryptCheckBoxChecked = Reader.ReadBytes((int)File.Length - 1);
            IsEncryptCheckBoxChecked = Reader.ReadBytes(1);
            Reader.Close();
            return (IsEncryptCheckBoxChecked[0] == 1) ? true : false;
        }

    }
}
