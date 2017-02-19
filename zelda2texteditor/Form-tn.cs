using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Refactored 4/9/2016, added backend class, moved logic, update methods, now just refactor the other forms...
 */
namespace zelda2texteditor {
    public partial class Form_tn : Form {
        public Form_tn() {
            InitializeComponent();
        }

        string filename;

        public string fntootherform {
            get {
                return filename;
            } set {
                filename = value;
            }
        }

        private void setMaxLengthOfTextBoxes() {
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

        private void Form_tn_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();

            try {
                Backend backend = new Backend();

                // RAURU
                backend.getText(filename, loc1TextBox, 0x7, 0xE4DD);
                backend.getText(filename, loc1aTextBox, 0x2, 0xE4E7);
                backend.getText(filename, loc1bTextBox, 0x5, 0xE4EB);

                // RUTO
                backend.getText(filename, loc2TextBox, 0x4, 0xE624);
                backend.getText(filename, loc2aTextBox, 0x2, 0xE62A);
                backend.getText(filename, loc2bTextBox, 0x4, 0xE62D);

                // SARIA
                backend.getText(filename, loc3TextBox, 0x5, 0xE72D);
                backend.getText(filename, loc3aTextBox, 0x4, 0xE733);
                backend.getText(filename, loc3bTextBox, 0x2, 0xE73C);
                backend.getText(filename, loc3cTextBox, 0x5, 0xE741);

                // KINGS TOMB
                backend.getText(filename, loc4TextBox, 0x7, 0xEA30);
                backend.getText(filename, loc4aTextBox, 0xA, 0xEA38);

                // MIDO
                backend.getText(filename, loc5TextBox, 0x6, 0xE8D8);
                backend.getText(filename, loc5aTextBox, 0x4, 0xE8E0);
                backend.getText(filename, loc5bTextBox, 0x2, 0xE8E7);
                backend.getText(filename, loc5cTextBox, 0x4, 0xE8EB);

                // NABOORU
                backend.getText(filename, loc6TextBox, 0x7, 0xEB34);
                backend.getText(filename, loc6aTextBox, 0x2, 0xEB3E);
                backend.getText(filename, loc6bTextBox, 0x7, 0xEB41);

                // DARUNIA
                backend.getText(filename, loc7TextBox, 0x8, 0xECF6);
                backend.getText(filename, loc7aTextBox, 0x4, 0xED00);
                backend.getText(filename, loc7bTextBox, 0x2, 0xED05);
                backend.getText(filename, loc7cTextBox, 0x7, 0xED09);

                // KASUTO
                backend.getText(filename, loc8TextBox, 0x6, 0xEE2F);
                backend.getText(filename, loc8aTextBox, 0x4, 0xEE37);
                backend.getText(filename, loc8bTextBox, 0x2, 0xEE3E);
                backend.getText(filename, loc8cTextBox, 0x6, 0xEE41);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // the update text button
        private void button1_Click(object sender, EventArgs e) {
            Backend backend = new Backend();

            // RAURU
            backend.updateROMText(filename, 0x7, loc1TextBox, 0xE4DD);
            backend.updateROMText(filename, 0x2, loc1aTextBox, 0xE4E7);
            backend.updateROMText(filename, 0x5, loc1bTextBox, 0xE4EB);

            // RUTO
            backend.updateROMText(filename, 0x4, loc2TextBox, 0xE624);
            backend.updateROMText(filename, 0x2, loc2aTextBox, 0xE62A);
            backend.updateROMText(filename, 0x4, loc2bTextBox, 0xE62D);

            // SARIA
            backend.updateROMText(filename, 0x5, loc3TextBox, 0xE72D);
            backend.updateROMText(filename, 0x4, loc3aTextBox, 0xE733);
            backend.updateROMText(filename, 0x2, loc3bTextBox, 0xE73C);
            backend.updateROMText(filename, 0x5, loc3cTextBox, 0xE741);

            // KINGS TOMB
            backend.updateROMText(filename, 0x7, loc4TextBox, 0xEA30);
            backend.updateROMText(filename, 0xA, loc4aTextBox, 0xEA38);

            // MIDO
            backend.updateROMText(filename, 0x6, loc5TextBox, 0xE8D8);
            backend.updateROMText(filename, 0x4, loc5aTextBox, 0xE8E0);
            backend.updateROMText(filename, 0x2, loc5bTextBox, 0xE8E7);
            backend.updateROMText(filename, 0x4, loc5cTextBox, 0xE8EB);

            // NABOORU
            backend.updateROMText(filename, 0x7, loc6TextBox, 0xEB34);
            backend.updateROMText(filename, 0x2, loc6aTextBox, 0xEB3E);
            backend.updateROMText(filename, 0x7, loc6bTextBox, 0xEB41);

            // DARUNIA
            backend.updateROMText(filename, 0x8, loc7TextBox, 0xECF6);
            backend.updateROMText(filename, 0x4, loc7aTextBox, 0xED00);
            backend.updateROMText(filename, 0x2, loc7bTextBox, 0xED05);
            backend.updateROMText(filename, 0x7, loc7cTextBox, 0xED09);

            // KASUTO
            backend.updateROMText(filename, 0x6, loc8TextBox, 0xEE2F);
            backend.updateROMText(filename, 0x4, loc8aTextBox, 0xEE37);
            backend.updateROMText(filename, 0x2, loc8bTextBox, 0xEE3E);
            backend.updateROMText(filename, 0x6, loc8cTextBox, 0xEE41);

            MessageBox.Show("Updated!", "Locations Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
