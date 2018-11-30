using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypt_Project
{
    public partial class PassForm : Form
    {
        public PassForm()
        {
            InitializeComponent();
        }
        int count = 0;

        private void checkPassButton_Click(object sender, EventArgs e)
        {
            Crypt_Project.Form1 Form1 = new Form1();
            bool decrypt = false;
            //File.Create(@"info.txt");
            //File.Create(@"WRITE.txt");
            StreamReader fs = new StreamReader(@"Write.txt");
            //StreamWriter sw = new StreamWriter(@"WRITE.txt");
            string inputString = "";
            string outputString = "";
            string cryptCode = "456-3";
            string inputPass = textPassBox.Text;
            int check = 0;
            while ((inputString = fs.ReadLine()) != null)
            {

                Form1.CryptString(cryptCode, inputPass, ref outputString, decrypt);
                //sw.WriteLine(outputString);
                if (String.Compare(inputString, outputString) == 0)
                    check = 1;
                outputString = "";
            }

            if (check == 1)
            {
                this.Hide();
                Form1 start = new Form1();
                start.Show();
                fs.Close();
            }
            else
            {
                count++;
                string chance;
                if (6 - count == 2 || 6 - count == 3 || 6 - count == 4)
                    chance = " спроби!";
                else if(6 - count == 5)
                    chance = " спроб!";
                else
                    chance = " спроба!";
                MessageBox.Show("Ви ввели неправильний пароль! Залишилось " + (6 - count) + chance);
            }
            if (count == 6)
                this.Close();
            fs.Close();

            //sw.Close();

        }
    }
}
