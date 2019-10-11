/**
 * @file           FormRegistrationAndMisc.cs
 * @brief          Creates the form for changing registration and misc text.
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
    public partial class FormRegistrationAndMisc : Form
    {

        public string FullFilename { get; set; }

        public FormRegistrationAndMisc(string filename)
        {
            InitializeComponent();
            FullFilename = filename;
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
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
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                m1TextBox.Text = backend.getText(0xa, 0x0013);
                m2TextBox.Text = backend.getText(0xf, 0x0020);
                m3TextBox.Text = backend.getText(0x4, 0x1BE5);
                m4TextBox.Text = backend.getText(0x6, 0x1BF9);
                m5TextBox.Text = backend.getText(0x5, 0x1C07);
                m6TextBox.Text = backend.getText(0x4, 0x1C15);
                m7TextBox.Text = backend.getText(0x2, 0x1C1E);
                m8TextBox.Text = backend.getText(0x6, 0x1C23);
                m9TextBox.Text = backend.getText(0xb, 0x17C2C);
                m10TextBox.Text = backend.getText(0x6, 0x17C4E);
                m11TextBox.Text = backend.getText(0x7, 0x17C57);
                m12TextBox.Text = backend.getText(0x3, 0x17C62);
                m12bTextBox.Text = backend.getText(0x3, 0x17C66);
                m12cTextBox.Text = backend.getText(0x2, 0x17C6A);
                m13TextBox.Text = backend.getText(0x3, 0x17C70);
                m13bTextBox.Text = backend.getText(0x3, 0x17C74);
                m13cTextBox.Text = backend.getText(0x2, 0x17C78);
                m14TextBox.Text = backend.getText(0x3, 0x17C7E);
                m14bTextBox.Text = backend.getText(0x3, 0x17C82);
                m14cTextBox.Text = backend.getText(0x2, 0x17C86);
                m15TextBox.Text = backend.getText(0x12, 0x17C8B);
                m16TextBox.Text = backend.getText(0x10, 0x17CB2);
                m17TextBox.Text = backend.getText(0x13, 0x17CD7);
                m18TextBox.Text = backend.getText(0x3, 0x17CED);
                m19TextBox.Text = backend.getText(0x15, 0x17D13);
                m20TextBox.Text = backend.getText(0x15, 0x17D2B);
                m21TextBox.Text = backend.getText(0xb, 0x17D43);
                m22TextBox.Text = backend.getText(0x13, 0x17D51);
                m23TextBox.Text = backend.getText(0x11, 0x17D6D);
                m24TextBox.Text = backend.getText(0x3, 0x17D81);
                m25TextBox.Text = backend.getText(0x1c, 0x17D85);
                m26TextBox.Text = backend.getText(0xa, 0x17DA6);
                m27TextBox.Text = backend.getText(0x10, 0x1976C);
                m28TextBox.Text = backend.getText(0x6, 0x1D0E4);
                m29TextBox.Text = backend.getText(0x5, 0x1D0ED);
                m30TextBox.Text = backend.getText(0x4, 0x1D0F5);
                m31TextBox.Text = backend.getText(0x8, 0x1FDE8);
                m32TextBox.Text = backend.getText(0x4, 0x1FDF3);
                m33TextBox.Text = backend.getText(0x7, 0x1FE1A);
                m34TextBox.Text = backend.getText(0x16, 0x1FE24);
                m35TextBox.Text = backend.getText(0xb, 0x1FE3D);
                m36TextBox.Text = backend.getText(0xa, 0x1FE49);
                m37TextBox.Text = backend.getText(0x16, 0x1FE56);
                m38TextBox.Text = backend.getText(0x16, 0x1FE6F);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRegistrationAndMisc_Load(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                backend.updateROMText(0xa, m1TextBox.Text, 0x0013);
                backend.updateROMText(0xf, m2TextBox.Text, 0x0020);
                backend.updateROMText(0x4, m3TextBox.Text, 0x1BE5);
                backend.updateROMText(0x6, m4TextBox.Text, 0x1BF9);
                backend.updateROMText(0x5, m5TextBox.Text, 0x1C07);
                backend.updateROMText(0x4, m6TextBox.Text, 0x1C15);
                backend.updateROMText(0x4, m7TextBox.Text, 0x1C1E);
                backend.updateROMText(0x6, m8TextBox.Text, 0x1C23);
                backend.updateROMText(0xb, m9TextBox.Text, 0x17C2C);
                backend.updateROMText(0x6, m10TextBox.Text, 0x17C4E);
                backend.updateROMText(0x7, m11TextBox.Text, 0x17C57);
                backend.updateROMText(0x3, m12TextBox.Text, 0x17C62);
                backend.updateROMText(0x3, m12bTextBox.Text, 0x17C66);
                backend.updateROMText(0x2, m12cTextBox.Text, 0x17C6A);
                backend.updateROMText(0x3, m13TextBox.Text, 0x17C70);
                backend.updateROMText(0x3, m13bTextBox.Text, 0x17C74);
                backend.updateROMText(0x2, m13cTextBox.Text, 0x17C78);
                backend.updateROMText(0x3, m14TextBox.Text, 0x17C7E);
                backend.updateROMText(0x3, m14bTextBox.Text, 0x17C82);
                backend.updateROMText(0x2, m14cTextBox.Text, 0x17C86);
                backend.updateROMText(0x12, m15TextBox.Text, 0x17C8B);
                backend.updateROMText(0x10, m16TextBox.Text, 0x17CB2);
                backend.updateROMText(0x13, m17TextBox.Text, 0x17CD7);
                backend.updateROMText(0x3, m18TextBox.Text, 0x17CED);
                backend.updateROMText(0x15, m19TextBox.Text, 0x17D13);
                backend.updateROMText(0x15, m20TextBox.Text, 0x17D2B);
                backend.updateROMText(0xb, m21TextBox.Text, 0x17D43);
                backend.updateROMText(0x13, m22TextBox.Text, 0x17D51);
                backend.updateROMText(0x11, m23TextBox.Text, 0x17D6D);
                backend.updateROMText(0x3, m24TextBox.Text, 0x17D81);
                backend.updateROMText(0x1c, m25TextBox.Text, 0x17D85);
                backend.updateROMText(0xa, m26TextBox.Text, 0x17DA6);
                backend.updateROMText(0x10, m27TextBox.Text, 0x1976C);
                backend.updateROMText(0x6, m28TextBox.Text, 0x1D0E4);
                backend.updateROMText(0x5, m29TextBox.Text, 0x1D0ED);
                backend.updateROMText(0x4, m30TextBox.Text, 0x1D0F5);
                backend.updateROMText(0x8, m31TextBox.Text, 0x1FDE8);
                backend.updateROMText(0x4, m32TextBox.Text, 0x1FDF3);
                backend.updateROMText(0x7, m33TextBox.Text, 0x1FE1A);
                backend.updateROMText(0x16, m34TextBox.Text, 0x1FE24);
                backend.updateROMText(0xb, m35TextBox.Text, 0x1FE3D);
                backend.updateROMText(0xa, m36TextBox.Text, 0x1FE49);
                backend.updateROMText(0x16, m37TextBox.Text, 0x1FE56);
                backend.updateROMText(0x16, m38TextBox.Text, 0x1FE6F);

                MessageBox.Show(@"Updated!", @"Registration and Misc Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
