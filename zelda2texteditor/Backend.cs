using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zelda2texteditor {

    /*
     * Backend class to handle common methods used to read/write the ROM.
     */
    class Backend {
        int textFlag = 0;

        public void getText(string path, TextBox texboxname, int length, int offset) {

            string romCodeString = "";
            string excitebikeAsciiOut = "";
            string tempHexString = "";
            int x = 0;
            FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);
            fileStream.Seek(offset, SeekOrigin.Begin);

            while (x < length) {
                romCodeString = fileStream.ReadByte().ToString("X");
                //if length is single digit add a 0 ( 1 now is 01)
                if (romCodeString.Length == 1) {
                    romCodeString = "0" + romCodeString;
                }
                tempHexString = romCodeString;

                decodeRomText(tempHexString);
                if (textFlag == 0) {
                    excitebikeAsciiOut += decodeRomText(tempHexString);
                }
                x++;

                texboxname.Text = excitebikeAsciiOut;
            }
            fileStream.Close();
        }

        public void updateROMText(string absoluteFilename, int length, TextBox textBox, int offset) {
            // TODO: Optimize, all of these steps are unneccesary
            string newZString = textBox.Text;

            Console.WriteLine("newEBString: " + newZString);

            newZString = newZString.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newZStringArray = new string[length];
            byte[] newZStringByteArray = new byte[length];
            int[] zDecimal = new int[length];
            string[] zFinal = new string[length];
            string[] zs = new string[length];

            int x = 0;
            while (x < length) {
                newZStringArray[x] = newZString[x].ToString();
                tempascii = newZStringArray[x];
                hexReturn += encodeRomText(tempascii);
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length) {
                zs[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            int q = 0;
            while (q < length) {
                zDecimal[q] = int.Parse(zs[q], System.Globalization.NumberStyles.HexNumber);
                zFinal[q] = zDecimal[q].ToString();
                newZStringByteArray[q] = byte.Parse(zFinal[q]);
                q++;
            }

            using (FileStream fileStream = new FileStream(@absoluteFilename, FileMode.Open, FileAccess.Write)) {
                fileStream.Seek(offset, SeekOrigin.Begin);
                q = 0;
                while (q < length) {
                    fileStream.WriteByte(newZStringByteArray[q]);
                    q++;
                }
            }
        }

        private string decodeRomText(string tempHexString) {
            string zeldaAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "34":
                    zeldaAscii += "?";
                    break;
                case "36":
                    zeldaAscii += "!";
                    break;
                case "9C":
                    zeldaAscii += ",";
                    break;
                case "CF":
                    zeldaAscii += ".";
                    break;
                case "D0":
                    zeldaAscii += "0";
                    break;
                case "D1":
                    zeldaAscii += "1";
                    break;
                case "D2":
                    zeldaAscii += "2";
                    break;
                case "D3":
                    zeldaAscii += "3";
                    break;
                case "D4":
                    zeldaAscii += "4";
                    break;
                case "D5":
                    zeldaAscii += "5";
                    break;
                case "D6":
                    zeldaAscii += "6";
                    break;
                case "D7":
                    zeldaAscii += "7";
                    break;
                case "D8":
                    zeldaAscii += "8";
                    break;
                case "D9":
                    zeldaAscii += "9";
                    break;
                case "DA":
                    zeldaAscii += "A";
                    break;
                case "DB":
                    zeldaAscii += "B";
                    break;
                case "DC":
                    zeldaAscii += "C";
                    break;
                case "DD":
                    zeldaAscii += "D";
                    break;
                case "DE":
                    zeldaAscii += "E";
                    break;
                case "DF":
                    zeldaAscii += "F";
                    break;
                case "E0":
                    zeldaAscii += "G";
                    break;
                case "E1":
                    zeldaAscii += "H";
                    break;
                case "E2":
                    zeldaAscii += "I";
                    break;
                case "E3":
                    zeldaAscii += "J";
                    break;
                case "E4":
                    zeldaAscii += "K";
                    break;
                case "E5":
                    zeldaAscii += "L";
                    break;
                case "E6":
                    zeldaAscii += "M";
                    break;
                case "E7":
                    zeldaAscii += "N";
                    break;
                case "E8":
                    zeldaAscii += "O";
                    break;
                case "E9":
                    zeldaAscii += "P";
                    break;
                case "EA":
                    zeldaAscii += "Q";
                    break;
                case "EB":
                    zeldaAscii += "R";
                    break;
                case "EC":
                    zeldaAscii += "S";
                    break;
                case "ED":
                    zeldaAscii += "T";
                    break;
                case "EE":
                    zeldaAscii += "U";
                    break;
                case "EF":
                    zeldaAscii += "V";
                    break;
                case "F0":
                    zeldaAscii += "W";
                    break;
                case "F1":
                    zeldaAscii += "X";
                    break;
                case "F2":
                    zeldaAscii += "Y";
                    break;
                case "F3":
                    zeldaAscii += "Z";
                    break;
                case "F4":
                    zeldaAscii += " ";
                    break;
                case "F5":
                    zeldaAscii += " ";
                    break;
                case "F6":
                    zeldaAscii += "-";
                    break;
                case "0E":
                    zeldaAscii += "@";
                    break;
                default:
                    zeldaAscii += " ";
                    textFlag = 1;
                    break;
            }

            return zeldaAscii;
        }

        public string encodeRomText(string tempascii) {
            string zeldaHex = "";
            tempascii = tempascii.ToUpper();

            switch (tempascii) {
                case "?":
                    zeldaHex += "34";
                    break;
                case "!":
                    zeldaHex += "36";
                    break;
                case ",":
                    zeldaHex += "9C";
                    break;
                case ".":
                    zeldaHex += "CF";
                    break;
                case "0":
                    zeldaHex += "D0";
                    break;
                case "1":
                    zeldaHex += "D1";
                    break;
                case "2":
                    zeldaHex += "D2";
                    break;
                case "3":
                    zeldaHex += "D3";
                    break;
                case "4":
                    zeldaHex += "D4";
                    break;
                case "5":
                    zeldaHex += "D5";
                    break;
                case "6":
                    zeldaHex += "D6";
                    break;
                case "7":
                    zeldaHex += "D7";
                    break;
                case "8":
                    zeldaHex += "D8";
                    break;
                case "9":
                    zeldaHex += "D9";
                    break;
                case "A":
                    zeldaHex += "DA";
                    break;
                case "B":
                    zeldaHex += "DB";
                    break;
                case "C":
                    zeldaHex += "DC";
                    break;
                case "D":
                    zeldaHex += "DD";
                    break;
                case "E":
                    zeldaHex += "DE";
                    break;
                case "F":
                    zeldaHex += "DF";
                    break;
                case "G":
                    zeldaHex += "E0";
                    break;
                case "H":
                    zeldaHex += "E1";
                    break;
                case "I":
                    zeldaHex += "E2";
                    break;
                case "J":
                    zeldaHex += "E3";
                    break;
                case "K":
                    zeldaHex += "E4";
                    break;
                case "L":
                    zeldaHex += "E5";
                    break;
                case "M":
                    zeldaHex += "E6";
                    break;
                case "N":
                    zeldaHex += "E7";
                    break;
                case "O":
                    zeldaHex += "E8";
                    break;
                case "P":
                    zeldaHex += "E9";
                    break;
                case "Q":
                    zeldaHex += "EA";
                    break;
                case "R":
                    zeldaHex += "EB";
                    break;
                case "S":
                    zeldaHex += "EC";
                    break;
                case "T":
                    zeldaHex += "ED";
                    break;
                case "U":
                    zeldaHex += "EE";
                    break;
                case "V":
                    zeldaHex += "EF";
                    break;
                case "W":
                    zeldaHex += "F0";
                    break;
                case "X":
                    zeldaHex += "F1";
                    break;
                case "Y":
                    zeldaHex += "F2";
                    break;
                case "Z":
                    zeldaHex += "F3";
                    break;
                case " ":
                    zeldaHex += "F4";
                    break;
                case "-":
                    zeldaHex += "F6";
                    break;
                case "@":
                    zeldaHex += "0E";
                    break;
                default:
                    // space
                    zeldaHex += "F4";
                    break;
            }

            return zeldaHex;
        }
    }
}
