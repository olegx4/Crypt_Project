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
            NumberOfRows = Math.Round(NumberOfRows, MidpointRounding.AwayFromZero);
        }

        //'А','Б','В','Г','Ґ','Д','Е','Є','Ж','З',
        //'И','І','Ї','Й','К','Л','М','Н','О','П',
        //'Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ',
        //'Ь','Ю','Я'
        static String Alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" +
                          "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя" +
           "ABCDEFGHIJKLMNOPQRSTUVWXYZ"+"abcdefghijklmnopqrstuvwxyzЫыЭэЪъ, .-";
        static int FreeSpace = 40; //40
        static int LettersInLine = 11; //11 
        static string CryptCode = "3827594185493761"; //3827594185493761
        int[] array = new int[] { };
        int i = 0, j = 0;
        bool flag = false; // флаг для обновление строки с зашифрованным текстом
        public double NumberOfRows = Alphabet.Length / LettersInLine;
        Pen Pen = new Pen(Color.Green, 2);
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

        public void EncrypCharacter(int CryptNumb, char InputChar, ref char OutputChar)
        {
            int IndexOfLetter = 0;
            //if (InputChar != ' ')
            //{
                if (Alphabet.IndexOf(InputChar) != -1)
                {
                    IndexOfLetter = Alphabet.IndexOf(InputChar) + CryptNumb; //Криптографическая стойкость – способность криптографического алгоритма противостоять криптоанализу

                    if (IndexOfLetter >= Alphabet.Length)
                        IndexOfLetter = IndexOfLetter - Alphabet.Length;   //TODO дописать -1, если индекс не найден.
                    else if (IndexOfLetter < 0)
                        IndexOfLetter = Alphabet.Length + IndexOfLetter;
                    OutputChar = Alphabet[IndexOfLetter];
                }
                else
                {
                    MessageBox.Show("Символ " + InputChar + " не є символом вхідного алфавіту ");
                    OutputChar = InputChar;
                    //return;
                }
            //}
            //else
            //    OutputChar = ' ';

        }

        public void CryptString(string CryptCode, string InputString, ref string Output, bool decrypt)
        {
            int j = 0;
            char outputChar = ' ';
            for (int i = 0; i < InputString.Length; i++)
            {
                if (decrypt)
                {
                    EncrypCharacter(-array[j], InputString[i], ref outputChar);
                }
                else
                    EncrypCharacter(array[j], InputString[i], ref outputChar);
                if (j < array.Length - 1)
                {
                    j++;
                }
                else
                    j = 0;
               // if (outputChar != '-')
                    Output += outputChar;
                //else
                //    return;
            }
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //for (int j = 0; j < NumberOfRows; j++)
            //    for (int i = 0; i < LettersInLine; i++)
            //        TextRenderer.DrawText(e.Graphics, Alphabet[i + (LettersInLine * j)].ToString(), font,
            //        new Point(30 + (FreeSpace * i), 60 + (FreeSpace * j)), SystemColors.ControlDarkDark);
            //foreach (Alph) ;
            int f = 0, n = 0;
            foreach (char c in Alphabet) 
            {
                
                if (n == LettersInLine)
                {
                    f++;
                    n = 0;
                }
                TextRenderer.DrawText(e.Graphics, c.ToString(), font,
                    new Point(30 + (FreeSpace * n), 0 + (FreeSpace * f)), SystemColors.ControlDarkDark);
                n++;
            }
            
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            string InputText = textLine.Text;
            e.Graphics.DrawRectangle(Pen, 0, 0, 90, 30);
            if (InputText != "" /*&& InputText[i].ToString() != " "*/)
            {
                TextRenderer.DrawText(e.Graphics, InputText[i].ToString() + "\t + (" + array[j] + ")", font,
                   new Point(0, 0), SystemColors.ControlDarkDark);
                if (enCryptText.Text != "")
                    TextRenderer.DrawText(e.Graphics, enCryptText.Text[i].ToString(), font,
                       new Point(440, 0), SystemColors.ControlDarkDark);
            }
            for (int k = 0; k < Math.Abs(array[j]) - 1; k++)
            {
                e.Graphics.DrawRectangle(Pen, 70 + (40 * (k + 1)), 0, 27, 30);
                int index = 0;
                if (InputText != "" && Alphabet.IndexOf(InputText[i]) != -1)
                {
                    if (array[j] <= 0)
                    {
                        index = Alphabet.IndexOf(InputText[i]) - k - 1;
                        if (index <= 0)
                            index = index + Alphabet.Length;
                    }
                    else if (array[j] > 0)
                    {
                        index = Alphabet.IndexOf(InputText[i]) + k + 1;
                        if (index >= Alphabet.Length)
                            index = index - Alphabet.Length;
                    }

                    TextRenderer.DrawText(e.Graphics, Alphabet[index].ToString(), font,
                       new Point(70 + (40 * (k + 1)), 0), SystemColors.ControlDarkDark);
                }

            }
            e.Graphics.DrawRectangle(Pen, 440, 0, 27, 30);
            TextRenderer.DrawText(e.Graphics, CryptCode, font,
                    new Point(0, 30), SystemColors.ControlDarkDark);
        }

        private void encrypt_MouseClick(object sender, MouseEventArgs e)
        {
            string InputText = textLine.Text;
            string Output = "";
            bool decrypt = false;
            CryptString(CryptCode, InputText, ref Output, decrypt);
            enCryptText.Text = Output;
            refresh_stepEnCrypt();
        }

        private void textLine_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            refresh_stepEnCrypt(); //если входящий текст меняется - обнулить данные  для пошагового шифрования
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string InputText = enCryptText.Text;
            string Output = "";
            bool decrypt = true;
            CryptString(CryptCode, InputText, ref Output, decrypt);
            deCryptText.Text = Output;
        }

        void refresh_stepEnCrypt()
        {
            flag = true;
            i = 0;
            j = 0;
        }

        private void enCryptText_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
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
            if (i < InputText.Length)
            {
                EncrypCharacter(array[j], InputText[i], ref OutputChar);

                enCryptText.Text += OutputChar;
                //if (OutputChar != ' ')
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


