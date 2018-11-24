using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Crypt_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //'А','Б','В','Г','Ґ','Д','Е','Є','Ж','З',
        //'И','І','Ї','Й','К','Л','М','Н','О','П',
        //'Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ',
        //'Ь','Ю','Я'
        static String Alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" +
                          "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
        static int FreeSpace = 40; //40
        static int LettersInLine = 11; //11 
        static string CryptCode = "3827594185493761";
        int NumberOfRows = Alphabet.Length / LettersInLine;
        Font font = new Font("Times New Roman", 18.0f); //18

        public void EncryptString(string CryptCode, string InputString, ref string Output)
        {
            int IndexOfLetter;
            int j = 0;
            for (int i = 0; i < InputString.Length; i++)
            {
                if (InputString[i] != ' ')
                {
                    IndexOfLetter = Alphabet.IndexOf(InputString[i]) + (Convert.ToInt32(CryptCode[j])-48);
                    if (IndexOfLetter > Alphabet.Length)
                        IndexOfLetter = IndexOfLetter - Alphabet.Length;
                    Output += Alphabet[IndexOfLetter];
                    if (j < CryptCode.Length)
                    {
                        j++;
                    }
                    else
                        j = 0;
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int j = 0; j < NumberOfRows; j++)
                for (int i = 0; i < LettersInLine; i++)
                    TextRenderer.DrawText(e.Graphics, Alphabet[i + (LettersInLine * j)].ToString(), font,
                    new Point(10 + (FreeSpace * i), 60 + (FreeSpace * j)), SystemColors.ControlDarkDark, TextFormatFlags.WordBreak);
            string InputText = textLine.Text;
            for (int j = 0; j < NumberOfRows; j++)
                TextRenderer.DrawText(e.Graphics, InputText, font,
                    new Point(0, 0), SystemColors.ControlDarkDark, TextFormatFlags.WordBreak);
                TextRenderer.DrawText(e.Graphics, CryptCode, font,
                        new Point(0, 30), SystemColors.ControlDarkDark);
        }
       
        private void encrypt_MouseClick(object sender, MouseEventArgs e)
        {
            string InputText = textLine.Text;
            string Output = "";
            EncryptString(CryptCode, InputText, ref Output);
            enCryptText.Text = Output;
        }

        private void textLine_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }


}


