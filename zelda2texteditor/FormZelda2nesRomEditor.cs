/**
 * @file           FormZelda2NesRomEditor.cs
 * @brief          Creates the main form.
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
    public partial class FormZelda2NesRomEditor : Form
    {

        public string FullFilename { get; set; }

        public FormZelda2NesRomEditor()
        {
            InitializeComponent();
            EnableDisableFormControls(false);
            SetTextBoxesMaxLength();
        }

        private void EnableDisableFormControls(bool isControlEnabled)
        {
            zstoryTextBox.Enabled = false; // Always disabled
            editGeneralGameTextToolStripMenuItem.Enabled = isControlEnabled;
            editGameCreditsToolStripMenuItem.Enabled = isControlEnabled;
            editSpellsToolStripMenuItem.Enabled = isControlEnabled;
            editRegisistrationAndMiscellanouseTextToolStripMenuItem.Enabled = isControlEnabled;
            editlocationsToolStripMenuItem.Enabled = isControlEnabled;

            updateButton.Enabled = isControlEnabled;

            zstoryeditTextBox.Enabled = isControlEnabled;
            zstoryeditTextBox2.Enabled = isControlEnabled;
            zstoryeditTextBox3.Enabled = isControlEnabled;
            zstoryeditTextBox4.Enabled = isControlEnabled;
            zstoryeditTextBox5.Enabled = isControlEnabled;
            zstoryeditTextBox6.Enabled = isControlEnabled;
            zstoryeditTextBox7.Enabled = isControlEnabled;
            zstoryeditTextBox8.Enabled = isControlEnabled;
            zstoryeditTextBox9.Enabled = isControlEnabled;
            zstoryeditTextBox10.Enabled = isControlEnabled;
            zstoryeditTextBox11.Enabled = isControlEnabled;
            zstoryeditTextBox12.Enabled = isControlEnabled;
            zstoryeditTextBox13.Enabled = isControlEnabled;
            zstoryeditTextBox14.Enabled = isControlEnabled;
            zstoryeditTextBox15.Enabled = isControlEnabled;
        }

        private void SetTextBoxesMaxLength()
        {
            zstoryeditTextBox.MaxLength = 0x1c;
            zstoryeditTextBox2.MaxLength = 0x1c;
            zstoryeditTextBox3.MaxLength = 0x1c;
            zstoryeditTextBox4.MaxLength = 0x1c;
            zstoryeditTextBox5.MaxLength = 0x1c;
            zstoryeditTextBox6.MaxLength = 0x1c;
            zstoryeditTextBox7.MaxLength = 0x1c;
            zstoryeditTextBox8.MaxLength = 0x1c;
            zstoryeditTextBox9.MaxLength = 0x1c;
            zstoryeditTextBox10.MaxLength = 0x1c;
            zstoryeditTextBox11.MaxLength = 0x1c;
            zstoryeditTextBox12.MaxLength = 0x1c;
            zstoryeditTextBox13.MaxLength = 0x1c;
            zstoryeditTextBox14.MaxLength = 0x1c;
            zstoryeditTextBox15.MaxLength = 0x1c;
        }

        private void btfButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = @"Open file...";
            openFileDialog.Filter = @"nes files (*.nes)|*.nes|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FullFilename = openFileDialog.FileName;
                SetFilenameTextBoxes();
                LoadRomData();
                EnableDisableFormControls(true);
            }
        }

        private void SetFilenameTextBoxes()
        {
            textBoxFullFilename.Text = FullFilename;
            textBoxFilename.Text = textBoxFullFilename.Text.Substring(textBoxFullFilename.Text.LastIndexOf('\\') + 1);
        }

        private void LoadRomData()
        {

            Backend backend = new Backend(FullFilename);

            zstoryTextBox.Text = backend.getText(0x1b2, 0x16942);

            zstoryeditTextBox.Text = backend.getText(0x1c, 0x16942);
            zstoryeditTextBox2.Text = backend.getText(0x1c, 0x1695F);
            zstoryeditTextBox3.Text = backend.getText(0x1c, 0x1697C);
            zstoryeditTextBox4.Text = backend.getText(0x1c, 0x16999);
            zstoryeditTextBox5.Text = backend.getText(0x1c, 0x169B6);
            zstoryeditTextBox6.Text = backend.getText(0x1c, 0x169D3);
            zstoryeditTextBox7.Text = backend.getText(0x1c, 0x169F0);
            zstoryeditTextBox8.Text = backend.getText(0x1c, 0x16A0D);
            zstoryeditTextBox9.Text = backend.getText(0x1c, 0x16A2A);
            zstoryeditTextBox10.Text = backend.getText(0x1c, 0x16A47);
            zstoryeditTextBox11.Text = backend.getText(0x1c, 0x16A64);
            zstoryeditTextBox12.Text = backend.getText(0x1c, 0x16A81);
            zstoryeditTextBox13.Text = backend.getText(0x1c, 0x16A9E);
            zstoryeditTextBox14.Text = backend.getText(0x1c, 0x16ABB);
            zstoryeditTextBox15.Text = backend.getText(0x1c, 0x16AD8);
        }

        private void FormZelda2NesRomEditor_Load(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditInGameTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGeneral formGeneral = new FormGeneral(FullFilename);

            formGeneral.ShowDialog();
        }

        private void EditGameCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCredits formCredits = new FormCredits(FullFilename);

            formCredits.ShowDialog();
        }

        private void EditSpellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpells formSpells = new FormSpells(FullFilename);

            formSpells.ShowDialog();
        }

        private void EditRegistrationAndMiscTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrationAndMisc formRegistrationAndMisc = new FormRegistrationAndMisc(FullFilename);

            formRegistrationAndMisc.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();

            aboutBox.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Backend backend = new Backend(FullFilename);

            backend.updateROMText(0x1C, zstoryeditTextBox.Text, 0x16942); // previously 0x19. why?
            backend.updateROMText(0x1C, zstoryeditTextBox2.Text, 0x1695F);
            backend.updateROMText(0x1C, zstoryeditTextBox3.Text, 0x1697C);
            backend.updateROMText(0x1C, zstoryeditTextBox4.Text, 0x16999);
            backend.updateROMText(0x1C, zstoryeditTextBox5.Text, 0x169B6);
            backend.updateROMText(0x1C, zstoryeditTextBox6.Text, 0x169D3);
            backend.updateROMText(0x1C, zstoryeditTextBox7.Text, 0x169F0);
            backend.updateROMText(0x1C, zstoryeditTextBox8.Text, 0x16A0D);
            backend.updateROMText(0x1C, zstoryeditTextBox9.Text, 0x16A2A);
            backend.updateROMText(0x1C, zstoryeditTextBox10.Text, 0x16A47);
            backend.updateROMText(0x1C, zstoryeditTextBox11.Text, 0x16A64);
            backend.updateROMText(0x1C, zstoryeditTextBox12.Text, 0x16A81);
            backend.updateROMText(0x1C, zstoryeditTextBox13.Text, 0x16A9E);
            backend.updateROMText(0x1C, zstoryeditTextBox14.Text, 0x16ABB);
            backend.updateROMText(0x1C, zstoryeditTextBox15.Text, 0x16AD8);

            MessageBox.Show(@"Updated! Restart program to see changes.", @"Story Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btfButton_Click(sender, e);
        }

        private void EditLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocations formLocations = new FormLocations(FullFilename);

            formLocations.ShowDialog();
        }

    }
}
