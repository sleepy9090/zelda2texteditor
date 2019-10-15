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
    public partial class FormGeneral4 : Form
    {

        public string FullFilename { get; set; }

        public FormGeneral4(string filename)
        {
            InitializeComponent();
            FullFilename = filename;
            SetMaxLengthOfTextBoxes();
            LoadRomData();
        }

        private void SetMaxLengthOfTextBoxes()
        {
            igt7TextBox.MaxLength = 0x9;
            igt7bTextBox.MaxLength = 0x8;
            igt7cTextBox.MaxLength = 0xa;
            igt7dTextBox.MaxLength = 0xb;
            igt8TextBox.MaxLength = 0x5;
            igt20TextBox.MaxLength = 0x9;
            igt20bTextBox.MaxLength = 0x6;
            igt20cTextBox.MaxLength = 0x9;
            igt20dTextBox.MaxLength = 0x6;
            igt22TextBox.MaxLength = 0x7;
            igt22bTextBox.MaxLength = 0x8;
            igt22cTextBox.MaxLength = 0x6;
            igt22dTextBox.MaxLength = 0xa;
            igt24TextBox.MaxLength = 0x8;
            igt24bTextBox.MaxLength = 0xa;
            igt24cTextBox.MaxLength = 0xa;
            igt24dTextBox.MaxLength = 0x9;
            igt29TextBox.MaxLength = 0x8;
            igt30dTextBox.MaxLength = 0xa;
            igt33TextBox.MaxLength = 0x9;
            igt33bTextBox.MaxLength = 0x8;
            igt33cTextBox.MaxLength = 0xa;
            igt33dTextBox.MaxLength = 0x5;
            igt34TextBox.MaxLength = 0x8;
            igt34bTextBox.MaxLength = 0xa;
            igt34cTextBox.MaxLength = 0xa;
            igt34dTextBox.MaxLength = 0xa;
            igt35dTextBox.MaxLength = 0xa;
            igt36TextBox.MaxLength = 0xa;
            igt36bTextBox.MaxLength = 0x9;
            igt36cTextBox.MaxLength = 0x9;
            igt56bTextBox.MaxLength = 0x7;
            igt56dTextBox.MaxLength = 0xa;
            igt58TextBox.MaxLength = 0x9;
            igt58bTextBox.MaxLength = 0xa;
            igt58cTextBox.MaxLength = 0xa;
            igt58dTextBox.MaxLength = 0x8;
            igt61bTextBox.MaxLength = 0x7;
            igt62TextBox.MaxLength = 0x7;
            igt62bTextBox.MaxLength = 0xa;
            igt62cTextBox.MaxLength = 0x7;
            igt66dTextBox.MaxLength = 0xa;
            igt71dTextBox.MaxLength = 0xa;
            igt72dTextBox.MaxLength = 0xa;
            igt75TextBox.MaxLength = 0x7;
            igt75bTextBox.MaxLength = 0x7;
            igt75cTextBox.MaxLength = 0x7;
            igt75dTextBox.MaxLength = 0xa;
            igt76TextBox.MaxLength = 0xa;
            igt76bTextBox.MaxLength = 0x9;
            igt76cTextBox.MaxLength = 0x6;
            igt76dTextBox.MaxLength = 0xa;
            igt77TextBox.MaxLength = 0x8;
            igt77bTextBox.MaxLength = 0x7;
            igt77cTextBox.MaxLength = 0x9;
            igt77dTextBox.MaxLength = 0xa;
            igt78TextBox.MaxLength = 0x8;
            igt78bTextBox.MaxLength = 0x9;
            igt78cTextBox.MaxLength = 0xa;
            igt78dTextBox.MaxLength = 0x5;
            igt79TextBox.MaxLength = 0x6;
            igt79bTextBox.MaxLength = 0x8;
            igt79dTextBox.MaxLength = 0xa;
            igt80dTextBox.MaxLength = 0xa;
            igt87bTextBox.MaxLength = 0x9;
        }

        private void LoadRomData()
        {
            try
            {
                Backend backend = new Backend(FullFilename);
                
                igt7TextBox.Text = backend.getText(0x9, 0xE40B);
                igt7bTextBox.Text = backend.getText(0x8, 0xE415);
                igt7cTextBox.Text = backend.getText(0xa, 0xE41E);
                igt7dTextBox.Text = backend.getText(0xb, 0xE429);
                igt8TextBox.Text = backend.getText(0x5, 0xE435);
                igt20TextBox.Text = backend.getText(0x9, 0xE632);
                igt20bTextBox.Text = backend.getText(0x6, 0xE63C);
                igt20cTextBox.Text = backend.getText(0x9, 0xE643);
                igt20dTextBox.Text = backend.getText(0x6, 0xE64D);
                igt22TextBox.Text = backend.getText(0x7, 0xE666);
                igt22bTextBox.Text = backend.getText(0x8, 0xE66E);
                igt22cTextBox.Text = backend.getText(0x6, 0xE677);
                igt22dTextBox.Text = backend.getText(0xa, 0xE67F);
                igt24TextBox.Text = backend.getText(0x8, 0xE6B8);
                igt24bTextBox.Text = backend.getText(0xa, 0xE6C1);
                igt24cTextBox.Text = backend.getText(0xa, 0xE6CC);
                igt24dTextBox.Text = backend.getText(0x9, 0xE6D7);
                igt29TextBox.Text = backend.getText(0x8, 0xE763);
                igt30dTextBox.Text = backend.getText(0xa, 0xE78D);
                igt33TextBox.Text = backend.getText(0x9, 0xE80E);
                igt33bTextBox.Text = backend.getText(0x8, 0xE818);
                igt33cTextBox.Text = backend.getText(0xa, 0xE821);
                igt33dTextBox.Text = backend.getText(0x5, 0xE82C);
                igt34TextBox.Text = backend.getText(0x8, 0xE833);
                igt34bTextBox.Text = backend.getText(0xa, 0xE83C);
                igt34cTextBox.Text = backend.getText(0xa, 0xE847);
                igt34dTextBox.Text = backend.getText(0xa, 0xE852);
                igt35dTextBox.Text = backend.getText(0xa, 0xE87D);
                igt36TextBox.Text = backend.getText(0xa, 0xE888);
                igt36bTextBox.Text = backend.getText(0x9, 0xE893);
                igt36cTextBox.Text = backend.getText(0x9, 0xE89D);
                igt56bTextBox.Text = backend.getText(0x7, 0xEB16);
                igt56dTextBox.Text = backend.getText(0xa, 0xEB29);
                igt58TextBox.Text = backend.getText(0x9, 0xEB61);
                igt58bTextBox.Text = backend.getText(0xa, 0xEB6B);
                igt58cTextBox.Text = backend.getText(0xa, 0xEB76);
                igt58dTextBox.Text = backend.getText(0x8, 0xEB81);
                igt61bTextBox.Text = backend.getText(0x7, 0xEBC5);
                igt62TextBox.Text = backend.getText(0x7, 0xEBE0);
                igt62bTextBox.Text = backend.getText(0xa, 0xEBE8);
                igt62cTextBox.Text = backend.getText(0x7, 0xEBF3);
                igt66dTextBox.Text = backend.getText(0xa, 0xECA9);
                igt71dTextBox.Text = backend.getText(0xa, 0xED77);
                igt72dTextBox.Text = backend.getText(0xa, 0xED9F);
                igt75TextBox.Text = backend.getText(0x7, 0xEE06);
                igt75bTextBox.Text = backend.getText(0x7, 0xEE0E);
                igt75cTextBox.Text = backend.getText(0x7, 0xEE16);
                igt75dTextBox.Text = backend.getText(0xa, 0xEE1E);
                igt76TextBox.Text = backend.getText(0xa, 0xEE48);
                igt76bTextBox.Text = backend.getText(0x9, 0xEE53);
                igt76cTextBox.Text = backend.getText(0x6, 0xEE5D);
                igt76dTextBox.Text = backend.getText(0xa, 0xEE64);
                igt77TextBox.Text = backend.getText(0x8, 0xEE6F);
                igt77bTextBox.Text = backend.getText(0x7, 0xEE78);
                igt77cTextBox.Text = backend.getText(0x9, 0xEE80);
                igt77dTextBox.Text = backend.getText(0xa, 0xEE8A);
                igt78TextBox.Text = backend.getText(0x8, 0xEE95);
                igt78bTextBox.Text = backend.getText(0x9, 0xEE9E);
                igt78cTextBox.Text = backend.getText(0xa, 0xEEA8);
                igt78dTextBox.Text = backend.getText(0x5, 0xEEB3);
                igt79TextBox.Text = backend.getText(0x6, 0xEEB9);
                igt79bTextBox.Text = backend.getText(0x8, 0xEEC0);
                igt79dTextBox.Text = backend.getText(0xa, 0xEED1);
                igt80dTextBox.Text = backend.getText(0xa, 0xEEF1);
                igt87bTextBox.Text = backend.getText(0x9, 0xE5BB);

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
                
                backend.updateROMText(0x9, igt7TextBox.Text, 0xE40B);
                backend.updateROMText(0x8, igt7bTextBox.Text, 0xE415);
                backend.updateROMText(0xa, igt7cTextBox.Text, 0xE41E);
                backend.updateROMText(0xb, igt7dTextBox.Text, 0xE429);
                backend.updateROMText(0x5, igt8TextBox.Text, 0xE435);
                backend.updateROMText(0x9, igt20TextBox.Text, 0xE632);
                backend.updateROMText(0x6, igt20bTextBox.Text, 0xE63C);
                backend.updateROMText(0x9, igt20cTextBox.Text, 0xE643);
                backend.updateROMText(0x6, igt20dTextBox.Text, 0xE64D);
                backend.updateROMText(0x7, igt22TextBox.Text, 0xE666);
                backend.updateROMText(0x8, igt22bTextBox.Text, 0xE66E);
                backend.updateROMText(0x6, igt22cTextBox.Text, 0xE677);
                backend.updateROMText(0xa, igt22dTextBox.Text, 0xE67F);
                backend.updateROMText(0x8, igt24TextBox.Text, 0xE6B8);
                backend.updateROMText(0xa, igt24bTextBox.Text, 0xE6C1);
                backend.updateROMText(0xa, igt24cTextBox.Text, 0xE6CC);
                backend.updateROMText(0x9, igt24dTextBox.Text, 0xE6D7);
                backend.updateROMText(0x8, igt29TextBox.Text, 0xE763);
                backend.updateROMText(0xa, igt30dTextBox.Text, 0xE78D);
                backend.updateROMText(0x9, igt33TextBox.Text, 0xE80E);
                backend.updateROMText(0x8, igt33bTextBox.Text, 0xE818);
                backend.updateROMText(0xa, igt33cTextBox.Text, 0xE821);
                backend.updateROMText(0x5, igt33dTextBox.Text, 0xE82C);
                backend.updateROMText(0x8, igt34TextBox.Text, 0xE833);
                backend.updateROMText(0xa, igt34bTextBox.Text, 0xE83C);
                backend.updateROMText(0xa, igt34cTextBox.Text, 0xE847);
                backend.updateROMText(0xa, igt34dTextBox.Text, 0xE852);
                backend.updateROMText(0xa, igt35dTextBox.Text, 0xE87D);
                backend.updateROMText(0xa, igt36TextBox.Text, 0xE888);
                backend.updateROMText(0x9, igt36bTextBox.Text, 0xE893);
                backend.updateROMText(0x9, igt36cTextBox.Text, 0xE89D);
                backend.updateROMText(0x7, igt56bTextBox.Text, 0xEB16);
                backend.updateROMText(0xa, igt56dTextBox.Text, 0xEB29);
                backend.updateROMText(0x9, igt58TextBox.Text, 0xEB61);
                backend.updateROMText(0xa, igt58bTextBox.Text, 0xEB6B);
                backend.updateROMText(0xa, igt58cTextBox.Text, 0xEB76);
                backend.updateROMText(0x8, igt58dTextBox.Text, 0xEB81);
                backend.updateROMText(0x7, igt61bTextBox.Text, 0xEBC5);
                backend.updateROMText(0x7, igt62TextBox.Text, 0xEBE0);
                backend.updateROMText(0xa, igt62bTextBox.Text, 0xEBE8);
                backend.updateROMText(0x7, igt62cTextBox.Text, 0xEBF3);
                backend.updateROMText(0xa, igt66dTextBox.Text, 0xECA9);
                backend.updateROMText(0xa, igt71dTextBox.Text, 0xED77);
                backend.updateROMText(0xa, igt72dTextBox.Text, 0xED9F);
                backend.updateROMText(0x7, igt75TextBox.Text, 0xEE06);
                backend.updateROMText(0x7, igt75bTextBox.Text, 0xEE0E);
                backend.updateROMText(0x7, igt75cTextBox.Text, 0xEE16);
                backend.updateROMText(0xa, igt75dTextBox.Text, 0xEE1E);
                backend.updateROMText(0xa, igt76TextBox.Text, 0xEE48);
                backend.updateROMText(0x9, igt76bTextBox.Text, 0xEE53);
                backend.updateROMText(0x6, igt76cTextBox.Text, 0xEE5D);
                backend.updateROMText(0xa, igt76dTextBox.Text, 0xEE64);
                backend.updateROMText(0x8, igt77TextBox.Text, 0xEE6F);
                backend.updateROMText(0x7, igt77bTextBox.Text, 0xEE78);
                backend.updateROMText(0x9, igt77cTextBox.Text, 0xEE80);
                backend.updateROMText(0xa, igt77dTextBox.Text, 0xEE8A);
                backend.updateROMText(0x8, igt78TextBox.Text, 0xEE95);
                backend.updateROMText(0x9, igt78bTextBox.Text, 0xEE9E);
                backend.updateROMText(0xa, igt78cTextBox.Text, 0xEEA8);
                backend.updateROMText(0x5, igt78dTextBox.Text, 0xEEB3);
                backend.updateROMText(0x6, igt79TextBox.Text, 0xEEB9);
                backend.updateROMText(0x8, igt79bTextBox.Text, 0xEEC0);
                backend.updateROMText(0xa, igt79dTextBox.Text, 0xEED1);
                backend.updateROMText(0xa, igt80dTextBox.Text, 0xEEF1);
                backend.updateROMText(0x9, igt87bTextBox.Text, 0xE5BB);

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
