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
            label4.Text = r.Next(20, 50).ToString() + " λεπτά.";
        }

        string txt_path = Application.StartupPath + @"\user.txt";
        string add = Application.StartupPath + @"\address.txt";
        //Αρχική σελίδα
        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(add, string.Empty);
            Hide();
            new Form2().ShowDialog();
            Close();
        }

        //Αποσύνδεση
        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txt_path, string.Empty);
            File.WriteAllText(add, string.Empty);
            Hide();
            new Form1().ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
