using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace WindowsFormsApp11
{
    class BMPCoder
    {
        int MaxSourceSize = 0;
        int SourceSize = 0;
        bool UseR = true;
        bool UseG = false;
        bool UseB = false;
        int ChannelCount = 0;
        bool UseMultyple = false;

        struct Point
        {
            public int X;
            public int Y;
            public Point(int NewX, int NewY)
            {
                X = NewX;
                Y = NewY;
            }
        }

        int ChannelInit()
        {
            int i = 0;

            if (UseR) i++;
            if (UseG) i++;
            if (UseB) i++;

            return i;
        }

        public BMPCoder(int StegoKey)
        {
            SourceSize = StegoKey;
            UseR = BMPParams.UseR;
            UseG = BMPParams.UseG;
            UseB = BMPParams.UseB;
            UseMultyple = BMPParams.UseMultyple;
            ChannelCount = ChannelInit();
        }

        void GetMaxSourceSize(Bitmap Container)
        {
            MaxSourceSize = ChannelCount * Container.Height * Container.Width / 8;
        }

        Point GetPosition(Point Point, int Step, int Width)

        {
            Point NewPoint = new Point(Point.X, Point.Y);
            int StepX = Point.X + Step;

            while (StepX >= Width)
            {
                StepX -= Width;
                NewPoint.Y++;
            }

            NewPoint.X = StepX;

            return NewPoint;
        }

        bool GetBit(byte Byte, byte Number)
        {
            bool Bit = (Byte & (1 << Number)) != 0;
            return Bit;
        }

        byte BitToByte(byte Byte, bool Bit, int BitNum)
        {
            byte[] NewByte = new byte[1];
            byte[] OldByte = new byte[] { Byte };
            BitArray Bits = new BitArray(new byte[] { Byte });
            Bits.Set(BitNum, Bit);
            Bits.CopyTo(NewByte, 0);
            return NewByte[0];
        }

        public void Encoder(byte[] Source, ref Bitmap Container)
        {
            GetMaxSourceSize(Container);
            int Step = (8 * MaxSourceSize) / SourceSize;
            byte BitNum = 0;

            if (Step < 8)
            {
                if (!UseMultyple) throw new Exception("OverflowEx");
                else
                {
                    if (Step < 1) throw new Exception("OverflowEx");
                    else Step = 1;
                }
            }
            else Step /= 8;

            //if (UseMultyple)
            //{
            //    Step *= 8;
            //}

            Point Next;    // позиция следующего кодируемого пиксела
            Point First = new Point(0, 0);   // позиция кодированного пиксела
            byte SourceByte;  // переменная для хранения символа
            Color PointColor = new Color();
            SourceByte = Source[0];
            byte j = 0;

            for (int i = 0; i < SourceSize;)
            {   
                Next = GetPosition(First, Step, Container.Width);

                if (First.Y >= Container.Height)
                {
                    if (!UseMultyple) First.Y--;
                    else
                    {
                        First = new Point(0, 0);
                        Next = First;
                        BitNum++;
                    }
                }

                PointColor = Container.GetPixel(First.X, First.Y);

                byte R = PointColor.R;
                byte G = PointColor.G;
                byte B = PointColor.B;

                if (UseR)
                {
                    if (j >= 8)
                    {
                        i++;
                        if (i == SourceSize)
                        {
                            PointColor = Color.FromArgb(R, G, B);
                            Container.SetPixel(First.X, First.Y, PointColor);
                            break;
                        }
                        SourceByte = Source[i];
                        j = 0;
                    }

                    bool Bit = GetBit(SourceByte, j); 
                    R = BitToByte(R, Bit, BitNum);
                    j++;
                }

                if (UseG)
                {
                    if (j >= 8)
                    {
                        i++;
                        if (i == SourceSize)
                        {
                            PointColor = Color.FromArgb(R, G, B);
                            Container.SetPixel(First.X, First.Y, PointColor);
                            break;
                        }
                        SourceByte = Source[i];
                        j = 0;
                    }

                    bool Bit = GetBit(SourceByte, j); 
                    G = BitToByte(G, Bit, BitNum); 
                    j++;
                }

                if (UseB)
                {
                    if (j >= 8)
                    {
                        i++;
                        if (i == SourceSize)
                        {
                            PointColor = Color.FromArgb(R, G, B);
                            Container.SetPixel(First.X, First.Y, PointColor);
                            break;
                        }
                        SourceByte = Source[i];
                        j = 0;
                    }

                    bool Bit = GetBit(SourceByte, j); 
                    B = BitToByte(B, Bit, BitNum);        
                    j++;
                }

                PointColor = Color.FromArgb(R, G, B);

                Container.SetPixel(First.X, First.Y, PointColor);

                First = Next;
            }

            /*for (int i = 0; i < SourceSize; i++)  // перебор символов
            {
                SourceByte = Source[i]; // загоняем очередной символ

                for (byte j = 0; j < 8;) // перебор битов символа
                {
                    Next = GetPosition(First, Step, Width);

                    PointColor = Container.GetPixel(First.X, First.Y);

                    byte R = PointColor.R;
                    byte G = PointColor.G;
                    byte B = PointColor.B;

                    if (UseR)
                    {
                        if (j < 8)
                        {
                            bool Bit = GetBit(SourceByte, j); // получили записываемый бит
                            R = BitToByte(R, Bit);         // записали jй бит в канал
                            j++;
                        }
                    }
                    if (UseG)
                    {
                        if (j < 8)
                        {
                            bool Bit = GetBit(SourceByte, j); // получили записываемый бит
                            G = BitToByte(G, Bit);         // записали jй бит в канал
                            j++;
                        }
                    }
                    if (UseB)
                    {
                        if (j < 8)
                        {
                            bool Bit = GetBit(SourceByte, j); // получили записываемый бит
                            B = BitToByte(B, Bit);         // записали jй бит в канал
                            j++;
                        }
                    }

                    PointColor = Color.FromArgb(R, G, B);

                    Container.SetPixel(First.X, First.Y, PointColor); // переопределили цвет

                    First = Next;
                }
            } */
        }

        public byte[] Decoder(Bitmap Container)
        {
            Point Next;   
            Point First = new Point(0, 0);  
            GetMaxSourceSize(Container);
            int Step = MaxSourceSize / SourceSize;
            int j = 0;

            if (Step < 1) Step = 1;

            int Width = Container.Width;
            byte[] DecodedBytes = new byte[SourceSize];
            byte BitNum = 0;
            BitArray Bits = new BitArray(8);

            for (int i = 0; i < SourceSize;)
            {

                Next = GetPosition(First, Step, Width);

                if (First.Y >= Container.Height)
                {
                    if (!UseMultyple) First.Y--;
                    else
                    {
                        First = new Point(0, 0);
                        Next = First;
                        BitNum++;
                    }
                }

                Color PointColor = Container.GetPixel(First.X, First.Y);

                byte R = PointColor.R;
                byte G = PointColor.G;
                byte B = PointColor.B;

                if (UseR)
                {
                    if (j >= 8)
                    {
                        Bits.CopyTo(DecodedBytes, i);
                        i++;
                        if (i == SourceSize) break;
                        Bits = new BitArray(8);
                        j = 0;

                    }

                    Bits.Set(j, GetBit(R, BitNum));
                    j++;
                }

                if (UseG)
                {
                    if (j >= 8)
                    {
                        Bits.CopyTo(DecodedBytes, i);
                        i++;
                        if (i == SourceSize) break;
                        Bits = new BitArray(8);
                        j = 0;

                    }

                    Bits.Set(j, GetBit(G, BitNum));
                    j++;
                }

                if (UseB)
                {
                    if (j >= 8)
                    {
                        Bits.CopyTo(DecodedBytes, i);
                        i++;
                        if (i == SourceSize) break;
                        Bits = new BitArray(8);
                        j = 0;

                    }

                    Bits.Set(j, GetBit(B, BitNum));
                    j++;
                }

                First = Next;

            }

            return DecodedBytes;

        }

 /*       public byte[] Decoder(Bitmap Container)
        {
            Point Next;    // позиция следующего кодируемого пиксела
            Point First = new Point(0, 0);   // позиция кодированного пиксел
            GetMaxSourceSize(Container);
            int Step = MaxSourceSize / SourceSize;

            if (Step < 1) Step = 1;

            int Width = Container.Width;
            byte[] DecodedBytes = new byte[SourceSize];
            byte BitNum = 0;

            for (int i = 0; i < SourceSize; i++)  // перебор символов дешифруемого сообщения
            {
                BitArray Bits = new BitArray(8); // массив для хранения битов

                for (int j = 0; j < 8;) // перебор битов символа
                {
                    Next = GetPosition(First, Step, Width);

                    if (First.Y >= Container.Height)
                    {
                        if (!UseMultyple) First.Y--;
                        else
                        {
                            First = new Point(0, 0);
                            Next = First;
                            BitNum++;
                        }
                    }

                    Color PointColor = Container.GetPixel(First.X, First.Y);

                    byte R = PointColor.R;
                    byte G = PointColor.G;
                    byte B = PointColor.B;

                    if (UseR)
                    {
                        if (j < 8)
                        {
                            Bits.Set(j, GetBit(R, BitNum));
                            j++;
                        }
                    }

                    if (UseG)
                    {
                        if (j < 8)
                        {
                            Bits.Set(j, GetBit(G, BitNum));
                            j++;
                        }
                    }

                    if (UseB)
                    {
                        if (j < 8)
                        {
                            Bits.Set(j, GetBit(B, BitNum));
                            j++;
                        }
                    }

                    First = Next;
                }

                Bits.CopyTo(DecodedBytes, i);
            }

            return DecodedBytes;

        }*/
    }
}
