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
    public partial class FormGeneral5 : Form
    {

        public string FullFilename { get; set; }

        public FormGeneral5(string filename)
        {
            InitializeComponent();
            FullFilename = filename;
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
        {
            igt25TextBox.MaxLength = 0x9;
            igt25bTextBox.MaxLength = 0xa;
            igt25cTextBox.MaxLength = 0x7;
            igt25dTextBox.MaxLength = 0x6;
            igt26TextBox.MaxLength = 0x7;
            igt26bTextBox.MaxLength = 0x9;
            igt26cTextBox.MaxLength = 0xa;
            igt26dTextBox.MaxLength = 0xa;
            igt30bTextBox.MaxLength = 0xa;
            igt30cTextBox.MaxLength = 0xa;
            igt31TextBox.MaxLength = 0x8;
            igt31bTextBox.MaxLength = 0xa;
            igt31cTextBox.MaxLength = 0x8;
            igt31dTextBox.MaxLength = 0x9;
            igt36dTextBox.MaxLength = 0xa;
            igt61dTextBox.MaxLength = 0xa;
            igt62dTextBox.MaxLength = 0x9;
            igt67dTextBox.MaxLength = 0x9;
            igt69dTextBox.MaxLength = 0x6;
            igt70dTextBox.MaxLength = 0x4;
            igt79cTextBox.MaxLength = 0x7;
            igt80TextBox.MaxLength = 0x3;
            igt80bTextBox.MaxLength = 0x7;
            igt80cTextBox.MaxLength = 0x8;
            igt81TextBox.MaxLength = 0x8;
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);
                
                igt25TextBox.Text = backend.getText(0x9, 0xE6E1);
                igt25bTextBox.Text = backend.getText(0xa, 0xE6EB);
                igt25cTextBox.Text = backend.getText(0x7, 0xE6F6);
                igt25dTextBox.Text = backend.getText(0x6, 0xE6FE);
                igt26TextBox.Text = backend.getText(0x7, 0xE705);
                igt26bTextBox.Text = backend.getText(0x9, 0xE70D);
                igt26cTextBox.Text = backend.getText(0xa, 0xE717);
                igt26dTextBox.Text = backend.getText(0xa, 0xE722);
                igt30bTextBox.Text = backend.getText(0xa, 0xE777);
                igt30cTextBox.Text = backend.getText(0xa, 0xE782);
                igt31TextBox.Text = backend.getText(0x8, 0xE798);
                igt31bTextBox.Text = backend.getText(0xa, 0xE7A1);
                igt31cTextBox.Text = backend.getText(0x8, 0xE7AC);
                igt31dTextBox.Text = backend.getText(0x9, 0xE7B5);
                igt36dTextBox.Text = backend.getText(0xa, 0xE8A7);
                igt61dTextBox.Text = backend.getText(0xa, 0xEBD5);
                igt62dTextBox.Text = backend.getText(0x9, 0xEBFB);
                igt67dTextBox.Text = backend.getText(0x9, 0xECD0);
                igt69dTextBox.Text = backend.getText(0x6, 0xED30);
                igt70dTextBox.Text = backend.getText(0x4, 0xED53);
                igt79cTextBox.Text = backend.getText(0x7, 0xEEC9);
                igt80TextBox.Text = backend.getText(0x3, 0xEEDC);
                igt80bTextBox.Text = backend.getText(0x7, 0xEEE0);
                igt80cTextBox.Text = backend.getText(0x8, 0xEEE8);
                igt81TextBox.Text = backend.getText(0x8, 0xEEFC);

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
                
                backend.updateROMText(0x9, igt25TextBox.Text, 0xE6E1);
                backend.updateROMText(0xa, igt25bTextBox.Text, 0xE6EB);
                backend.updateROMText(0x7, igt25cTextBox.Text, 0xE6F6);
                backend.updateROMText(0x6, igt25dTextBox.Text, 0xE6FE);
                backend.updateROMText(0x7, igt26TextBox.Text, 0xE705);
                backend.updateROMText(0x9, igt26bTextBox.Text, 0xE70D);
                backend.updateROMText(0xa, igt26cTextBox.Text, 0xE717);
                backend.updateROMText(0xa, igt26dTextBox.Text, 0xE722);
                backend.updateROMText(0xa, igt30bTextBox.Text, 0xE777);
                backend.updateROMText(0xa, igt30cTextBox.Text, 0xE782);
                backend.updateROMText(0x8, igt31TextBox.Text, 0xE798);
                backend.updateROMText(0xa, igt31bTextBox.Text, 0xE7A1);
                backend.updateROMText(0x8, igt31cTextBox.Text, 0xE7AC);
                backend.updateROMText(0x9, igt31dTextBox.Text, 0xE7B5);
                backend.updateROMText(0xa, igt36dTextBox.Text, 0xE8A7);
                backend.updateROMText(0xa, igt61dTextBox.Text, 0xEBD5);
                backend.updateROMText(0x9, igt62dTextBox.Text, 0xEBFB);
                backend.updateROMText(0x9, igt67dTextBox.Text, 0xECD0);
                backend.updateROMText(0x6, igt69dTextBox.Text, 0xED30);
                backend.updateROMText(0x4, igt70dTextBox.Text, 0xED53);
                backend.updateROMText(0x7, igt79cTextBox.Text, 0xEEC9);
                backend.updateROMText(0x3, igt80TextBox.Text, 0xEEDC);
                backend.updateROMText(0x7, igt80bTextBox.Text, 0xEEE0);
                backend.updateROMText(0x8, igt80cTextBox.Text, 0xEEE8);
                backend.updateROMText(0x8, igt81TextBox.Text, 0xEEFC);

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
