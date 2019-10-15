/**
 * @file           FormGeneral.cs
 * @brief          Creates the form for changing general text.
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
using System.Windows.Forms;

namespace zelda2texteditor
{
    public partial class FormGeneral : Form
    {

        public string FullFilename { get; set; }

        public FormGeneral(string filename)
        {
            InitializeComponent();
            FullFilename = filename;
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
        {
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
            igt9TextBox.MaxLength = 0x5;
            igt9bTextBox.MaxLength = 0x5;
            igt9cTextBox.MaxLength = 0x7;
            igt21TextBox.MaxLength = 0x6;
            igt21bTextBox.MaxLength = 0xa;
            igt23TextBox.MaxLength = 0x4;
            igt23bTextBox.MaxLength = 0x6;
            igt27TextBox.MaxLength = 0x6;
            igt27bTextBox.MaxLength = 0xa;
            igt27cTextBox.MaxLength = 0x9;
            igt46TextBox.MaxLength = 0x7;
            igt46bTextBox.MaxLength = 0xa;
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
            igt57TextBox.MaxLength = 0x7;
            igt57bTextBox.MaxLength = 0x8;
            igt57cTextBox.MaxLength = 0x5;
            igt59TextBox.MaxLength = 0x4;
            igt59bTextBox.MaxLength = 0x8;
            igt63TextBox.MaxLength = 0x9;
            igt63bTextBox.MaxLength = 0x8;
            igt63cTextBox.MaxLength = 0xa;
            igt65TextBox.MaxLength = 0x9;
            igt65bTextBox.MaxLength = 0x8;
            igt65cTextBox.MaxLength = 0xa;
            igt68cTextBox.MaxLength = 0xa;
            igt73TextBox.MaxLength = 0x8;
            igt73bTextBox.MaxLength = 0xa;
            igt73cTextBox.MaxLength = 0xb;
            igt74TextBox.MaxLength = 0x6;
            igt74bTextBox.MaxLength = 0x7;
            igt74cTextBox.MaxLength = 0x7;
            igt83TextBox.MaxLength = 0x5;
            igt83bTextBox.MaxLength = 0x9;
            igt84TextBox.MaxLength = 0x8;
            igt84bTextBox.MaxLength = 0x8;
            igt85TextBox.MaxLength = 0x9;
            igt85bTextBox.MaxLength = 0x9;
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                igt1TextBox.Text = backend.getText(0xa, 0xE390);
                igt1bTextBox.Text = backend.getText(0x7, 0xE39B);
                igt1cTextBox.Text = backend.getText(0x4, 0xE3A3);
                igt2TextBox.Text = backend.getText(0x4, 0xE3A8);
                igt2bTextBox.Text = backend.getText(0x7, 0xE3AD);
                igt3TextBox.Text = backend.getText(0x5, 0xE3B5);
                igt3bTextBox.Text = backend.getText(0x7, 0xE3BB);
                igt3cTextBox.Text = backend.getText(0xa, 0xE3C3);
                igt4TextBox.Text = backend.getText(0x8, 0xE3CE);
                igt4bTextBox.Text = backend.getText(0xa, 0xE3D7);
                igt5TextBox.Text = backend.getText(0xa, 0xE3E2);
                igt5bTextBox.Text = backend.getText(0xa, 0xE3ED);
                igt6TextBox.Text = backend.getText(0x9, 0xE3F8);
                igt6bTextBox.Text = backend.getText(0x8, 0xE402);
                igt9TextBox.Text = backend.getText(0x5, 0xE43C);
                igt9bTextBox.Text = backend.getText(0x5, 0xE442);
                igt9cTextBox.Text = backend.getText(0x7, 0xE448);
                igt21TextBox.Text = backend.getText(0x6, 0xE654);
                igt21bTextBox.Text = backend.getText(0xa, 0xE65B);
                igt23TextBox.Text = backend.getText(0x4, 0xE6AC);
                igt23bTextBox.Text = backend.getText(0x6, 0xE6B1);
                igt27TextBox.Text = backend.getText(0x6, 0xE747);
                igt27bTextBox.Text = backend.getText(0xa, 0xE74E);
                igt27cTextBox.Text = backend.getText(0x9, 0xE759);
                igt46TextBox.Text = backend.getText(0x7, 0xEA43);
                igt46bTextBox.Text = backend.getText(0xa, 0xEA4B);
                igt49TextBox.Text = backend.getText(0x9, 0xEA6A);
                igt49bTextBox.Text = backend.getText(0x4, 0xEA74);
                igt50TextBox.Text = backend.getText(0x4, 0xEA79);
                igt50bTextBox.Text = backend.getText(0xa, 0xEA7E);
                igt50cTextBox.Text = backend.getText(0x9, 0xEA89);
                igt51TextBox.Text = backend.getText(0x6, 0xEA93);
                igt51bTextBox.Text = backend.getText(0x8, 0xEA9A);
                igt52TextBox.Text = backend.getText(0x6, 0xEAA3);
                igt52bTextBox.Text = backend.getText(0x8, 0xEAAA);
                igt52cTextBox.Text = backend.getText(0x4, 0xEAB3);
                igt53TextBox.Text = backend.getText(0x8, 0xEAB9);
                igt53bTextBox.Text = backend.getText(0x4, 0xEAC2);
                igt53cTextBox.Text = backend.getText(0x6, 0xEAC7);
                igt54TextBox.Text = backend.getText(0x9, 0xEACF);
                igt54bTextBox.Text = backend.getText(0x9, 0xEAD9);
                igt57TextBox.Text = backend.getText(0x7, 0xEB49);
                igt57bTextBox.Text = backend.getText(0x8, 0xEB51);
                igt57cTextBox.Text = backend.getText(0x5, 0xEB5A);
                igt59TextBox.Text = backend.getText(0x4, 0xEB8A);
                igt59bTextBox.Text = backend.getText(0x8, 0xEB8F);
                igt63TextBox.Text = backend.getText(0x9, 0xEC05);
                igt63bTextBox.Text = backend.getText(0x8, 0xEC0F);
                igt63cTextBox.Text = backend.getText(0xa, 0xEC18);
                igt65TextBox.Text = backend.getText(0x9, 0xEC70);
                igt65bTextBox.Text = backend.getText(0x8, 0xEC7A);
                igt65cTextBox.Text = backend.getText(0xa, 0xEC83);
                igt68cTextBox.Text = backend.getText(0xa, 0xECEB);
                igt73TextBox.Text = backend.getText(0x8, 0xEDCF);
                igt73bTextBox.Text = backend.getText(0xa, 0xEDD8);
                igt73cTextBox.Text = backend.getText(0xb, 0xEDE3);
                igt74TextBox.Text = backend.getText(0x6, 0xEDEF);
                igt74bTextBox.Text = backend.getText(0x7, 0xEDF6);
                igt74cTextBox.Text = backend.getText(0x7, 0xEDFE);
                igt83TextBox.Text = backend.getText(0x5, 0xEF4B);
                igt83bTextBox.Text = backend.getText(0x9, 0xEF51);
                igt84TextBox.Text = backend.getText(0x8, 0xEF5B);
                igt84bTextBox.Text = backend.getText(0x8, 0xEF64);
                igt85TextBox.Text = backend.getText(0x9, 0xEF6D);
                igt85bTextBox.Text = backend.getText(0x9, 0xEF77);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormGeneral_Load(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                backend.updateROMText(0xa, igt1TextBox.Text, 0xE390);
                backend.updateROMText(0x7, igt1bTextBox.Text, 0xE39B);
                backend.updateROMText(0x4, igt1cTextBox.Text, 0xE3A3);
                backend.updateROMText(0x4, igt2TextBox.Text, 0xE3A8);
                backend.updateROMText(0x7, igt2bTextBox.Text, 0xE3AD);
                backend.updateROMText(0x5, igt3TextBox.Text, 0xE3B5);
                backend.updateROMText(0x7, igt3bTextBox.Text, 0xE3BB);
                backend.updateROMText(0xa, igt3cTextBox.Text, 0xE3C3);
                backend.updateROMText(0x8, igt4TextBox.Text, 0xE3CE);
                backend.updateROMText(0xa, igt4bTextBox.Text, 0xE3D7);
                backend.updateROMText(0xa, igt5TextBox.Text, 0xE3E2);
                backend.updateROMText(0xa, igt5bTextBox.Text, 0xE3ED);
                backend.updateROMText(0x9, igt6TextBox.Text, 0xE3F8);
                backend.updateROMText(0x8, igt6bTextBox.Text, 0xE402);
                backend.updateROMText(0x5, igt9TextBox.Text, 0xE43C);
                backend.updateROMText(0x5, igt9bTextBox.Text, 0xE442);
                backend.updateROMText(0x7, igt9cTextBox.Text, 0xE448);
                backend.updateROMText(0x6, igt21TextBox.Text, 0xE654);
                backend.updateROMText(0xa, igt21bTextBox.Text, 0xE65B);
                backend.updateROMText(0x4, igt23TextBox.Text, 0xE6AC);
                backend.updateROMText(0x6, igt23bTextBox.Text, 0xE6B1);
                backend.updateROMText(0x6, igt27TextBox.Text, 0xE747);
                backend.updateROMText(0xa, igt27bTextBox.Text, 0xE74E);
                backend.updateROMText(0x9, igt27cTextBox.Text, 0xE759);
                backend.updateROMText(0x7, igt46TextBox.Text, 0xEA43);
                backend.updateROMText(0xa, igt46bTextBox.Text, 0xEA4B);
                backend.updateROMText(0x9, igt49TextBox.Text, 0xEA6A);
                backend.updateROMText(0x4, igt49bTextBox.Text, 0xEA74);
                backend.updateROMText(0x4, igt50TextBox.Text, 0xEA79);
                backend.updateROMText(0xa, igt50bTextBox.Text, 0xEA7E);
                backend.updateROMText(0x9, igt50cTextBox.Text, 0xEA89);
                backend.updateROMText(0x6, igt51TextBox.Text, 0xEA93);
                backend.updateROMText(0x8, igt51bTextBox.Text, 0xEA9A);
                backend.updateROMText(0x6, igt52TextBox.Text, 0xEAA3);
                backend.updateROMText(0x8, igt52bTextBox.Text, 0xEAAA);
                backend.updateROMText(0x4, igt52cTextBox.Text, 0xEAB3);
                backend.updateROMText(0x8, igt53TextBox.Text, 0xEAB9);
                backend.updateROMText(0x4, igt53bTextBox.Text, 0xEAC2);
                backend.updateROMText(0x6, igt53cTextBox.Text, 0xEAC7);
                backend.updateROMText(0x9, igt54TextBox.Text, 0xEACF);
                backend.updateROMText(0x9, igt54bTextBox.Text, 0xEAD9);
                backend.updateROMText(0x7, igt57TextBox.Text, 0xEB49);
                backend.updateROMText(0x8, igt57bTextBox.Text, 0xEB51);
                backend.updateROMText(0x5, igt57cTextBox.Text, 0xEB5A);
                backend.updateROMText(0x4, igt59TextBox.Text, 0xEB8A);
                backend.updateROMText(0x8, igt59bTextBox.Text, 0xEB8F);
                backend.updateROMText(0x9, igt63TextBox.Text, 0xEC05);
                backend.updateROMText(0x8, igt63bTextBox.Text, 0xEC0F);
                backend.updateROMText(0xa, igt63cTextBox.Text, 0xEC18);
                backend.updateROMText(0x9, igt65TextBox.Text, 0xEC70);
                backend.updateROMText(0x8, igt65bTextBox.Text, 0xEC7A);
                backend.updateROMText(0xa, igt65cTextBox.Text, 0xEC83);
                backend.updateROMText(0xa, igt68cTextBox.Text, 0xECEB);
                backend.updateROMText(0x8, igt73TextBox.Text, 0xEDCF);
                backend.updateROMText(0xa, igt73bTextBox.Text, 0xEDD8);
                backend.updateROMText(0xb, igt73cTextBox.Text, 0xEDE3);
                backend.updateROMText(0x6, igt74TextBox.Text, 0xEDEF);
                backend.updateROMText(0x7, igt74bTextBox.Text, 0xEDF6);
                backend.updateROMText(0x7, igt74cTextBox.Text, 0xEDFE);
                backend.updateROMText(0x5, igt83TextBox.Text, 0xEF4B);
                backend.updateROMText(0x9, igt83bTextBox.Text, 0xEF51);
                backend.updateROMText(0x8, igt84TextBox.Text, 0xEF5B);
                backend.updateROMText(0x8, igt84bTextBox.Text, 0xEF64);
                backend.updateROMText(0x9, igt85TextBox.Text, 0xEF6D);
                backend.updateROMText(0x9, igt85bTextBox.Text, 0xEF77);

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
