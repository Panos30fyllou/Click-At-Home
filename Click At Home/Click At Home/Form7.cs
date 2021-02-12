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

namespace ClickAtHome
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(20,50);
            label4.Text = rInt.ToString() + " λεπτά.";
        }


        string txt_path = "C:\\Users\\eyaki\\Desktop\\test\\user.txt";
        string add = "C:\\Users\\eyaki\\Desktop\\test\\address.txt";
        //Αρχική σελίδα
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            File.WriteAllText(add, string.Empty);
            this.Hide();
            f2.ShowDialog();

        }

        //Αποσύνδεση
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            File.WriteAllText(txt_path, string.Empty);
            File.WriteAllText(add, string.Empty);
            this.Hide();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
