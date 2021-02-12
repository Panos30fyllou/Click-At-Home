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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string txt_path = Application.StartupPath + @"\user.txt";

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader Textfile = new StreamReader(txt_path);
            string line;
            while ((line = Textfile.ReadLine()) != null)
            {
                linkLabel2.Text = "Καλωσήρθες , " + line;
            }
            Textfile.Close();
        }

        //Οn-line κατάστημα αγορών
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }

        //Αποσύνδεση
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.ShowDialog();
            File.WriteAllText(txt_path, string.Empty);
        }
        //Ηλεκτρονικό θερμόμετρο
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            Hide();
            f10.ShowDialog();
        }

        //Συσκευές σπιτιού
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            Hide();
            f11.ShowDialog();
        }

        //Ηλικιωμένοι
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            Hide();
            f8.ShowDialog();
        }

        //Πλάνο καραντίνας
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            Hide();
            f12.ShowDialog();
        }

        //Έξοδος από την εφαρμογή
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

