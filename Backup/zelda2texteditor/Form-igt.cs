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
    public partial class Form2_igt : Form
    {
        public Form2_igt()
        {
            InitializeComponent();
        }

        string filename;
        string temphex, tempascii;
        int textFlag = 0;

        //test
        //setup arrays
        string[] zs = new string[0x1C];
        byte[] zb = new byte[0x1C];
        int[] zd = new int[0x1C];
        string[] zs_final = new string[0x1C];
        string[] zsw = new string[0x1C];
        string ZeldaHexReturn = "";
        int i=0;
        
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

        

        private void Form2_igt_Load(object sender, EventArgs e)
        {
            //there is no 28
            igt1TextBox.MaxLength = 0xa;
            igt1bTextBox.MaxLength = 0x7;
            igt1cTextBox.MaxLength = 0x4;

            igt2TextBox.MaxLength = 0x4;
            igt2bTextBox.MaxLength = 0x7;

            igt3TextBox.MaxLength = 0x5;
            igt3bTextBox.MaxLength = 0x7;
            igt3cTextBox.MaxLength = 0xa;

            igt4TextBox.MaxLength = 0x8;
            igt4bTextBox.MaxLength = 0xa;

            igt5TextBox.MaxLength = 0xa;
            igt5bTextBox.MaxLength = 0xa;

            igt6TextBox.MaxLength = 0x9;
            igt6bTextBox.MaxLength = 0x8;

            igt7TextBox.MaxLength = 0x9;
            igt7bTextBox.MaxLength = 0x8;
            igt7cTextBox.MaxLength = 0xa;
            igt7dTextBox.MaxLength = 0xb;

            igt8TextBox.MaxLength = 0x5;

            igt9TextBox.MaxLength = 0x5;
            igt9bTextBox.MaxLength = 0x5;
            igt9cTextBox.MaxLength = 0x7;

            igt10TextBox.MaxLength = 0x6;
            igt10bTextBox.MaxLength = 0x6;
            igt10cTextBox.MaxLength = 0x8;

            igt11TextBox.MaxLength = 0x8;
            igt11bTextBox.MaxLength = 0xa;
            igt11cTextBox.MaxLength = 0xa;
            igt11dTextBox.MaxLength = 0x9;

            igt12TextBox.MaxLength = 0x8;
            igt12bTextBox.MaxLength = 0x8;
            igt12cTextBox.MaxLength = 0x8;
            igt12dTextBox.MaxLength = 0x7;

            igt13TextBox.MaxLength = 0x8;
            igt13bTextBox.MaxLength = 0xa;
            igt13cTextBox.MaxLength = 0x9;
            igt13dTextBox.MaxLength = 0xa;

            igt14TextBox.MaxLength = 0xa;
            igt14bTextBox.MaxLength = 0x9;
            igt14cTextBox.MaxLength = 0x7;
            igt14dTextBox.MaxLength = 0x8;

            igt15TextBox.MaxLength = 0x9;
            igt15bTextBox.MaxLength = 0x7;
            igt15cTextBox.MaxLength = 0x9;
            igt15dTextBox.MaxLength = 0x7;

            igt16TextBox.MaxLength = 0x9;
            igt16bTextBox.MaxLength = 0xa;
            igt16cTextBox.MaxLength = 0x8;
            igt16dTextBox.MaxLength = 0x9;

            igt17TextBox.MaxLength = 0x8;
            igt17bTextBox.MaxLength = 0x8;
            igt17cTextBox.MaxLength = 0x8;
            igt17dTextBox.MaxLength = 0x7;

            igt18TextBox.MaxLength = 0x9;
            igt18bTextBox.MaxLength = 0x5;
            igt18cTextBox.MaxLength = 0x9;
            igt18dTextBox.MaxLength = 0x7;

            igt19TextBox.MaxLength = 0xa;
            igt19bTextBox.MaxLength = 0x9;
            igt19cTextBox.MaxLength = 0x8;
            igt19dTextBox.MaxLength = 0xb;

            igt20TextBox.MaxLength = 0x9;
            igt20bTextBox.MaxLength = 0x6;
            igt20cTextBox.MaxLength = 0x9;
            igt20dTextBox.MaxLength = 0x6;

            igt21TextBox.MaxLength = 0x6;
            igt21bTextBox.MaxLength = 0xa;

            igt22TextBox.MaxLength = 0x7;
            igt22bTextBox.MaxLength = 0x8;
            igt22cTextBox.MaxLength = 0x6;
            igt22dTextBox.MaxLength = 0xa;

            igt23TextBox.MaxLength = 0x4;
            igt23bTextBox.MaxLength = 0x6;

            igt24TextBox.MaxLength = 0x8;
            igt24bTextBox.MaxLength = 0xa;
            igt24cTextBox.MaxLength = 0xa;
            igt24dTextBox.MaxLength = 0x9;

            igt25TextBox.MaxLength = 0x9;
            igt25bTextBox.MaxLength = 0xa;
            igt25cTextBox.MaxLength = 0x7;
            igt25dTextBox.MaxLength = 0x6;

            igt26TextBox.MaxLength = 0x7;
            igt26bTextBox.MaxLength = 0x9;
            igt26cTextBox.MaxLength = 0xa;
            igt26dTextBox.MaxLength = 0xa;

            igt27TextBox.MaxLength = 0x6;
            igt27bTextBox.MaxLength = 0xa;
            igt27cTextBox.MaxLength = 0x9;

            //there is no 28

            igt29TextBox.MaxLength = 0x8;

            igt30TextBox.MaxLength = 0xa;
            igt30bTextBox.MaxLength = 0xa;
            igt30cTextBox.MaxLength = 0xa;
            igt30dTextBox.MaxLength = 0xa;

            igt31TextBox.MaxLength = 0x8;
            igt31bTextBox.MaxLength = 0xa;
            igt31cTextBox.MaxLength = 0x8;
            igt31dTextBox.MaxLength = 0x9;

            igt32TextBox.MaxLength = 0x9;
            igt32bTextBox.MaxLength = 0x9;
            igt32cTextBox.MaxLength = 0xa;
            igt32dTextBox.MaxLength = 0xa;

            igt33TextBox.MaxLength = 0x9;
            igt33bTextBox.MaxLength = 0x8;
            igt33cTextBox.MaxLength = 0xa;
            igt33dTextBox.MaxLength = 0x5;

            igt34TextBox.MaxLength = 0x8;
            igt34bTextBox.MaxLength = 0xa;
            igt34cTextBox.MaxLength = 0xa;
            igt34dTextBox.MaxLength = 0xa;

            igt35TextBox.MaxLength = 0x9;
            igt35bTextBox.MaxLength = 0xa;
            igt35cTextBox.MaxLength = 0xa;
            igt35dTextBox.MaxLength = 0xa;

            igt36TextBox.MaxLength = 0xa;
            igt36bTextBox.MaxLength = 0x9;
            igt36cTextBox.MaxLength = 0x9;
            igt36dTextBox.MaxLength = 0xa;

            igt37TextBox.MaxLength = 0xa;
            igt37bTextBox.MaxLength = 0x9;
            igt37cTextBox.MaxLength = 0x9;
            igt37dTextBox.MaxLength = 0x6;

            igt38TextBox.MaxLength = 0x8;
            igt38bTextBox.MaxLength = 0x8;
            igt38cTextBox.MaxLength = 0x9;
            igt38dTextBox.MaxLength = 0xa;

            igt39TextBox.MaxLength = 0xa;
            igt39bTextBox.MaxLength = 0x8;
            igt39cTextBox.MaxLength = 0x8;
            igt39dTextBox.MaxLength = 0x8;

            igt40TextBox.MaxLength = 0x9;
            igt40bTextBox.MaxLength = 0x8;
            igt40cTextBox.MaxLength = 0xa;
            igt40dTextBox.MaxLength = 0x8;

            igt41TextBox.MaxLength = 0x9;
            igt41bTextBox.MaxLength = 0x7;
            igt41cTextBox.MaxLength = 0x9;
            igt41dTextBox.MaxLength = 0x7;

            igt42TextBox.MaxLength = 0x8;
            igt42bTextBox.MaxLength = 0xa;
            igt42cTextBox.MaxLength = 0x8;
            igt42dTextBox.MaxLength = 0x8;

            igt43TextBox.MaxLength = 0xa;
            igt43bTextBox.MaxLength = 0xa;
            igt43cTextBox.MaxLength = 0xa;
            igt43dTextBox.MaxLength = 0xa;

            igt44TextBox.MaxLength = 0x6;

            igt45TextBox.MaxLength = 0xa;
            igt45bTextBox.MaxLength = 0x9;
            igt45cTextBox.MaxLength = 0x8;
            igt45dTextBox.MaxLength = 0xa;

            igt46TextBox.MaxLength = 0x7;
            igt46bTextBox.MaxLength = 0xa;

            igt47TextBox.MaxLength = 0x7;

            igt48TextBox.MaxLength = 0xa;

            igt49TextBox.MaxLength = 0x9;
            igt49bTextBox.MaxLength = 0x4;

            igt50TextBox.MaxLength = 0x4;
            igt50bTextBox.MaxLength = 0xa;
            igt50cTextBox.MaxLength = 0x9;

            igt51TextBox.MaxLength = 0x6;
            igt51bTextBox.MaxLength = 0x8;

            igt52TextBox.MaxLength = 0x6;
            igt52bTextBox.MaxLength = 0x8;
            igt52cTextBox.MaxLength = 0x4;

            igt53TextBox.MaxLength = 0x8;
            igt53bTextBox.MaxLength = 0x4;
            igt53cTextBox.MaxLength = 0x6;

            igt54TextBox.MaxLength = 0x9;
            igt54bTextBox.MaxLength = 0x9;

            igt55TextBox.MaxLength = 0x9;
            igt55bTextBox.MaxLength = 0xa;
            igt55cTextBox.MaxLength = 0x9;
            igt55dTextBox.MaxLength = 0x9;

            igt56TextBox.MaxLength = 0x9;
            igt56bTextBox.MaxLength = 0x7;
            igt56cTextBox.MaxLength = 0xa;
            igt56dTextBox.MaxLength = 0xa;

            igt57TextBox.MaxLength = 0x7;
            igt57bTextBox.MaxLength = 0x8;
            igt57cTextBox.MaxLength = 0x5;

            igt58TextBox.MaxLength = 0x9;
            igt58bTextBox.MaxLength = 0xa;
            igt58cTextBox.MaxLength = 0xa;
            igt58dTextBox.MaxLength = 0x8;

            igt59TextBox.MaxLength = 0x4;
            igt59bTextBox.MaxLength = 0x8;

            igt60TextBox.MaxLength = 0x8;
            igt60bTextBox.MaxLength = 0x6;
            igt60cTextBox.MaxLength = 0x7;
            igt60dTextBox.MaxLength = 0x9;

            igt61TextBox.MaxLength = 0xa;
            igt61bTextBox.MaxLength = 0x7;
            igt61cTextBox.MaxLength = 0x7;
            igt61dTextBox.MaxLength = 0xa;

            igt62TextBox.MaxLength = 0x7;
            igt62bTextBox.MaxLength = 0xa;
            igt62cTextBox.MaxLength = 0x7;
            igt62dTextBox.MaxLength = 0x9;

            igt63TextBox.MaxLength = 0x9;
            igt63bTextBox.MaxLength = 0x8;
            igt63cTextBox.MaxLength = 0xa;

            igt64TextBox.MaxLength = 0x8;
            igt64bTextBox.MaxLength = 0x9;
            igt64cTextBox.MaxLength = 0xa;
            igt64dTextBox.MaxLength = 0x3;

            igt65TextBox.MaxLength = 0x9;
            igt65bTextBox.MaxLength = 0x8;
            igt65cTextBox.MaxLength = 0xa;

            igt66TextBox.MaxLength = 0xa;
            igt66bTextBox.MaxLength = 0x6;
            igt66cTextBox.MaxLength = 0x8;
            igt66dTextBox.MaxLength = 0xa;

            igt67TextBox.MaxLength = 0x9;
            igt67bTextBox.MaxLength = 0x8;
            igt67cTextBox.MaxLength = 0x8;
            igt67dTextBox.MaxLength = 0x9;

            igt68TextBox.MaxLength = 0xa;
            igt68bTextBox.MaxLength = 0x5;
            igt68cTextBox.MaxLength = 0xa;

            igt69TextBox.MaxLength = 0xa;
            igt69bTextBox.MaxLength = 0x8;
            igt69cTextBox.MaxLength = 0xa;
            igt69dTextBox.MaxLength = 0x6;

            igt70TextBox.MaxLength = 0x8;
            igt70bTextBox.MaxLength = 0x7;
            igt70cTextBox.MaxLength = 0xa;
            igt70dTextBox.MaxLength = 0x4;

            igt71TextBox.MaxLength = 0xa;
            igt71bTextBox.MaxLength = 0x9;
            igt71cTextBox.MaxLength = 0x8;
            igt71dTextBox.MaxLength = 0xa;

            igt72TextBox.MaxLength = 0x9;
            igt72bTextBox.MaxLength = 0x8;
            igt72cTextBox.MaxLength = 0x9;
            igt72dTextBox.MaxLength = 0xa;

            igt73TextBox.MaxLength = 0x8;
            igt73bTextBox.MaxLength = 0xa;
            igt73cTextBox.MaxLength = 0xb;

            igt74TextBox.MaxLength = 0x6;
            igt74bTextBox.MaxLength = 0x7;
            igt74cTextBox.MaxLength = 0x7;

            igt75TextBox.MaxLength = 0x7;
            igt75bTextBox.MaxLength = 0x7;
            igt75cTextBox.MaxLength = 0x7;
            igt75dTextBox.MaxLength = 0xa;

            igt76TextBox.MaxLength = 0xa;
            igt76bTextBox.MaxLength = 0x9;
            igt76cTextBox.MaxLength = 0x6;
            igt76dTextBox.MaxLength = 0xa;

            igt77TextBox.MaxLength = 0x8;
            igt77bTextBox.MaxLength = 0x7;
            igt77cTextBox.MaxLength = 0x9;
            igt77dTextBox.MaxLength = 0xa;

            igt78TextBox.MaxLength = 0x8;
            igt78bTextBox.MaxLength = 0x9;
            igt78cTextBox.MaxLength = 0xa;
            igt78dTextBox.MaxLength = 0x5;

            igt79TextBox.MaxLength = 0x6;
            igt79bTextBox.MaxLength = 0x8;
            igt79cTextBox.MaxLength = 0x7;
            igt79dTextBox.MaxLength = 0xa;

            igt80TextBox.MaxLength = 0x3;
            igt80bTextBox.MaxLength = 0x7;
            igt80cTextBox.MaxLength = 0x8;
            igt80dTextBox.MaxLength = 0xa;

            igt81TextBox.MaxLength = 0x8;
            igt81bTextBox.MaxLength = 0x8;
            igt81cTextBox.MaxLength = 0x7;
            igt81dTextBox.MaxLength = 0x8;

            igt82TextBox.MaxLength = 0xa;

            igt83TextBox.MaxLength = 0x5;
            igt83bTextBox.MaxLength = 0x9;

            igt84TextBox.MaxLength = 0x8;
            igt84bTextBox.MaxLength = 0x8;

            igt85TextBox.MaxLength = 0x9;
            igt85bTextBox.MaxLength = 0x9;

            igt86TextBox.MaxLength = 0x7;
            igt86bTextBox.MaxLength = 0xa;
            igt86cTextBox.MaxLength = 0xa;
            igt86dTextBox.MaxLength = 0xa;

            igt87TextBox.MaxLength = 0x9;
            igt87bTextBox.MaxLength = 0x9;
            igt87cTextBox.MaxLength = 0x7;
            igt87dTextBox.MaxLength = 0xa;

            string rctext = "";
            string zeldaAsciiRet = "";
            int x = 0;

            igt1TextBox.MaxLength = 0xa;

            //begin reading text
            FileStream fs1 = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            fs1.Seek(0xE390, SeekOrigin.Begin);
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
            igt1TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE39B, SeekOrigin.Begin);
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
            igt1bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3A3, SeekOrigin.Begin);
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
            igt1cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3A8, SeekOrigin.Begin);
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
            igt2TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3AD, SeekOrigin.Begin);
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
            igt2bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3B5, SeekOrigin.Begin);
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
            igt3TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3BB, SeekOrigin.Begin);
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
            igt3bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3C3, SeekOrigin.Begin);
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
            igt3cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3CE, SeekOrigin.Begin);
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
            igt4TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3D7, SeekOrigin.Begin);
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
            igt4bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3E2, SeekOrigin.Begin);
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
            igt5TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3ED, SeekOrigin.Begin);
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
            igt5bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE3F8, SeekOrigin.Begin);
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
            igt6TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE402, SeekOrigin.Begin);
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
            igt6bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE40B, SeekOrigin.Begin);
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
            igt7TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE415, SeekOrigin.Begin);
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
            igt7bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE41E, SeekOrigin.Begin);
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
            igt7cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE429, SeekOrigin.Begin);
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
            igt7dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE435, SeekOrigin.Begin);
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
            igt8TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE43C, SeekOrigin.Begin);
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
            igt9TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE442, SeekOrigin.Begin);
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
            igt9bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE448, SeekOrigin.Begin);
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
            igt9cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE450, SeekOrigin.Begin);
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
            igt10TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE457, SeekOrigin.Begin);
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
            igt10bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE45E, SeekOrigin.Begin);
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
            igt10cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE467, SeekOrigin.Begin);
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
            igt11TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE471, SeekOrigin.Begin);
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
            igt11bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE47C, SeekOrigin.Begin);
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
            igt11cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE487, SeekOrigin.Begin);
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
            igt11dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE491, SeekOrigin.Begin);
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
            igt12TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE49A, SeekOrigin.Begin);
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
            igt12bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4A3, SeekOrigin.Begin);
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
            igt12cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4AC, SeekOrigin.Begin);
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
            igt12dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4B4, SeekOrigin.Begin);
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
            igt13TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4BD, SeekOrigin.Begin);
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
            igt13bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4C8, SeekOrigin.Begin);
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
            igt13cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4D2, SeekOrigin.Begin);
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
            igt13dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4F1, SeekOrigin.Begin);
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
            igt14TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE4FC, SeekOrigin.Begin);
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
            igt14bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE506, SeekOrigin.Begin);
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
            igt14cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE50E, SeekOrigin.Begin);
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
            igt14dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE517, SeekOrigin.Begin);
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
            igt15TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE521, SeekOrigin.Begin);
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
            igt15bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE529, SeekOrigin.Begin);
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
            igt15cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE533, SeekOrigin.Begin);
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
            igt15dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE53B, SeekOrigin.Begin);
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
            igt16TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE545, SeekOrigin.Begin);
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
            igt16bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE550, SeekOrigin.Begin);
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
            igt16cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE559, SeekOrigin.Begin);
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
            igt16dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE58E, SeekOrigin.Begin);
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
            igt17TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE597, SeekOrigin.Begin);
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
            igt17bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5A0, SeekOrigin.Begin);
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
            igt17cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5A9, SeekOrigin.Begin);
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
            igt17dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5D8, SeekOrigin.Begin);
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
            igt18TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5E2, SeekOrigin.Begin);
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
            igt18bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5E8, SeekOrigin.Begin);
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
            igt18cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5F2, SeekOrigin.Begin);
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
            igt18dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5FA, SeekOrigin.Begin);
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
            igt19TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE605, SeekOrigin.Begin);
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
            igt19bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE60F, SeekOrigin.Begin);
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
            igt19cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE618, SeekOrigin.Begin);
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
            igt19dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE632, SeekOrigin.Begin);
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
            igt20TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE63C, SeekOrigin.Begin);
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
            igt20bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE643, SeekOrigin.Begin);
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
            igt20cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE64D, SeekOrigin.Begin);
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
            igt20dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE654, SeekOrigin.Begin);
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
            igt21TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE65B, SeekOrigin.Begin);
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
            igt21bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE666, SeekOrigin.Begin);
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
            igt22TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE66E, SeekOrigin.Begin);
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
            igt22bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE677, SeekOrigin.Begin);
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
            igt22cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE67F, SeekOrigin.Begin);
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
            igt22dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6AC, SeekOrigin.Begin);
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
            igt23TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6B1, SeekOrigin.Begin);
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
            igt23bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6B8, SeekOrigin.Begin);
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
            igt24TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6C1, SeekOrigin.Begin);
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
            igt24bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6CC, SeekOrigin.Begin);
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
            igt24cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6D7, SeekOrigin.Begin);
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
            igt24dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6E1, SeekOrigin.Begin);
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
            igt25TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6EB, SeekOrigin.Begin);
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
            igt25bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6F6, SeekOrigin.Begin);
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
            igt25cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE6FE, SeekOrigin.Begin);
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
            igt25dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE705, SeekOrigin.Begin);
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
            igt26TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE70D, SeekOrigin.Begin);
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
            igt26bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE717, SeekOrigin.Begin);
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
            igt26cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE722, SeekOrigin.Begin);
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
            igt26dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE747, SeekOrigin.Begin);
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
            igt27TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE74E, SeekOrigin.Begin);
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
            igt27bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE759, SeekOrigin.Begin);
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
            igt27cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE763, SeekOrigin.Begin);
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
            igt29TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE76C, SeekOrigin.Begin);
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
            igt30TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE777, SeekOrigin.Begin);
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
            igt30bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE782, SeekOrigin.Begin);
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
            igt30cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE78D, SeekOrigin.Begin);
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
            igt30dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE798, SeekOrigin.Begin);
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
            igt31TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7A1, SeekOrigin.Begin);
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
            igt31bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7AC, SeekOrigin.Begin);
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
            igt31cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7B5, SeekOrigin.Begin);
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
            igt31dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7BF, SeekOrigin.Begin);
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
            igt32TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7C9, SeekOrigin.Begin);
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
            igt32bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7D3, SeekOrigin.Begin);
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
            igt32cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE7DE, SeekOrigin.Begin);
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
            igt32dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE80E, SeekOrigin.Begin);
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
            igt33TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE818, SeekOrigin.Begin);
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
            igt33bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE821, SeekOrigin.Begin);
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
            igt33cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE82C, SeekOrigin.Begin);
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
            igt33dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE833, SeekOrigin.Begin);
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
            igt34TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE83C, SeekOrigin.Begin);
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
            igt34bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE847, SeekOrigin.Begin);
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
            igt34cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE852, SeekOrigin.Begin);
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
            igt34dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE85D, SeekOrigin.Begin);
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
            igt35TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE867, SeekOrigin.Begin);
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
            igt35bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE872, SeekOrigin.Begin);
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
            igt35cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE87D, SeekOrigin.Begin);
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
            igt35dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE888, SeekOrigin.Begin);
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
            igt36TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE893, SeekOrigin.Begin);
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
            igt36bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE89D, SeekOrigin.Begin);
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
            igt36cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE8A7, SeekOrigin.Begin);
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
            igt36dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE8B2, SeekOrigin.Begin);
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
            igt37TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE8BD, SeekOrigin.Begin);
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
            igt37bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE8C7, SeekOrigin.Begin);
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
            igt37cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE8D1, SeekOrigin.Begin);
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
            igt37dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE8F0, SeekOrigin.Begin);
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
            igt38TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE8F9, SeekOrigin.Begin);
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
            igt38bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE902, SeekOrigin.Begin);
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
            igt38cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE90C, SeekOrigin.Begin);
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
            igt38dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE917, SeekOrigin.Begin);
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
            igt39TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE922, SeekOrigin.Begin);
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
            igt39bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE92B, SeekOrigin.Begin);
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
            igt39cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE934, SeekOrigin.Begin);
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
            igt39dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE93E, SeekOrigin.Begin);
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
            igt40TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE948, SeekOrigin.Begin);
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
            igt40bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE951, SeekOrigin.Begin);
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
            igt40cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE95C, SeekOrigin.Begin);
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
            igt40dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE965, SeekOrigin.Begin);
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
            igt41TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE96F, SeekOrigin.Begin);
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
            igt41bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE977, SeekOrigin.Begin);
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
            igt41cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE981, SeekOrigin.Begin);
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
            igt41dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9AE, SeekOrigin.Begin);
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
            igt42TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9B7, SeekOrigin.Begin);
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
            igt42bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9C2, SeekOrigin.Begin);
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
            igt42cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9CB, SeekOrigin.Begin);
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
            igt42dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9D4, SeekOrigin.Begin);
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
            igt43TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9DF, SeekOrigin.Begin);
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
            igt43bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9EA, SeekOrigin.Begin);
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
            igt43cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE9F5, SeekOrigin.Begin);
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
            igt43dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA00, SeekOrigin.Begin);
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
            igt44TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA07, SeekOrigin.Begin);
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
            igt45TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA12, SeekOrigin.Begin);
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
            igt45bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA1C, SeekOrigin.Begin);
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
            igt45cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA25, SeekOrigin.Begin);
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
            igt45dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA43, SeekOrigin.Begin);
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
            igt46TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA4B, SeekOrigin.Begin);
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
            igt46bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA56, SeekOrigin.Begin);
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
            igt47TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA5F, SeekOrigin.Begin);
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
            igt48TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA6A, SeekOrigin.Begin);
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
            igt49TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA74, SeekOrigin.Begin);
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
            igt49bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA79, SeekOrigin.Begin);
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
            igt50TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA7E, SeekOrigin.Begin);
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
            igt50bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA89, SeekOrigin.Begin);
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
            igt50cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA93, SeekOrigin.Begin);
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
            igt51TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEA9A, SeekOrigin.Begin);
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
            igt51bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAA3, SeekOrigin.Begin);
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
            igt52TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAAA, SeekOrigin.Begin);
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
            igt52bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAB3, SeekOrigin.Begin);
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
            igt52cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAB9, SeekOrigin.Begin);
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
            igt53TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAC2, SeekOrigin.Begin);
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
            igt53bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAC7, SeekOrigin.Begin);
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
            igt53cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEACF, SeekOrigin.Begin);
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
            igt54TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAD9, SeekOrigin.Begin);
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
            igt54bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAE3, SeekOrigin.Begin);
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
            igt55TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAED, SeekOrigin.Begin);
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
            igt55bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEAF8, SeekOrigin.Begin);
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
            igt55cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB02, SeekOrigin.Begin);
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
            igt55dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB0C, SeekOrigin.Begin);
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
            igt56TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB16, SeekOrigin.Begin);
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
            igt56bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB1E, SeekOrigin.Begin);
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
            igt56cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB29, SeekOrigin.Begin);
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
            igt56dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB49, SeekOrigin.Begin);
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
            igt57TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB51, SeekOrigin.Begin);
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
            igt57bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB5A, SeekOrigin.Begin);
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
            igt57cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB61, SeekOrigin.Begin);
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
            igt58TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB6B, SeekOrigin.Begin);
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
            igt58bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB76, SeekOrigin.Begin);
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
            igt58cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB81, SeekOrigin.Begin);
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
            igt58dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB8A, SeekOrigin.Begin);
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
            igt59TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB8F, SeekOrigin.Begin);
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
            igt59bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEB98, SeekOrigin.Begin);
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
            igt60TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBA1, SeekOrigin.Begin);
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
            igt60bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBA8, SeekOrigin.Begin);
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
            igt60cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBB0, SeekOrigin.Begin);
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
            igt60dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBBA, SeekOrigin.Begin);
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
            igt61TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBC5, SeekOrigin.Begin);
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
            igt61bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBCD, SeekOrigin.Begin);
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
            igt61cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBD5, SeekOrigin.Begin);
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
            igt61dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBE0, SeekOrigin.Begin);
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
            igt62TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBE8, SeekOrigin.Begin);
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
            igt62bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBF3, SeekOrigin.Begin);
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
            igt62cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEBFB, SeekOrigin.Begin);
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
            igt62dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC05, SeekOrigin.Begin);
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
            igt63TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC0F, SeekOrigin.Begin);
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
            igt63bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC18, SeekOrigin.Begin);
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
            igt63cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC4E, SeekOrigin.Begin);
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
            igt64TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC57, SeekOrigin.Begin);
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
            igt64bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC61, SeekOrigin.Begin);
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
            igt64cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC6C, SeekOrigin.Begin);
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
            igt64dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC70, SeekOrigin.Begin);
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
            igt65TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC7A, SeekOrigin.Begin);
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
            igt65bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC83, SeekOrigin.Begin);
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
            igt65cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC8E, SeekOrigin.Begin);
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
            igt66TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEC99, SeekOrigin.Begin);
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
            igt66bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECA0, SeekOrigin.Begin);
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
            igt66cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECA9, SeekOrigin.Begin);
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
            igt66dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECB4, SeekOrigin.Begin);
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
            igt67TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECBE, SeekOrigin.Begin);
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
            igt67bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECC7, SeekOrigin.Begin);
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
            igt67cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECD0, SeekOrigin.Begin);
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
            igt67dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECDA, SeekOrigin.Begin);
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
            igt68TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECE5, SeekOrigin.Begin);
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
            igt68bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECEB, SeekOrigin.Begin);
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
            igt68cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED11, SeekOrigin.Begin);
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
            igt69TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED1C, SeekOrigin.Begin);
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
            igt69bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED25, SeekOrigin.Begin);
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
            igt69cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED30, SeekOrigin.Begin);
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
            igt69dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED37, SeekOrigin.Begin);
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
            igt70TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED40, SeekOrigin.Begin);
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
            igt70bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED48, SeekOrigin.Begin);
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
            igt70cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED53, SeekOrigin.Begin);
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
            igt70dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED59, SeekOrigin.Begin);
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
            igt71TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED64, SeekOrigin.Begin);
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
            igt71bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED6E, SeekOrigin.Begin);
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
            igt71cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED77, SeekOrigin.Begin);
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
            igt71dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED82, SeekOrigin.Begin);
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
            igt72TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED8C, SeekOrigin.Begin);
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
            igt72bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED95, SeekOrigin.Begin);
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
            igt72cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED9F, SeekOrigin.Begin);
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
            igt72dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDCF, SeekOrigin.Begin);
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
            igt73TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDD8, SeekOrigin.Begin);
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
            igt73bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDE3, SeekOrigin.Begin);
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
            igt73cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDEF, SeekOrigin.Begin);
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
            igt74TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDF6, SeekOrigin.Begin);
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
            igt74bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDFE, SeekOrigin.Begin);
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
            igt74cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE06, SeekOrigin.Begin);
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
            igt75TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE0E, SeekOrigin.Begin);
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
            igt75bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE16, SeekOrigin.Begin);
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
            igt75cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE1E, SeekOrigin.Begin);
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
            igt75dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE48, SeekOrigin.Begin);
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
            igt76TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE53, SeekOrigin.Begin);
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
            igt76bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE5D, SeekOrigin.Begin);
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
            igt76cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE64, SeekOrigin.Begin);
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
            igt76dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE6F, SeekOrigin.Begin);
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
            igt77TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE78, SeekOrigin.Begin);
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
            igt77bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE80, SeekOrigin.Begin);
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
            igt77cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE8A, SeekOrigin.Begin);
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
            igt77dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE95, SeekOrigin.Begin);
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
            igt78TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE9E, SeekOrigin.Begin);
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
            igt78bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEA8, SeekOrigin.Begin);
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
            igt78cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEB3, SeekOrigin.Begin);
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
            igt78dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEB9, SeekOrigin.Begin);
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
            igt79TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEC0, SeekOrigin.Begin);
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
            igt79bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEC9, SeekOrigin.Begin);
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
            igt79cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEED1, SeekOrigin.Begin);
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
            igt79dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEDC, SeekOrigin.Begin);
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
            igt80TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEE0, SeekOrigin.Begin);
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
            igt80bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEE8, SeekOrigin.Begin);
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
            igt80cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEF1, SeekOrigin.Begin);
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
            igt80dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEFC, SeekOrigin.Begin);
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
            igt81TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF05, SeekOrigin.Begin);
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
            igt81bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF0E, SeekOrigin.Begin);
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
            igt81cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF16, SeekOrigin.Begin);
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
            igt81dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF40, SeekOrigin.Begin);
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
            igt82TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF4B, SeekOrigin.Begin);
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
            igt83TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF51, SeekOrigin.Begin);
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
            igt83bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF5B, SeekOrigin.Begin);
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
            igt84TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF64, SeekOrigin.Begin);
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
            igt84bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF6D, SeekOrigin.Begin);
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
            igt85TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF77, SeekOrigin.Begin);
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
            igt85bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFA5, SeekOrigin.Begin);
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
            igt86TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFAD, SeekOrigin.Begin);
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
            igt86bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFB8, SeekOrigin.Begin);
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
            igt86cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFC3, SeekOrigin.Begin);
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
            igt86dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5B1, SeekOrigin.Begin);
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
            igt87TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5BB, SeekOrigin.Begin);
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
            igt87bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5C5, SeekOrigin.Begin);
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
            igt87cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5CD, SeekOrigin.Begin);
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
            igt87dTextBox.Text = zeldaAsciiRet;
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
            //update text
            //code to update the rom here
            //string newgcString, ZeldaHexReturn = "";
            //string newgcString;
            //int x = 0, q = 0, offset = 0x0;
            //setup arrays
            //string[] zs = new string[0x1C];
            //byte[] zb = new byte[0x1C];
            //int[] zd = new int[0x1C];
            //string[] zs_final = new string[0x1C];
            //string[] zsw = new string[0x1C];
            //FileStream fs2 = new FileStream(@filename, FileMode.Open, FileAccess.Write);


            //1
            //these 3 values need set and the rest is history
            newgcString = igt1TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE390;
            writeByte();

            //call function, set value, call function
            newgcString = igt1bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE39B;
            writeByte();

            newgcString = igt1cTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xE3A3;
            writeByte();

            newgcString = igt2TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xE3A8;
            writeByte();

            newgcString = igt2bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE3AD;
            writeByte();

            newgcString = igt3TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE3B5;
            writeByte();

            newgcString = igt3bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE3BB;
            writeByte();

            newgcString = igt3cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3C3;
            writeByte();

            newgcString = igt4TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE3CE;
            writeByte();

            newgcString = igt4bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3D7;
            writeByte();

            newgcString = igt5TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3E2;
            writeByte();

            newgcString = igt5bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3ED;
            writeByte();

            newgcString = igt6TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE3F8;
            writeByte();

            newgcString = igt6bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE402;
            writeByte();

            newgcString = igt7TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE40B;
            writeByte();

            newgcString = igt7bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE415;
            writeByte();

            newgcString = igt7cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE41E;
            writeByte();

            newgcString = igt7dTextBox.Text;
            newgcString = newgcString.PadRight(0xb);
            offset = 0xE429;
            writeByte();

            newgcString = igt8TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE435;
            writeByte();

            newgcString = igt9TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE43C;
            writeByte();

            newgcString = igt9bTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE442;
            writeByte();

            newgcString = igt9cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE448;
            writeByte();

            newgcString = igt10TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE450;
            writeByte();

            newgcString = igt10bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE457;
            writeByte();

            newgcString = igt10cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE45E;
            writeByte();

            newgcString = igt11TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE467;
            writeByte();

            newgcString = igt11bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE471;
            writeByte();

            newgcString = igt11cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE47C;
            writeByte();

            newgcString = igt11dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE487;
            writeByte();

            newgcString = igt12TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE491;
            writeByte();

            newgcString = igt12bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE49A;
            writeByte();

            newgcString = igt12cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE4A3;
            writeByte();

            newgcString = igt12dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE4AC;
            writeByte();

            newgcString = igt13TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE4B4;
            writeByte();

            newgcString = igt13bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE4BD;
            writeByte();

            newgcString = igt13cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE4C8;
            writeByte();

            newgcString = igt13dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE4D2;
            writeByte();

            newgcString = igt14TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE4F1;
            writeByte();

            newgcString = igt14bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5FC;
            writeByte();

            newgcString = igt14cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE506;
            writeByte();

            newgcString = igt14dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE50E;
            writeByte();

            newgcString = igt15TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE517;
            writeByte();

            newgcString = igt15bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE521;
            writeByte();

            newgcString = igt15cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE529;
            writeByte();

            newgcString = igt15dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE533;
            writeByte();

            newgcString = igt16TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE53B;
            writeByte();

            newgcString = igt16bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE545;
            writeByte();

            newgcString = igt16cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE550;
            writeByte();
            
            newgcString = igt16dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE559;
            writeByte();

            //-----

            newgcString = igt17TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE58E;
            writeByte();

            newgcString = igt17bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE597;
            writeByte();

            newgcString = igt17cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE5A0;
            writeByte();

            newgcString = igt17dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE5A9;
            writeByte();

            newgcString = igt18TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5D8;
            writeByte();

            newgcString = igt18bTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE5E2;
            writeByte();

            newgcString = igt18cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5E8;
            writeByte();

            newgcString = igt18dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE5F2;
            writeByte();

            newgcString = igt19TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE5FA;
            writeByte();

            newgcString = igt19bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE605;
            writeByte();

            newgcString = igt19cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE60F;
            writeByte();

            newgcString = igt19dTextBox.Text;
            newgcString = newgcString.PadRight(0xb);
            offset = 0xE618;
            writeByte();

            newgcString = igt20TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE632;
            writeByte();

            newgcString = igt20bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE63C;
            writeByte();

            newgcString = igt20cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE643;
            writeByte();

            newgcString = igt20dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE64D;
            writeByte();

            newgcString = igt21TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE654;
            writeByte();

            newgcString = igt21bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE65B;
            writeByte();

            newgcString = igt22TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE666;
            writeByte();

            newgcString = igt22bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE66E;
            writeByte();

            newgcString = igt22cTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE677;
            writeByte();

            newgcString = igt22dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE67F;
            writeByte();

            newgcString = igt23TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xE6AC;
            writeByte();

            newgcString = igt23bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE6B1;
            writeByte();

            newgcString = igt24TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE6B8;
            writeByte();

            newgcString = igt24bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE6C1;
            writeByte();

            newgcString = igt24cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE6CC;
            writeByte();

            newgcString = igt24dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE6D7;
            writeByte();

            newgcString = igt25TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE6E1;
            writeByte();

            newgcString = igt25bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE6EB;
            writeByte();

            newgcString = igt25cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE6F6;
            writeByte();

            newgcString = igt25dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE6FE;
            writeByte();

            newgcString = igt26TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE705;
            writeByte();

            newgcString = igt26bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE70D;
            writeByte();

            newgcString = igt26cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE717;
            writeByte();

            newgcString = igt26dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE722;
            writeByte();

            newgcString = igt27TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE747;
            writeByte();

            newgcString = igt27bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE74E;
            writeByte();

            newgcString = igt27cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE759;
            writeByte();

            newgcString = igt29TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE763;
            writeByte();

            //30.
            newgcString = igt30TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE76C;
            writeByte();

            newgcString = igt30bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE777;
            writeByte();

            newgcString = igt30cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE782;
            writeByte();

            newgcString = igt30dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE78D;
            writeByte();

            newgcString = igt31TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE798;
            writeByte();

            newgcString = igt31bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE7A1;
            writeByte();

            newgcString = igt31cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE7AC;
            writeByte();

            newgcString = igt31dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE7B5;
            writeByte();

            newgcString = igt32TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE7BF;
            writeByte();

            newgcString = igt32bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE7C9;
            writeByte();

            newgcString = igt32cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE7D3;
            writeByte();

            newgcString = igt32dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE7DE;
            writeByte();

            newgcString = igt33TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE80E;
            writeByte();

            newgcString = igt33bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE818;
            writeByte();

            newgcString = igt33cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE821;
            writeByte();

            newgcString = igt33dTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE82C;
            writeByte();

            newgcString = igt34TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE833;
            writeByte();

            newgcString = igt34bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE83C;
            writeByte();

            newgcString = igt34cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE847;
            writeByte();

            newgcString = igt34dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE852;
            writeByte();

            newgcString = igt35TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE85D;
            writeByte();

            newgcString = igt35bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE867;
            writeByte();

            newgcString = igt35cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE872;
            writeByte();

            newgcString = igt35dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE87D;
            writeByte();

            newgcString = igt36TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE888;
            writeByte();

            newgcString = igt36bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE893;
            writeByte();

            newgcString = igt36cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE89D;
            writeByte();

            newgcString = igt36dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE8A7;
            writeByte();

            newgcString = igt37TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE8B2;
            writeByte();

            newgcString = igt37bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE8BD;
            writeByte();

            newgcString = igt37cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE8C7;
            writeByte();

            newgcString = igt37dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE8D1;
            writeByte();

            newgcString = igt38TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE8F0;
            writeByte();

            newgcString = igt38bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE8F9;
            writeByte();

            newgcString = igt38cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE902;
            writeByte();

            newgcString = igt38dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE90C;
            writeByte();

            newgcString = igt39TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE917;
            writeByte();

            newgcString = igt39bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE922;
            writeByte();

            newgcString = igt39cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE92B;
            writeByte();

            newgcString = igt39dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE934;
            writeByte();

            newgcString = igt40TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE93E;
            writeByte();

            newgcString = igt40bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE948;
            writeByte();

            newgcString = igt40cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE951;
            writeByte();

            newgcString = igt40dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE95C;
            writeByte();

            newgcString = igt41TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE965;
            writeByte();

            newgcString = igt41bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE96F;
            writeByte();

            newgcString = igt41cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE977;
            writeByte();

            newgcString = igt41dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE981;
            writeByte();

            newgcString = igt42TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE9AE;
            writeByte();

            newgcString = igt42bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9B7;
            writeByte();

            newgcString = igt42cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE9C2;
            writeByte();

            newgcString = igt42dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE9CB;
            writeByte();

            newgcString = igt43TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9D4;
            writeByte();

            newgcString = igt43bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9DF;
            writeByte();

            newgcString = igt43cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9EA;
            writeByte();

            newgcString = igt43dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9F5;
            writeByte();

            newgcString = igt44TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEA00;
            writeByte();

            //you are here

            newgcString = igt45TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA07;
            writeByte();

            newgcString = igt45bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEA12;
            writeByte();

            newgcString = igt45cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEA1C;
            writeByte();

            newgcString = igt45dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA25;
            writeByte();

            newgcString = igt46TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEA43;
            writeByte();

            newgcString = igt46bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA4B;
            writeByte();

            newgcString = igt47TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEA56;
            writeByte();

            newgcString = igt48TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA5F;
            writeByte();

            newgcString = igt49TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEA6A;
            writeByte();

            newgcString = igt49bTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEA74;
            writeByte();

            newgcString = igt50TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEA79;
            writeByte();

            newgcString = igt50bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA7E;
            writeByte();

            newgcString = igt50cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEA89;
            writeByte();

            newgcString = igt51TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEA93;
            writeByte();

            newgcString = igt51bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEA9A;
            writeByte();

            newgcString = igt52TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEAA3;
            writeByte();

            newgcString = igt52bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEAAA;
            writeByte();

            newgcString = igt52cTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEAB3;
            writeByte();

            newgcString = igt53TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEAB9;
            writeByte();

            newgcString = igt53bTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEAC2;
            writeByte();

            newgcString = igt53cTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEAC7;
            writeByte();

            newgcString = igt54TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEACF;
            writeByte();

            newgcString = igt54bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEAD9;
            writeByte();

            newgcString = igt55TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEAE3;
            writeByte();

            newgcString = igt55bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEAED;
            writeByte();

            newgcString = igt55cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEAF8;
            writeByte();

            newgcString = igt55dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEB02;
            writeByte();

            newgcString = igt56TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEB0C;
            writeByte();

            newgcString = igt56bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEB16;
            writeByte();

            newgcString = igt56cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB1E;
            writeByte();

            newgcString = igt56dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB29;
            writeByte();

            newgcString = igt57TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEB49;
            writeByte();

            newgcString = igt57bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB51;
            writeByte();

            newgcString = igt57cTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xEB5A;
            writeByte();

            newgcString = igt58TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEB61;
            writeByte();

            newgcString = igt58bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB6B;
            writeByte();

            newgcString = igt58cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB76;
            writeByte();

            newgcString = igt58dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB81;
            writeByte();

            newgcString = igt59TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEB8A;
            writeByte();

            newgcString = igt59bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB8F;
            writeByte();

            newgcString = igt60TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB98;
            writeByte();

            newgcString = igt60bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEBA1;
            writeByte();

            newgcString = igt60cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBA8;
            writeByte();

            newgcString = igt60dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEBB0;
            writeByte();

            newgcString = igt61TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEBBA;
            writeByte();

            newgcString = igt61bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBC5;
            writeByte();

            newgcString = igt61cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBCD;
            writeByte();

            newgcString = igt61dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEBD5;
            writeByte();

            newgcString = igt62TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBE0;
            writeByte();

            newgcString = igt62bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEBE8;
            writeByte();

            newgcString = igt62cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBF3;
            writeByte();

            newgcString = igt62dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEBFB;
            writeByte();

            newgcString = igt63TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEC05;
            writeByte();

            newgcString = igt63bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEC0F;
            writeByte();

            newgcString = igt63cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC18;
            writeByte();

            newgcString = igt64TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEC4E;
            writeByte();

            newgcString = igt64bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEC57;
            writeByte();

            newgcString = igt64cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC61;
            writeByte();

            newgcString = igt64dTextBox.Text;
            newgcString = newgcString.PadRight(0x3);
            offset = 0xEC6C;
            writeByte();

            newgcString = igt65TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEC70;
            writeByte();

            newgcString = igt65bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEC7A;
            writeByte();

            newgcString = igt65cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC83;
            writeByte();

            newgcString = igt66TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC8E;
            writeByte();

            newgcString = igt66bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEC99;
            writeByte();

            newgcString = igt66cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xECA0;
            writeByte();

            newgcString = igt66dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xECA9;
            writeByte();

            newgcString = igt67TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xECB4;
            writeByte();

            newgcString = igt67bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xECBE;
            writeByte();

            newgcString = igt67cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xECC7;
            writeByte();

            newgcString = igt67dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xECD0;
            writeByte();

            newgcString = igt68TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xECDA;
            writeByte();

            newgcString = igt68bTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xECE5;
            writeByte();

            newgcString = igt68cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xECEB;
            writeByte();

            newgcString = igt69TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED11;
            writeByte();

            newgcString = igt69bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED1C;
            writeByte();

            newgcString = igt69cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED25;
            writeByte();

            newgcString = igt69dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xED30;
            writeByte();

            newgcString = igt70TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED37;
            writeByte();

            newgcString = igt70bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xED40;
            writeByte();

            newgcString = igt70cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED48;
            writeByte();

            newgcString = igt70dTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xED53;
            writeByte();

            newgcString = igt71TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED59;
            writeByte();

            newgcString = igt71bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xED64;
            writeByte();

            newgcString = igt71cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED6E;
            writeByte();

            newgcString = igt71dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED77;
            writeByte();

            newgcString = igt72TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xED82;
            writeByte();

            newgcString = igt72bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED8C;
            writeByte();

            newgcString = igt72cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xED95;
            writeByte();

            newgcString = igt72dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED9F;
            writeByte();

            newgcString = igt73TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEDCF;
            writeByte();

            newgcString = igt73bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEDD8;
            writeByte();

            newgcString = igt73cTextBox.Text;
            newgcString = newgcString.PadRight(0xb);
            offset = 0xEDE3;
            writeByte();

            newgcString = igt74TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEDEF;
            writeByte();

            newgcString = igt74bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEDF6;
            writeByte();

            newgcString = igt74cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEDFE;
            writeByte();

            newgcString = igt75TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE06;
            writeByte();

            newgcString = igt75bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE0E;
            writeByte();

            newgcString = igt75cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE16;
            writeByte();

            newgcString = igt75dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE1E;
            writeByte();

            newgcString = igt76TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE48;
            writeByte();

            newgcString = igt76bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEE53;
            writeByte();

            newgcString = igt76cTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEE5D;
            writeByte();

            newgcString = igt76dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE64;
            writeByte();

            newgcString = igt77TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEE6F;
            writeByte();

            newgcString = igt77bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE78;
            writeByte();

            newgcString = igt77cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEE80;
            writeByte();

            newgcString = igt77dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE8A;
            writeByte();

            newgcString = igt78TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEE95;
            writeByte();

            newgcString = igt78bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEE9E;
            writeByte();

            newgcString = igt78cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEEA8;
            writeByte();

            newgcString = igt78dTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xEEB3;
            writeByte();

            newgcString = igt79TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEEB9;
            writeByte();

            newgcString = igt79bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEEC0;
            writeByte();

            newgcString = igt79cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEEC9;
            writeByte();

            newgcString = igt79dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEED1;
            writeByte();

            newgcString = igt80TextBox.Text;
            newgcString = newgcString.PadRight(0x3);
            offset = 0xEEDC;
            writeByte();

            newgcString = igt80bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEEE0;
            writeByte();

            newgcString = igt80cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEEE8;
            writeByte();

            newgcString = igt80dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEEF1;
            writeByte();

            newgcString = igt81TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEEFC;
            writeByte();

            newgcString = igt81bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF05;
            writeByte();

            newgcString = igt81cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEF0E;
            writeByte();

            newgcString = igt81dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF16;
            writeByte();

            newgcString = igt82TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEF40;
            writeByte();

            newgcString = igt83TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xEF4B;
            writeByte();

            newgcString = igt83bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEF51;
            writeByte();

            newgcString = igt84TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF5B;
            writeByte();

            newgcString = igt84bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF64;
            writeByte();

            newgcString = igt85TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEF6D;
            writeByte();

            newgcString = igt85bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEF77;
            writeByte();

            newgcString = igt86TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEFA5;
            writeByte();

            newgcString = igt86bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEFAD;
            writeByte();

            newgcString = igt86cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEFB8;
            writeByte();

            newgcString = igt86dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEFC3;
            writeByte();

            newgcString = igt87TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5B1;
            writeByte();

            newgcString = igt87bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5BB;
            writeByte();

            newgcString = igt87cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE5C5;
            writeByte();

            newgcString = igt87dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE5CD;
            writeByte();

            MessageBox.Show("Updated!", "In Game Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
        }
 




















    }
}
