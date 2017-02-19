//programmed by Shawn M. Crawford, 06/02/2010
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename;
        string path;
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

        private void btfButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fnTextBox.Text = ofd.FileName;
                dButton.Enabled = true;
                disassembleToolStripMenuItem.Enabled = true;

            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disassembleToolStripMenuItem.Enabled = false;
            dButton.Enabled = false;
            zstoryTextBox.Enabled = false;
            editInGameTextToolStripMenuItem.Enabled = false;
            editGameCreditsToolStripMenuItem.Enabled = false;
            editSpellsToolStripMenuItem.Enabled = false;
            editRegisistrationAndMiscellanouseTextToolStripMenuItem.Enabled = false;
            editTownNamesToolStripMenuItem.Enabled = false;
            updateButton.Enabled = false;
            zstoryeditTextBox.MaxLength = 0x1c;
            zstoryeditTextBox2.MaxLength = 0x1c;
            zstoryeditTextBox3.MaxLength = 0x1c;
            zstoryeditTextBox4.MaxLength = 0x1c;
            zstoryeditTextBox5.MaxLength = 0x1c;
            zstoryeditTextBox6.MaxLength = 0x1c;
            zstoryeditTextBox7.MaxLength = 0x1c;
            zstoryeditTextBox8.MaxLength = 0x1c;
            //zstoryeditTextBox9.MaxLength = 0x17;
            zstoryeditTextBox10.MaxLength = 0x1c;
            zstoryeditTextBox11.MaxLength = 0x1c;
            zstoryeditTextBox12.MaxLength = 0x1c;
            zstoryeditTextBox13.MaxLength = 0x1c;
            zstoryeditTextBox14.MaxLength = 0x1c;
            zstoryeditTextBox15.MaxLength = 0x1c;
            zstoryeditTextBox16.MaxLength = 0x1c;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadfile()
        {
            
             

            //1.Identify and output the rom code
            string rctext = "";
            string zeldaAsciiRet = "";
            int x = 0;

            
            FileStream fs1 = new FileStream(@path, FileMode.Open, FileAccess.Read);
            fs1.Seek(0x16942, SeekOrigin.Begin);   // Seek to 0x16942th byte in the file

            while (x < 0x1b2)
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
            zstoryTextBox.Text = zeldaAsciiRet;


            //for edit boxes
            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16942, SeekOrigin.Begin);   // Seek to 0x16942th byte in the file

            while (x < 0x1c)
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
            zstoryeditTextBox.Text = zeldaAsciiRet;


            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x1695F, SeekOrigin.Begin);   // Seek to 0x16942th byte in the file

            while (x < 0x1c)
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
            zstoryeditTextBox2.Text = zeldaAsciiRet;


            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x1697C, SeekOrigin.Begin);   // Seek to 0x16942th byte in the file

            while (x < 0x1c)
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
            zstoryeditTextBox3.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16999, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox4.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x169B6, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox5.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x169D3, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox6.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x169F0, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox7.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16A0D, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox8.Text = zeldaAsciiRet;
            /*
            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16A12, SeekOrigin.Begin);

            while (x < 0x17)
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
            zstoryeditTextBox9.Text = zeldaAsciiRet;
            */
            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16A2A, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox10.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16A47, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox11.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16A64, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox12.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16A81, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox13.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16A9E, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox14.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16ABB, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox15.Text = zeldaAsciiRet;

            x = 0;
            zeldaAsciiRet = "";
            fs1.Seek(0x16AD8, SeekOrigin.Begin);

            while (x < 0x1c)
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
            zstoryeditTextBox16.Text = zeldaAsciiRet;


            fs1.Close();

            openRomProgressBar.PerformStep();
         
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
                case "9C":
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

        private void dButton_Click(object sender, EventArgs e)
        {
            openRomProgressBar.PerformStep();

            if (fnTextBox.Text != "")
            {
                path = fnTextBox.Text;
                filename = fnTextBox.Text.Substring(fnTextBox.Text.LastIndexOf('\\') + 1);
                sfnTextBox.Text = filename.ToString();

                loadfile();

                editInGameTextToolStripMenuItem.Enabled = true;
                editGameCreditsToolStripMenuItem.Enabled = true;
                editSpellsToolStripMenuItem.Enabled = true;
                editRegisistrationAndMiscellanouseTextToolStripMenuItem.Enabled = true;
                editTownNamesToolStripMenuItem.Enabled = true;
                updateButton.Enabled = true;
            }
        }

        private void editInGameTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_igt figt = new Form2_igt();

            figt.fntootherform = fnTextBox.Text;

            figt.ShowDialog();
        }

        private void editGameCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_gct fgct = new Form_gct();

            fgct.fntootherform = fnTextBox.Text;

            fgct.ShowDialog();
        }

        private void editSpellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_st fst = new Form_st();

            fst.fntootherform = fnTextBox.Text;

            fst.ShowDialog();
        }

        private void editRegisistrationAndMiscellanouseTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ramt framt = new Form_ramt();

            framt.fntootherform = fnTextBox.Text;

            framt.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();

            ab.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            newgcString = zstoryeditTextBox.Text;
            newgcString = newgcString.PadRight(0x19);
            offset = 0x16942;
            writeByte();

            newgcString = zstoryeditTextBox2.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x1695F;
            writeByte();

            newgcString = zstoryeditTextBox3.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x1697C;
            writeByte();

            newgcString = zstoryeditTextBox4.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16999;
            writeByte();

            newgcString = zstoryeditTextBox5.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x169B6;
            writeByte();

            newgcString = zstoryeditTextBox6.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x169D3;
            writeByte();

            newgcString = zstoryeditTextBox7.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x169F0;
            writeByte();

            newgcString = zstoryeditTextBox8.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16A0D;
            writeByte();
            /*
            newgcString = zstoryeditTextBox9.Text;
            newgcString = newgcString.PadRight(0x17);
            offset = 0x16A12;
            writeByte();
            */
            newgcString = zstoryeditTextBox10.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16A2A;
            writeByte();

            newgcString = zstoryeditTextBox11.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16A47;
            writeByte();

            newgcString = zstoryeditTextBox12.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16A64;
            writeByte();

            newgcString = zstoryeditTextBox13.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16A81;
            writeByte();

            newgcString = zstoryeditTextBox14.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16A9E;
            writeByte();

            newgcString = zstoryeditTextBox15.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16ABB;
            writeByte();

            newgcString = zstoryeditTextBox16.Text;
            newgcString = newgcString.PadRight(0x1C);
            offset = 0x16AD8;
            writeByte();

            MessageBox.Show("Updated! Restart program to see changes.", "Story Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //old code
            /*
            int x = 0, y=0, z=0;
            //write the new text to string
            string newStoryString;
            //string ZeldaHexReturn = "";

            //use non-standard ascii for FD=©, 9C=¿
            //this is a temp fix

            newStoryString = zstoryeditTextBox.Text + "¿  ©" + zstoryeditTextBox2.Text + "©" +
                zstoryeditTextBox3.Text + "©" + zstoryeditTextBox4.Text + "©" + zstoryeditTextBox5.Text + "©"
                + zstoryeditTextBox6.Text + "©" + zstoryeditTextBox7.Text + "©" + zstoryeditTextBox8.Text + "¿"
                + zstoryeditTextBox9.Text + "©" + zstoryeditTextBox10.Text + "©" + zstoryeditTextBox11.Text + "©"
                + zstoryeditTextBox12.Text + "©" + zstoryeditTextBox13.Text + "©" + zstoryeditTextBox14.Text + "©"
                + zstoryeditTextBox15.Text;

            //pad string length to 11 so no array errors
            newStoryString = newStoryString.PadRight(0x1b2);

            //setup arrays
            string[] zs = new string[0x1b2];
            byte[] zb = new byte[0x1b2];
            int[] zd = new int[0x1b2];
            string[] zs_final = new string[0x1b2];
            string[] zsw = new string[0x1b2];

            while (x < 0x1b2)
            {
                zs[x] = newStoryString[x].ToString();

                //convert string back into zelda text hex code
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            x = 0;
            y = 0;
            z = 1;

            while (x < 0x1b2)
            {
                zsw[x] = ZeldaHexReturn[y].ToString() + ZeldaHexReturn[z].ToString();
                x++;
                y = y + 2;
                z = z + 2;
            }


            //convert the chars to int32, then to string, then byte again
            int q = 0;
            while (q < 0x1b2)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            FileStream fs2 = new FileStream(@path, FileMode.Open, FileAccess.Write);
            fs2.Seek(0x16942, SeekOrigin.Begin);   // Seek to 0x1C3Ath byte in the file

            //this is converting to hex before it writes
            q = 0;
            while (q < 0x1b2)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            fs2.Close();



            MessageBox.Show("Updated! Restart program to see changes.", "Story Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            zstoryTextBox.Text = zstoryeditTextBox.Text + "  " + zstoryeditTextBox2.Text +
                zstoryeditTextBox3.Text + zstoryeditTextBox4.Text + zstoryeditTextBox5.Text
                + zstoryeditTextBox6.Text + zstoryeditTextBox7.Text + zstoryeditTextBox8.Text
                + zstoryeditTextBox9.Text + zstoryeditTextBox10.Text + zstoryeditTextBox11.Text
                + zstoryeditTextBox12.Text + zstoryeditTextBox13.Text + zstoryeditTextBox14.Text
                + zstoryeditTextBox15.Text;
            */
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btfButton_Click(sender, e);
        }

        private void disassembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dButton_Click(sender, e);
        }

        private void writeByte()
        {
            FileStream fs2 = new FileStream(@path, FileMode.Open, FileAccess.Write);
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

        private void editTownNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_tn ftn = new Form_tn();

            ftn.fntootherform = fnTextBox.Text;

            ftn.ShowDialog();
        }

    }
}
