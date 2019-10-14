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
            //there is no 28
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

            igt7TextBox.MaxLength = 0x9;
            igt7bTextBox.MaxLength = 0x8;
            igt7cTextBox.MaxLength = 0xa;
            igt7dTextBox.MaxLength = 0xb;

            igt8TextBox.MaxLength = 0x5;

            igt9TextBox.MaxLength = 0x5;
            igt9bTextBox.MaxLength = 0x5;
            igt9cTextBox.MaxLength = 0x7;

            igt10TextBox.MaxLength = 0x6;
            igt10bTextBox.MaxLength = 0x6;
            igt10cTextBox.MaxLength = 0x8;

            igt11TextBox.MaxLength = 0x8;
            igt11bTextBox.MaxLength = 0xa;
            igt11cTextBox.MaxLength = 0xa;
            igt11dTextBox.MaxLength = 0x9;

            igt12TextBox.MaxLength = 0x8;
            igt12bTextBox.MaxLength = 0x8;
            igt12cTextBox.MaxLength = 0x8;
            igt12dTextBox.MaxLength = 0x7;

            igt13TextBox.MaxLength = 0x8;
            igt13bTextBox.MaxLength = 0xa;
            igt13cTextBox.MaxLength = 0x9;
            igt13dTextBox.MaxLength = 0xa;

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

            igt20TextBox.MaxLength = 0x9;
            igt20bTextBox.MaxLength = 0x6;
            igt20cTextBox.MaxLength = 0x9;
            igt20dTextBox.MaxLength = 0x6;

            igt21TextBox.MaxLength = 0x6;
            igt21bTextBox.MaxLength = 0xa;

            igt22TextBox.MaxLength = 0x7;
            igt22bTextBox.MaxLength = 0x8;
            igt22cTextBox.MaxLength = 0x6;
            igt22dTextBox.MaxLength = 0xa;

            igt23TextBox.MaxLength = 0x4;
            igt23bTextBox.MaxLength = 0x6;

            igt24TextBox.MaxLength = 0x8;
            igt24bTextBox.MaxLength = 0xa;
            igt24cTextBox.MaxLength = 0xa;
            igt24dTextBox.MaxLength = 0x9;

            igt25TextBox.MaxLength = 0x9;
            igt25bTextBox.MaxLength = 0xa;
            igt25cTextBox.MaxLength = 0x7;
            igt25dTextBox.MaxLength = 0x6;

            igt26TextBox.MaxLength = 0x7;
            igt26bTextBox.MaxLength = 0x9;
            igt26cTextBox.MaxLength = 0xa;
            igt26dTextBox.MaxLength = 0xa;

            igt27TextBox.MaxLength = 0x6;
            igt27bTextBox.MaxLength = 0xa;
            igt27cTextBox.MaxLength = 0x9;

            //there is no 28

            igt29TextBox.MaxLength = 0x8;

            igt30TextBox.MaxLength = 0xa;
            igt30bTextBox.MaxLength = 0xa;
            igt30cTextBox.MaxLength = 0xa;
            igt30dTextBox.MaxLength = 0xa;

            igt31TextBox.MaxLength = 0x8;
            igt31bTextBox.MaxLength = 0xa;
            igt31cTextBox.MaxLength = 0x8;
            igt31dTextBox.MaxLength = 0x9;

            igt32TextBox.MaxLength = 0x9;
            igt32bTextBox.MaxLength = 0x9;
            igt32cTextBox.MaxLength = 0xa;
            igt32dTextBox.MaxLength = 0xa;

            igt33TextBox.MaxLength = 0x9;
            igt33bTextBox.MaxLength = 0x8;
            igt33cTextBox.MaxLength = 0xa;
            igt33dTextBox.MaxLength = 0x5;

            igt34TextBox.MaxLength = 0x8;
            igt34bTextBox.MaxLength = 0xa;
            igt34cTextBox.MaxLength = 0xa;
            igt34dTextBox.MaxLength = 0xa;

            igt35TextBox.MaxLength = 0x9;
            igt35bTextBox.MaxLength = 0xa;
            igt35cTextBox.MaxLength = 0xa;
            igt35dTextBox.MaxLength = 0xa;

            igt36TextBox.MaxLength = 0xa;
            igt36bTextBox.MaxLength = 0x9;
            igt36cTextBox.MaxLength = 0x9;
            igt36dTextBox.MaxLength = 0xa;

            igt37TextBox.MaxLength = 0xa;
            igt37bTextBox.MaxLength = 0x9;
            igt37cTextBox.MaxLength = 0x9;
            igt37dTextBox.MaxLength = 0x6;

            igt38TextBox.MaxLength = 0x8;
            igt38bTextBox.MaxLength = 0x8;
            igt38cTextBox.MaxLength = 0x9;
            igt38dTextBox.MaxLength = 0xa;

            igt39TextBox.MaxLength = 0xa;
            igt39bTextBox.MaxLength = 0x8;
            igt39cTextBox.MaxLength = 0x8;
            igt39dTextBox.MaxLength = 0x8;

            igt40TextBox.MaxLength = 0x9;
            igt40bTextBox.MaxLength = 0x8;
            igt40cTextBox.MaxLength = 0xa;
            igt40dTextBox.MaxLength = 0x8;

            igt41TextBox.MaxLength = 0x9;
            igt41bTextBox.MaxLength = 0x7;
            igt41cTextBox.MaxLength = 0x9;
            igt41dTextBox.MaxLength = 0x7;

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

            igt46TextBox.MaxLength = 0x7;
            igt46bTextBox.MaxLength = 0xa;

            igt47TextBox.MaxLength = 0x7;

            igt48TextBox.MaxLength = 0xa;

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

            igt55TextBox.MaxLength = 0x9;
            igt55bTextBox.MaxLength = 0xa;
            igt55cTextBox.MaxLength = 0x9;
            igt55dTextBox.MaxLength = 0x9;

            igt56TextBox.MaxLength = 0x9;
            igt56bTextBox.MaxLength = 0x7;
            igt56cTextBox.MaxLength = 0xa;
            igt56dTextBox.MaxLength = 0xa;

            igt57TextBox.MaxLength = 0x7;
            igt57bTextBox.MaxLength = 0x8;
            igt57cTextBox.MaxLength = 0x5;

            igt58TextBox.MaxLength = 0x9;
            igt58bTextBox.MaxLength = 0xa;
            igt58cTextBox.MaxLength = 0xa;
            igt58dTextBox.MaxLength = 0x8;

            igt59TextBox.MaxLength = 0x4;
            igt59bTextBox.MaxLength = 0x8;

            igt60TextBox.MaxLength = 0x8;
            igt60bTextBox.MaxLength = 0x6;
            igt60cTextBox.MaxLength = 0x7;
            igt60dTextBox.MaxLength = 0x9;

            igt61TextBox.MaxLength = 0xa;
            igt61bTextBox.MaxLength = 0x7;
            igt61cTextBox.MaxLength = 0x7;
            igt61dTextBox.MaxLength = 0xa;

            igt62TextBox.MaxLength = 0x7;
            igt62bTextBox.MaxLength = 0xa;
            igt62cTextBox.MaxLength = 0x7;
            igt62dTextBox.MaxLength = 0x9;

            igt63TextBox.MaxLength = 0x9;
            igt63bTextBox.MaxLength = 0x8;
            igt63cTextBox.MaxLength = 0xa;

            igt64TextBox.MaxLength = 0x8;
            igt64bTextBox.MaxLength = 0x9;
            igt64cTextBox.MaxLength = 0xa;
            igt64dTextBox.MaxLength = 0x3;

            igt65TextBox.MaxLength = 0x9;
            igt65bTextBox.MaxLength = 0x8;
            igt65cTextBox.MaxLength = 0xa;

            igt66TextBox.MaxLength = 0xa;
            igt66bTextBox.MaxLength = 0x6;
            igt66cTextBox.MaxLength = 0x8;
            igt66dTextBox.MaxLength = 0xa;

            igt67TextBox.MaxLength = 0x9;
            igt67bTextBox.MaxLength = 0x8;
            igt67cTextBox.MaxLength = 0x8;
            igt67dTextBox.MaxLength = 0x9;

            igt68TextBox.MaxLength = 0xa;
            igt68bTextBox.MaxLength = 0x5;
            igt68cTextBox.MaxLength = 0xa;

            igt69TextBox.MaxLength = 0xa;
            igt69bTextBox.MaxLength = 0x8;
            igt69cTextBox.MaxLength = 0xa;
            igt69dTextBox.MaxLength = 0x6;

            igt70TextBox.MaxLength = 0x8;
            igt70bTextBox.MaxLength = 0x7;
            igt70cTextBox.MaxLength = 0xa;
            igt70dTextBox.MaxLength = 0x4;

            igt71TextBox.MaxLength = 0xa;
            igt71bTextBox.MaxLength = 0x9;
            igt71cTextBox.MaxLength = 0x8;
            igt71dTextBox.MaxLength = 0xa;

            igt72TextBox.MaxLength = 0x9;
            igt72bTextBox.MaxLength = 0x8;
            igt72cTextBox.MaxLength = 0x9;
            igt72dTextBox.MaxLength = 0xa;

            igt73TextBox.MaxLength = 0x8;
            igt73bTextBox.MaxLength = 0xa;
            igt73cTextBox.MaxLength = 0xb;

            igt74TextBox.MaxLength = 0x6;
            igt74bTextBox.MaxLength = 0x7;
            igt74cTextBox.MaxLength = 0x7;

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
            igt79cTextBox.MaxLength = 0x7;
            igt79dTextBox.MaxLength = 0xa;

            igt80TextBox.MaxLength = 0x3;
            igt80bTextBox.MaxLength = 0x7;
            igt80cTextBox.MaxLength = 0x8;
            igt80dTextBox.MaxLength = 0xa;

            igt81TextBox.MaxLength = 0x8;
            igt81bTextBox.MaxLength = 0x8;
            igt81cTextBox.MaxLength = 0x7;
            igt81dTextBox.MaxLength = 0x8;

            igt82TextBox.MaxLength = 0xa;

            igt83TextBox.MaxLength = 0x5;
            igt83bTextBox.MaxLength = 0x9;

            igt84TextBox.MaxLength = 0x8;
            igt84bTextBox.MaxLength = 0x8;

            igt85TextBox.MaxLength = 0x9;
            igt85bTextBox.MaxLength = 0x9;

            igt86TextBox.MaxLength = 0x7;
            igt86bTextBox.MaxLength = 0xa;
            igt86cTextBox.MaxLength = 0xa;
            igt86dTextBox.MaxLength = 0xa;

            igt87TextBox.MaxLength = 0x9;
            igt87bTextBox.MaxLength = 0x9;
            igt87cTextBox.MaxLength = 0x7;
            igt87dTextBox.MaxLength = 0xa;
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
                igt7TextBox.Text = backend.getText(0x9, 0xE40B);
                igt7bTextBox.Text = backend.getText(0x8, 0xE415);
                igt7cTextBox.Text = backend.getText(0xa, 0xE41E);
                igt7dTextBox.Text = backend.getText(0xb, 0xE429);
                igt8TextBox.Text = backend.getText(0x5, 0xE435);
                igt9TextBox.Text = backend.getText(0x5, 0xE43C);
                igt9bTextBox.Text = backend.getText(0x5, 0xE442);
                igt9cTextBox.Text = backend.getText(0x7, 0xE448);
                igt10TextBox.Text = backend.getText(0x6, 0xE450);
                igt10bTextBox.Text = backend.getText(0x6, 0xE457);
                igt10cTextBox.Text = backend.getText(0x8, 0xE45E);
                igt11TextBox.Text = backend.getText(0x9, 0xE467);
                igt11bTextBox.Text = backend.getText(0xa, 0xE471);
                igt11cTextBox.Text = backend.getText(0xa, 0xE47C);
                igt11dTextBox.Text = backend.getText(0x9, 0xE487);
                igt12TextBox.Text = backend.getText(0x8, 0xE491);
                igt12bTextBox.Text = backend.getText(0x8, 0xE49A);
                igt12cTextBox.Text = backend.getText(0x8, 0xE4A3);
                igt12dTextBox.Text = backend.getText(0x7, 0xE4AC);
                igt13TextBox.Text = backend.getText(0x8, 0xE4B4);
                igt13bTextBox.Text = backend.getText(0xa, 0xE4BD);
                igt13cTextBox.Text = backend.getText(0x9, 0xE4C8);
                igt13dTextBox.Text = backend.getText(0xa, 0xE4D2);
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
                igt20TextBox.Text = backend.getText(0x9, 0xE632);
                igt20bTextBox.Text = backend.getText(0x6, 0xE63C);
                igt20cTextBox.Text = backend.getText(0x9, 0xE643);
                igt20dTextBox.Text = backend.getText(0x6, 0xE64D);
                igt21TextBox.Text = backend.getText(0x6, 0xE654);
                igt21bTextBox.Text = backend.getText(0xa, 0xE65B);
                igt22TextBox.Text = backend.getText(0x7, 0xE666);
                igt22bTextBox.Text = backend.getText(0x8, 0xE66E);
                igt22cTextBox.Text = backend.getText(0x6, 0xE677);
                igt22dTextBox.Text = backend.getText(0xa, 0xE67F);
                igt23TextBox.Text = backend.getText(0x4, 0xE6AC);
                igt23bTextBox.Text = backend.getText(0x6, 0xE6B1);
                igt24TextBox.Text = backend.getText(0x8, 0xE6B8);
                igt24bTextBox.Text = backend.getText(0xa, 0xE6C1);
                igt24cTextBox.Text = backend.getText(0xa, 0xE6CC);
                igt24dTextBox.Text = backend.getText(0x9, 0xE6D7);
                igt25TextBox.Text = backend.getText(0x9, 0xE6E1);
                igt25bTextBox.Text = backend.getText(0xa, 0xE6EB);
                igt25cTextBox.Text = backend.getText(0x7, 0xE6F6);
                igt25dTextBox.Text = backend.getText(0x6, 0xE6FE);
                igt26TextBox.Text = backend.getText(0x7, 0xE705);
                igt26bTextBox.Text = backend.getText(0x9, 0xE70D);
                igt26cTextBox.Text = backend.getText(0xa, 0xE717);
                igt26dTextBox.Text = backend.getText(0xa, 0xE722);
                igt27TextBox.Text = backend.getText(0x6, 0xE747);
                igt27bTextBox.Text = backend.getText(0xa, 0xE74E);
                igt27cTextBox.Text = backend.getText(0x9, 0xE759);
                igt29TextBox.Text = backend.getText(0x8, 0xE763);
                igt30TextBox.Text = backend.getText(0xa, 0xE76C);
                igt30bTextBox.Text = backend.getText(0xa, 0xE777);
                igt30cTextBox.Text = backend.getText(0xa, 0xE782);
                igt30dTextBox.Text = backend.getText(0xa, 0xE78D);
                igt31TextBox.Text = backend.getText(0x8, 0xE798);
                igt31bTextBox.Text = backend.getText(0xa, 0xE7A1);
                igt31cTextBox.Text = backend.getText(0x8, 0xE7AC);
                igt31dTextBox.Text = backend.getText(0x9, 0xE7B5);
                igt32TextBox.Text = backend.getText(0x9, 0xE7BF);
                igt32bTextBox.Text = backend.getText(0x9, 0xE7C9);
                igt32cTextBox.Text = backend.getText(0xa, 0xE7D3);
                igt32dTextBox.Text = backend.getText(0xa, 0xE7DE);
                igt33TextBox.Text = backend.getText(0x9, 0xE80E);
                igt33bTextBox.Text = backend.getText(0x8, 0xE818);
                igt33cTextBox.Text = backend.getText(0xa, 0xE821);
                igt33dTextBox.Text = backend.getText(0x5, 0xE82C);
                igt34TextBox.Text = backend.getText(0x8, 0xE833);
                igt34bTextBox.Text = backend.getText(0xa, 0xE83C);
                igt34cTextBox.Text = backend.getText(0xa, 0xE847);
                igt34dTextBox.Text = backend.getText(0xa, 0xE852);
                igt35TextBox.Text = backend.getText(0x9, 0xE85D);
                igt35bTextBox.Text = backend.getText(0xa, 0xE867);
                igt35cTextBox.Text = backend.getText(0xa, 0xE872);
                igt35dTextBox.Text = backend.getText(0xa, 0xE87D);
                igt36TextBox.Text = backend.getText(0xa, 0xE888);
                igt36bTextBox.Text = backend.getText(0x9, 0xE893);
                igt36cTextBox.Text = backend.getText(0x9, 0xE89D);
                igt36dTextBox.Text = backend.getText(0xa, 0xE8A7);
                igt37TextBox.Text = backend.getText(0x9, 0xE8B2);
                igt37bTextBox.Text = backend.getText(0x9, 0xE8BD);
                igt37cTextBox.Text = backend.getText(0x9, 0xE8C7);
                igt37dTextBox.Text = backend.getText(0x6, 0xE8D1);
                igt38TextBox.Text = backend.getText(0x8, 0xE8F0);
                igt38bTextBox.Text = backend.getText(0x8, 0xE8F9);
                igt38cTextBox.Text = backend.getText(0x9, 0xE902);
                igt38dTextBox.Text = backend.getText(0xa, 0xE90C);
                igt39TextBox.Text = backend.getText(0xa, 0xE917);
                igt39bTextBox.Text = backend.getText(0x8, 0xE922);
                igt39cTextBox.Text = backend.getText(0x8, 0xE92B);
                igt39dTextBox.Text = backend.getText(0x8, 0xE934);
                igt40TextBox.Text = backend.getText(0x9, 0xE93E);
                igt40bTextBox.Text = backend.getText(0x8, 0xE948);
                igt40cTextBox.Text = backend.getText(0xa, 0xE951);
                igt40dTextBox.Text = backend.getText(0x8, 0xE95C);
                igt41TextBox.Text = backend.getText(0x9, 0xE965);
                igt41bTextBox.Text = backend.getText(0x7, 0xE96F);
                igt41cTextBox.Text = backend.getText(0x9, 0xE977);
                igt41dTextBox.Text = backend.getText(0x7, 0xE981);
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
                igt46TextBox.Text = backend.getText(0x7, 0xEA43);
                igt46bTextBox.Text = backend.getText(0xa, 0xEA4B);
                igt47TextBox.Text = backend.getText(0x7, 0xEA56);
                igt48TextBox.Text = backend.getText(0xa, 0xEA5F);
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
                igt55TextBox.Text = backend.getText(0x9, 0xEAE3);
                igt55bTextBox.Text = backend.getText(0xa, 0xEAED);
                igt55cTextBox.Text = backend.getText(0x9, 0xEAF8);
                igt55dTextBox.Text = backend.getText(0x9, 0xEB02);
                igt56TextBox.Text = backend.getText(0x9, 0xEB0C);
                igt56bTextBox.Text = backend.getText(0x7, 0xEB16);
                igt56cTextBox.Text = backend.getText(0xa, 0xEB1E);
                igt56dTextBox.Text = backend.getText(0xa, 0xEB29);
                igt57TextBox.Text = backend.getText(0x7, 0xEB49);
                igt57bTextBox.Text = backend.getText(0x8, 0xEB51);
                igt57cTextBox.Text = backend.getText(0x5, 0xEB5A);
                igt58TextBox.Text = backend.getText(0x9, 0xEB61);
                igt58bTextBox.Text = backend.getText(0xa, 0xEB6B);
                igt58cTextBox.Text = backend.getText(0xa, 0xEB76);
                igt58dTextBox.Text = backend.getText(0x8, 0xEB81);
                igt59TextBox.Text = backend.getText(0x4, 0xEB8A);
                igt59bTextBox.Text = backend.getText(0x8, 0xEB8F);
                igt60TextBox.Text = backend.getText(0x8, 0xEB98);
                igt60bTextBox.Text = backend.getText(0x6, 0xEBA1);
                igt60cTextBox.Text = backend.getText(0x7, 0xEBA8);
                igt60dTextBox.Text = backend.getText(0x9, 0xEBB0);
                igt61TextBox.Text = backend.getText(0xa, 0xEBBA);
                igt61bTextBox.Text = backend.getText(0x7, 0xEBC5);
                igt61cTextBox.Text = backend.getText(0x7, 0xEBCD);
                igt61dTextBox.Text = backend.getText(0xa, 0xEBD5);
                igt62TextBox.Text = backend.getText(0x7, 0xEBE0);
                igt62bTextBox.Text = backend.getText(0xa, 0xEBE8);
                igt62cTextBox.Text = backend.getText(0x7, 0xEBF3);
                igt62dTextBox.Text = backend.getText(0x9, 0xEBFB);
                igt63TextBox.Text = backend.getText(0x9, 0xEC05);
                igt63bTextBox.Text = backend.getText(0x8, 0xEC0F);
                igt63cTextBox.Text = backend.getText(0xa, 0xEC18);
                igt64TextBox.Text = backend.getText(0x8, 0xEC4E);
                igt64bTextBox.Text = backend.getText(0x9, 0xEC57);
                igt64cTextBox.Text = backend.getText(0xa, 0xEC61);
                igt64dTextBox.Text = backend.getText(0x3, 0xEC6C);
                igt65TextBox.Text = backend.getText(0x9, 0xEC70);
                igt65bTextBox.Text = backend.getText(0x8, 0xEC7A);
                igt65cTextBox.Text = backend.getText(0xa, 0xEC83);
                igt66TextBox.Text = backend.getText(0xa, 0xEC8E);
                igt66bTextBox.Text = backend.getText(0x6, 0xEC99);
                igt66cTextBox.Text = backend.getText(0x8, 0xECA0);
                igt66dTextBox.Text = backend.getText(0xa, 0xECA9);
                igt67TextBox.Text = backend.getText(0x9, 0xECB4);
                igt67bTextBox.Text = backend.getText(0x8, 0xECBE);
                igt67cTextBox.Text = backend.getText(0x8, 0xECC7);
                igt67dTextBox.Text = backend.getText(0x9, 0xECD0);
                igt68TextBox.Text = backend.getText(0xa, 0xECDA);
                igt68bTextBox.Text = backend.getText(0x5, 0xECE5);
                igt68cTextBox.Text = backend.getText(0xa, 0xECEB);
                igt69TextBox.Text = backend.getText(0xa, 0xED11);
                igt69bTextBox.Text = backend.getText(0x8, 0xED1C);
                igt69cTextBox.Text = backend.getText(0xa, 0xED25);
                igt69dTextBox.Text = backend.getText(0x6, 0xED30);
                igt70TextBox.Text = backend.getText(0x8, 0xED37);
                igt70bTextBox.Text = backend.getText(0x7, 0xED40);
                igt70cTextBox.Text = backend.getText(0xa, 0xED48);
                igt70dTextBox.Text = backend.getText(0x4, 0xED53);
                igt71TextBox.Text = backend.getText(0xa, 0xED59);
                igt71bTextBox.Text = backend.getText(0x9, 0xED64);
                igt71cTextBox.Text = backend.getText(0x8, 0xED6E);
                igt71dTextBox.Text = backend.getText(0xa, 0xED77);
                igt72TextBox.Text = backend.getText(0x9, 0xED82);
                igt72bTextBox.Text = backend.getText(0x8, 0xED8C);
                igt72cTextBox.Text = backend.getText(0x9, 0xED95);
                igt72dTextBox.Text = backend.getText(0xa, 0xED9F);
                igt73TextBox.Text = backend.getText(0x8, 0xEDCF);
                igt73bTextBox.Text = backend.getText(0xa, 0xEDD8);
                igt73cTextBox.Text = backend.getText(0xb, 0xEDE3);
                igt74TextBox.Text = backend.getText(0x6, 0xEDEF);
                igt74bTextBox.Text = backend.getText(0x7, 0xEDF6);
                igt74cTextBox.Text = backend.getText(0x7, 0xEDFE);
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
                igt79cTextBox.Text = backend.getText(0x7, 0xEEC9);
                igt79dTextBox.Text = backend.getText(0xa, 0xEED1);
                igt80TextBox.Text = backend.getText(0x3, 0xEEDC);
                igt80bTextBox.Text = backend.getText(0x7, 0xEEE0);
                igt80cTextBox.Text = backend.getText(0x8, 0xEEE8);
                igt80dTextBox.Text = backend.getText(0xa, 0xEEF1);
                igt81TextBox.Text = backend.getText(0x8, 0xEEFC);
                igt81bTextBox.Text = backend.getText(0x8, 0xEF05);
                igt81cTextBox.Text = backend.getText(0x7, 0xEF0E);
                igt81dTextBox.Text = backend.getText(0x8, 0xEF16);
                igt82TextBox.Text = backend.getText(0xa, 0xEF40);
                igt83TextBox.Text = backend.getText(0x5, 0xEF4B);
                igt83bTextBox.Text = backend.getText(0x9, 0xEF51);
                igt84TextBox.Text = backend.getText(0x8, 0xEF5B);
                igt84bTextBox.Text = backend.getText(0x8, 0xEF64);
                igt85TextBox.Text = backend.getText(0x9, 0xEF6D);
                igt85bTextBox.Text = backend.getText(0x9, 0xEF77);
                igt86TextBox.Text = backend.getText(0x7, 0xEFA5);
                igt86bTextBox.Text = backend.getText(0xa, 0xEFAD);
                igt86cTextBox.Text = backend.getText(0xa, 0xEFB8);
                igt86dTextBox.Text = backend.getText(0xa, 0xEFC3);
                igt87TextBox.Text = backend.getText(0x9, 0xE5B1);
                igt87bTextBox.Text = backend.getText(0x9, 0xE5BB);
                igt87cTextBox.Text = backend.getText(0x7, 0xE5C5);
                igt87dTextBox.Text = backend.getText(0xa, 0xE5CD);

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
                backend.updateROMText(0x9, igt7TextBox.Text, 0xE40B);
                backend.updateROMText(0x8, igt7bTextBox.Text, 0xE415);
                backend.updateROMText(0xa, igt7cTextBox.Text, 0xE41E);
                backend.updateROMText(0xb, igt7dTextBox.Text, 0xE429);
                backend.updateROMText(0x5, igt8TextBox.Text, 0xE435);
                backend.updateROMText(0x5, igt9TextBox.Text, 0xE43C);
                backend.updateROMText(0x5, igt9bTextBox.Text, 0xE442);
                backend.updateROMText(0x7, igt9cTextBox.Text, 0xE448);
                backend.updateROMText(0x6, igt10TextBox.Text, 0xE450);
                backend.updateROMText(0x6, igt10bTextBox.Text, 0xE457);
                backend.updateROMText(0x8, igt10cTextBox.Text, 0xE45E);
                backend.updateROMText(0x8, igt11TextBox.Text, 0xE467);
                backend.updateROMText(0xa, igt11bTextBox.Text, 0xE471);
                backend.updateROMText(0xa, igt11cTextBox.Text, 0xE47C);
                backend.updateROMText(0x9, igt11dTextBox.Text, 0xE487);
                backend.updateROMText(0x8, igt12TextBox.Text, 0xE491);
                backend.updateROMText(0x8, igt12bTextBox.Text, 0xE49A);
                backend.updateROMText(0x8, igt12cTextBox.Text, 0xE4A3);
                backend.updateROMText(0x7, igt12dTextBox.Text, 0xE4AC);
                backend.updateROMText(0x8, igt13TextBox.Text, 0xE4B4);
                backend.updateROMText(0xa, igt13bTextBox.Text, 0xE4BD);
                backend.updateROMText(0x9, igt13cTextBox.Text, 0xE4C8);
                backend.updateROMText(0xa, igt13dTextBox.Text, 0xE4D2);
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
                backend.updateROMText(0x9, igt20TextBox.Text, 0xE632);
                backend.updateROMText(0x6, igt20bTextBox.Text, 0xE63C);
                backend.updateROMText(0x9, igt20cTextBox.Text, 0xE643);
                backend.updateROMText(0x6, igt20dTextBox.Text, 0xE64D);
                backend.updateROMText(0x6, igt21TextBox.Text, 0xE654);
                backend.updateROMText(0xa, igt21bTextBox.Text, 0xE65B);
                backend.updateROMText(0x7, igt22TextBox.Text, 0xE666);
                backend.updateROMText(0x8, igt22bTextBox.Text, 0xE66E);
                backend.updateROMText(0x6, igt22cTextBox.Text, 0xE677);
                backend.updateROMText(0xa, igt22dTextBox.Text, 0xE67F);
                backend.updateROMText(0x4, igt23TextBox.Text, 0xE6AC);
                backend.updateROMText(0x6, igt23bTextBox.Text, 0xE6B1);
                backend.updateROMText(0x8, igt24TextBox.Text, 0xE6B8);
                backend.updateROMText(0xa, igt24bTextBox.Text, 0xE6C1);
                backend.updateROMText(0xa, igt24cTextBox.Text, 0xE6CC);
                backend.updateROMText(0x9, igt24dTextBox.Text, 0xE6D7);
                backend.updateROMText(0x9, igt25TextBox.Text, 0xE6E1);
                backend.updateROMText(0xa, igt25bTextBox.Text, 0xE6EB);
                backend.updateROMText(0x7, igt25cTextBox.Text, 0xE6F6);
                backend.updateROMText(0x6, igt25dTextBox.Text, 0xE6FE);
                backend.updateROMText(0x7, igt26TextBox.Text, 0xE705);
                backend.updateROMText(0x9, igt26bTextBox.Text, 0xE70D);
                backend.updateROMText(0xa, igt26cTextBox.Text, 0xE717);
                backend.updateROMText(0xa, igt26dTextBox.Text, 0xE722);
                backend.updateROMText(0x6, igt27TextBox.Text, 0xE747);
                backend.updateROMText(0xa, igt27bTextBox.Text, 0xE74E);
                backend.updateROMText(0x9, igt27cTextBox.Text, 0xE759);
                backend.updateROMText(0x8, igt29TextBox.Text, 0xE763);
                backend.updateROMText(0xa, igt30TextBox.Text, 0xE76C);
                backend.updateROMText(0xa, igt30bTextBox.Text, 0xE777);
                backend.updateROMText(0xa, igt30cTextBox.Text, 0xE782);
                backend.updateROMText(0xa, igt30dTextBox.Text, 0xE78D);
                backend.updateROMText(0x8, igt31TextBox.Text, 0xE798);
                backend.updateROMText(0xa, igt31bTextBox.Text, 0xE7A1);
                backend.updateROMText(0x8, igt31cTextBox.Text, 0xE7AC);
                backend.updateROMText(0x9, igt31dTextBox.Text, 0xE7B5);
                backend.updateROMText(0x9, igt32TextBox.Text, 0xE7BF);
                backend.updateROMText(0x9, igt32bTextBox.Text, 0xE7C9);
                backend.updateROMText(0xa, igt32cTextBox.Text, 0xE7D3);
                backend.updateROMText(0xa, igt32dTextBox.Text, 0xE7DE);
                backend.updateROMText(0x9, igt33TextBox.Text, 0xE80E);
                backend.updateROMText(0x8, igt33bTextBox.Text, 0xE818);
                backend.updateROMText(0xa, igt33cTextBox.Text, 0xE821);
                backend.updateROMText(0x5, igt33dTextBox.Text, 0xE82C);
                backend.updateROMText(0x8, igt34TextBox.Text, 0xE833);
                backend.updateROMText(0xa, igt34bTextBox.Text, 0xE83C);
                backend.updateROMText(0xa, igt34cTextBox.Text, 0xE847);
                backend.updateROMText(0xa, igt34dTextBox.Text, 0xE852);
                backend.updateROMText(0x9, igt35TextBox.Text, 0xE85D);
                backend.updateROMText(0xa, igt35bTextBox.Text, 0xE867);
                backend.updateROMText(0xa, igt35cTextBox.Text, 0xE872);
                backend.updateROMText(0xa, igt35dTextBox.Text, 0xE87D);
                backend.updateROMText(0xa, igt36TextBox.Text, 0xE888);
                backend.updateROMText(0x9, igt36bTextBox.Text, 0xE893);
                backend.updateROMText(0x9, igt36cTextBox.Text, 0xE89D);
                backend.updateROMText(0xa, igt36dTextBox.Text, 0xE8A7);
                backend.updateROMText(0xa, igt37TextBox.Text, 0xE8B2);
                backend.updateROMText(0x9, igt37bTextBox.Text, 0xE8BD);
                backend.updateROMText(0x9, igt37cTextBox.Text, 0xE8C7);
                backend.updateROMText(0x6, igt37dTextBox.Text, 0xE8D1);
                backend.updateROMText(0x8, igt38TextBox.Text, 0xE8F0);
                backend.updateROMText(0x8, igt38bTextBox.Text, 0xE8F9);
                backend.updateROMText(0x9, igt38cTextBox.Text, 0xE902);
                backend.updateROMText(0xa, igt38dTextBox.Text, 0xE90C);
                backend.updateROMText(0xa, igt39TextBox.Text, 0xE917);
                backend.updateROMText(0x8, igt39bTextBox.Text, 0xE922);
                backend.updateROMText(0x8, igt39cTextBox.Text, 0xE92B);
                backend.updateROMText(0x8, igt39dTextBox.Text, 0xE934);
                backend.updateROMText(0x9, igt40TextBox.Text, 0xE93E);
                backend.updateROMText(0x8, igt40bTextBox.Text, 0xE948);
                backend.updateROMText(0xa, igt40cTextBox.Text, 0xE951);
                backend.updateROMText(0x8, igt40dTextBox.Text, 0xE95C);
                backend.updateROMText(0x9, igt41TextBox.Text, 0xE965);
                backend.updateROMText(0x7, igt41bTextBox.Text, 0xE96F);
                backend.updateROMText(0x9, igt41cTextBox.Text, 0xE977);
                backend.updateROMText(0x7, igt41dTextBox.Text, 0xE981);
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
                backend.updateROMText(0x7, igt46TextBox.Text, 0xEA43);
                backend.updateROMText(0xa, igt46bTextBox.Text, 0xEA4B);
                backend.updateROMText(0x7, igt47TextBox.Text, 0xEA56);
                backend.updateROMText(0xa, igt48TextBox.Text, 0xEA5F);
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
                backend.updateROMText(0x9, igt55TextBox.Text, 0xEAE3);
                backend.updateROMText(0xa, igt55bTextBox.Text, 0xEAED);
                backend.updateROMText(0x9, igt55cTextBox.Text, 0xEAF8);
                backend.updateROMText(0x9, igt55dTextBox.Text, 0xEB02);
                backend.updateROMText(0x9, igt56TextBox.Text, 0xEB0C);
                backend.updateROMText(0x7, igt56bTextBox.Text, 0xEB16);
                backend.updateROMText(0xa, igt56cTextBox.Text, 0xEB1E);
                backend.updateROMText(0xa, igt56dTextBox.Text, 0xEB29);
                backend.updateROMText(0x7, igt57TextBox.Text, 0xEB49);
                backend.updateROMText(0x8, igt57bTextBox.Text, 0xEB51);
                backend.updateROMText(0x5, igt57cTextBox.Text, 0xEB5A);
                backend.updateROMText(0x9, igt58TextBox.Text, 0xEB61);
                backend.updateROMText(0xa, igt58bTextBox.Text, 0xEB6B);
                backend.updateROMText(0xa, igt58cTextBox.Text, 0xEB76);
                backend.updateROMText(0x8, igt58dTextBox.Text, 0xEB81);
                backend.updateROMText(0x4, igt59TextBox.Text, 0xEB8A);
                backend.updateROMText(0x8, igt59bTextBox.Text, 0xEB8F);
                backend.updateROMText(0x8, igt60TextBox.Text, 0xEB98);
                backend.updateROMText(0x6, igt60bTextBox.Text, 0xEBA1);
                backend.updateROMText(0x7, igt60cTextBox.Text, 0xEBA8);
                backend.updateROMText(0x9, igt60dTextBox.Text, 0xEBB0);
                backend.updateROMText(0xa, igt61TextBox.Text, 0xEBBA);
                backend.updateROMText(0x7, igt61bTextBox.Text, 0xEBC5);
                backend.updateROMText(0x7, igt61cTextBox.Text, 0xEBCD);
                backend.updateROMText(0xa, igt61dTextBox.Text, 0xEBD5);
                backend.updateROMText(0x7, igt62TextBox.Text, 0xEBE0);
                backend.updateROMText(0xa, igt62bTextBox.Text, 0xEBE8);
                backend.updateROMText(0x7, igt62cTextBox.Text, 0xEBF3);
                backend.updateROMText(0x9, igt62dTextBox.Text, 0xEBFB);
                backend.updateROMText(0x9, igt63TextBox.Text, 0xEC05);
                backend.updateROMText(0x8, igt63bTextBox.Text, 0xEC0F);
                backend.updateROMText(0xa, igt63cTextBox.Text, 0xEC18);
                backend.updateROMText(0x8, igt64TextBox.Text, 0xEC4E);
                backend.updateROMText(0x9, igt64bTextBox.Text, 0xEC57);
                backend.updateROMText(0xa, igt64cTextBox.Text, 0xEC61);
                backend.updateROMText(0x3, igt64dTextBox.Text, 0xEC6C);
                backend.updateROMText(0x9, igt65TextBox.Text, 0xEC70);
                backend.updateROMText(0x8, igt65bTextBox.Text, 0xEC7A);
                backend.updateROMText(0xa, igt65cTextBox.Text, 0xEC83);
                backend.updateROMText(0xa, igt66TextBox.Text, 0xEC8E);
                backend.updateROMText(0x6, igt66bTextBox.Text, 0xEC99);
                backend.updateROMText(0x8, igt66cTextBox.Text, 0xECA0);
                backend.updateROMText(0xa, igt66dTextBox.Text, 0xECA9);
                backend.updateROMText(0x9, igt67TextBox.Text, 0xECB4);
                backend.updateROMText(0x8, igt67bTextBox.Text, 0xECBE);
                backend.updateROMText(0x8, igt67cTextBox.Text, 0xECC7);
                backend.updateROMText(0x9, igt67dTextBox.Text, 0xECD0);
                backend.updateROMText(0xa, igt68TextBox.Text, 0xECDA);
                backend.updateROMText(0x5, igt68bTextBox.Text, 0xECE5);
                backend.updateROMText(0xa, igt68cTextBox.Text, 0xECEB);
                backend.updateROMText(0xa, igt69TextBox.Text, 0xED11);
                backend.updateROMText(0x8, igt69bTextBox.Text, 0xED1C);
                backend.updateROMText(0xa, igt69cTextBox.Text, 0xED25);
                backend.updateROMText(0x6, igt69dTextBox.Text, 0xED30);
                backend.updateROMText(0x8, igt70TextBox.Text, 0xED37);
                backend.updateROMText(0x7, igt70bTextBox.Text, 0xED40);
                backend.updateROMText(0xa, igt70cTextBox.Text, 0xED48);
                backend.updateROMText(0x4, igt70dTextBox.Text, 0xED53);
                backend.updateROMText(0xa, igt71TextBox.Text, 0xED59);
                backend.updateROMText(0x9, igt71bTextBox.Text, 0xED64);
                backend.updateROMText(0x8, igt71cTextBox.Text, 0xED6E);
                backend.updateROMText(0xa, igt71dTextBox.Text, 0xED77);
                backend.updateROMText(0x9, igt72TextBox.Text, 0xED82);
                backend.updateROMText(0x8, igt72bTextBox.Text, 0xED8C);
                backend.updateROMText(0x9, igt72cTextBox.Text, 0xED95);
                backend.updateROMText(0xa, igt72dTextBox.Text, 0xED9F);
                backend.updateROMText(0x8, igt73TextBox.Text, 0xEDCF);
                backend.updateROMText(0xa, igt73bTextBox.Text, 0xEDD8);
                backend.updateROMText(0xb, igt73cTextBox.Text, 0xEDE3);
                backend.updateROMText(0x6, igt74TextBox.Text, 0xEDEF);
                backend.updateROMText(0x7, igt74bTextBox.Text, 0xEDF6);
                backend.updateROMText(0x7, igt74cTextBox.Text, 0xEDFE);
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
                backend.updateROMText(0x7, igt79cTextBox.Text, 0xEEC9);
                backend.updateROMText(0xa, igt79dTextBox.Text, 0xEED1);
                backend.updateROMText(0x3, igt80TextBox.Text, 0xEEDC);
                backend.updateROMText(0x7, igt80bTextBox.Text, 0xEEE0);
                backend.updateROMText(0x8, igt80cTextBox.Text, 0xEEE8);
                backend.updateROMText(0xa, igt80dTextBox.Text, 0xEEF1);
                backend.updateROMText(0x8, igt81TextBox.Text, 0xEEFC);
                backend.updateROMText(0x8, igt81bTextBox.Text, 0xEF05);
                backend.updateROMText(0x7, igt81cTextBox.Text, 0xEF0E);
                backend.updateROMText(0x8, igt81dTextBox.Text, 0xEF16);
                backend.updateROMText(0xa, igt82TextBox.Text, 0xEF40);
                backend.updateROMText(0x5, igt83TextBox.Text, 0xEF4B);
                backend.updateROMText(0x9, igt83bTextBox.Text, 0xEF51);
                backend.updateROMText(0x8, igt84TextBox.Text, 0xEF5B);
                backend.updateROMText(0x8, igt84bTextBox.Text, 0xEF64);
                backend.updateROMText(0x9, igt85TextBox.Text, 0xEF6D);
                backend.updateROMText(0x9, igt85bTextBox.Text, 0xEF77);
                backend.updateROMText(0x7, igt86TextBox.Text, 0xEFA5);
                backend.updateROMText(0xa, igt86bTextBox.Text, 0xEFAD);
                backend.updateROMText(0xa, igt86cTextBox.Text, 0xEFB8);
                backend.updateROMText(0xa, igt86dTextBox.Text, 0xEFC3);
                backend.updateROMText(0x9, igt87TextBox.Text, 0xE5B1);
                backend.updateROMText(0x9, igt87bTextBox.Text, 0xE5BB);
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
