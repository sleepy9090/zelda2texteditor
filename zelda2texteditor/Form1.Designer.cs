namespace zelda2texteditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btfButton = new System.Windows.Forms.Button();
            this.fnTextBox = new System.Windows.Forms.TextBox();
            this.fnLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInGameTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGameCreditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSpellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRegisistrationAndMiscellanouseTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTownNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfnTextBox = new System.Windows.Forms.TextBox();
            this.openRomProgressBar = new System.Windows.Forms.ProgressBar();
            this.zstoryTextBox = new System.Windows.Forms.TextBox();
            this.zstoryLabel = new System.Windows.Forms.Label();
            this.zstoryeditTextBox = new System.Windows.Forms.TextBox();
            this.zstoryeditLabel = new System.Windows.Forms.Label();
            this.rzrtLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zstoryeditTextBox16 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox12 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox11 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox10 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox13 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox14 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox15 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox8 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox7 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox6 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox5 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox4 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox3 = new System.Windows.Forms.TextBox();
            this.zstoryeditTextBox2 = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btfButton
            // 
            this.btfButton.Location = new System.Drawing.Point(440, 11);
            this.btfButton.Name = "btfButton";
            this.btfButton.Size = new System.Drawing.Size(28, 23);
            this.btfButton.TabIndex = 1;
            this.btfButton.Text = "...";
            this.btfButton.UseVisualStyleBackColor = true;
            this.btfButton.Click += new System.EventHandler(this.btfButton_Click);
            // 
            // fnTextBox
            // 
            this.fnTextBox.Location = new System.Drawing.Point(69, 13);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.ReadOnly = true;
            this.fnTextBox.Size = new System.Drawing.Size(365, 20);
            this.fnTextBox.TabIndex = 0;
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(11, 16);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(52, 13);
            this.fnLabel.TabIndex = 4;
            this.fnLabel.Text = "Filename:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInGameTextToolStripMenuItem,
            this.editGameCreditsToolStripMenuItem,
            this.editSpellsToolStripMenuItem,
            this.editRegisistrationAndMiscellanouseTextToolStripMenuItem,
            this.editTownNamesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // editInGameTextToolStripMenuItem
            // 
            this.editInGameTextToolStripMenuItem.Name = "editInGameTextToolStripMenuItem";
            this.editInGameTextToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.editInGameTextToolStripMenuItem.Text = "Edit In &Game Text";
            this.editInGameTextToolStripMenuItem.Click += new System.EventHandler(this.editInGameTextToolStripMenuItem_Click);
            // 
            // editGameCreditsToolStripMenuItem
            // 
            this.editGameCreditsToolStripMenuItem.Name = "editGameCreditsToolStripMenuItem";
            this.editGameCreditsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.editGameCreditsToolStripMenuItem.Text = "Edit Game &Credits Text";
            this.editGameCreditsToolStripMenuItem.Click += new System.EventHandler(this.editGameCreditsToolStripMenuItem_Click);
            // 
            // editSpellsToolStripMenuItem
            // 
            this.editSpellsToolStripMenuItem.Name = "editSpellsToolStripMenuItem";
            this.editSpellsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.editSpellsToolStripMenuItem.Text = "Edit &Spells Text";
            this.editSpellsToolStripMenuItem.Click += new System.EventHandler(this.editSpellsToolStripMenuItem_Click);
            // 
            // editRegisistrationAndMiscellanouseTextToolStripMenuItem
            // 
            this.editRegisistrationAndMiscellanouseTextToolStripMenuItem.Name = "editRegisistrationAndMiscellanouseTextToolStripMenuItem";
            this.editRegisistrationAndMiscellanouseTextToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.editRegisistrationAndMiscellanouseTextToolStripMenuItem.Text = "Edit &Regisistration and Miscellaneous Text";
            this.editRegisistrationAndMiscellanouseTextToolStripMenuItem.Click += new System.EventHandler(this.editRegisistrationAndMiscellanouseTextToolStripMenuItem_Click);
            // 
            // editTownNamesToolStripMenuItem
            // 
            this.editTownNamesToolStripMenuItem.Name = "editTownNamesToolStripMenuItem";
            this.editTownNamesToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.editTownNamesToolStripMenuItem.Text = "Edit &Locations";
            this.editTownNamesToolStripMenuItem.Click += new System.EventHandler(this.editTownNamesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sfnTextBox
            // 
            this.sfnTextBox.Location = new System.Drawing.Point(474, 13);
            this.sfnTextBox.Name = "sfnTextBox";
            this.sfnTextBox.ReadOnly = true;
            this.sfnTextBox.Size = new System.Drawing.Size(240, 20);
            this.sfnTextBox.TabIndex = 3;
            // 
            // openRomProgressBar
            // 
            this.openRomProgressBar.Location = new System.Drawing.Point(23, 464);
            this.openRomProgressBar.Name = "openRomProgressBar";
            this.openRomProgressBar.Size = new System.Drawing.Size(724, 23);
            this.openRomProgressBar.Step = 50;
            this.openRomProgressBar.TabIndex = 8;
            // 
            // zstoryTextBox
            // 
            this.zstoryTextBox.Enabled = false;
            this.zstoryTextBox.Location = new System.Drawing.Point(9, 32);
            this.zstoryTextBox.Multiline = true;
            this.zstoryTextBox.Name = "zstoryTextBox";
            this.zstoryTextBox.Size = new System.Drawing.Size(706, 61);
            this.zstoryTextBox.TabIndex = 9;
            // 
            // zstoryLabel
            // 
            this.zstoryLabel.AutoSize = true;
            this.zstoryLabel.Location = new System.Drawing.Point(6, 16);
            this.zstoryLabel.Name = "zstoryLabel";
            this.zstoryLabel.Size = new System.Drawing.Size(34, 13);
            this.zstoryLabel.TabIndex = 10;
            this.zstoryLabel.Text = "Story:";
            // 
            // zstoryeditTextBox
            // 
            this.zstoryeditTextBox.Enabled = false;
            this.zstoryeditTextBox.Location = new System.Drawing.Point(9, 124);
            this.zstoryeditTextBox.Name = "zstoryeditTextBox";
            this.zstoryeditTextBox.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox.TabIndex = 0;
            // 
            // zstoryeditLabel
            // 
            this.zstoryeditLabel.AutoSize = true;
            this.zstoryeditLabel.Location = new System.Drawing.Point(6, 108);
            this.zstoryeditLabel.Name = "zstoryeditLabel";
            this.zstoryeditLabel.Size = new System.Drawing.Size(55, 13);
            this.zstoryeditLabel.TabIndex = 12;
            this.zstoryeditLabel.Text = "Edit Story:";
            // 
            // rzrtLabel
            // 
            this.rzrtLabel.AutoSize = true;
            this.rzrtLabel.Location = new System.Drawing.Point(20, 448);
            this.rzrtLabel.Name = "rzrtLabel";
            this.rzrtLabel.Size = new System.Drawing.Size(138, 13);
            this.rzrtLabel.TabIndex = 13;
            this.rzrtLabel.Text = "Reading Zelda 2 Rom Text:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zstoryeditTextBox16);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox12);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox11);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox10);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox13);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox14);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox15);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox8);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox7);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox6);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox5);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox4);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox3);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox2);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.zstoryLabel);
            this.groupBox1.Controls.Add(this.zstoryTextBox);
            this.groupBox1.Controls.Add(this.zstoryeditLabel);
            this.groupBox1.Controls.Add(this.zstoryeditTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 365);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // zstoryeditTextBox16
            // 
            this.zstoryeditTextBox16.Enabled = false;
            this.zstoryeditTextBox16.Location = new System.Drawing.Point(364, 280);
            this.zstoryeditTextBox16.Name = "zstoryeditTextBox16";
            this.zstoryeditTextBox16.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox16.TabIndex = 14;
            // 
            // zstoryeditTextBox12
            // 
            this.zstoryeditTextBox12.Enabled = false;
            this.zstoryeditTextBox12.Location = new System.Drawing.Point(365, 176);
            this.zstoryeditTextBox12.Name = "zstoryeditTextBox12";
            this.zstoryeditTextBox12.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox12.TabIndex = 10;
            // 
            // zstoryeditTextBox11
            // 
            this.zstoryeditTextBox11.Enabled = false;
            this.zstoryeditTextBox11.Location = new System.Drawing.Point(365, 150);
            this.zstoryeditTextBox11.Name = "zstoryeditTextBox11";
            this.zstoryeditTextBox11.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox11.TabIndex = 9;
            // 
            // zstoryeditTextBox10
            // 
            this.zstoryeditTextBox10.Enabled = false;
            this.zstoryeditTextBox10.Location = new System.Drawing.Point(364, 124);
            this.zstoryeditTextBox10.Name = "zstoryeditTextBox10";
            this.zstoryeditTextBox10.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox10.TabIndex = 8;
            // 
            // zstoryeditTextBox13
            // 
            this.zstoryeditTextBox13.Enabled = false;
            this.zstoryeditTextBox13.Location = new System.Drawing.Point(365, 202);
            this.zstoryeditTextBox13.Name = "zstoryeditTextBox13";
            this.zstoryeditTextBox13.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox13.TabIndex = 11;
            // 
            // zstoryeditTextBox14
            // 
            this.zstoryeditTextBox14.Enabled = false;
            this.zstoryeditTextBox14.Location = new System.Drawing.Point(364, 228);
            this.zstoryeditTextBox14.Name = "zstoryeditTextBox14";
            this.zstoryeditTextBox14.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox14.TabIndex = 12;
            // 
            // zstoryeditTextBox15
            // 
            this.zstoryeditTextBox15.Enabled = false;
            this.zstoryeditTextBox15.Location = new System.Drawing.Point(365, 254);
            this.zstoryeditTextBox15.Name = "zstoryeditTextBox15";
            this.zstoryeditTextBox15.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox15.TabIndex = 13;
            // 
            // zstoryeditTextBox8
            // 
            this.zstoryeditTextBox8.Enabled = false;
            this.zstoryeditTextBox8.Location = new System.Drawing.Point(9, 306);
            this.zstoryeditTextBox8.Name = "zstoryeditTextBox8";
            this.zstoryeditTextBox8.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox8.TabIndex = 7;
            // 
            // zstoryeditTextBox7
            // 
            this.zstoryeditTextBox7.Enabled = false;
            this.zstoryeditTextBox7.Location = new System.Drawing.Point(9, 280);
            this.zstoryeditTextBox7.Name = "zstoryeditTextBox7";
            this.zstoryeditTextBox7.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox7.TabIndex = 6;
            // 
            // zstoryeditTextBox6
            // 
            this.zstoryeditTextBox6.Enabled = false;
            this.zstoryeditTextBox6.Location = new System.Drawing.Point(9, 254);
            this.zstoryeditTextBox6.Name = "zstoryeditTextBox6";
            this.zstoryeditTextBox6.Size = new System.Drawing.Size(349, 20);
            this.zstoryeditTextBox6.TabIndex = 5;
            // 
            // zstoryeditTextBox5
            // 
            this.zstoryeditTextBox5.Enabled = false;
            this.zstoryeditTextBox5.Location = new System.Drawing.Point(9, 228);
            this.zstoryeditTextBox5.Name = "zstoryeditTextBox5";
            this.zstoryeditTextBox5.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox5.TabIndex = 4;
            // 
            // zstoryeditTextBox4
            // 
            this.zstoryeditTextBox4.Enabled = false;
            this.zstoryeditTextBox4.Location = new System.Drawing.Point(8, 202);
            this.zstoryeditTextBox4.Name = "zstoryeditTextBox4";
            this.zstoryeditTextBox4.Size = new System.Drawing.Size(351, 20);
            this.zstoryeditTextBox4.TabIndex = 3;
            // 
            // zstoryeditTextBox3
            // 
            this.zstoryeditTextBox3.Enabled = false;
            this.zstoryeditTextBox3.Location = new System.Drawing.Point(8, 176);
            this.zstoryeditTextBox3.Name = "zstoryeditTextBox3";
            this.zstoryeditTextBox3.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox3.TabIndex = 2;
            // 
            // zstoryeditTextBox2
            // 
            this.zstoryeditTextBox2.Enabled = false;
            this.zstoryeditTextBox2.Location = new System.Drawing.Point(8, 150);
            this.zstoryeditTextBox2.Name = "zstoryeditTextBox2";
            this.zstoryeditTextBox2.Size = new System.Drawing.Size(350, 20);
            this.zstoryeditTextBox2.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(639, 332);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fnLabel);
            this.groupBox2.Controls.Add(this.btfButton);
            this.groupBox2.Controls.Add(this.fnTextBox);
            this.groupBox2.Controls.Add(this.sfnTextBox);
            this.groupBox2.Location = new System.Drawing.Point(15, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rzrtLabel);
            this.Controls.Add(this.openRomProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zelda II NES ROM Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btfButton;
        private System.Windows.Forms.TextBox fnTextBox;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox sfnTextBox;
        private System.Windows.Forms.ProgressBar openRomProgressBar;
        private System.Windows.Forms.TextBox zstoryTextBox;
        private System.Windows.Forms.Label zstoryLabel;
        private System.Windows.Forms.TextBox zstoryeditTextBox;
        private System.Windows.Forms.Label zstoryeditLabel;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInGameTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGameCreditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSpellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRegisistrationAndMiscellanouseTextToolStripMenuItem;
        private System.Windows.Forms.Label rzrtLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox zstoryeditTextBox3;
        private System.Windows.Forms.TextBox zstoryeditTextBox2;
        private System.Windows.Forms.TextBox zstoryeditTextBox14;
        private System.Windows.Forms.TextBox zstoryeditTextBox15;
        private System.Windows.Forms.TextBox zstoryeditTextBox8;
        private System.Windows.Forms.TextBox zstoryeditTextBox7;
        private System.Windows.Forms.TextBox zstoryeditTextBox6;
        private System.Windows.Forms.TextBox zstoryeditTextBox5;
        private System.Windows.Forms.TextBox zstoryeditTextBox4;
        private System.Windows.Forms.TextBox zstoryeditTextBox13;
        private System.Windows.Forms.TextBox zstoryeditTextBox12;
        private System.Windows.Forms.TextBox zstoryeditTextBox11;
        private System.Windows.Forms.TextBox zstoryeditTextBox10;
        private System.Windows.Forms.TextBox zstoryeditTextBox16;
        private System.Windows.Forms.ToolStripMenuItem editTownNamesToolStripMenuItem;
    }
}

