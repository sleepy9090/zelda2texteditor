/**
 * @file           FormGeneral.cs
 * @brief          Creates the form for changing general text.
 *
 * @copyright      Shawn M. Crawford
 * @date           10/15/2019
 *
 * @remark Author  Shawn M. Crawford
 *
 * @note           N/A
 * 
 */
using System;
using System.Windows.Forms;

namespace zelda2texteditor
{
    public partial class FormGeneral2 : Form
    {

        public string FullFilename { get; set; }

        public FormGeneral2(string filename)
        {
            InitializeComponent();
            FullFilename = filename;
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
        {
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
            igt30TextBox.MaxLength = 0xa;
            igt32dTextBox.MaxLength = 0xa;
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
            igt55TextBox.MaxLength = 0x9;
            igt55bTextBox.MaxLength = 0xa;
            igt55cTextBox.MaxLength = 0x9;
            igt55dTextBox.MaxLength = 0x9;
            igt56cTextBox.MaxLength = 0xa;
            igt60cTextBox.MaxLength = 0x7;
            igt60dTextBox.MaxLength = 0x9;
            igt61cTextBox.MaxLength = 0x7;
            igt64TextBox.MaxLength = 0x8;
            igt64bTextBox.MaxLength = 0x9;
            igt64cTextBox.MaxLength = 0xa;
            igt64dTextBox.MaxLength = 0x3;
            igt66TextBox.MaxLength = 0xa;
            igt66bTextBox.MaxLength = 0x6;
            igt66cTextBox.MaxLength = 0x8;
            igt67TextBox.MaxLength = 0x9;
            igt67bTextBox.MaxLength = 0x8;
            igt67cTextBox.MaxLength = 0x8;
            igt68TextBox.MaxLength = 0xa;
            igt68bTextBox.MaxLength = 0x5;
            igt81bTextBox.MaxLength = 0x8;
            igt81cTextBox.MaxLength = 0x7;
            igt82TextBox.MaxLength = 0xa;
            igt86TextBox.MaxLength = 0x7;
            igt86bTextBox.MaxLength = 0xa;
            igt86cTextBox.MaxLength = 0xa;
            igt86dTextBox.MaxLength = 0xa;
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);
                
                igt10TextBox.Text = backend.getText(0x6, 0xE450);
                igt10bTextBox.Text = backend.getText(0x6, 0xE457);
                igt10cTextBox.Text = backend.getText(0x8, 0xE45E);
                igt11TextBox.Text = backend.getText(0x9, 0xE467);
                igt11bTextBox.Text = backend.getText(0xa, 0xE471);
                igt11cTextBox.Text = backend.getText(0xa, 0xE47C);
                igt11dTextBox.Text = backend.getText(0x9, 0xE487);
                igt12TextBox.Text = backend.getText(0x8, 0xE491);
                igt12bTextBox.Text = backend.getText(0x8, 0xE49A);
                igt12cTextBox.Text = backend.getText(0x8, 0xE4A3);
                igt12dTextBox.Text = backend.getText(0x7, 0xE4AC);
                igt13TextBox.Text = backend.getText(0x8, 0xE4B4);
                igt13bTextBox.Text = backend.getText(0xa, 0xE4BD);
                igt13cTextBox.Text = backend.getText(0x9, 0xE4C8);
                igt13dTextBox.Text = backend.getText(0xa, 0xE4D2);
                igt30TextBox.Text = backend.getText(0xa, 0xE76C);
                igt32dTextBox.Text = backend.getText(0xa, 0xE7DE);
                igt37TextBox.Text = backend.getText(0x9, 0xE8B2);
                igt37bTextBox.Text = backend.getText(0x9, 0xE8BD);
                igt37cTextBox.Text = backend.getText(0x9, 0xE8C7);
                igt37dTextBox.Text = backend.getText(0x6, 0xE8D1);
                igt38TextBox.Text = backend.getText(0x8, 0xE8F0);
                igt38bTextBox.Text = backend.getText(0x8, 0xE8F9);
                igt38cTextBox.Text = backend.getText(0x9, 0xE902);
                igt38dTextBox.Text = backend.getText(0xa, 0xE90C);
                igt39TextBox.Text = backend.getText(0xa, 0xE917);
                igt39bTextBox.Text = backend.getText(0x8, 0xE922);
                igt39cTextBox.Text = backend.getText(0x8, 0xE92B);
                igt39dTextBox.Text = backend.getText(0x8, 0xE934);
                igt40TextBox.Text = backend.getText(0x9, 0xE93E);
                igt40bTextBox.Text = backend.getText(0x8, 0xE948);
                igt40cTextBox.Text = backend.getText(0xa, 0xE951);
                igt40dTextBox.Text = backend.getText(0x8, 0xE95C);
                igt41TextBox.Text = backend.getText(0x9, 0xE965);
                igt41bTextBox.Text = backend.getText(0x7, 0xE96F);
                igt41cTextBox.Text = backend.getText(0x9, 0xE977);
                igt41dTextBox.Text = backend.getText(0x7, 0xE981);
                igt55TextBox.Text = backend.getText(0x9, 0xEAE3);
                igt55bTextBox.Text = backend.getText(0xa, 0xEAED);
                igt55cTextBox.Text = backend.getText(0x9, 0xEAF8);
                igt55dTextBox.Text = backend.getText(0x9, 0xEB02);
                igt56cTextBox.Text = backend.getText(0xa, 0xEB1E);
                igt60cTextBox.Text = backend.getText(0x7, 0xEBA8);
                igt60dTextBox.Text = backend.getText(0x9, 0xEBB0);
                igt61cTextBox.Text = backend.getText(0x7, 0xEBCD);
                igt64TextBox.Text = backend.getText(0x8, 0xEC4E);
                igt64bTextBox.Text = backend.getText(0x9, 0xEC57);
                igt64cTextBox.Text = backend.getText(0xa, 0xEC61);
                igt64dTextBox.Text = backend.getText(0x3, 0xEC6C);
                igt66TextBox.Text = backend.getText(0xa, 0xEC8E);
                igt66bTextBox.Text = backend.getText(0x6, 0xEC99);
                igt66cTextBox.Text = backend.getText(0x8, 0xECA0);
                igt67TextBox.Text = backend.getText(0x9, 0xECB4);
                igt67bTextBox.Text = backend.getText(0x8, 0xECBE);
                igt67cTextBox.Text = backend.getText(0x8, 0xECC7);
                igt68TextBox.Text = backend.getText(0xa, 0xECDA);
                igt68bTextBox.Text = backend.getText(0x5, 0xECE5);
                igt81bTextBox.Text = backend.getText(0x8, 0xEF05);
                igt81cTextBox.Text = backend.getText(0x7, 0xEF0E);
                igt82TextBox.Text = backend.getText(0xa, 0xEF40);
                igt86TextBox.Text = backend.getText(0x7, 0xEFA5);
                igt86bTextBox.Text = backend.getText(0xa, 0xEFAD);
                igt86cTextBox.Text = backend.getText(0xa, 0xEFB8);
                igt86dTextBox.Text = backend.getText(0xa, 0xEFC3);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(FullFilename);
                
                backend.updateROMText(0x6, igt10TextBox.Text, 0xE450);
                backend.updateROMText(0x6, igt10bTextBox.Text, 0xE457);
                backend.updateROMText(0x8, igt10cTextBox.Text, 0xE45E);
                backend.updateROMText(0x8, igt11TextBox.Text, 0xE467);
                backend.updateROMText(0xa, igt11bTextBox.Text, 0xE471);
                backend.updateROMText(0xa, igt11cTextBox.Text, 0xE47C);
                backend.updateROMText(0x9, igt11dTextBox.Text, 0xE487);
                backend.updateROMText(0x8, igt12TextBox.Text, 0xE491);
                backend.updateROMText(0x8, igt12bTextBox.Text, 0xE49A);
                backend.updateROMText(0x8, igt12cTextBox.Text, 0xE4A3);
                backend.updateROMText(0x7, igt12dTextBox.Text, 0xE4AC);
                backend.updateROMText(0x8, igt13TextBox.Text, 0xE4B4);
                backend.updateROMText(0xa, igt13bTextBox.Text, 0xE4BD);
                backend.updateROMText(0x9, igt13cTextBox.Text, 0xE4C8);
                backend.updateROMText(0xa, igt13dTextBox.Text, 0xE4D2);
                backend.updateROMText(0xa, igt30TextBox.Text, 0xE76C);
                backend.updateROMText(0xa, igt32dTextBox.Text, 0xE7DE);
                backend.updateROMText(0xa, igt37TextBox.Text, 0xE8B2);
                backend.updateROMText(0x9, igt37bTextBox.Text, 0xE8BD);
                backend.updateROMText(0x9, igt37cTextBox.Text, 0xE8C7);
                backend.updateROMText(0x6, igt37dTextBox.Text, 0xE8D1);
                backend.updateROMText(0x8, igt38TextBox.Text, 0xE8F0);
                backend.updateROMText(0x8, igt38bTextBox.Text, 0xE8F9);
                backend.updateROMText(0x9, igt38cTextBox.Text, 0xE902);
                backend.updateROMText(0xa, igt38dTextBox.Text, 0xE90C);
                backend.updateROMText(0xa, igt39TextBox.Text, 0xE917);
                backend.updateROMText(0x8, igt39bTextBox.Text, 0xE922);
                backend.updateROMText(0x8, igt39cTextBox.Text, 0xE92B);
                backend.updateROMText(0x8, igt39dTextBox.Text, 0xE934);
                backend.updateROMText(0x9, igt40TextBox.Text, 0xE93E);
                backend.updateROMText(0x8, igt40bTextBox.Text, 0xE948);
                backend.updateROMText(0xa, igt40cTextBox.Text, 0xE951);
                backend.updateROMText(0x8, igt40dTextBox.Text, 0xE95C);
                backend.updateROMText(0x9, igt41TextBox.Text, 0xE965);
                backend.updateROMText(0x7, igt41bTextBox.Text, 0xE96F);
                backend.updateROMText(0x9, igt41cTextBox.Text, 0xE977);
                backend.updateROMText(0x7, igt41dTextBox.Text, 0xE981);
                backend.updateROMText(0x9, igt55TextBox.Text, 0xEAE3);
                backend.updateROMText(0xa, igt55bTextBox.Text, 0xEAED);
                backend.updateROMText(0x9, igt55cTextBox.Text, 0xEAF8);
                backend.updateROMText(0x9, igt55dTextBox.Text, 0xEB02);
                backend.updateROMText(0xa, igt56cTextBox.Text, 0xEB1E);
                backend.updateROMText(0x7, igt60cTextBox.Text, 0xEBA8);
                backend.updateROMText(0x9, igt60dTextBox.Text, 0xEBB0);
                backend.updateROMText(0x7, igt61cTextBox.Text, 0xEBCD);
                backend.updateROMText(0x8, igt64TextBox.Text, 0xEC4E);
                backend.updateROMText(0x9, igt64bTextBox.Text, 0xEC57);
                backend.updateROMText(0xa, igt64cTextBox.Text, 0xEC61);
                backend.updateROMText(0x3, igt64dTextBox.Text, 0xEC6C);
                backend.updateROMText(0xa, igt66TextBox.Text, 0xEC8E);
                backend.updateROMText(0x6, igt66bTextBox.Text, 0xEC99);
                backend.updateROMText(0x8, igt66cTextBox.Text, 0xECA0);
                backend.updateROMText(0x9, igt67TextBox.Text, 0xECB4);
                backend.updateROMText(0x8, igt67bTextBox.Text, 0xECBE);
                backend.updateROMText(0x8, igt67cTextBox.Text, 0xECC7);
                backend.updateROMText(0xa, igt68TextBox.Text, 0xECDA);
                backend.updateROMText(0x5, igt68bTextBox.Text, 0xECE5);
                backend.updateROMText(0x8, igt81bTextBox.Text, 0xEF05);
                backend.updateROMText(0x7, igt81cTextBox.Text, 0xEF0E);
                backend.updateROMText(0xa, igt82TextBox.Text, 0xEF40);
                backend.updateROMText(0x7, igt86TextBox.Text, 0xEFA5);
                backend.updateROMText(0xa, igt86bTextBox.Text, 0xEFAD);
                backend.updateROMText(0xa, igt86cTextBox.Text, 0xEFB8);
                backend.updateROMText(0xa, igt86dTextBox.Text, 0xEFC3);

                MessageBox.Show(@"Updated!", @"General Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
