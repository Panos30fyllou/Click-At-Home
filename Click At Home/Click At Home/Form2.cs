using System;
using System.Collections.Generic;
using System.IO;
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
                linkLabel2.Text = "Καλωσήρθες, " + line;
            }
            Textfile.Close();
        }

        //Οn-line κατάστημα αγορών
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Close();
        }

        //Αποσύνδεση
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        //Ηλεκτρονικό θερμόμετρο
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
            Close();
        }

        //Συσκευές σπιτιού
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            Form11 f11 = new Form11();
            f11.ShowDialog();
            Close();
        }

        //Ηλικιωμένοι
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            Close();
        }

        //Πλάνο καραντίνας
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
            Form12 f12 = new Form12();
            f12.ShowDialog();
            Close();
        }

        //Έξοδος από την εφαρμογή
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

