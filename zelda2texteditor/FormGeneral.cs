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
using System.IO;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormGeneral_Load(object sender, EventArgs e)
        {

            fs1.Seek(0xECA0, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt66cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECA9, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt66dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECB4, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt67TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECBE, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt67bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECC7, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt67cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECD0, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt67dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECDA, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt68TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECE5, SeekOrigin.Begin);
            while (x < 0x5)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt68bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xECEB, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt68cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED11, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt69TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED1C, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt69bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED25, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt69cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED30, SeekOrigin.Begin);
            while (x < 0x6)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt69dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED37, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt70TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED40, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt70bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED48, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt70cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED53, SeekOrigin.Begin);
            while (x < 0x4)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt70dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED59, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt71TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED64, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt71bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED6E, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt71cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED77, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt71dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED82, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt72TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED8C, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt72bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED95, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt72cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xED9F, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt72dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDCF, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt73TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDD8, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt73bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDE3, SeekOrigin.Begin);
            while (x < 0xb)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt73cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDEF, SeekOrigin.Begin);
            while (x < 0x6)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt74TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDF6, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt74bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEDFE, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt74cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE06, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt75TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE0E, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt75bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE16, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt75cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE1E, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt75dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE48, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt76TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE53, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt76bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE5D, SeekOrigin.Begin);
            while (x < 0x6)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt76cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE64, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt76dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE6F, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt77TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE78, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt77bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE80, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt77cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE8A, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt77dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE95, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt78TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEE9E, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt78bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEA8, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt78cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEB3, SeekOrigin.Begin);
            while (x < 0x5)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt78dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEB9, SeekOrigin.Begin);
            while (x < 0x6)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt79TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEC0, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt79bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEC9, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt79cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEED1, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt79dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEDC, SeekOrigin.Begin);
            while (x < 0x3)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt80TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEE0, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt80bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEE8, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt80cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEF1, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt80dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEEFC, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt81TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF05, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt81bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF0E, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt81cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF16, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt81dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF40, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt82TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF4B, SeekOrigin.Begin);
            while (x < 0x5)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt83TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF51, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt83bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF5B, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt84TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF64, SeekOrigin.Begin);
            while (x < 0x8)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt84bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF6D, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt85TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEF77, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt85bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFA5, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt86TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFAD, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt86bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFB8, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt86cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xEFC3, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt86dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5B1, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt87TextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5BB, SeekOrigin.Begin);
            while (x < 0x9)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt87bTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5C5, SeekOrigin.Begin);
            while (x < 0x7)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt87cTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Seek(0xE5CD, SeekOrigin.Begin);
            while (x < 0xa)
            {
                rctext = fs1.ReadByte().ToString("X");
                if (rctext.Length == 1)
                {
                    rctext = "0" + rctext;
                }
                temphex = rctext;
                decodeZText();
                if (textFlag == 0)
                {
                    zeldaAsciiRet += decodeZText();
                }
                x++;
            }
            igt87dTextBox.Text = zeldaAsciiRet;
            zeldaAsciiRet = "";
            x = 0;

            fs1.Close();
        }








        
        private void updateButton_Click(object sender, EventArgs e)
        {


            //1
            //these 3 values need set and the rest is history
            newgcString = igt1TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE390;
            writeByte();

            //call function, set value, call function
            newgcString = igt1bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE39B;
            writeByte();

            newgcString = igt1cTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xE3A3;
            writeByte();

            newgcString = igt2TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xE3A8;
            writeByte();

            newgcString = igt2bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE3AD;
            writeByte();

            newgcString = igt3TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE3B5;
            writeByte();

            newgcString = igt3bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE3BB;
            writeByte();

            newgcString = igt3cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3C3;
            writeByte();

            newgcString = igt4TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE3CE;
            writeByte();

            newgcString = igt4bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3D7;
            writeByte();

            newgcString = igt5TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3E2;
            writeByte();

            newgcString = igt5bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE3ED;
            writeByte();

            newgcString = igt6TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE3F8;
            writeByte();

            newgcString = igt6bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE402;
            writeByte();

            newgcString = igt7TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE40B;
            writeByte();

            newgcString = igt7bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE415;
            writeByte();

            newgcString = igt7cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE41E;
            writeByte();

            newgcString = igt7dTextBox.Text;
            newgcString = newgcString.PadRight(0xb);
            offset = 0xE429;
            writeByte();

            newgcString = igt8TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE435;
            writeByte();

            newgcString = igt9TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE43C;
            writeByte();

            newgcString = igt9bTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE442;
            writeByte();

            newgcString = igt9cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE448;
            writeByte();

            newgcString = igt10TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE450;
            writeByte();

            newgcString = igt10bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE457;
            writeByte();

            newgcString = igt10cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE45E;
            writeByte();

            newgcString = igt11TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE467;
            writeByte();

            newgcString = igt11bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE471;
            writeByte();

            newgcString = igt11cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE47C;
            writeByte();

            newgcString = igt11dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE487;
            writeByte();

            newgcString = igt12TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE491;
            writeByte();

            newgcString = igt12bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE49A;
            writeByte();

            newgcString = igt12cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE4A3;
            writeByte();

            newgcString = igt12dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE4AC;
            writeByte();

            newgcString = igt13TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE4B4;
            writeByte();

            newgcString = igt13bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE4BD;
            writeByte();

            newgcString = igt13cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE4C8;
            writeByte();

            newgcString = igt13dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE4D2;
            writeByte();

            newgcString = igt14TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE4F1;
            writeByte();

            newgcString = igt14bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5FC;
            writeByte();

            newgcString = igt14cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE506;
            writeByte();

            newgcString = igt14dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE50E;
            writeByte();

            newgcString = igt15TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE517;
            writeByte();

            newgcString = igt15bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE521;
            writeByte();

            newgcString = igt15cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE529;
            writeByte();

            newgcString = igt15dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE533;
            writeByte();

            newgcString = igt16TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE53B;
            writeByte();

            newgcString = igt16bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE545;
            writeByte();

            newgcString = igt16cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE550;
            writeByte();

            newgcString = igt16dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE559;
            writeByte();

            //-----

            newgcString = igt17TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE58E;
            writeByte();

            newgcString = igt17bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE597;
            writeByte();

            newgcString = igt17cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE5A0;
            writeByte();

            newgcString = igt17dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE5A9;
            writeByte();

            newgcString = igt18TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5D8;
            writeByte();

            newgcString = igt18bTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE5E2;
            writeByte();

            newgcString = igt18cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5E8;
            writeByte();

            newgcString = igt18dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE5F2;
            writeByte();

            newgcString = igt19TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE5FA;
            writeByte();

            newgcString = igt19bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE605;
            writeByte();

            newgcString = igt19cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE60F;
            writeByte();

            newgcString = igt19dTextBox.Text;
            newgcString = newgcString.PadRight(0xb);
            offset = 0xE618;
            writeByte();

            newgcString = igt20TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE632;
            writeByte();

            newgcString = igt20bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE63C;
            writeByte();

            newgcString = igt20cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE643;
            writeByte();

            newgcString = igt20dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE64D;
            writeByte();

            newgcString = igt21TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE654;
            writeByte();

            newgcString = igt21bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE65B;
            writeByte();

            newgcString = igt22TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE666;
            writeByte();

            newgcString = igt22bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE66E;
            writeByte();

            newgcString = igt22cTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE677;
            writeByte();

            newgcString = igt22dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE67F;
            writeByte();

            newgcString = igt23TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xE6AC;
            writeByte();

            newgcString = igt23bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE6B1;
            writeByte();

            newgcString = igt24TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE6B8;
            writeByte();

            newgcString = igt24bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE6C1;
            writeByte();

            newgcString = igt24cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE6CC;
            writeByte();

            newgcString = igt24dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE6D7;
            writeByte();

            newgcString = igt25TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE6E1;
            writeByte();

            newgcString = igt25bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE6EB;
            writeByte();

            newgcString = igt25cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE6F6;
            writeByte();

            newgcString = igt25dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE6FE;
            writeByte();

            newgcString = igt26TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE705;
            writeByte();

            newgcString = igt26bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE70D;
            writeByte();

            newgcString = igt26cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE717;
            writeByte();

            newgcString = igt26dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE722;
            writeByte();

            newgcString = igt27TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE747;
            writeByte();

            newgcString = igt27bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE74E;
            writeByte();

            newgcString = igt27cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE759;
            writeByte();

            newgcString = igt29TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE763;
            writeByte();

            //30.
            newgcString = igt30TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE76C;
            writeByte();

            newgcString = igt30bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE777;
            writeByte();

            newgcString = igt30cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE782;
            writeByte();

            newgcString = igt30dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE78D;
            writeByte();

            newgcString = igt31TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE798;
            writeByte();

            newgcString = igt31bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE7A1;
            writeByte();

            newgcString = igt31cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE7AC;
            writeByte();

            newgcString = igt31dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE7B5;
            writeByte();

            newgcString = igt32TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE7BF;
            writeByte();

            newgcString = igt32bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE7C9;
            writeByte();

            newgcString = igt32cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE7D3;
            writeByte();

            newgcString = igt32dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE7DE;
            writeByte();

            newgcString = igt33TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE80E;
            writeByte();

            newgcString = igt33bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE818;
            writeByte();

            newgcString = igt33cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE821;
            writeByte();

            newgcString = igt33dTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xE82C;
            writeByte();

            newgcString = igt34TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE833;
            writeByte();

            newgcString = igt34bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE83C;
            writeByte();

            newgcString = igt34cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE847;
            writeByte();

            newgcString = igt34dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE852;
            writeByte();

            newgcString = igt35TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE85D;
            writeByte();

            newgcString = igt35bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE867;
            writeByte();

            newgcString = igt35cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE872;
            writeByte();

            newgcString = igt35dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE87D;
            writeByte();

            newgcString = igt36TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE888;
            writeByte();

            newgcString = igt36bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE893;
            writeByte();

            newgcString = igt36cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE89D;
            writeByte();

            newgcString = igt36dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE8A7;
            writeByte();

            newgcString = igt37TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE8B2;
            writeByte();

            newgcString = igt37bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE8BD;
            writeByte();

            newgcString = igt37cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE8C7;
            writeByte();

            newgcString = igt37dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xE8D1;
            writeByte();

            newgcString = igt38TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE8F0;
            writeByte();

            newgcString = igt38bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE8F9;
            writeByte();

            newgcString = igt38cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE902;
            writeByte();

            newgcString = igt38dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE90C;
            writeByte();

            newgcString = igt39TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE917;
            writeByte();

            newgcString = igt39bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE922;
            writeByte();

            newgcString = igt39cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE92B;
            writeByte();

            newgcString = igt39dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE934;
            writeByte();

            newgcString = igt40TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE93E;
            writeByte();

            newgcString = igt40bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE948;
            writeByte();

            newgcString = igt40cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE951;
            writeByte();

            newgcString = igt40dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE95C;
            writeByte();

            newgcString = igt41TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE965;
            writeByte();

            newgcString = igt41bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE96F;
            writeByte();

            newgcString = igt41cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE977;
            writeByte();

            newgcString = igt41dTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE981;
            writeByte();

            newgcString = igt42TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE9AE;
            writeByte();

            newgcString = igt42bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9B7;
            writeByte();

            newgcString = igt42cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE9C2;
            writeByte();

            newgcString = igt42dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xE9CB;
            writeByte();

            newgcString = igt43TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9D4;
            writeByte();

            newgcString = igt43bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9DF;
            writeByte();

            newgcString = igt43cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9EA;
            writeByte();

            newgcString = igt43dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE9F5;
            writeByte();

            newgcString = igt44TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEA00;
            writeByte();

            //you are here

            newgcString = igt45TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA07;
            writeByte();

            newgcString = igt45bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEA12;
            writeByte();

            newgcString = igt45cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEA1C;
            writeByte();

            newgcString = igt45dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA25;
            writeByte();

            newgcString = igt46TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEA43;
            writeByte();

            newgcString = igt46bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA4B;
            writeByte();

            newgcString = igt47TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEA56;
            writeByte();

            newgcString = igt48TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA5F;
            writeByte();

            newgcString = igt49TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEA6A;
            writeByte();

            newgcString = igt49bTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEA74;
            writeByte();

            newgcString = igt50TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEA79;
            writeByte();

            newgcString = igt50bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEA7E;
            writeByte();

            newgcString = igt50cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEA89;
            writeByte();

            newgcString = igt51TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEA93;
            writeByte();

            newgcString = igt51bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEA9A;
            writeByte();

            newgcString = igt52TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEAA3;
            writeByte();

            newgcString = igt52bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEAAA;
            writeByte();

            newgcString = igt52cTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEAB3;
            writeByte();

            newgcString = igt53TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEAB9;
            writeByte();

            newgcString = igt53bTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEAC2;
            writeByte();

            newgcString = igt53cTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEAC7;
            writeByte();

            newgcString = igt54TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEACF;
            writeByte();

            newgcString = igt54bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEAD9;
            writeByte();

            newgcString = igt55TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEAE3;
            writeByte();

            newgcString = igt55bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEAED;
            writeByte();

            newgcString = igt55cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEAF8;
            writeByte();

            newgcString = igt55dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEB02;
            writeByte();

            newgcString = igt56TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEB0C;
            writeByte();

            newgcString = igt56bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEB16;
            writeByte();

            newgcString = igt56cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB1E;
            writeByte();

            newgcString = igt56dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB29;
            writeByte();

            newgcString = igt57TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEB49;
            writeByte();

            newgcString = igt57bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB51;
            writeByte();

            newgcString = igt57cTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xEB5A;
            writeByte();

            newgcString = igt58TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEB61;
            writeByte();

            newgcString = igt58bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB6B;
            writeByte();

            newgcString = igt58cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEB76;
            writeByte();

            newgcString = igt58dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB81;
            writeByte();

            newgcString = igt59TextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xEB8A;
            writeByte();

            newgcString = igt59bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB8F;
            writeByte();

            newgcString = igt60TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEB98;
            writeByte();

            newgcString = igt60bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEBA1;
            writeByte();

            newgcString = igt60cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBA8;
            writeByte();

            newgcString = igt60dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEBB0;
            writeByte();

            newgcString = igt61TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEBBA;
            writeByte();

            newgcString = igt61bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBC5;
            writeByte();

            newgcString = igt61cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBCD;
            writeByte();

            newgcString = igt61dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEBD5;
            writeByte();

            newgcString = igt62TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBE0;
            writeByte();

            newgcString = igt62bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEBE8;
            writeByte();

            newgcString = igt62cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEBF3;
            writeByte();

            newgcString = igt62dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEBFB;
            writeByte();

            newgcString = igt63TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEC05;
            writeByte();

            newgcString = igt63bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEC0F;
            writeByte();

            newgcString = igt63cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC18;
            writeByte();

            newgcString = igt64TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEC4E;
            writeByte();

            newgcString = igt64bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEC57;
            writeByte();

            newgcString = igt64cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC61;
            writeByte();

            newgcString = igt64dTextBox.Text;
            newgcString = newgcString.PadRight(0x3);
            offset = 0xEC6C;
            writeByte();

            newgcString = igt65TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEC70;
            writeByte();

            newgcString = igt65bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEC7A;
            writeByte();

            newgcString = igt65cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC83;
            writeByte();

            newgcString = igt66TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEC8E;
            writeByte();

            newgcString = igt66bTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEC99;
            writeByte();

            newgcString = igt66cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xECA0;
            writeByte();

            newgcString = igt66dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xECA9;
            writeByte();

            newgcString = igt67TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xECB4;
            writeByte();

            newgcString = igt67bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xECBE;
            writeByte();

            newgcString = igt67cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xECC7;
            writeByte();

            newgcString = igt67dTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xECD0;
            writeByte();

            newgcString = igt68TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xECDA;
            writeByte();

            newgcString = igt68bTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xECE5;
            writeByte();

            newgcString = igt68cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xECEB;
            writeByte();

            newgcString = igt69TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED11;
            writeByte();

            newgcString = igt69bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED1C;
            writeByte();

            newgcString = igt69cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED25;
            writeByte();

            newgcString = igt69dTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xED30;
            writeByte();

            newgcString = igt70TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED37;
            writeByte();

            newgcString = igt70bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xED40;
            writeByte();

            newgcString = igt70cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED48;
            writeByte();

            newgcString = igt70dTextBox.Text;
            newgcString = newgcString.PadRight(0x4);
            offset = 0xED53;
            writeByte();

            newgcString = igt71TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED59;
            writeByte();

            newgcString = igt71bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xED64;
            writeByte();

            newgcString = igt71cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED6E;
            writeByte();

            newgcString = igt71dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED77;
            writeByte();

            newgcString = igt72TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xED82;
            writeByte();

            newgcString = igt72bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xED8C;
            writeByte();

            newgcString = igt72cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xED95;
            writeByte();

            newgcString = igt72dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xED9F;
            writeByte();

            newgcString = igt73TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEDCF;
            writeByte();

            newgcString = igt73bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEDD8;
            writeByte();

            newgcString = igt73cTextBox.Text;
            newgcString = newgcString.PadRight(0xb);
            offset = 0xEDE3;
            writeByte();

            newgcString = igt74TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEDEF;
            writeByte();

            newgcString = igt74bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEDF6;
            writeByte();

            newgcString = igt74cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEDFE;
            writeByte();

            newgcString = igt75TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE06;
            writeByte();

            newgcString = igt75bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE0E;
            writeByte();

            newgcString = igt75cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE16;
            writeByte();

            newgcString = igt75dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE1E;
            writeByte();

            newgcString = igt76TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE48;
            writeByte();

            newgcString = igt76bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEE53;
            writeByte();

            newgcString = igt76cTextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEE5D;
            writeByte();

            newgcString = igt76dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE64;
            writeByte();

            newgcString = igt77TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEE6F;
            writeByte();

            newgcString = igt77bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEE78;
            writeByte();

            newgcString = igt77cTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEE80;
            writeByte();

            newgcString = igt77dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEE8A;
            writeByte();

            newgcString = igt78TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEE95;
            writeByte();

            newgcString = igt78bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEE9E;
            writeByte();

            newgcString = igt78cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEEA8;
            writeByte();

            newgcString = igt78dTextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xEEB3;
            writeByte();

            newgcString = igt79TextBox.Text;
            newgcString = newgcString.PadRight(0x6);
            offset = 0xEEB9;
            writeByte();

            newgcString = igt79bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEEC0;
            writeByte();

            newgcString = igt79cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEEC9;
            writeByte();

            newgcString = igt79dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEED1;
            writeByte();

            newgcString = igt80TextBox.Text;
            newgcString = newgcString.PadRight(0x3);
            offset = 0xEEDC;
            writeByte();

            newgcString = igt80bTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEEE0;
            writeByte();

            newgcString = igt80cTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEEE8;
            writeByte();

            newgcString = igt80dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEEF1;
            writeByte();

            newgcString = igt81TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEEFC;
            writeByte();

            newgcString = igt81bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF05;
            writeByte();

            newgcString = igt81cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEF0E;
            writeByte();

            newgcString = igt81dTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF16;
            writeByte();

            newgcString = igt82TextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEF40;
            writeByte();

            newgcString = igt83TextBox.Text;
            newgcString = newgcString.PadRight(0x5);
            offset = 0xEF4B;
            writeByte();

            newgcString = igt83bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEF51;
            writeByte();

            newgcString = igt84TextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF5B;
            writeByte();

            newgcString = igt84bTextBox.Text;
            newgcString = newgcString.PadRight(0x8);
            offset = 0xEF64;
            writeByte();

            newgcString = igt85TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEF6D;
            writeByte();

            newgcString = igt85bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xEF77;
            writeByte();

            newgcString = igt86TextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xEFA5;
            writeByte();

            newgcString = igt86bTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEFAD;
            writeByte();

            newgcString = igt86cTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEFB8;
            writeByte();

            newgcString = igt86dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xEFC3;
            writeByte();

            newgcString = igt87TextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5B1;
            writeByte();

            newgcString = igt87bTextBox.Text;
            newgcString = newgcString.PadRight(0x9);
            offset = 0xE5BB;
            writeByte();

            newgcString = igt87cTextBox.Text;
            newgcString = newgcString.PadRight(0x7);
            offset = 0xE5C5;
            writeByte();

            newgcString = igt87dTextBox.Text;
            newgcString = newgcString.PadRight(0xa);
            offset = 0xE5CD;
            writeByte();

            MessageBox.Show("Updated!", "In Game Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }





        private void writeByte()
        {
            FileStream fs2 = new FileStream(@filename, FileMode.Open, FileAccess.Write);
            i = newgcString.Length;
            x = 0;
            while (x < i)
            {
                zs[x] = newgcString[x].ToString();
                tempascii = zs[x];
                encodeZText();
                ZeldaHexReturn += encodeZText();
                x++;
            }

            //setup array
            zhrArray();

            q = 0;
            while (q < i)
            {
                zd[q] = int.Parse(zsw[q], System.Globalization.NumberStyles.HexNumber);
                zs_final[q] = zd[q].ToString();
                zb[q] = byte.Parse(zs_final[q]);
                q++;
            }

            fs2.Seek(offset, SeekOrigin.Begin);
            q = 0;
            while (q < i)
            {
                fs2.WriteByte(zb[q]);
                q++;
            }
            newgcString = "";
            ZeldaHexReturn = "";

            fs2.Close();
        }




        private void zhrArray()
        {
            //3 is smallest, 0xb is largest
            //send a value over as stringlength, denote it as i

            if (i > 0x2)
            {
                zsw[0] = ZeldaHexReturn[0].ToString() + ZeldaHexReturn[1].ToString();
                zsw[1] = ZeldaHexReturn[2].ToString() + ZeldaHexReturn[3].ToString();
                zsw[2] = ZeldaHexReturn[4].ToString() + ZeldaHexReturn[5].ToString();
            }
            if (i > 0x3)
            {
                zsw[3] = ZeldaHexReturn[6].ToString() + ZeldaHexReturn[7].ToString();
            }
            if (i > 0x4)
            {
                zsw[4] = ZeldaHexReturn[8].ToString() + ZeldaHexReturn[9].ToString();
            }
            if (i > 0x5)
            {
                zsw[5] = ZeldaHexReturn[10].ToString() + ZeldaHexReturn[11].ToString();
            }
            if (i > 0x6)
            {
                zsw[6] = ZeldaHexReturn[12].ToString() + ZeldaHexReturn[13].ToString();
            }
            if (i > 0x7)
            {
                zsw[7] = ZeldaHexReturn[14].ToString() + ZeldaHexReturn[15].ToString();
            }
            if (i > 0x8)
            {
                zsw[8] = ZeldaHexReturn[16].ToString() + ZeldaHexReturn[17].ToString();
            }
            if (i > 0x9)
            {
                zsw[9] = ZeldaHexReturn[18].ToString() + ZeldaHexReturn[19].ToString();
            }
            if (i > 0xa)
            {
                zsw[10] = ZeldaHexReturn[20].ToString() + ZeldaHexReturn[21].ToString();
            }
            if (i > 0xb)
            {
                zsw[11] = ZeldaHexReturn[22].ToString() + ZeldaHexReturn[23].ToString();
            }
        }
 




















    }
}
