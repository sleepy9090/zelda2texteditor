/**
 * @file           FormLocations.cs
 * @brief          Creates the form for changing text for locations.
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

namespace zelda2texteditor {
    public partial class FormLocations : Form {

        public FormLocations() {
            InitializeComponent();
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        public string FullFilename { get; set; }

        private void SetMaxLengthOfTextBoxes() {

            // RAURU
            loc1TextBox.MaxLength = 0x7;
            loc1aTextBox.MaxLength = 0x2;
            loc1bTextBox.MaxLength = 0x5;

            // RUTO
            loc2TextBox.MaxLength = 0x4;
            loc2aTextBox.MaxLength = 0x2;
            loc2bTextBox.MaxLength = 0x4;

            // SARIA
            loc3TextBox.MaxLength = 0x5;
            loc3aTextBox.MaxLength = 0x4;
            loc3bTextBox.MaxLength = 0x2;
            loc3cTextBox.MaxLength = 0x5;

            // KINGS TOMB
            loc4TextBox.MaxLength = 0x7;
            loc4aTextBox.MaxLength = 0xA;

            // MIDO
            loc5TextBox.MaxLength = 0x6;
            loc5aTextBox.MaxLength = 0x4;
            loc5bTextBox.MaxLength = 0x2;
            loc5cTextBox.MaxLength = 0x4;

            // NABOORU
            loc6TextBox.MaxLength = 0x7;
            loc6aTextBox.MaxLength = 0x2;
            loc6bTextBox.MaxLength = 0x7;

            // DARUNIA
            loc7TextBox.MaxLength = 0x8;
            loc7aTextBox.MaxLength = 0x4;
            loc7bTextBox.MaxLength = 0x2;
            loc7cTextBox.MaxLength = 0x7;

            // KASUTO
            loc8TextBox.MaxLength = 0x6;
            loc8aTextBox.MaxLength = 0x4;
            loc8bTextBox.MaxLength = 0x2;
            loc8cTextBox.MaxLength = 0x6;
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                // RAURU
                loc1TextBox.Text = backend.getText(0x7, 0xE4DD);
                loc1aTextBox.Text = backend.getText(0x2, 0xE4E7);
                loc1bTextBox.Text = backend.getText(0x5, 0xE4EB);

                // RUTO
                loc2TextBox.Text = backend.getText(0x4, 0xE624);
                loc2aTextBox.Text = backend.getText(0x2, 0xE62A);
                loc2bTextBox.Text = backend.getText(0x4, 0xE62D);

                // SARIA
                loc3TextBox.Text = backend.getText(0x5, 0xE72D);
                loc3aTextBox.Text = backend.getText(0x4, 0xE733);
                loc3bTextBox.Text = backend.getText(0x2, 0xE73C);
                loc3cTextBox.Text = backend.getText(0x5, 0xE741);

                // KINGS TOMB
                loc4TextBox.Text = backend.getText(0x7, 0xEA30);
                loc4aTextBox.Text = backend.getText(0xA, 0xEA38);

                // MIDO
                loc5TextBox.Text = backend.getText(0x6, 0xE8D8);
                loc5aTextBox.Text = backend.getText(0x4, 0xE8E0);
                loc5bTextBox.Text = backend.getText(0x2, 0xE8E7);
                loc5cTextBox.Text = backend.getText(0x4, 0xE8EB);

                // NABOORU
                loc6TextBox.Text = backend.getText(0x7, 0xEB34);
                loc6aTextBox.Text = backend.getText(0x2, 0xEB3E);
                loc6bTextBox.Text = backend.getText(0x7, 0xEB41);

                // DARUNIA
                loc7TextBox.Text = backend.getText(0x8, 0xECF6);
                loc7aTextBox.Text = backend.getText(0x4, 0xED00);
                loc7bTextBox.Text = backend.getText(0x2, 0xED05);
                loc7cTextBox.Text = backend.getText(0x7, 0xED09);

                // KASUTO
                loc8TextBox.Text = backend.getText(0x6, 0xEE2F);
                loc8aTextBox.Text = backend.getText(0x4, 0xEE37);
                loc8bTextBox.Text = backend.getText(0x2, 0xEE3E);
                loc8cTextBox.Text = backend.getText(0x6, 0xEE41);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLocations_Load(object sender, EventArgs e)
        {
            // Do nothing
        }

        // the update text button
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(FullFilename);

                // RAURU
                backend.updateROMText(0x7, loc1TextBox.Text, 0xE4DD);
                backend.updateROMText(0x2, loc1aTextBox.Text, 0xE4E7);
                backend.updateROMText(0x5, loc1bTextBox.Text, 0xE4EB);

                // RUTO
                backend.updateROMText(0x4, loc2TextBox.Text, 0xE624);
                backend.updateROMText(0x2, loc2aTextBox.Text, 0xE62A);
                backend.updateROMText(0x4, loc2bTextBox.Text, 0xE62D);

                // SARIA
                backend.updateROMText(0x5, loc3TextBox.Text, 0xE72D);
                backend.updateROMText(0x4, loc3aTextBox.Text, 0xE733);
                backend.updateROMText(0x2, loc3bTextBox.Text, 0xE73C);
                backend.updateROMText(0x5, loc3cTextBox.Text, 0xE741);

                // KINGS TOMB
                backend.updateROMText(0x7, loc4TextBox.Text, 0xEA30);
                backend.updateROMText(0xA, loc4aTextBox.Text, 0xEA38);

                // MIDO
                backend.updateROMText(0x6, loc5TextBox.Text, 0xE8D8);
                backend.updateROMText(0x4, loc5aTextBox.Text, 0xE8E0);
                backend.updateROMText(0x2, loc5bTextBox.Text, 0xE8E7);
                backend.updateROMText(0x4, loc5cTextBox.Text, 0xE8EB);

                // NABOORU
                backend.updateROMText(0x7, loc6TextBox.Text, 0xEB34);
                backend.updateROMText(0x2, loc6aTextBox.Text, 0xEB3E);
                backend.updateROMText(0x7, loc6bTextBox.Text, 0xEB41);

                // DARUNIA
                backend.updateROMText(0x8, loc7TextBox.Text, 0xECF6);
                backend.updateROMText(0x4, loc7aTextBox.Text, 0xED00);
                backend.updateROMText(0x2, loc7bTextBox.Text, 0xED05);
                backend.updateROMText(0x7, loc7cTextBox.Text, 0xED09);

                // KASUTO
                backend.updateROMText(0x6, loc8TextBox.Text, 0xEE2F);
                backend.updateROMText(0x4, loc8aTextBox.Text, 0xEE37);
                backend.updateROMText(0x2, loc8bTextBox.Text, 0xEE3E);
                backend.updateROMText(0x6, loc8cTextBox.Text, 0xEE41);

                MessageBox.Show(@"Updated!", @"Locations Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Close();
        }
    }
}
