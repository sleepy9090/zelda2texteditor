/**
 * @file           FormSpells.cs
 * @brief          Creates the form for changing spell text.
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
    public partial class FormSpells : Form
    {

        public string FullFilename { get; set; }

        public FormSpells()
        {
            InitializeComponent();
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
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
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                /** - Spells */
                esp1TextBox.Text = backend.getText(0xb, 0x1C3A);
                esp2TextBox.Text = backend.getText(0xb, 0x1C48);
                esp3TextBox.Text = backend.getText(0xb, 0x1C56);
                esp4TextBox.Text = backend.getText(0xb, 0x1C64);
                esp5TextBox.Text = backend.getText(0xb, 0x1C72);
                esp6TextBox.Text = backend.getText(0x9, 0x1C80);
                esp7TextBox.Text = backend.getText(0xb, 0x1C8E);
                esp8TextBox.Text = backend.getText(0xb, 0x1C9C);

                /** - Wizards */
                ws1TextBox.Text = backend.getText(0x9, 0xE563);
                ws1bTextBox.Text = backend.getText(0xa, 0xE56D);
                ws1cTextBox.Text = backend.getText(0xa, 0xE578);
                ws1dTextBox.Text = backend.getText(0xa, 0xE583);

                ws2TextBox.Text = backend.getText(0x9, 0xE68A);
                ws2bTextBox.Text = backend.getText(0x7, 0xE694);
                ws2cTextBox.Text = backend.getText(0x9, 0xE69C);
                ws2dTextBox.Text = backend.getText(0x5, 0xE6A6);

                ws3TextBox.Text = backend.getText(0x8, 0xE7E9);
                ws3bTextBox.Text = backend.getText(0x8, 0xE7F2);
                ws3cTextBox.Text = backend.getText(0x7, 0xE7FB);
                ws3dTextBox.Text = backend.getText(0xa, 0xE803);

                ws4TextBox.Text = backend.getText(0xa, 0xE989);
                ws4bTextBox.Text = backend.getText(0x9, 0xE994);
                ws4cTextBox.Text = backend.getText(0x8, 0xE99E);
                ws4dTextBox.Text = backend.getText(0x6, 0xE9A7);

                ws5TextBox.Text = backend.getText(0xa, 0xEC23);
                ws5bTextBox.Text = backend.getText(0x9, 0xEC2E);
                ws5cTextBox.Text = backend.getText(0xa, 0xEC38);
                ws5dTextBox.Text = backend.getText(0xa, 0xEC43);

                ws6TextBox.Text = backend.getText(0xa, 0xEDAA);
                ws6bTextBox.Text = backend.getText(0x4, 0xEDB5);
                ws6cTextBox.Text = backend.getText(0xa, 0xEDBA);
                ws6dTextBox.Text = backend.getText(0x9, 0xEDC5);

                ws7TextBox.Text = backend.getText(0x8, 0xEF1F);
                ws7bTextBox.Text = backend.getText(0x9, 0xEF28);
                ws7cTextBox.Text = backend.getText(0x5, 0xEF32);

                ws8TextBox.Text = backend.getText(0xa, 0xEF81);
                ws8bTextBox.Text = backend.getText(0x8, 0xEF8C);
                ws8cTextBox.Text = backend.getText(0x8, 0xEF95);
                ws8dTextBox.Text = backend.getText(0x6, 0xEF9E);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSpells_Load(object sender, EventArgs e)
        {
            // Do nothing
        }
        

        private void updateSpellButton_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                // Spells
                backend.updateROMText(0xb, esp1TextBox.Text, 0x1C3A);
                backend.updateROMText(0xb, esp2TextBox.Text, 0x1C48);
                backend.updateROMText(0xb, esp3TextBox.Text, 0x1C56);
                backend.updateROMText(0xb, esp4TextBox.Text, 0x1C64);
                backend.updateROMText(0xb, esp5TextBox.Text, 0x1C72);
                backend.updateROMText(0x9, esp6TextBox.Text, 0x1C80);
                backend.updateROMText(0xb, esp7TextBox.Text, 0x1C8E);
                backend.updateROMText(0xb, esp8TextBox.Text, 0x1C9C);

                // Wizards
                backend.updateROMText(0x9, ws1TextBox.Text, 0xE563);
                backend.updateROMText(0xa, ws1bTextBox.Text, 0xE56D);
                backend.updateROMText(0xa, ws1cTextBox.Text, 0xE578);
                backend.updateROMText(0xa, ws1dTextBox.Text, 0xE583);

                backend.updateROMText(0x9, ws2TextBox.Text, 0xE68A);
                backend.updateROMText(0x7, ws2bTextBox.Text, 0xE694);
                backend.updateROMText(0x9, ws2cTextBox.Text, 0xE69C);
                backend.updateROMText(0x5, ws2dTextBox.Text, 0xE6A6);

                backend.updateROMText(0x8, ws3TextBox.Text, 0xE7E9);
                backend.updateROMText(0x8, ws3bTextBox.Text, 0xE7F2);
                backend.updateROMText(0x7, ws3cTextBox.Text, 0xE7FB);
                backend.updateROMText(0xa, ws3dTextBox.Text, 0xE803);

                backend.updateROMText(0xa, ws4TextBox.Text, 0xE989);
                backend.updateROMText(0xa, ws4bTextBox.Text, 0xE994);
                backend.updateROMText(0x8, ws4cTextBox.Text, 0xE99E);
                backend.updateROMText(0x6, ws4dTextBox.Text, 0xE9A7);

                backend.updateROMText(0xa, ws5TextBox.Text, 0xEC23);
                backend.updateROMText(0x9, ws5bTextBox.Text, 0xEC2E);
                backend.updateROMText(0xa, ws5cTextBox.Text, 0xEC38);
                backend.updateROMText(0xa, ws5dTextBox.Text, 0xEC43);

                backend.updateROMText(0xa, ws6TextBox.Text, 0xEDAA);
                backend.updateROMText(0x4, ws6bTextBox.Text, 0xEDB5);
                backend.updateROMText(0xa, ws6cTextBox.Text, 0xEDBA);
                backend.updateROMText(0x9, ws6dTextBox.Text, 0xEDC5);

                backend.updateROMText(0x8, ws7TextBox.Text, 0xEF1F);
                backend.updateROMText(0x9, ws7bTextBox.Text, 0xEF28);
                backend.updateROMText(0x5, ws7cTextBox.Text, 0xEF32);

                backend.updateROMText(0xa, ws8TextBox.Text, 0xEF81);
                backend.updateROMText(0x8, ws8bTextBox.Text, 0xEF8C);
                backend.updateROMText(0x8, ws8cTextBox.Text, 0xEF95);
                backend.updateROMText(0x6, ws8dTextBox.Text, 0xEF9E);

                MessageBox.Show(@"Updated!", @"Spell Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Close();
        }
    }
}
