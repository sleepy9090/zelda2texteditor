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

        public FormCredits(string filename)
        {
            InitializeComponent();
            FullFilename = filename;
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
        {
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
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                gctextBox1.Text = backend.getText(0x3, 0x14DF1);
                gctextBox2.Text = backend.getText(0x5, 0x14DF5);
                gctextBox3.Text = backend.getText(0x6, 0x14DFB);
                gctextBox4.Text = backend.getText(0x6, 0x14E02);
                gctextBox5.Text = backend.getText(0x3, 0x14E09);
                gctextBox6.Text = backend.getText(0x1, 0x14E0D);
                gctextBox7.Text = backend.getText(0x4, 0x14E0F);
                gctextBox8.Text = backend.getText(0x4, 0x14E14);
                gctextBox9.Text = backend.getText(0x12, 0x15290);
                gctextBox10.Text = backend.getText(0xa, 0x152A6);
                gctextBox11.Text = backend.getText(0x12, 0x152B4);
                gctextBox12.Text = backend.getText(0xa, 0x152CA);
                gctextBox13.Text = backend.getText(0x8, 0x152D8);
                gctextBox14.Text = backend.getText(0x7, 0x152E4);
                gctextBox15.Text = backend.getText(0x8, 0x152F9);
                gctextBox16.Text = backend.getText(0x7, 0x15305);
                gctextBox17.Text = backend.getText(0xe, 0x1531A);
                gctextBox18.Text = backend.getText(0x8, 0x1532C);
                gctextBox19.Text = backend.getText(0xe, 0x15338);
                gctextBox20.Text = backend.getText(0x9, 0x1534A);
                gctextBox21.Text = backend.getText(0x8, 0x15356);
                gctextBox22.Text = backend.getText(0x11, 0x15362);
                gctextBox23.Text = backend.getText(0xa, 0x15377);
                gctextBox24.Text = backend.getText(0x9, 0x15384);
                gctextBox25.Text = backend.getText(0x9, 0x15391);
                gctextBox26.Text = backend.getText(0x8, 0x1539D);
                gctextBox27.Text = backend.getText(0x9, 0x153A9);
                gctextBox28.Text = backend.getText(0x7, 0x152EE);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCredits_Load(object sender, EventArgs e)
        {
            // Do nothing

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                backend.updateROMText(0x3, gctextBox1.Text, 0x14DF1);
                backend.updateROMText(0x5, gctextBox2.Text, 0x14DF5);
                backend.updateROMText(0x6, gctextBox3.Text, 0x14DFB);
                backend.updateROMText(0x6, gctextBox4.Text, 0x14E02);
                backend.updateROMText(0x3, gctextBox5.Text, 0x14E09);
                backend.updateROMText(0x1, gctextBox6.Text, 0x14E0D);
                backend.updateROMText(0x4, gctextBox7.Text, 0x14E0F);
                backend.updateROMText(0x4, gctextBox8.Text, 0x14E14);
                backend.updateROMText(0x12, gctextBox9.Text, 0x15290);
                backend.updateROMText(0xa, gctextBox10.Text, 0x152A6);
                backend.updateROMText(0x12, gctextBox11.Text, 0x152B4);
                backend.updateROMText(0xa, gctextBox12.Text, 0x152CA);
                backend.updateROMText(0x8, gctextBox13.Text, 0x152D8);
                backend.updateROMText(0x7, gctextBox14.Text, 0x152E4);
                backend.updateROMText(0x8, gctextBox15.Text, 0x152F9);
                backend.updateROMText(0x7, gctextBox16.Text, 0x15305);
                backend.updateROMText(0xe, gctextBox17.Text, 0x1531A);
                backend.updateROMText(0x8, gctextBox18.Text, 0x1532C);
                backend.updateROMText(0xe, gctextBox19.Text, 0x15338);
                backend.updateROMText(0x9, gctextBox20.Text, 0x1534A);
                backend.updateROMText(0x8, gctextBox21.Text, 0x15356);
                backend.updateROMText(0x11, gctextBox22.Text, 0x15362);
                backend.updateROMText(0xa, gctextBox23.Text, 0x15377);
                backend.updateROMText(0x9, gctextBox24.Text, 0x15384);
                backend.updateROMText(0x9, gctextBox25.Text, 0x15391);
                backend.updateROMText(0x8, gctextBox26.Text, 0x1539D);
                backend.updateROMText(0x9, gctextBox27.Text, 0x153A9);
                backend.updateROMText(0x7, gctextBox28.Text, 0x152EE);

                MessageBox.Show(@"Updated!", @"Credits Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
