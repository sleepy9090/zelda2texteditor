using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zelda2texteditor
{
    public partial class Form_tn : Form
    {
        public Form_tn()
        {
            InitializeComponent();
        }

        string filename;
        string temphex, tempascii;
        int textFlag = 0;

        string[] zs = new string[0x1C];
        byte[] zb = new byte[0x1C];
        int[] zd = new int[0x1C];
        string[] zs_final = new string[0x1C];
        string[] zsw = new string[0x1C];
        string ZeldaHexReturn = "";
        int i = 0;

        string newgcString;
        int x = 0, q = 0, offset = 0x0;

        public string fntootherform
        {
            get
            {
                return filename;
            }
            set
            {
                filename = value;
            }
        }

        private void Form_tn_Load(object sender, EventArgs e)
        {
            loc1TextBox.MaxLength = 0x13;
            loc2TextBox.MaxLength = 0xd;
            loc3TextBox.MaxLength = 0x19;
            loc4TextBox.MaxLength = 0x12;
            loc5TextBox.MaxLength = 0x17;
            loc6TextBox.MaxLength = 0x14;
            loc7TextBox.MaxLength = 0x1a;
            loc8TextBox.MaxLength = 0x18;
            loc9TextBox.MaxLength = 0x7;


            string rctext = "";
            string zeldaAsciiRet = "";
            int x = 0;


            FileStream fs1 = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            fs1.Seek(0xE4DD, SeekOrigin.Begin);
            while (x < 0x13)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc1TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xE624, SeekOrigin.Begin);
            while (x < 0xd)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc2TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xE72D, SeekOrigin.Begin);
            while (x < 0x19)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc3TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xEA30, SeekOrigin.Begin);
            while (x < 0x12)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc4TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xE8D8, SeekOrigin.Begin);
            while (x < 0x17)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc5TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xEB34, SeekOrigin.Begin);
            while (x < 0x14)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc6TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xECF6, SeekOrigin.Begin);
            while (x < 0x1a)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc7TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xEE2F, SeekOrigin.Begin);
            while (x < 0x18)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc8TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0xEF38, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            loc9TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Close();
        }





























        private void writeByte()
        {
            FileStream fs2 = new FileStream(@filename, FileMode.Open, FileAccess.Write);
            i = newgcString.Length;
            x = 0;
            while (x < i)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            //setup array
            zhrArray();

            q = 0;
            while (q < i)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(offset, SeekOrigin.Begin);
            q = 0;
            while (q < i)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            fs2.Close();
        }


        private void zhrArray()
        {
            //3 is smallest, 0xb is largest
            //send a value over as stringlength, denote it as i

            if (i > 0x2)
            {
                zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
                zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
                zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            }
            if (i > 0x3)
            {
                zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            }
            if (i > 0x4)
            {
                zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            }
            if (i > 0x5)
            {
                zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            }
            if (i > 0x6)
            {
                zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            }
            if (i > 0x7)
            {
                zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            }
            if (i > 0x8)
            {
                zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            }
            if (i > 0x9)
            {
                zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            }
            if (i > 0xa)
            {
                zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            }
            if (i > 0xb)
            {
                zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            }
            if (i > 0xc)
            {
                zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            }
            if (i > 0xd)
            {
                zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            }
            if (i > 0xe)
            {
                zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            }
            if (i > 0xf)
            {
                zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            }
            if (i > 0x10)
            {
                zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            }
            if (i > 0x11)
            {
                zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            }
            if (i > 0x12)
            {
                zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();
            }
            if (i > 0x13)
            {
                zsw[19] = ZeldaHexReturn[38].ToString() + ZeldaHexReturn[39].ToString();
            }
            if (i > 0x14)
            {
                zsw[20] = ZeldaHexReturn[40].ToString() + ZeldaHexReturn[41].ToString();
            }
            if (i > 0x15)
            {
                zsw[21] = ZeldaHexReturn[42].ToString() + ZeldaHexReturn[43].ToString();
            }
            if (i > 0x16)
            {
                zsw[22] = ZeldaHexReturn[44].ToString() + ZeldaHexReturn[45].ToString();
            }
            if (i > 0x17)
            {
                zsw[23] = ZeldaHexReturn[46].ToString() + ZeldaHexReturn[47].ToString();
            }
            if (i > 0x18)
            {
                zsw[24] = ZeldaHexReturn[48].ToString() + ZeldaHexReturn[49].ToString();
            }
            if (i > 0x19)
            {
                zsw[25] = ZeldaHexReturn[50].ToString() + ZeldaHexReturn[51].ToString();
            }
            if (i > 0x1A)
            {
                zsw[26] = ZeldaHexReturn[52].ToString() + ZeldaHexReturn[53].ToString();
            }
            if (i > 0x1B)
            {
                zsw[27] = ZeldaHexReturn[54].ToString() + ZeldaHexReturn[55].ToString();
            }
            if (i > 0x1C)
            {
                zsw[28] = ZeldaHexReturn[56].ToString() + ZeldaHexReturn[57].ToString();
            }
        }




        private string decodeZText()
        {
            string zeldaAscii = "";
            textFlag = 0;

            switch (temphex)
            {
                case "34":
                    zeldaAscii += "?";
                    break;
                case "36":
                    zeldaAscii += "!";
                    break;
                case "(9C":
                    zeldaAscii += ",";
                    break;
                case "CF":
                    zeldaAscii += ".";
                    break;
                case "D0":
                    zeldaAscii += "0";
                    break;
                case "D1":
                    zeldaAscii += "1";
                    break;
                case "D2":
                    zeldaAscii += "2";
                    break;
                case "D3":
                    zeldaAscii += "3";
                    break;
                case "D4":
                    zeldaAscii += "4";
                    break;
                case "D5":
                    zeldaAscii += "5";
                    break;
                case "D6":
                    zeldaAscii += "6";
                    break;
                case "D7":
                    zeldaAscii += "7";
                    break;
                case "D8":
                    zeldaAscii += "8";
                    break;
                case "D9":
                    zeldaAscii += "9";
                    break;
                case "DA":
                    zeldaAscii += "A";
                    break;
                case "DB":
                    zeldaAscii += "B";
                    break;
                case "DC":
                    zeldaAscii += "C";
                    break;
                case "DD":
                    zeldaAscii += "D";
                    break;
                case "DE":
                    zeldaAscii += "E";
                    break;
                case "DF":
                    zeldaAscii += "F";
                    break;
                case "E0":
                    zeldaAscii += "G";
                    break;
                case "E1":
                    zeldaAscii += "H";
                    break;
                case "E2":
                    zeldaAscii += "I";
                    break;
                case "E3":
                    zeldaAscii += "J";
                    break;
                case "E4":
                    zeldaAscii += "K";
                    break;
                case "E5":
                    zeldaAscii += "L";
                    break;
                case "E6":
                    zeldaAscii += "M";
                    break;
                case "E7":
                    zeldaAscii += "N";
                    break;
                case "E8":
                    zeldaAscii += "O";
                    break;
                case "E9":
                    zeldaAscii += "P";
                    break;
                case "EA":
                    zeldaAscii += "Q";
                    break;
                case "EB":
                    zeldaAscii += "R";
                    break;
                case "EC":
                    zeldaAscii += "S";
                    break;
                case "ED":
                    zeldaAscii += "T";
                    break;
                case "EE":
                    zeldaAscii += "U";
                    break;
                case "EF":
                    zeldaAscii += "V";
                    break;
                case "F0":
                    zeldaAscii += "W";
                    break;
                case "F1":
                    zeldaAscii += "X";
                    break;
                case "F2":
                    zeldaAscii += "Y";
                    break;
                case "F3":
                    zeldaAscii += "Z";
                    break;
                case "F4":
                    zeldaAscii += " ";
                    break;
                case "F5":
                    zeldaAscii += " ";
                    break;
                case "F6":
                    zeldaAscii += "-";
                    break;
                case "0E":
                    zeldaAscii += "@";
                    break;
                default:
                    zeldaAscii += " ";
                    textFlag = 1;
                    break;
            }
            return zeldaAscii;
        }

        private string encodeZText()
        {
            string zeldaHexAscii = "";

            switch (tempascii)
            {
                case "?":
                    zeldaHexAscii += "34";
                    break;
                case "!":
                    zeldaHexAscii += "36";
                    break;
                case ",":
                    zeldaHexAscii += "9C";
                    break;
                case ".":
                    zeldaHexAscii += "CF";
                    break;
                case "0":
                    zeldaHexAscii += "D0";
                    break;
                case "1":
                    zeldaHexAscii += "D1";
                    break;
                case "2":
                    zeldaHexAscii += "D2";
                    break;
                case "3":
                    zeldaHexAscii += "D3";
                    break;
                case "4":
                    zeldaHexAscii += "D4";
                    break;
                case "5":
                    zeldaHexAscii += "D5";
                    break;
                case "6":
                    zeldaHexAscii += "D6";
                    break;
                case "7":
                    zeldaHexAscii += "D7";
                    break;
                case "8":
                    zeldaHexAscii += "D8";
                    break;
                case "9":
                    zeldaHexAscii += "D9";
                    break;
                case "A":
                    zeldaHexAscii += "DA";
                    break;
                case "B":
                    zeldaHexAscii += "DB";
                    break;
                case "C":
                    zeldaHexAscii += "DC";
                    break;
                case "D":
                    zeldaHexAscii += "DD";
                    break;
                case "E":
                    zeldaHexAscii += "DE";
                    break;
                case "F":
                    zeldaHexAscii += "DF";
                    break;
                case "G":
                    zeldaHexAscii += "E0";
                    break;
                case "H":
                    zeldaHexAscii += "E1";
                    break;
                case "I":
                    zeldaHexAscii += "E2";
                    break;
                case "J":
                    zeldaHexAscii += "E3";
                    break;
                case "K":
                    zeldaHexAscii += "E4";
                    break;
                case "L":
                    zeldaHexAscii += "E5";
                    break;
                case "M":
                    zeldaHexAscii += "E6";
                    break;
                case "N":
                    zeldaHexAscii += "E7";
                    break;
                case "O":
                    zeldaHexAscii += "E8";
                    break;
                case "P":
                    zeldaHexAscii += "E9";
                    break;
                case "Q":
                    zeldaHexAscii += "EA";
                    break;
                case "R":
                    zeldaHexAscii += "EB";
                    break;
                case "S":
                    zeldaHexAscii += "EC";
                    break;
                case "T":
                    zeldaHexAscii += "ED";
                    break;
                case "U":
                    zeldaHexAscii += "EE";
                    break;
                case "V":
                    zeldaHexAscii += "EF";
                    break;
                case "W":
                    zeldaHexAscii += "F0";
                    break;
                case "X":
                    zeldaHexAscii += "F1";
                    break;
                case "Y":
                    zeldaHexAscii += "F2";
                    break;
                case "Z":
                    zeldaHexAscii += "F3";
                    break;
                case " ":
                    zeldaHexAscii += "F4";
                    break;
                case "-":
                    zeldaHexAscii += "F6";
                    break;
                case "@":
                    zeldaHexAscii += "0E";
                    break;
                case "a":
                    zeldaHexAscii += "DA";
                    break;
                case "b":
                    zeldaHexAscii += "DB";
                    break;
                case "c":
                    zeldaHexAscii += "DC";
                    break;
                case "d":
                    zeldaHexAscii += "DD";
                    break;
                case "e":
                    zeldaHexAscii += "DE";
                    break;
                case "f":
                    zeldaHexAscii += "DF";
                    break;
                case "g":
                    zeldaHexAscii += "E0";
                    break;
                case "h":
                    zeldaHexAscii += "E1";
                    break;
                case "i":
                    zeldaHexAscii += "E2";
                    break;
                case "j":
                    zeldaHexAscii += "E3";
                    break;
                case "k":
                    zeldaHexAscii += "E4";
                    break;
                case "l":
                    zeldaHexAscii += "E5";
                    break;
                case "m":
                    zeldaHexAscii += "E6";
                    break;
                case "n":
                    zeldaHexAscii += "E7";
                    break;
                case "o":
                    zeldaHexAscii += "E8";
                    break;
                case "p":
                    zeldaHexAscii += "E9";
                    break;
                case "q":
                    zeldaHexAscii += "EA";
                    break;
                case "r":
                    zeldaHexAscii += "EB";
                    break;
                case "s":
                    zeldaHexAscii += "EC";
                    break;
                case "t":
                    zeldaHexAscii += "ED";
                    break;
                case "u":
                    zeldaHexAscii += "EE";
                    break;
                case "v":
                    zeldaHexAscii += "EF";
                    break;
                case "w":
                    zeldaHexAscii += "F0";
                    break;
                case "x":
                    zeldaHexAscii += "F1";
                    break;
                case "y":
                    zeldaHexAscii += "F2";
                    break;
                case "z":
                    zeldaHexAscii += "F3";
                    break;
                default:
                    zeldaHexAscii += "F4";
                    break;
            }

            return zeldaHexAscii;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newgcString = loc1TextBox.Text;
            newgcString = newgcString.PadRight(0x13);
            offset = 0xE4DD;
            writeByte();

            newgcString = loc2TextBox.Text;
            newgcString = newgcString.PadRight(0xd);
            offset = 0xE624;
            writeByte();

            newgcString = loc3TextBox.Text;
            newgcString = newgcString.PadRight(0x19);
            offset = 0xE72D;
            writeByte();

            newgcString = loc4TextBox.Text;
            newgcString = newgcString.PadRight(0x12);
            offset = 0xEA30;
            writeByte();

            newgcString = loc5TextBox.Text;
            newgcString = newgcString.PadRight(0x17);
            offset = 0xE8D8;
            writeByte();

            newgcString = loc6TextBox.Text;
            newgcString = newgcString.PadRight(0x14);
            offset = 0xEB34;
            writeByte();

            newgcString = loc7TextBox.Text;
            newgcString = newgcString.PadRight(0x1a);
            offset = 0xECF6;
            writeByte();

            newgcString = loc8TextBox.Text;
            newgcString = newgcString.PadRight(0x18);
            offset = 0xEE2F;
            writeByte();

            newgcString = loc9TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEF38;
            writeByte();

            MessageBox.Show("Updated!", "Locations Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }



    }
}
