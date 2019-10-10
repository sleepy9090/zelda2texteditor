/**
 * @file           FormCredits.cs
 * @brief          Creates the form for changing text for credits.
 *
 * @copyright      Shawn M. Crawford
 * @date           10/10/2019
 *
 * @remark Author  Shawn M. Crawford
 *
 * @note           N/A
 * 
 */
using System;
using System.IO;
using System.Windows.Forms;

namespace zelda2texteditor
{
    public partial class FormCredits : Form
    {
        public string FullFilename { get; set; }

        public FormCredits()
        {
            InitializeComponent();
        }

        string filename;
        string temphex, tempascii;
        int textFlag = 0;

        

        private void FormCredits_Load(object sender, EventArgs e)
        {
            //textbox length
            gctextBox1.MaxLength = 0x3;
            gctextBox2.MaxLength = 0x5;
            gctextBox3.MaxLength = 0x6;
            gctextBox4.MaxLength = 0x6;
            gctextBox5.MaxLength = 0x3;
            gctextBox6.MaxLength = 0x1;
            gctextBox7.MaxLength = 0x4;
            gctextBox8.MaxLength = 0x4;
            gctextBox9.MaxLength = 0x12;
            gctextBox10.MaxLength = 0xa;
            gctextBox11.MaxLength = 0x12;
            gctextBox12.MaxLength = 0xa;
            gctextBox13.MaxLength = 0x8;
            gctextBox14.MaxLength = 0x7;
            gctextBox15.MaxLength = 0x8;
            gctextBox16.MaxLength = 0x7;
            gctextBox17.MaxLength = 0xe;
            gctextBox18.MaxLength = 0x8;
            gctextBox19.MaxLength = 0xe;
            gctextBox20.MaxLength = 0x9;
            gctextBox21.MaxLength = 0x8;
            gctextBox22.MaxLength = 0x11;
            gctextBox23.MaxLength = 0xa;
            gctextBox24.MaxLength = 0x9;
            gctextBox25.MaxLength = 0x9;
            gctextBox26.MaxLength = 0x8;
            gctextBox27.MaxLength = 0x9;
            gctextBox28.MaxLength = 0x7;


            string rctext = "";
            string zeldaAsciiRet = "";
            int x = 0;

            FileStream fs1 = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            fs1.Seek(0x14DF1, SeekOrigin.Begin);
            while (x < 0x3)
            {
                rctext = fs1.ReadByte().ToString("X");
                //if length is single digit add a 0 ( 1 now is 01)
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
            gctextBox1.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x14DF5, SeekOrigin.Begin);
            while (x < 0x5)
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
            gctextBox2.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x14DFB, SeekOrigin.Begin);
            while (x < 0x6)
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
            gctextBox3.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x14E02, SeekOrigin.Begin);
            while (x < 0x6)
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
            gctextBox4.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x14E09, SeekOrigin.Begin);
            while (x < 0x3)
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
            gctextBox5.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x14E0D, SeekOrigin.Begin);
            while (x < 0x1)
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
            gctextBox6.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x14E0F, SeekOrigin.Begin);
            while (x < 0x4)
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
            gctextBox7.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x14E14, SeekOrigin.Begin);
            while (x < 0x4)
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
            gctextBox8.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x15290, SeekOrigin.Begin);
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
            gctextBox9.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x152A6, SeekOrigin.Begin);
            while (x < 0xa)
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
            gctextBox10.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x152B4, SeekOrigin.Begin);
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
            gctextBox11.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x152CA, SeekOrigin.Begin);
            while (x < 0xa)
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
            gctextBox12.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x152D8, SeekOrigin.Begin);
            while (x < 0x8)
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
            gctextBox13.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x152E4, SeekOrigin.Begin);
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
            gctextBox14.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x152F9, SeekOrigin.Begin);
            while (x < 0x8)
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
            gctextBox15.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x15305, SeekOrigin.Begin);
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
            gctextBox16.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x1531A, SeekOrigin.Begin);
            while (x < 0xe)
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
            gctextBox17.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x1532C, SeekOrigin.Begin);
            while (x < 0x8)
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
            gctextBox18.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x15338, SeekOrigin.Begin);
            while (x < 0xe)
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
            gctextBox19.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x1534A, SeekOrigin.Begin);
            while (x < 0x9)
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
            gctextBox20.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x15356, SeekOrigin.Begin);
            while (x < 0x8)
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
            gctextBox21.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x15362, SeekOrigin.Begin);
            while (x < 0x11)
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
            gctextBox22.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;
        
            //next
            fs1.Seek(0x15377, SeekOrigin.Begin);
            while (x < 0xa)
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
            gctextBox23.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x15384, SeekOrigin.Begin);
            while (x < 0x9)
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
            gctextBox24.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;


            //next
            fs1.Seek(0x15391, SeekOrigin.Begin);
            while (x < 0x9)
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
            gctextBox25.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x1539D, SeekOrigin.Begin);
            while (x < 0x8)
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
            gctextBox26.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x153A9, SeekOrigin.Begin);
            while (x < 0x9)
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
            gctextBox27.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next
            fs1.Seek(0x152EE, SeekOrigin.Begin);
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
            gctextBox28.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Close();

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            //write the new text to string
            string newgcString;
            string ZeldaHexReturn = "";

            newgcString = gctextBox1.Text;

            //pad string length to 3 so no array errors
            newgcString = newgcString.PadRight(0x3);

            //setup arrays
            string[] zs = new string[3];
            byte[] zb = new byte[3];
            int[] zd = new int[3];
            string[] zs_final = new string[3];
            string[] zsw = new string[3];

            while (x < 3)
            {
                zs[x] = newgcString[x].ToString();

                //convert string back into zelda text hex code
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();

            //convert the chars to int32, then to string, then byte again
            int q = 0;
            while (q < 3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            FileStream fs2 = new FileStream(@filename, FileMode.Open, FileAccess.Write);
            fs2.Seek(0x14DF1, SeekOrigin.Begin);   // Seek to 0x14DF1th byte in the file

            //this is converting to hex before it writes
            q = 0;
            while (q < 3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox2.Text;
            newgcString = newgcString.PadRight(0x5);

            string[] zs2 = new string[5];
            byte[] zb2 = new byte[5];
            int[] zd2 = new int[5];
            string[] zs_final2 = new string[5];
            string[] zsw2 = new string[5];

            x = 0;
            while (x < 5)
            {
                zs2[x] = newgcString[x].ToString();
                tempascii = zs2[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw2[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw2[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw2[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw2[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw2[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();

            q = 0;
            while (q < 5)
            {
                zd2[q] = int.Parse(zsw2[q], System.Globalization.NumberStyles.HexNumber);
                zs_final2[q] = zd2[q].ToString();
                zb2[q] = byte.Parse(zs_final2[q]);
                q++;
            }

            fs2.Seek(0x14DF5, SeekOrigin.Begin);
            q = 0;
            while (q < 5)
            {
                fs2.WriteByte(zb2[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox3.Text;
            newgcString = newgcString.PadRight(0x6);

            string[] zs3 = new string[6];
            byte[] zb3 = new byte[6];
            int[] zd3 = new int[6];
            string[] zs_final3 = new string[6];
            string[] zsw3 = new string[6];
            x = 0;
            while (x < 6)
            {
                zs3[x] = newgcString[x].ToString();
                tempascii = zs3[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw3[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw3[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw3[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw3[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw3[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw3[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();

            q = 0;
            while (q < 6)
            {
                zd3[q] = int.Parse(zsw3[q], System.Globalization.NumberStyles.HexNumber);
                zs_final3[q] = zd3[q].ToString();
                zb3[q] = byte.Parse(zs_final3[q]);
                q++;
            }

            fs2.Seek(0x14DFB, SeekOrigin.Begin);
            q = 0;
            while (q < 6)
            {
                fs2.WriteByte(zb3[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox4.Text;
            newgcString = newgcString.PadRight(0x6);

            string[] zs4 = new string[6];
            byte[] zb4 = new byte[6];
            int[] zd4 = new int[6];
            string[] zs_final4 = new string[6];
            string[] zsw4 = new string[6];
            x = 0;
            while (x < 6)
            {
                zs4[x] = newgcString[x].ToString();
                tempascii = zs4[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw4[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw4[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw4[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw4[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw4[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw4[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();

            q = 0;
            while (q < 6)
            {
                zd4[q] = int.Parse(zsw4[q], System.Globalization.NumberStyles.HexNumber);
                zs_final4[q] = zd4[q].ToString();
                zb4[q] = byte.Parse(zs_final4[q]);
                q++;
            }

            fs2.Seek(0x14E02, SeekOrigin.Begin);
            q = 0;
            while (q < 6)
            {
                fs2.WriteByte(zb4[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox5.Text;
            newgcString = newgcString.PadRight(0x3);

            string[] zs5 = new string[3];
            byte[] zb5 = new byte[3];
            int[] zd5 = new int[3];
            string[] zs_final5 = new string[3];
            string[] zsw5 = new string[3];
            x = 0;
            while (x < 3)
            {
                zs5[x] = newgcString[x].ToString();
                tempascii = zs5[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw5[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw5[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw5[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();

            q = 0;
            while (q < 3)
            {
                zd5[q] = int.Parse(zsw5[q], System.Globalization.NumberStyles.HexNumber);
                zs_final5[q] = zd5[q].ToString();
                zb5[q] = byte.Parse(zs_final5[q]);
                q++;
            }

            fs2.Seek(0x14E09, SeekOrigin.Begin);
            q = 0;
            while (q < 3)
            {
                fs2.WriteByte(zb5[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox6.Text;
            newgcString = newgcString.PadRight(0x1);

            string[] zs6 = new string[1];
            byte[] zb6 = new byte[1];
            int[] zd6 = new int[1];
            string[] zs_final6 = new string[1];
            string[] zsw6 = new string[1];
            x = 0;
            while (x < 1)
            {
                zs6[x] = newgcString[x].ToString();
                tempascii = zs6[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw6[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();

            q = 0;
            while (q < 1)
            {
                zd6[q] = int.Parse(zsw6[q], System.Globalization.NumberStyles.HexNumber);
                zs_final6[q] = zd6[q].ToString();
                zb6[q] = byte.Parse(zs_final6[q]);
                q++;
            }

            fs2.Seek(0x14E0D, SeekOrigin.Begin);
            q = 0;
            while (q < 1)
            {
                fs2.WriteByte(zb6[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox7.Text;
            newgcString = newgcString.PadRight(0x4);

            string[] zs7 = new string[4];
            byte[] zb7 = new byte[4];
            int[] zd7 = new int[4];
            string[] zs_final7 = new string[4];
            string[] zsw7 = new string[4];
            x = 0;
            while (x < 4)
            {
                zs7[x] = newgcString[x].ToString();
                tempascii = zs7[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw7[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw7[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw7[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw7[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();

            q = 0;
            while (q < 4)
            {
                zd7[q] = int.Parse(zsw7[q], System.Globalization.NumberStyles.HexNumber);
                zs_final7[q] = zd7[q].ToString();
                zb7[q] = byte.Parse(zs_final7[q]);
                q++;
            }

            fs2.Seek(0x14E0F, SeekOrigin.Begin);
            q = 0;
            while (q < 4)
            {
                fs2.WriteByte(zb7[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox8.Text;
            newgcString = newgcString.PadRight(0x4);

            string[] zs8 = new string[4];
            byte[] zb8 = new byte[4];
            int[] zd8 = new int[4];
            string[] zs_final8 = new string[4];
            string[] zsw8 = new string[4];
            x = 0;
            while (x < 4)
            {
                zs8[x] = newgcString[x].ToString();
                tempascii = zs8[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw8[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw8[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw8[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw8[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();

            q = 0;
            while (q < 4)
            {
                zd8[q] = int.Parse(zsw8[q], System.Globalization.NumberStyles.HexNumber);
                zs_final8[q] = zd8[q].ToString();
                zb8[q] = byte.Parse(zs_final8[q]);
                q++;
            }

            fs2.Seek(0x14E14, SeekOrigin.Begin);
            q = 0;
            while (q < 4)
            {
                fs2.WriteByte(zb8[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox9.Text;
            newgcString = newgcString.PadRight(0x12);

            string[] zs9 = new string[0x12];
            byte[] zb9 = new byte[0x12];
            int[] zd9 = new int[0x12];
            string[] zs_final9 = new string[0x12];
            string[] zsw9 = new string[0x12];
            x = 0;
            while (x < 0x12)
            {
                zs9[x] = newgcString[x].ToString();
                tempascii = zs9[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw9[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw9[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw9[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw9[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw9[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw9[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw9[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw9[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw9[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw9[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw9[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw9[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw9[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw9[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw9[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw9[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw9[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw9[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();

            q = 0;
            while (q < 0x12)
            {
                zd9[q] = int.Parse(zsw9[q], System.Globalization.NumberStyles.HexNumber);
                zs_final9[q] = zd9[q].ToString();
                zb9[q] = byte.Parse(zs_final9[q]);
                q++;
            }

            fs2.Seek(0x15290, SeekOrigin.Begin);
            q = 0;
            while (q < 0x12)
            {
                fs2.WriteByte(zb9[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox10.Text;
            newgcString = newgcString.PadRight(0xa);

            string[] zs10 = new string[0xa];
            byte[] zb10 = new byte[0xa];
            int[] zd10 = new int[0xa];
            string[] zs_final10 = new string[0xa];
            string[] zsw10 = new string[0xa];
            x = 0;
            while (x < 0xa)
            {
                zs10[x] = newgcString[x].ToString();
                tempascii = zs10[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw10[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw10[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw10[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw10[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw10[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw10[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw10[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw10[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw10[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw10[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            q = 0;
            while (q < 0xa)
            {
                zd10[q] = int.Parse(zsw10[q], System.Globalization.NumberStyles.HexNumber);
                zs_final10[q] = zd10[q].ToString();
                zb10[q] = byte.Parse(zs_final10[q]);
                q++;
            }

            fs2.Seek(0x152A6, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb10[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox11.Text;
            newgcString = newgcString.PadRight(0x12);

            string[] zs11 = new string[0x12];
            byte[] zb11 = new byte[0x12];
            int[] zd11 = new int[0x12];
            string[] zs_final11 = new string[0x12];
            string[] zsw11 = new string[0x12];
            x = 0;
            while (x < 0x12)
            {
                zs11[x] = newgcString[x].ToString();
                tempascii = zs11[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw11[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw11[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw11[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw11[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw11[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw11[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw11[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw11[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw11[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw11[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw11[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw11[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw11[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw11[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw11[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw11[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw11[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw11[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            q = 0;
            while (q < 0x12)
            {
                zd11[q] = int.Parse(zsw11[q], System.Globalization.NumberStyles.HexNumber);
                zs_final11[q] = zd11[q].ToString();
                zb11[q] = byte.Parse(zs_final11[q]);
                q++;
            }

            fs2.Seek(0x152B4, SeekOrigin.Begin);
            q = 0;
            while (q < 0x12)
            {
                fs2.WriteByte(zb11[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox12.Text;
            newgcString = newgcString.PadRight(0xa);

            string[] zs12 = new string[0xa];
            byte[] zb12 = new byte[0xa];
            int[] zd12 = new int[0xa];
            string[] zs_final12 = new string[0xa];
            string[] zsw12 = new string[0xa];
            x = 0;
            while (x < 0xa)
            {
                zs12[x] = newgcString[x].ToString();
                tempascii = zs12[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw12[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw12[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw12[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw12[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw12[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw12[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw12[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw12[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw12[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw12[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            q = 0;
            while (q < 0xa)
            {
                zd12[q] = int.Parse(zsw12[q], System.Globalization.NumberStyles.HexNumber);
                zs_final12[q] = zd12[q].ToString();
                zb12[q] = byte.Parse(zs_final12[q]);
                q++;
            }

            fs2.Seek(0x152CA, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb12[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox13.Text;
            newgcString = newgcString.PadRight(0x8);

            string[] zs13 = new string[0x8];
            byte[] zb13 = new byte[0x8];
            int[] zd13 = new int[0x8];
            string[] zs_final13 = new string[0x8];
            string[] zsw13 = new string[0x8];
            x = 0;
            while (x < 0x8)
            {
                zs13[x] = newgcString[x].ToString();
                tempascii = zs13[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw13[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw13[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw13[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw13[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw13[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw13[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw13[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw13[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            q = 0;
            while (q < 0x8)
            {
                zd13[q] = int.Parse(zsw13[q], System.Globalization.NumberStyles.HexNumber);
                zs_final13[q] = zd13[q].ToString();
                zb13[q] = byte.Parse(zs_final13[q]);
                q++;
            }

            fs2.Seek(0x152D8, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb13[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox14.Text;
            newgcString = newgcString.PadRight(0x7);

            string[] zs14 = new string[0x7];
            byte[] zb14 = new byte[0x7];
            int[] zd14 = new int[0x7];
            string[] zs_final14 = new string[0x7];
            string[] zsw14 = new string[0x7];
            x = 0;
            while (x < 0x7)
            {
                zs14[x] = newgcString[x].ToString();
                tempascii = zs14[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw14[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw14[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw14[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw14[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw14[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw14[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw14[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            q = 0;
            while (q < 0x7)
            {
                zd14[q] = int.Parse(zsw14[q], System.Globalization.NumberStyles.HexNumber);
                zs_final14[q] = zd14[q].ToString();
                zb14[q] = byte.Parse(zs_final14[q]);
                q++;
            }

            fs2.Seek(0x152E4, SeekOrigin.Begin);
            q = 0;
            while (q < 0x7)
            {
                fs2.WriteByte(zb14[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox15.Text;
            newgcString = newgcString.PadRight(0x8);

            string[] zs15 = new string[0x8];
            byte[] zb15 = new byte[0x8];
            int[] zd15 = new int[0x8];
            string[] zs_final15 = new string[0x8];
            string[] zsw15 = new string[0x8];
            x = 0;
            while (x < 0x8)
            {
                zs15[x] = newgcString[x].ToString();
                tempascii = zs15[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw15[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw15[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw15[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw15[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw15[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw15[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw15[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw15[7] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            q = 0;
            while (q < 0x8)
            {
                zd15[q] = int.Parse(zsw15[q], System.Globalization.NumberStyles.HexNumber);
                zs_final15[q] = zd15[q].ToString();
                zb15[q] = byte.Parse(zs_final15[q]);
                q++;
            }

            fs2.Seek(0x152F9, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb15[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox16.Text;
            newgcString = newgcString.PadRight(0x7);

            string[] zs16 = new string[0x7];
            byte[] zb16 = new byte[0x7];
            int[] zd16 = new int[0x7];
            string[] zs_final16 = new string[0x7];
            string[] zsw16 = new string[0x7];
            x = 0;
            while (x < 0x7)
            {
                zs16[x] = newgcString[x].ToString();
                tempascii = zs16[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw16[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw16[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw16[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw16[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw16[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw16[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw16[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            q = 0;
            while (q < 0x7)
            {
                zd16[q] = int.Parse(zsw16[q], System.Globalization.NumberStyles.HexNumber);
                zs_final16[q] = zd16[q].ToString();
                zb16[q] = byte.Parse(zs_final16[q]);
                q++;
            }

            fs2.Seek(0x15305, SeekOrigin.Begin);
            q = 0;
            while (q < 0x7)
            {
                fs2.WriteByte(zb16[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox17.Text;
            newgcString = newgcString.PadRight(0xe);

            string[] zs17 = new string[0xe];
            byte[] zb17 = new byte[0xe];
            int[] zd17 = new int[0xe];
            string[] zs_final17 = new string[0xe];
            string[] zsw17 = new string[0xe];
            x = 0;
            while (x < 0xe)
            {
                zs17[x] = newgcString[x].ToString();
                tempascii = zs17[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw17[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw17[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw17[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw17[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw17[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw17[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw17[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw17[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw17[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw17[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw17[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw17[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw17[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw17[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            q = 0;
            while (q < 0xe)
            {
                zd17[q] = int.Parse(zsw17[q], System.Globalization.NumberStyles.HexNumber);
                zs_final17[q] = zd17[q].ToString();
                zb17[q] = byte.Parse(zs_final17[q]);
                q++;
            }

            fs2.Seek(0x1531A, SeekOrigin.Begin);
            q = 0;
            while (q < 0xe)
            {
                fs2.WriteByte(zb17[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox18.Text;
            newgcString = newgcString.PadRight(0x8);

            string[] zs18 = new string[0x8];
            byte[] zb18 = new byte[0x8];
            int[] zd18 = new int[0x8];
            string[] zs_final18 = new string[0x8];
            string[] zsw18 = new string[0x8];
            x = 0;
            while (x < 0x8)
            {
                zs18[x] = newgcString[x].ToString();
                tempascii = zs18[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw18[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw18[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw18[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw18[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw18[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw18[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw18[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw18[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            q = 0;
            while (q < 0x8)
            {
                zd18[q] = int.Parse(zsw18[q], System.Globalization.NumberStyles.HexNumber);
                zs_final18[q] = zd18[q].ToString();
                zb18[q] = byte.Parse(zs_final18[q]);
                q++;
            }

            fs2.Seek(0x1532C, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb18[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox19.Text;
            newgcString = newgcString.PadRight(0xe);

            string[] zs19 = new string[0xe];
            byte[] zb19 = new byte[0xe];
            int[] zd19 = new int[0xe];
            string[] zs_final19 = new string[0xe];
            string[] zsw19 = new string[0xe];
            x = 0;
            while (x < 0xe)
            {
                zs19[x] = newgcString[x].ToString();
                tempascii = zs19[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw19[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw19[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw19[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw19[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw19[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw19[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw19[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw19[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw19[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw19[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw19[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw19[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw19[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw19[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            q = 0;
            while (q < 0xe)
            {
                zd19[q] = int.Parse(zsw19[q], System.Globalization.NumberStyles.HexNumber);
                zs_final19[q] = zd19[q].ToString();
                zb19[q] = byte.Parse(zs_final19[q]);
                q++;
            }

            fs2.Seek(0x15338, SeekOrigin.Begin);
            q = 0;
            while (q < 0xe)
            {
                fs2.WriteByte(zb19[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox20.Text;
            newgcString = newgcString.PadRight(0x9);

            string[] zs20 = new string[0x9];
            byte[] zb20 = new byte[0x9];
            int[] zd20 = new int[0x9];
            string[] zs_final20 = new string[0x9];
            string[] zsw20 = new string[0x9];
            x = 0;
            while (x < 0x9)
            {
                zs20[x] = newgcString[x].ToString();
                tempascii = zs20[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw20[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw20[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw20[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw20[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw20[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw20[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw20[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw20[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw20[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            q = 0;
            while (q < 0x9)
            {
                zd20[q] = int.Parse(zsw20[q], System.Globalization.NumberStyles.HexNumber);
                zs_final20[q] = zd20[q].ToString();
                zb20[q] = byte.Parse(zs_final20[q]);
                q++;
            }

            fs2.Seek(0x1534A, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb20[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox21.Text;
            newgcString = newgcString.PadRight(0x8);

            string[] zs21 = new string[0x8];
            byte[] zb21 = new byte[0x8];
            int[] zd21 = new int[0x8];
            string[] zs_final21 = new string[0x8];
            string[] zsw21 = new string[0x8];
            x = 0;
            while (x < 0x8)
            {
                zs21[x] = newgcString[x].ToString();
                tempascii = zs21[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw21[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw21[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw21[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw21[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw21[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw21[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw21[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw21[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            q = 0;
            while (q < 0x8)
            {
                zd21[q] = int.Parse(zsw21[q], System.Globalization.NumberStyles.HexNumber);
                zs_final21[q] = zd21[q].ToString();
                zb21[q] = byte.Parse(zs_final21[q]);
                q++;
            }

            fs2.Seek(0x15356, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb21[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox22.Text;
            newgcString = newgcString.PadRight(0x11);

            string[] zs22 = new string[0x11];
            byte[] zb22 = new byte[0x11];
            int[] zd22 = new int[0x11];
            string[] zs_final22 = new string[0x11];
            string[] zsw22 = new string[0x11];
            x = 0;
            while (x < 0x11)
            {
                zs22[x] = newgcString[x].ToString();
                tempascii = zs22[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw22[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw22[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw22[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw22[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw22[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw22[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw22[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw22[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw22[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw22[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw22[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw22[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw22[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw22[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw22[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw22[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw22[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();

            q = 0;
            while (q < 0x11)
            {
                zd22[q] = int.Parse(zsw22[q], System.Globalization.NumberStyles.HexNumber);
                zs_final22[q] = zd22[q].ToString();
                zb22[q] = byte.Parse(zs_final22[q]);
                q++;
            }

            fs2.Seek(0x15362, SeekOrigin.Begin);
            q = 0;
            while (q < 0x11)
            {
                fs2.WriteByte(zb22[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox23.Text;
            newgcString = newgcString.PadRight(0xa);

            string[] zs23 = new string[0xa];
            byte[] zb23 = new byte[0xa];
            int[] zd23 = new int[0xa];
            string[] zs_final23 = new string[0xa];
            string[] zsw23 = new string[0xa];
            x = 0;
            while (x < 0xa)
            {
                zs23[x] = newgcString[x].ToString();
                tempascii = zs23[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw23[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw23[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw23[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw23[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw23[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw23[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw23[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw23[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw23[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw23[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            q = 0;
            while (q < 0xa)
            {
                zd23[q] = int.Parse(zsw23[q], System.Globalization.NumberStyles.HexNumber);
                zs_final23[q] = zd23[q].ToString();
                zb23[q] = byte.Parse(zs_final23[q]);
                q++;
            }

            fs2.Seek(0x15377, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb23[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox24.Text;
            newgcString = newgcString.PadRight(0x9);

            string[] zs24 = new string[0x9];
            byte[] zb24 = new byte[0x9];
            int[] zd24 = new int[0x9];
            string[] zs_final24 = new string[0x9];
            string[] zsw24 = new string[0x9];
            x = 0;
            while (x < 0x9)
            {
                zs24[x] = newgcString[x].ToString();
                tempascii = zs24[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw24[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw24[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw24[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw24[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw24[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw24[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw24[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw24[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw24[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            q = 0;
            while (q < 0x9)
            {
                zd24[q] = int.Parse(zsw24[q], System.Globalization.NumberStyles.HexNumber);
                zs_final24[q] = zd24[q].ToString();
                zb24[q] = byte.Parse(zs_final24[q]);
                q++;
            }

            fs2.Seek(0x15384, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb24[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox25.Text;
            newgcString = newgcString.PadRight(0x9);

            string[] zs25 = new string[0x9];
            byte[] zb25 = new byte[0x9];
            int[] zd25 = new int[0x9];
            string[] zs_final25 = new string[0x9];
            string[] zsw25 = new string[0x9];
            x = 0;
            while (x < 0x9)
            {
                zs25[x] = newgcString[x].ToString();
                tempascii = zs25[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw25[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw25[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw25[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw25[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw25[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw25[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw25[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw25[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw25[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            q = 0;
            while (q < 0x9)
            {
                zd25[q] = int.Parse(zsw25[q], System.Globalization.NumberStyles.HexNumber);
                zs_final25[q] = zd25[q].ToString();
                zb25[q] = byte.Parse(zs_final25[q]);
                q++;
            }

            fs2.Seek(0x15391, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb25[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox26.Text;
            newgcString = newgcString.PadRight(0x8);

            string[] zs26 = new string[0x8];
            byte[] zb26 = new byte[0x8];
            int[] zd26 = new int[0x8];
            string[] zs_final26 = new string[0x8];
            string[] zsw26 = new string[0x8];
            x = 0;
            while (x < 0x8)
            {
                zs26[x] = newgcString[x].ToString();
                tempascii = zs26[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw26[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw26[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw26[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw26[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw26[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw26[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw26[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw26[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            q = 0;
            while (q < 0x8)
            {
                zd26[q] = int.Parse(zsw26[q], System.Globalization.NumberStyles.HexNumber);
                zs_final26[q] = zd26[q].ToString();
                zb26[q] = byte.Parse(zs_final26[q]);
                q++;
            }

            fs2.Seek(0x1539D, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb26[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox27.Text;
            newgcString = newgcString.PadRight(0x9);

            string[] zs27 = new string[0x9];
            byte[] zb27 = new byte[0x9];
            int[] zd27 = new int[0x9];
            string[] zs_final27 = new string[0x9];
            string[] zsw27 = new string[0x9];
            x = 0;
            while (x < 0x9)
            {
                zs27[x] = newgcString[x].ToString();
                tempascii = zs27[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw27[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw27[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw27[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw27[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw27[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw27[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw27[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw27[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw27[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            q = 0;
            while (q < 0x9)
            {
                zd27[q] = int.Parse(zsw27[q], System.Globalization.NumberStyles.HexNumber);
                zs_final27[q] = zd27[q].ToString();
                zb27[q] = byte.Parse(zs_final27[q]);
                q++;
            }

            fs2.Seek(0x153A9, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb27[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //next
            newgcString = gctextBox28.Text;
            newgcString = newgcString.PadRight(0x7);

            string[] zs28 = new string[0x7];
            byte[] zb28 = new byte[0x7];
            int[] zd28 = new int[0x7];
            string[] zs_final28 = new string[0x7];
            string[] zsw28 = new string[0x7];
            x = 0;
            while (x < 0x7)
            {
                zs28[x] = newgcString[x].ToString();
                tempascii = zs28[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw28[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw28[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw28[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw28[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw28[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw28[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw28[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            q = 0;
            while (q < 0x7)
            {
                zd28[q] = int.Parse(zsw28[q], System.Globalization.NumberStyles.HexNumber);
                zs_final28[q] = zd28[q].ToString();
                zb28[q] = byte.Parse(zs_final28[q]);
                q++;
            }

            fs2.Seek(0x152EE, SeekOrigin.Begin);
            q = 0;
            while (q < 0x7)
            {
                fs2.WriteByte(zb28[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            fs2.Close();

            MessageBox.Show("Updated!", "Ending and Game Credits Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }




    }
}
