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
    public partial class Form_ramt : Form
    {
        public Form_ramt()
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

        private void Form_ramt_Load(object sender, EventArgs e)
        {

            m1TextBox.MaxLength = 0xa;
            m2TextBox.MaxLength = 0xf;
            m3TextBox.MaxLength = 0x4;
            m4TextBox.MaxLength = 0x6;
            m5TextBox.MaxLength = 0x5;
            m6TextBox.MaxLength = 0x4;
            m7TextBox.MaxLength = 0x4;
            m8TextBox.MaxLength = 0x6;
            m9TextBox.MaxLength = 0xb;
            m10TextBox.MaxLength = 0x6;
            m11TextBox.MaxLength = 0x7;
            m12TextBox.MaxLength = 0x3;
            m12bTextBox.MaxLength = 0x3;
            m12cTextBox.MaxLength = 0x2;
            m13TextBox.MaxLength = 0x3;
            m13bTextBox.MaxLength = 0x3;
            m13cTextBox.MaxLength = 0x2;
            m14TextBox.MaxLength = 0x3;
            m14bTextBox.MaxLength = 0x3;
            m14cTextBox.MaxLength = 0x2;
            m15TextBox.MaxLength = 0x12;
            m16TextBox.MaxLength = 0x10;
            m17TextBox.MaxLength = 0x13;
            m18TextBox.MaxLength = 0x3;
            m19TextBox.MaxLength = 0x15;
            m20TextBox.MaxLength = 0x15;
            m21TextBox.MaxLength = 0xb;
            m22TextBox.MaxLength = 0x13;
            m23TextBox.MaxLength = 0x11;
            m24TextBox.MaxLength = 0x3;
            m25TextBox.MaxLength = 0x1c;
            m26TextBox.MaxLength = 0xa;
            m27TextBox.MaxLength = 0x10;
            m28TextBox.MaxLength = 0x6;
            m29TextBox.MaxLength = 0x5;
            m30TextBox.MaxLength = 0x4;
            m31TextBox.MaxLength = 0x8;
            m32TextBox.MaxLength = 0x4;
            m33TextBox.MaxLength = 0x7;
            m34TextBox.MaxLength = 0x16;
            m35TextBox.MaxLength = 0xb;
            m36TextBox.MaxLength = 0xa;
            m37TextBox.MaxLength = 0x16;
            m38TextBox.MaxLength = 0x16;

            string rctext = "";
            string zeldaAsciiRet = "";
            int x = 0;


            FileStream fs1 = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            fs1.Seek(0x0013, SeekOrigin.Begin);
            while (x < 0xa)
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
            m1TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x0020, SeekOrigin.Begin);
            while (x < 0xf)
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
            m2TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1BE5, SeekOrigin.Begin);
            while (x < 0x4)
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
            m3TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1BF9, SeekOrigin.Begin);
            while (x < 0x6)
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
            m4TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1C07, SeekOrigin.Begin);
            while (x < 0x5)
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
            m5TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1C15, SeekOrigin.Begin);
            while (x < 0x4)
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
            m6TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1C1E, SeekOrigin.Begin);
            while (x < 0x2)
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
            m7TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1C23, SeekOrigin.Begin);
            while (x < 0x6)
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
            m8TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C2C, SeekOrigin.Begin);
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
            m9TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C4E, SeekOrigin.Begin);
            while (x < 0x6)
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
            m10TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C57, SeekOrigin.Begin);
            while (x < 0x7)
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
            m11TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C62, SeekOrigin.Begin);
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
            m12TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C66, SeekOrigin.Begin);
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
            m12bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C6A, SeekOrigin.Begin);
            while (x < 0x2)
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
            m12cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;


            fs1.Seek(0x17C70, SeekOrigin.Begin);
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
            m13TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C74, SeekOrigin.Begin);
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
            m13bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C78, SeekOrigin.Begin);
            while (x < 0x2)
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
            m13cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C7E, SeekOrigin.Begin);
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
            m14TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C82, SeekOrigin.Begin);
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
            m14bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C86, SeekOrigin.Begin);
            while (x < 0x2)
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
            m14cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17C8B, SeekOrigin.Begin);
            while (x < 0x12)
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
            m15TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17CB2, SeekOrigin.Begin);
            while (x < 0x10)
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
            m16TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17CD7, SeekOrigin.Begin);
            while (x < 0x13)
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
            m17TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17CED, SeekOrigin.Begin);
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
            m18TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17D13, SeekOrigin.Begin);
            while (x < 0x15)
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
            m19TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17D2B, SeekOrigin.Begin);
            while (x < 0x15)
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
            m20TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17D43, SeekOrigin.Begin);
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
            m21TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17D51, SeekOrigin.Begin);
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
            m22TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17D6D, SeekOrigin.Begin);
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
            m23TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17D81, SeekOrigin.Begin);
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
            m24TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17D85, SeekOrigin.Begin);
            while (x < 0x1c)
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
            m25TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x17DA6, SeekOrigin.Begin);
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
            m26TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1976C, SeekOrigin.Begin);
            while (x < 0x10)
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
            m27TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1D0E4, SeekOrigin.Begin);
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
            m28TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1D0ED, SeekOrigin.Begin);
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
            m29TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1D0F5, SeekOrigin.Begin);
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
            m30TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FDE8, SeekOrigin.Begin);
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
            m31TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FDF3, SeekOrigin.Begin);
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
            m32TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FE1A, SeekOrigin.Begin);
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
            m33TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FE24, SeekOrigin.Begin);
            while (x < 0x16)
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
            m34TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FE3D, SeekOrigin.Begin);
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
            m35TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FE49, SeekOrigin.Begin);
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
            m36TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FE56, SeekOrigin.Begin);
            while (x < 0x16)
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
            m37TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0x1FE6F, SeekOrigin.Begin);
            while (x < 0x16)
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
            m38TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Close();

        }




        private string decodeZText()
        {
            string zeldaAscii = "";

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
            //code to update the rom here
            string newgcString, ZeldaHexReturn="";
            int x = 0, q=0;
            //setup arrays
            string[] zs = new string[0x1C];
            byte[] zb = new byte[0x1C];
            int[] zd = new int[0x1C];
            string[] zs_final = new string[0x1C];
            string[] zsw = new string[0x1C];
            FileStream fs2 = new FileStream(@filename, FileMode.Open, FileAccess.Write);

            //1
            newgcString = m1TextBox.Text;
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

            fs2.Seek(0x0013, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //2
            newgcString = m2TextBox.Text;
            newgcString = newgcString.PadRight(0xf);

            x = 0;
            while (x < 0xf)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();

            q = 0;
            while (q < 0xf)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x0020, SeekOrigin.Begin);
            q = 0;
            while (q < 0xf)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //3
            newgcString = m3TextBox.Text;
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

            fs2.Seek(0x1BE5, SeekOrigin.Begin);
            q = 0;
            while (q < 0x4)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //4
            newgcString = m4TextBox.Text;
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

            fs2.Seek(0x1BF9, SeekOrigin.Begin);
            q = 0;
            while (q < 0x6)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //5
            newgcString = m5TextBox.Text;
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

            fs2.Seek(0x1C07, SeekOrigin.Begin);
            q = 0;
            while (q < 0x5)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //6
            newgcString = m6TextBox.Text;
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

            fs2.Seek(0x1C15, SeekOrigin.Begin);
            q = 0;
            while (q < 0x4)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //7
            newgcString = m7TextBox.Text;
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

            fs2.Seek(0x1C1E, SeekOrigin.Begin);
            q = 0;
            while (q < 0x4)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //8
            newgcString = m8TextBox.Text;
            newgcString = newgcString.PadRight(0x4);

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

            fs2.Seek(0x1C23, SeekOrigin.Begin);
            q = 0;
            while (q < 0x6)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //9
            newgcString = m9TextBox.Text;
            newgcString = newgcString.PadRight(0xb);

            x = 0;
            while (x < 0xb)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 0xb)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C2C, SeekOrigin.Begin);
            q = 0;
            while (q < 0xb)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //10
            newgcString = m10TextBox.Text;
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

            fs2.Seek(0x17C4E, SeekOrigin.Begin);
            q = 0;
            while (q < 0x6)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //11
            newgcString = m11TextBox.Text;
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

            fs2.Seek(0x17C57, SeekOrigin.Begin);
            q = 0;
            while (q < 0x7)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //12
            newgcString = m12TextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C62, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //12b
            newgcString = m12bTextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C66, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //12c
            newgcString = m12cTextBox.Text;
            newgcString = newgcString.PadRight(0x2);

            x = 0;
            while (x < 0x2)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();

            q = 0;
            while (q < 0x2)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C6A, SeekOrigin.Begin);
            q = 0;
            while (q < 0x2)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //13
            newgcString = m13TextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C70, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //13b
            newgcString = m13bTextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C74, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //13c
            newgcString = m13cTextBox.Text;
            newgcString = newgcString.PadRight(0x2);

            x = 0;
            while (x < 0x2)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();

            q = 0;
            while (q < 0x2)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C78, SeekOrigin.Begin);
            q = 0;
            while (q < 0x2)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";


            //14
            newgcString = m14TextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C7E, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";


            //14b
            newgcString = m14bTextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C82, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //14c
            newgcString = m14cTextBox.Text;
            newgcString = newgcString.PadRight(0x2);

            x = 0;
            while (x < 0x2)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
            zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();

            q = 0;
            while (q < 0x2)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C86, SeekOrigin.Begin);
            q = 0;
            while (q < 0x2)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //??
            newgcString = m15TextBox.Text;
            newgcString = newgcString.PadRight(0x12);

            x = 0;
            while (x < 0x12)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();

            q = 0;
            while (q < 0x12)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17C8B, SeekOrigin.Begin);
            q = 0;
            while (q < 0x12)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //15
            newgcString = m16TextBox.Text;
            newgcString = newgcString.PadRight(0x10);

            x = 0;
            while (x < 0x10)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();

            q = 0;
            while (q < 0x10)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17CB2, SeekOrigin.Begin);
            q = 0;
            while (q < 0x10)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //22
            newgcString = m17TextBox.Text;
            newgcString = newgcString.PadRight(0x13);

            x = 0;
            while (x < 0x13)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();

            q = 0;
            while (q < 0x13)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17CD7, SeekOrigin.Begin);
            q = 0;
            while (q < 0x13)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //23
            newgcString = m18TextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17CED, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //24
            newgcString = m19TextBox.Text;
            newgcString = newgcString.PadRight(0x15);

            x = 0;
            while (x < 0x15)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();
            zsw[19] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[39].ToString();
            zsw[20] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[41].ToString();

            q = 0;
            while (q < 0x15)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17D13, SeekOrigin.Begin);
            q = 0;
            while (q < 0x15)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //25
            newgcString = m20TextBox.Text;
            newgcString = newgcString.PadRight(0x15);

            x = 0;
            while (x < 0x15)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();
            zsw[19] = ZeldaHexReturn[38].ToString() + ZeldaHexReturn[39].ToString();
            zsw[20] = ZeldaHexReturn[40].ToString() + ZeldaHexReturn[41].ToString();

            q = 0;
            while (q < 0x15)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17D2B, SeekOrigin.Begin);
            q = 0;
            while (q < 0x15)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //21
            newgcString = m21TextBox.Text;
            newgcString = newgcString.PadRight(0xb);

            x = 0;
            while (x < 0xb)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 0xb)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17D43, SeekOrigin.Begin);
            q = 0;
            while (q < 0xb)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //26
            newgcString = m22TextBox.Text;
            newgcString = newgcString.PadRight(0x13);

            x = 0;
            while (x < 0x13)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();

            q = 0;
            while (q < 0x13)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17D51, SeekOrigin.Begin);
            q = 0;
            while (q < 0x13)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //27
            newgcString = m23TextBox.Text;
            newgcString = newgcString.PadRight(0x11);

            x = 0;
            while (x < 0x11)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();

            q = 0;
            while (q < 0x11)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17D6D, SeekOrigin.Begin);
            q = 0;
            while (q < 0x11)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //28
            newgcString = m24TextBox.Text;
            newgcString = newgcString.PadRight(0x3);

            x = 0;
            while (x < 0x3)
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

            q = 0;
            while (q < 0x3)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17D81, SeekOrigin.Begin);
            q = 0;
            while (q < 0x3)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //29
            newgcString = m25TextBox.Text;
            newgcString = newgcString.PadRight(0x1c);

            x = 0;
            while (x < 0x1c)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();
            zsw[19] = ZeldaHexReturn[38].ToString() + ZeldaHexReturn[39].ToString();
            zsw[20] = ZeldaHexReturn[40].ToString() + ZeldaHexReturn[41].ToString();
            zsw[21] = ZeldaHexReturn[42].ToString() + ZeldaHexReturn[43].ToString();
            zsw[22] = ZeldaHexReturn[44].ToString() + ZeldaHexReturn[45].ToString();
            zsw[23] = ZeldaHexReturn[46].ToString() + ZeldaHexReturn[47].ToString();
            zsw[24] = ZeldaHexReturn[48].ToString() + ZeldaHexReturn[49].ToString();
            zsw[25] = ZeldaHexReturn[50].ToString() + ZeldaHexReturn[51].ToString();
            zsw[26] = ZeldaHexReturn[52].ToString() + ZeldaHexReturn[53].ToString();
            zsw[27] = ZeldaHexReturn[54].ToString() + ZeldaHexReturn[55].ToString();

            q = 0;
            while (q < 0x1c)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x17D85, SeekOrigin.Begin);
            q = 0;
            while (q < 0x1c)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //30
            newgcString = m26TextBox.Text;
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

            fs2.Seek(0x17DA6, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //31
            newgcString = m27TextBox.Text;
            newgcString = newgcString.PadRight(0x10);

            x = 0;
            while (x < 0x10)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();

            q = 0;
            while (q < 0x10)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1976C, SeekOrigin.Begin);
            q = 0;
            while (q < 0x10)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //32
            newgcString = m28TextBox.Text;
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

            fs2.Seek(0x1D0E4, SeekOrigin.Begin);
            q = 0;
            while (q < 0x6)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //33
            newgcString = m29TextBox.Text;
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

            fs2.Seek(0x1D0ED, SeekOrigin.Begin);
            q = 0;
            while (q < 0x5)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //34
            newgcString = m30TextBox.Text;
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

            fs2.Seek(0x1D0F5, SeekOrigin.Begin);
            q = 0;
            while (q < 0x4)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //35
            newgcString = m31TextBox.Text;
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

            fs2.Seek(0x1FDE8, SeekOrigin.Begin);
            q = 0;
            while (q < 0x8)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //36
            newgcString = m32TextBox.Text;
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

            fs2.Seek(0x1FDF3, SeekOrigin.Begin);
            q = 0;
            while (q < 0x4)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //37
            newgcString = m33TextBox.Text;
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

            fs2.Seek(0x1FE1A, SeekOrigin.Begin);
            q = 0;
            while (q < 0x7)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //38
            newgcString = m34TextBox.Text;
            newgcString = newgcString.PadRight(0x1c);

            x = 0;
            while (x < 0x16)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();
            zsw[19] = ZeldaHexReturn[38].ToString() + ZeldaHexReturn[39].ToString();
            zsw[20] = ZeldaHexReturn[40].ToString() + ZeldaHexReturn[41].ToString();
            zsw[21] = ZeldaHexReturn[42].ToString() + ZeldaHexReturn[43].ToString();

            q = 0;
            while (q < 0x16)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1FE24, SeekOrigin.Begin);
            q = 0;
            while (q < 0x16)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //35
            newgcString = m35TextBox.Text;
            newgcString = newgcString.PadRight(0xb);

            x = 0;
            while (x < 0xb)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();

            q = 0;
            while (q < 0xb)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1FE3D, SeekOrigin.Begin);
            q = 0;
            while (q < 0xb)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //40
            newgcString = m36TextBox.Text;
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

            fs2.Seek(0x1FE49, SeekOrigin.Begin);
            q = 0;
            while (q < 0xa)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //41
            newgcString = m37TextBox.Text;
            newgcString = newgcString.PadRight(0x1c);

            x = 0;
            while (x < 0x16)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();
            zsw[19] = ZeldaHexReturn[38].ToString() + ZeldaHexReturn[39].ToString();
            zsw[20] = ZeldaHexReturn[40].ToString() + ZeldaHexReturn[41].ToString();
            zsw[21] = ZeldaHexReturn[42].ToString() + ZeldaHexReturn[43].ToString();

            q = 0;
            while (q < 0x16)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1FE56, SeekOrigin.Begin);
            q = 0;
            while (q < 0x16)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            //42
            newgcString = m38TextBox.Text;
            newgcString = newgcString.PadRight(0x1c);

            x = 0;
            while (x < 0x16)
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
            zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            zsw[12] = ZeldaHexReturn[24].ToString() + ZeldaHexReturn[25].ToString();
            zsw[13] = ZeldaHexReturn[26].ToString() + ZeldaHexReturn[27].ToString();
            zsw[14] = ZeldaHexReturn[28].ToString() + ZeldaHexReturn[29].ToString();
            zsw[15] = ZeldaHexReturn[30].ToString() + ZeldaHexReturn[31].ToString();
            zsw[16] = ZeldaHexReturn[32].ToString() + ZeldaHexReturn[33].ToString();
            zsw[17] = ZeldaHexReturn[34].ToString() + ZeldaHexReturn[35].ToString();
            zsw[18] = ZeldaHexReturn[36].ToString() + ZeldaHexReturn[37].ToString();
            zsw[19] = ZeldaHexReturn[38].ToString() + ZeldaHexReturn[39].ToString();
            zsw[20] = ZeldaHexReturn[40].ToString() + ZeldaHexReturn[41].ToString();
            zsw[21] = ZeldaHexReturn[42].ToString() + ZeldaHexReturn[43].ToString();

            q = 0;
            while (q < 0x16)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(0x1FE6F, SeekOrigin.Begin);
            q = 0;
            while (q < 0x16)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";


            fs2.Close();

            //MessageBox.Show("Not implemented yet!", "Not implemented yet.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
            MessageBox.Show("Updated!", "Random and Miscellaneous Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
