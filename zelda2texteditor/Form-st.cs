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
    public partial class Form_st : Form
    {
        public Form_st()
        {
            InitializeComponent();
        }

        string filename;
        string temphex, tempascii;
        int textFlag = 0;

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

        private void Form_st_Load(object sender, EventArgs e)
        {


            esp1TextBox.MaxLength = 11;
            esp2TextBox.MaxLength = 11;
            esp3TextBox.MaxLength = 11;
            esp4TextBox.MaxLength = 11;
            esp5TextBox.MaxLength = 11;
            esp6TextBox.MaxLength = 9;
            esp7TextBox.MaxLength = 11;
            esp8TextBox.MaxLength = 11;

            ws1TextBox.MaxLength = 0x9;
            ws1bTextBox.MaxLength = 0xa;
            ws1cTextBox.MaxLength = 0xa;
            ws1dTextBox.MaxLength = 0xa;

            ws2TextBox.MaxLength = 0x9;
            ws2bTextBox.MaxLength = 0x7;
            ws2cTextBox.MaxLength = 0x9;
            ws2dTextBox.MaxLength = 0x5;

            ws3TextBox.MaxLength = 0x8;
            ws3bTextBox.MaxLength = 0x8;
            ws3cTextBox.MaxLength = 0x7;
            ws3dTextBox.MaxLength = 0xa;

            ws4TextBox.MaxLength = 0xa;
            ws4bTextBox.MaxLength = 0x9;
            ws4cTextBox.MaxLength = 0x8;
            ws4dTextBox.MaxLength = 0x6;

            ws5TextBox.MaxLength = 0xa;
            ws5bTextBox.MaxLength = 0x9;
            ws5cTextBox.MaxLength = 0xa;
            ws5dTextBox.MaxLength = 0xa;

            ws6TextBox.MaxLength = 0xa;
            ws6bTextBox.MaxLength = 0x4;
            ws6cTextBox.MaxLength = 0xa;
            ws6dTextBox.MaxLength = 0x9;

            ws7TextBox.MaxLength = 0x8;
            ws7bTextBox.MaxLength = 0x9;
            ws7cTextBox.MaxLength = 0x5;

            ws8TextBox.MaxLength = 0xa;
            ws8bTextBox.MaxLength = 0x8;
            ws8cTextBox.MaxLength = 0x8;
            ws8dTextBox.MaxLength = 0x6;

            string rctext = "";
            string zeldaAsciiRet = "";
            int x = 0;


            FileStream fs1 = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            fs1.Seek(0x1C3A, SeekOrigin.Begin);   
            while (x < 0xb)
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
            esp1TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next spell
            fs1.Seek(0x1C48, SeekOrigin.Begin);
            while (x < 0xb)
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
            esp2TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next spell
            fs1.Seek(0x1C56, SeekOrigin.Begin);
            while (x < 0xb)
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
            esp3TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next spell
            fs1.Seek(0x1C64, SeekOrigin.Begin);
            while (x < 0xb)
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
            esp4TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next spell
            fs1.Seek(0x1C72, SeekOrigin.Begin);
            while (x < 0xb)
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
            esp5TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next spell
            fs1.Seek(0x1C80, SeekOrigin.Begin);
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
            esp6TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next spell
            fs1.Seek(0x1C8E, SeekOrigin.Begin);
            while (x < 0xb)
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
            esp7TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //next spell
            fs1.Seek(0x1C9C, SeekOrigin.Begin);
            while (x < 0xb)
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
            esp8TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard1
            fs1.Seek(0xE563, SeekOrigin.Begin);
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
            ws1TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE56D, SeekOrigin.Begin);
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
            ws1bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE578, SeekOrigin.Begin);
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
            ws1cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE583, SeekOrigin.Begin);
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
            ws1dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard2
            fs1.Seek(0xE68A, SeekOrigin.Begin);
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
            ws2TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE694, SeekOrigin.Begin);
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
            ws2bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE69C, SeekOrigin.Begin);
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
            ws2cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6A6, SeekOrigin.Begin);
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
            ws2dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard3
            fs1.Seek(0xE7E9, SeekOrigin.Begin);
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
            ws3TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7F2, SeekOrigin.Begin);
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
            ws3bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7FB, SeekOrigin.Begin);
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
            ws3cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE803, SeekOrigin.Begin);
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
            ws3dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard4
            fs1.Seek(0xE989, SeekOrigin.Begin);
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
            ws4TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE994, SeekOrigin.Begin);
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
            ws4bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE99E, SeekOrigin.Begin);
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
            ws4cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9A7, SeekOrigin.Begin);
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
            ws4dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard5
            fs1.Seek(0xEC23, SeekOrigin.Begin);
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
            ws5TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC2E, SeekOrigin.Begin);
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
            ws5bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC38, SeekOrigin.Begin);
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
            ws5cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC43, SeekOrigin.Begin);
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
            ws5dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard6
            fs1.Seek(0xEDAA, SeekOrigin.Begin);
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
            ws6TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDB5, SeekOrigin.Begin);
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
            ws6bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDBA, SeekOrigin.Begin);
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
            ws6cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDC5, SeekOrigin.Begin);
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
            ws6dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard7
            fs1.Seek(0xEF1F, SeekOrigin.Begin);
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
            ws7TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF28, SeekOrigin.Begin);
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
            ws7bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF32, SeekOrigin.Begin);
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
            ws7cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            //wizard8
            fs1.Seek(0xEF81, SeekOrigin.Begin);
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
            ws8TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF8C, SeekOrigin.Begin);
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
            ws8bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF95, SeekOrigin.Begin);
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
            ws8cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF9E, SeekOrigin.Begin);
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
            ws8dTextBox.Text = zeldaAsciiRet;
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

        private void updateSpellButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            //write the new text to string
            string newSp1String, newSp2String, newSp3String, newSp4String, newSp5String,
                newSp6String, newSp7String, newSp8String;
            string ZeldaHexReturn="";

            newSp1String = esp1TextBox.Text;

            //pad string length to 11 so no array errors
            newSp1String = newSp1String.PadRight(11);

            //setup arrays
            string[] zs = new string[11];
            byte[] zb = new byte[11];
            int[] zd = new int[11];
            string[] zs_final = new string[11];
            string[] zsw = new string[11];

            while (x < 11)
            {
                zs[x] = newSp1String[x].ToString();
                
                //convert string back into zelda text hex code
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            //convert the chars to int32, then to string, then byte again
            int q = 0;
            while (q < 11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }
            
            FileStream fs2 = new FileStream(@filename, FileMode.Open, FileAccess.Write);
            fs2.Seek(0x1C3A, SeekOrigin.Begin);   // Seek to 0x1C3Ath byte in the file
            
            //this is converting to hex before it writes
            q = 0;
            while (q < 11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }

            //next spell
            ZeldaHexReturn = "";
            newSp2String = esp2TextBox.Text;
            newSp2String = newSp2String.PadRight(11);
            x = 0;
            while (x < 11)
            {
                zs[x] = newSp2String[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1C48, SeekOrigin.Begin);

            q = 0;
            while (q < 11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }

            //next spell

            ZeldaHexReturn = "";
            newSp3String = esp3TextBox.Text;
            newSp3String = newSp3String.PadRight(11);
            x = 0;
            while (x < 11)
            {
                zs[x] = newSp3String[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1C56, SeekOrigin.Begin);

            q = 0;
            while (q < 11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }

            //next spell
            ZeldaHexReturn = "";
            newSp4String = esp4TextBox.Text;
            newSp4String = newSp4String.PadRight(11);
            x = 0;
            while (x < 11)
            {
                zs[x] = newSp4String[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1C64, SeekOrigin.Begin);

            q = 0;
            while (q < 11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }

            //next spell
            ZeldaHexReturn = "";
            newSp5String = esp5TextBox.Text;
            newSp5String = newSp5String.PadRight(11);
            x = 0;
            while (x < 11)
            {
                zs[x] = newSp5String[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1C72, SeekOrigin.Begin);

            q = 0;
            while (q < 11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }

            //next spell
            ZeldaHexReturn = "";
            newSp6String = esp6TextBox.Text;
            newSp6String = newSp6String.PadRight(9);
            x = 0;
            while (x < 9)
            {
                zs[x] = newSp6String[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1C80, SeekOrigin.Begin);

            q = 0;
            while (q < 9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }

            //next spell
            ZeldaHexReturn = "";
            newSp7String = esp7TextBox.Text;
            newSp7String = newSp7String.PadRight(11);
            x = 0;
            while (x < 11)
            {
                zs[x] = newSp7String[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1C8E, SeekOrigin.Begin);

            q = 0;
            while (q < 11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }

            //next spell
            ZeldaHexReturn = "";
            newSp8String = esp8TextBox.Text;
            newSp8String = newSp8String.PadRight(11);
            x = 0;
            while (x < 11)
            {
                zs[x] = newSp8String[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1C9C, SeekOrigin.Begin);

            q = 0;
            while (q < 11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }


            //wizard1
            string newgcString;
            ZeldaHexReturn = "";
            newgcString = ws1TextBox.Text;
            newgcString = newgcString.PadRight(0x9);

            x = 0;
            while (x < 9)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE563, SeekOrigin.Begin);
            q = 0;
            while (q < 9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard1b
            newgcString = ws1bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE56D, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard1c
            newgcString = ws1cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE578, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard1d
            newgcString = ws1dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE583, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard2
            newgcString = ws2TextBox.Text;
            newgcString = newgcString.PadRight(0x9);

            x = 0;
            while (x < 0x9)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 0x9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE68A, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard2b
            newgcString = ws2bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);

            x = 0;
            while (x < 0x7)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();

            q = 0;
            while (q < 0x7)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE694, SeekOrigin.Begin);
            q = 0;
            while (q < 0x7)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard2c
            newgcString = ws2cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);

            x = 0;
            while (x < 0x9)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 0x9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE69C, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard2d
            newgcString = ws2dTextBox.Text;
            newgcString = newgcString.PadRight(0x5);

            x = 0;
            while (x < 0x5)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();

            q = 0;
            while (q < 0x5)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE6A6, SeekOrigin.Begin);
            q = 0;
            while (q < 0x5)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";


            //wizard3
            newgcString = ws3TextBox.Text;
            newgcString = newgcString.PadRight(0x8);

            x = 0;
            while (x < 0x8)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();

            q = 0;
            while (q < 0x8)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE7E9, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard3b
            newgcString = ws3bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);

            x = 0;
            while (x < 0x8)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();

            q = 0;
            while (q < 0x8)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE7F2, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard3c
            newgcString = ws3cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);

            x = 0;
            while (x < 0x7)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();

            q = 0;
            while (q < 0x7)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE7FB, SeekOrigin.Begin);
            q = 0;
            while (q < 0x7)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard3d
            newgcString = ws3dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE803, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard4
            newgcString = ws4TextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE989, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard4b
            newgcString = ws4bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0x9)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 0x9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE994, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard4c
            newgcString = ws4cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);

            x = 0;
            while (x < 0x8)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();

            q = 0;
            while (q < 0x8)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE99E, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard4d
            newgcString = ws4dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);

            x = 0;
            while (x < 0x6)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();

            q = 0;
            while (q < 0x6)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xE9A7, SeekOrigin.Begin);
            q = 0;
            while (q < 0x6)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard5
            newgcString = ws5TextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEC23, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard5b
            newgcString = ws5bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);

            x = 0;
            while (x < 0x9)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 0x9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEC2E, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard5c
            newgcString = ws5cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEC38, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard5d
            newgcString = ws5dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEC43, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard6
            newgcString = ws6TextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEDAA, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard6b
            newgcString = ws6bTextBox.Text;
            newgcString = newgcString.PadRight(0x4);

            x = 0;
            while (x < 0x4)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();

            q = 0;
            while (q < 0x4)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEDB5, SeekOrigin.Begin);
            q = 0;
            while (q < 0x4)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard6c
            newgcString = ws6cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEDBA, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard6d
            newgcString = ws6dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);

            x = 0;
            while (x < 0x9)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 0x9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEDC5, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard7
            newgcString = ws7TextBox.Text;
            newgcString = newgcString.PadRight(0x8);

            x = 0;
            while (x < 0x8)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();

            q = 0;
            while (q < 0x8)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEF1F, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard7b
            newgcString = ws7bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);

            x = 0;
            while (x < 0x9)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();

            q = 0;
            while (q < 0x9)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEF28, SeekOrigin.Begin);
            q = 0;
            while (q < 0x9)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard7c
            newgcString = ws7cTextBox.Text;
            newgcString = newgcString.PadRight(0x5);

            x = 0;
            while (x < 0x5)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();

            q = 0;
            while (q < 0x5)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEF32, SeekOrigin.Begin);
            q = 0;
            while (q < 0x5)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard8
            newgcString = ws8TextBox.Text;
            newgcString = newgcString.PadRight(0xa);

            x = 0;
            while (x < 0xa)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();

            q = 0;
            while (q < 0xa)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEF81, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard8b
            newgcString = ws8bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);

            x = 0;
            while (x < 0x8)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();

            q = 0;
            while (q < 0x8)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEF8C, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard8c
            newgcString = ws8cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);

            x = 0;
            while (x < 0x8)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();

            q = 0;
            while (q < 0x8)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEF95, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //wizard8d
            newgcString = ws8dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);

            x = 0;
            while (x < 0x6)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
            zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();

            q = 0;
            while (q < 0x6)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0xEF9E, SeekOrigin.Begin);
            q = 0;
            while (q < 0x6)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";


            fs2.Close();


            MessageBox.Show("Updated!", "Spell Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

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


    
    }



}
