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
    public partial class FormGeneral3 : Form
    {

        public string FullFilename { get; set; }

        public FormGeneral3(string filename)
        {
            InitializeComponent();
            FullFilename = filename;
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
        {
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
            igt32TextBox.MaxLength = 0x9;
            igt32bTextBox.MaxLength = 0x9;
            igt32cTextBox.MaxLength = 0xa;
            igt35TextBox.MaxLength = 0x9;
            igt35bTextBox.MaxLength = 0xa;
            igt35cTextBox.MaxLength = 0xa;
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
            igt47TextBox.MaxLength = 0x7;
            igt48TextBox.MaxLength = 0xa;
            igt56TextBox.MaxLength = 0x9;
            igt60TextBox.MaxLength = 0x8;
            igt60bTextBox.MaxLength = 0x6;
            igt61TextBox.MaxLength = 0xa;
            igt69TextBox.MaxLength = 0xa;
            igt69bTextBox.MaxLength = 0x8;
            igt69cTextBox.MaxLength = 0xa;
            igt70TextBox.MaxLength = 0x8;
            igt70bTextBox.MaxLength = 0x7;
            igt70cTextBox.MaxLength = 0xa;
            igt71TextBox.MaxLength = 0xa;
            igt71bTextBox.MaxLength = 0x9;
            igt71cTextBox.MaxLength = 0x8;
            igt72TextBox.MaxLength = 0x9;
            igt72bTextBox.MaxLength = 0x8;
            igt72cTextBox.MaxLength = 0x9;
            igt81dTextBox.MaxLength = 0x8;
            igt87TextBox.MaxLength = 0x9;
            igt87cTextBox.MaxLength = 0x7;
            igt87dTextBox.MaxLength = 0xa;
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);
                
                igt14TextBox.Text = backend.getText(0xa, 0xE4F1);
                igt14bTextBox.Text = backend.getText(0x9, 0xE4FC);
                igt14cTextBox.Text = backend.getText(0x7, 0xE506);
                igt14dTextBox.Text = backend.getText(0x8, 0xE50E);
                igt15TextBox.Text = backend.getText(0x9, 0xE517);
                igt15bTextBox.Text = backend.getText(0x7, 0xE521);
                igt15cTextBox.Text = backend.getText(0x9, 0xE529);
                igt15dTextBox.Text = backend.getText(0x7, 0xE533);
                igt16TextBox.Text = backend.getText(0x9, 0xE53B);
                igt16bTextBox.Text = backend.getText(0xa, 0xE545);
                igt16cTextBox.Text = backend.getText(0x8, 0xE550);
                igt16dTextBox.Text = backend.getText(0x9, 0xE559);
                igt17TextBox.Text = backend.getText(0x8, 0xE58E);
                igt17bTextBox.Text = backend.getText(0x8, 0xE597);
                igt17cTextBox.Text = backend.getText(0x8, 0xE5A0);
                igt17dTextBox.Text = backend.getText(0x7, 0xE5A9);
                igt18TextBox.Text = backend.getText(0x9, 0xE5D8);
                igt18bTextBox.Text = backend.getText(0x5, 0xE5E2);
                igt18cTextBox.Text = backend.getText(0x9, 0xE5E8);
                igt18dTextBox.Text = backend.getText(0x7, 0xE5F2);
                igt19TextBox.Text = backend.getText(0xa, 0xE5FA);
                igt19bTextBox.Text = backend.getText(0x9, 0xE605);
                igt19cTextBox.Text = backend.getText(0x8, 0xE60F);
                igt19dTextBox.Text = backend.getText(0xb, 0xE618);
                igt32TextBox.Text = backend.getText(0x9, 0xE7BF);
                igt32bTextBox.Text = backend.getText(0x9, 0xE7C9);
                igt32cTextBox.Text = backend.getText(0xa, 0xE7D3);
                igt35TextBox.Text = backend.getText(0x9, 0xE85D);
                igt35bTextBox.Text = backend.getText(0xa, 0xE867);
                igt35cTextBox.Text = backend.getText(0xa, 0xE872);
                igt42TextBox.Text = backend.getText(0x8, 0xE9AE);
                igt42bTextBox.Text = backend.getText(0xa, 0xE9B7);
                igt42cTextBox.Text = backend.getText(0x8, 0xE9C2);
                igt42dTextBox.Text = backend.getText(0x8, 0xE9CB);
                igt43TextBox.Text = backend.getText(0xa, 0xE9D4);
                igt43bTextBox.Text = backend.getText(0xa, 0xE9DF);
                igt43cTextBox.Text = backend.getText(0xa, 0xE9EA);
                igt43dTextBox.Text = backend.getText(0xa, 0xE9F5);
                igt44TextBox.Text = backend.getText(0x6, 0xEA00);
                igt45TextBox.Text = backend.getText(0xa, 0xEA07);
                igt45bTextBox.Text = backend.getText(0x9, 0xEA12);
                igt45cTextBox.Text = backend.getText(0x8, 0xEA1C);
                igt45dTextBox.Text = backend.getText(0xa, 0xEA25);
                igt47TextBox.Text = backend.getText(0x7, 0xEA56);
                igt48TextBox.Text = backend.getText(0xa, 0xEA5F);
                igt56TextBox.Text = backend.getText(0x9, 0xEB0C);
                igt60TextBox.Text = backend.getText(0x8, 0xEB98);
                igt60bTextBox.Text = backend.getText(0x6, 0xEBA1);
                igt61TextBox.Text = backend.getText(0xa, 0xEBBA);
                igt69TextBox.Text = backend.getText(0xa, 0xED11);
                igt69bTextBox.Text = backend.getText(0x8, 0xED1C);
                igt69cTextBox.Text = backend.getText(0xa, 0xED25);
                igt70TextBox.Text = backend.getText(0x8, 0xED37);
                igt70bTextBox.Text = backend.getText(0x7, 0xED40);
                igt70cTextBox.Text = backend.getText(0xa, 0xED48);
                igt71TextBox.Text = backend.getText(0xa, 0xED59);
                igt71bTextBox.Text = backend.getText(0x9, 0xED64);
                igt71cTextBox.Text = backend.getText(0x8, 0xED6E);
                igt72TextBox.Text = backend.getText(0x9, 0xED82);
                igt72bTextBox.Text = backend.getText(0x8, 0xED8C);
                igt72cTextBox.Text = backend.getText(0x9, 0xED95);
                igt81dTextBox.Text = backend.getText(0x8, 0xEF16);
                igt87TextBox.Text = backend.getText(0x9, 0xE5B1);
                igt87cTextBox.Text = backend.getText(0x7, 0xE5C5);
                igt87dTextBox.Text = backend.getText(0xa, 0xE5CD);

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
                
                backend.updateROMText(0xa, igt14TextBox.Text, 0xE4F1);
                backend.updateROMText(0x9, igt14bTextBox.Text, 0xE5FC);
                backend.updateROMText(0x7, igt14cTextBox.Text, 0xE506);
                backend.updateROMText(0x8, igt14dTextBox.Text, 0xE50E);
                backend.updateROMText(0x9, igt15TextBox.Text, 0xE517);
                backend.updateROMText(0x7, igt15bTextBox.Text, 0xE521);
                backend.updateROMText(0x9, igt15cTextBox.Text, 0xE529);
                backend.updateROMText(0x7, igt15dTextBox.Text, 0xE533);
                backend.updateROMText(0x9, igt16TextBox.Text, 0xE53B);
                backend.updateROMText(0xa, igt16bTextBox.Text, 0xE545);
                backend.updateROMText(0x8, igt16cTextBox.Text, 0xE550);
                backend.updateROMText(0x9, igt16dTextBox.Text, 0xE559);
                backend.updateROMText(0x8, igt17TextBox.Text, 0xE58E);
                backend.updateROMText(0x8, igt17bTextBox.Text, 0xE597);
                backend.updateROMText(0x8, igt17cTextBox.Text, 0xE5A0);
                backend.updateROMText(0x7, igt17dTextBox.Text, 0xE5A9);
                backend.updateROMText(0x9, igt18TextBox.Text, 0xE5D8);
                backend.updateROMText(0x5, igt18bTextBox.Text, 0xE5E2);
                backend.updateROMText(0x9, igt18cTextBox.Text, 0xE5E8);
                backend.updateROMText(0x7, igt18dTextBox.Text, 0xE5F2);
                backend.updateROMText(0xa, igt19TextBox.Text, 0xE5FA);
                backend.updateROMText(0x9, igt19bTextBox.Text, 0xE605);
                backend.updateROMText(0x8, igt19cTextBox.Text, 0xE60F);
                backend.updateROMText(0xb, igt19dTextBox.Text, 0xE618);
                backend.updateROMText(0x9, igt32TextBox.Text, 0xE7BF);
                backend.updateROMText(0x9, igt32bTextBox.Text, 0xE7C9);
                backend.updateROMText(0xa, igt32cTextBox.Text, 0xE7D3);
                backend.updateROMText(0x9, igt35TextBox.Text, 0xE85D);
                backend.updateROMText(0xa, igt35bTextBox.Text, 0xE867);
                backend.updateROMText(0xa, igt35cTextBox.Text, 0xE872);
                backend.updateROMText(0x8, igt42TextBox.Text, 0xE9AE);
                backend.updateROMText(0xa, igt42bTextBox.Text, 0xE9B7);
                backend.updateROMText(0x8, igt42cTextBox.Text, 0xE9C2);
                backend.updateROMText(0x8, igt42dTextBox.Text, 0xE9CB);
                backend.updateROMText(0xa, igt43TextBox.Text, 0xE9D4);
                backend.updateROMText(0xa, igt43bTextBox.Text, 0xE9DF);
                backend.updateROMText(0xa, igt43cTextBox.Text, 0xE9EA);
                backend.updateROMText(0xa, igt43dTextBox.Text, 0xE9F5);
                backend.updateROMText(0x6, igt44TextBox.Text, 0xEA00);
                backend.updateROMText(0xa, igt45TextBox.Text, 0xEA07);
                backend.updateROMText(0x9, igt45bTextBox.Text, 0xEA12);
                backend.updateROMText(0x8, igt45cTextBox.Text, 0xEA1C);
                backend.updateROMText(0xa, igt45dTextBox.Text, 0xEA25);
                backend.updateROMText(0x7, igt47TextBox.Text, 0xEA56);
                backend.updateROMText(0xa, igt48TextBox.Text, 0xEA5F);
                backend.updateROMText(0x9, igt56TextBox.Text, 0xEB0C);
                backend.updateROMText(0x8, igt60TextBox.Text, 0xEB98);
                backend.updateROMText(0x6, igt60bTextBox.Text, 0xEBA1);
                backend.updateROMText(0xa, igt61TextBox.Text, 0xEBBA);
                backend.updateROMText(0xa, igt69TextBox.Text, 0xED11);
                backend.updateROMText(0x8, igt69bTextBox.Text, 0xED1C);
                backend.updateROMText(0xa, igt69cTextBox.Text, 0xED25);
                backend.updateROMText(0x8, igt70TextBox.Text, 0xED37);
                backend.updateROMText(0x7, igt70bTextBox.Text, 0xED40);
                backend.updateROMText(0xa, igt70cTextBox.Text, 0xED48);
                backend.updateROMText(0xa, igt71TextBox.Text, 0xED59);
                backend.updateROMText(0x9, igt71bTextBox.Text, 0xED64);
                backend.updateROMText(0x8, igt71cTextBox.Text, 0xED6E);
                backend.updateROMText(0x9, igt72TextBox.Text, 0xED82);
                backend.updateROMText(0x8, igt72bTextBox.Text, 0xED8C);
                backend.updateROMText(0x9, igt72cTextBox.Text, 0xED95);
                backend.updateROMText(0x8, igt81dTextBox.Text, 0xEF16);
                backend.updateROMText(0x9, igt87TextBox.Text, 0xE5B1);
                backend.updateROMText(0x7, igt87cTextBox.Text, 0xE5C5);
                backend.updateROMText(0xa, igt87dTextBox.Text, 0xE5CD);

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
