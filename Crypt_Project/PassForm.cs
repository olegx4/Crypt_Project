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
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace Crypt_Project
{
    public partial class PassForm : Form
    {
        public PassForm()
        {
            InitializeComponent();
        }
        int count = 0;

        public void uninstall()
        {
            string app_name = Application.StartupPath + "\\" + Application.ProductName + ".exe";
            string bat_name = app_name + ".bat";

            string bat = "@echo off\n"
                + ":loop\n"
                + "del \"" + app_name + "\"\n"
                + "if Exist \"" + app_name + "\" GOTO loop\n"
                + "del %0";

            StreamWriter file = new StreamWriter(bat_name);
            file.Write(bat);
            file.Close();

            Process bat_call = new Process();
            bat_call.StartInfo.FileName = bat_name;
            bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            bat_call.StartInfo.UseShellExecute = true;
            bat_call.Start();

            
        }

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
                //MessageBox.Show(/*Environment.CurrentDirectory*/ Application.ExecutablePath);
                string chance = "";
                if (6 - count == 2 || 6 - count == 3 || 6 - count == 4)
                    chance = " спроби!";
                else if (6 - count == 5 || 6 - count == 0)
                    chance = " спроб!";
                else if(6 - count == 1)
                    chance = " спроба!";
                MessageBox.Show("Ви ввели неправильний пароль! Залишилось " + (6 - count) + chance);
            }


            if (count == 6)
            {
                uninstall();
                reboot r = new reboot();

                //r.halt(true, false); //мягкая перезагрузка
                Thread.Sleep(2000);
                //r.halt(true, true); //жесткая перезагрузка
                Application.Exit();
            }
            fs.Close();

            //sw.Close();

        }
    }
}
