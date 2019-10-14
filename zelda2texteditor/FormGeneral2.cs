using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //SetMaxLengthOfTextBoxes();
            //LoadRomData();
        }
    }
}
