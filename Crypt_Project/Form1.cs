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
            stringToArray(CryptCode, ref array);
            
        }

        //'А','Б','В','Г','Ґ','Д','Е','Є','Ж','З',
        //'И','І','Ї','Й','К','Л','М','Н','О','П',
        //'Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ',
        //'Ь','Ю','Я'
        static String Alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" +
                          "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
        static int FreeSpace = 40; //40
        static int LettersInLine = 11; //11 
        static string CryptCode = "-3-127594185493761"; //3827594185493761
        int[] array = new int[] { };
        int i = 0, j = 0;
        bool flag = false; // флаг для обновление строки с зашифрованным текстом
        int NumberOfRows = Alphabet.Length / LettersInLine;
        Font font = new Font("Times New Roman", 18.0f); //18
        

        public void stringToArray(string inputString, ref int[] array) // разделяет входящую строку на цифры и помещает в массив 
        {
            string buffer = "";
            List<int> list = new List<int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '-')
                {
                    i++;
                    buffer += inputString[i - 1];
                    buffer += inputString[i];
                }
                else
                {
                    buffer += inputString[i];
                }
                int number = Convert.ToInt32(buffer);
                list.Add(number);
                buffer = "";
            }
            array = list.ToArray();
        }

        public void EncryptString(string CryptCode, string InputString, ref string Output)
        {
            int[] array = new int[] { };
            stringToArray(CryptCode, ref array);
            int j = 0, IndexOfLetter = 0;
            for (int i = 0; i < InputString.Length; i++)
            {
                if (InputString[i] != ' ')
                {
                    IndexOfLetter = Alphabet.IndexOf(InputString[i]) + array[j]; //гггггггггггггггггггггггггггггггг
                    if (IndexOfLetter > Alphabet.Length)
                        IndexOfLetter = IndexOfLetter - Alphabet.Length;
                    else if (IndexOfLetter < 0)
                        IndexOfLetter = Alphabet.Length + IndexOfLetter;
                    Output += Alphabet[IndexOfLetter];
                    if (j < array.Length - 1)
                    {
                        j++;
                    }
                    else
                        j = 0;
                }
                else
                    Output += " ";
            }
        }

        public void EncrypCharacter(int CryptNumb, char InputChar, ref char OutputChar)
        {
            int j = 0, IndexOfLetter = 0;
            if (InputChar != ' ')
            {
                IndexOfLetter = Alphabet.IndexOf(InputChar) + CryptNumb; //гггггггггггггггггггггггггггггггг
                if (IndexOfLetter > Alphabet.Length)
                    IndexOfLetter = IndexOfLetter - Alphabet.Length;   //TODO дописать -1, если индекс не найден.
                else if (IndexOfLetter < 0)
                    IndexOfLetter = Alphabet.Length + IndexOfLetter;
                OutputChar = Alphabet[IndexOfLetter];
              
            }
            else
                OutputChar = ' ';

        }

        public void DecryptString(string CryptCode, string InputString, ref string Output)
        {
            int[] array = new int[] { };
            stringToArray(CryptCode, ref array);
            int j = 0, IndexOfLetter = 0;
            for (int i = 0; i < InputString.Length; i++)
            {
                if (InputString[i] != ' ')
                {
                    IndexOfLetter = Alphabet.IndexOf(InputString[i]) - array[j]; //гггггггггггггггггггггггггггггггг
                    if (IndexOfLetter > Alphabet.Length)
                        IndexOfLetter = IndexOfLetter - Alphabet.Length;
                    else if (IndexOfLetter < 0)
                        IndexOfLetter = Alphabet.Length + IndexOfLetter;
                    Output += Alphabet[IndexOfLetter];
                    if (j < array.Length - 1)
                    {
                        j++;
                    }
                    else
                        j = 0;
                }
                else
                    Output += " ";
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
            refresh_stepEnCrypt();
        }

        private void textLine_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            refresh_stepEnCrypt();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string InputText = enCryptText.Text;
            string Output = "";
            DecryptString(CryptCode, InputText, ref Output);
            deCryptText.Text = Output;
            //refresh_stepEnCrypt();
        }

        void refresh_stepEnCrypt()
        {
            flag = true;
            i = 0;
            j = 0;
        }

        private void stepEnCrypt_Click(object sender, EventArgs e)
        {
            string InputText = textLine.Text;
            char OutputChar = ' ';
            if (flag == true)
            {
                enCryptText.Text = "";
                flag = false;
            }
            if (i < InputText.Length )
            {
                EncrypCharacter(array[j], InputText[i], ref OutputChar);

                enCryptText.Text += OutputChar;
                if (OutputChar != ' ')
                    j++;
            }
            
            i++;
            if (i == InputText.Length)
            {
                MessageBox.Show("Виконано!");
                refresh_stepEnCrypt();
            }
            if (j > array.Length - 1)
            {
                j = 0;
            }
            
            
        }
    }


}


