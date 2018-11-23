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
        String Alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" +
                          "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
        Font font = new Font("Times New Roman", 15.0f);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int j = 0; j < 6 ; j++)
                for (int i=0; i<11; i++ )
                    TextRenderer.DrawText(e.Graphics, Alphabet[i + (11 * j)].ToString(), font,
                    new Point(10 + (30 * i), 10+(30 * j)), SystemColors.ControlDark);
        }
    }


}


