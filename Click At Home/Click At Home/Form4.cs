using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Image pic_im { get; set; }
        public string lab_txt { get; set; }

        string[] lb_food = { "Τσάι Bubble", "Μπέργκερ", "Cappucinno", "Κρύα σοκολάτα", "Churos", "Φραπές", "Ντολμαδάκια", "Τηγανιτό ψάρι", "Ελληνικός", "Ζημαρικά", "Πίτσα", "Σούπα", "Σουβλάκι", "Tacos", "Τσάι" };
        double[] price = { 3.50, 7.00, 4.00, 4.00, 6.00, 3.50, 8.00, 8.90, 3.00, 5.50, 10.00, 5.00, 2.30, 6.00, 3.00 };
        int[] food_cnt = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        //Όταν φορτώσει η φόρμα θα εμφανιστεί η φωτογραφία και το όνομα του επιλεγμένου καταστήματος στη πάνω αριστερή γωνία
        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = this.pic_im;
            label7.Text = this.lab_txt;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Image_change()
        {
            string[] im = { "bub", "burger", "cap", "choc", "churos", "cof", "dol", "fish", "greek", "pasta", "pizza", "soup", "souvlaki", "tacos", "tea" };

            int[] r = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            List<int> rand = new List<int>(r);

            Random rn = new Random();
            int rInt;

            for (int i = 0; i <= 6; i++) {
                do {
                    rInt = rn.Next(0, 14);
                } while (rand.Contains(rInt) == false);
                rand.Remove(rInt);
            }

            pictureBox1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[0]]);
            pictureBox2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[1]]);
            pictureBox3.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[2]]);
            pictureBox4.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[3]]);
            pictureBox5.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[4]]);
            pictureBox6.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[5]]);

            //Εμφανίζει την ονομασία του κάθε προϊόντος
            label1.Text = lb_food[rand[0]];
            label2.Text = lb_food[rand[1]];
            label3.Text = lb_food[rand[2]];
            label4.Text = lb_food[rand[3]];
            label5.Text = lb_food[rand[4]];
            label6.Text = lb_food[rand[5]];

            //Εμφανίζει τη τιμή του κάθε προϊόντος
            label8.Text = price[rand[0]].ToString() + " €";
            label9.Text = price[rand[1]].ToString() + " €";
            label10.Text = price[rand[2]].ToString() + " €";
            label11.Text = price[rand[3]].ToString() + " €";
            label12.Text = price[rand[4]].ToString() + " €";
            label13.Text = price[rand[5]].ToString() + " €";

            //Εμφανίζει τη ποσότητα του κάθε προϊόντος
            numericUpDown1.Value = food_cnt[rand[0]];
            numericUpDown2.Value = food_cnt[rand[1]];
            numericUpDown3.Value = food_cnt[rand[2]];
            numericUpDown4.Value = food_cnt[rand[3]];
            numericUpDown5.Value = food_cnt[rand[4]];
            numericUpDown6.Value = food_cnt[rand[5]];
        }

        //Η συνάστηρη Food_Count χρησιμοποιείται για να αποθηκεύει τις επιλογές του χρήστη όταν αυτός επιλέγει ένα συγκεκριμένο φαγητό.
        //Το κάθε κελί της λίστας food_cnt αντιστοιχεί στη ποσότητα ενός από τις 15 επιλογές φαγητού.
        //Η συνάρτηση καλείται κάθε φορά που υπάρχει αλλαγή σε ένα numericUpDown και η συνάρτηση παίρνει ως όρισμα το numericUpDown και το αντίστοιχο label  
        //Μόλις γίνει η σύγκριση του text του label με κάθε κελί της λίστας lb_food,που περιέχει τα ονόματα όλων των φαγητών, και βρεθεί το κελί της 
        //λίστας που αντιστοιχεί στο label γίνεται έλεγχος γιατο αν το αντίστοιχο κελί της λίστας food_cnt είναι 0.
        //Αν είναι 0 τότε παίρνει απλά τη τιμή του numericUpDown , αλλιώς προστήθεται η τιμή του. 
        public void Food_Count(Label lab, NumericUpDown num)
        {
            for (int i = 0; i <= 14; i++)
                if (lab.Text == lb_food[i])
                    food_cnt[i] = (int)num.Value;
            //
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Image_change();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Image_change();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Image_change();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Image_change();
        }

        //Κάθε φορά που ο χρήστης θα αλλάζει τη ποσότητα ενός προϊόντος θα ενημερώνεται η λίστα food_cnt
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Food_Count(label1, numericUpDown1);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Food_Count(label2, numericUpDown2);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Food_Count(label3, numericUpDown3);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Food_Count(label4, numericUpDown4);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            Food_Count(label5, numericUpDown5);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            Food_Count(label6, numericUpDown6);
        }

        string txt_path = Application.StartupPath + @"\user.txt";
        string add = Application.StartupPath + @"\address.txt";
        //Αρχική σελίδα 
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllText(add, string.Empty);
            Hide();
            Form f2 = new Form2();
            f2.Show();
            Close();
        }

        // προηγούμενη σελίδα
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            File.WriteAllText(add, string.Empty);
            Hide();
            Form f3 = new Form3();
            f3.ShowDialog();
            Close();
        }

        //Αποσύνδεση
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllText(txt_path, string.Empty);
            File.WriteAllText(add, string.Empty);
            Hide();
            Form f1 = new Form1();
            f1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = false;
            int i = 0;
            do {
                if (food_cnt[i] > 0)
                    check = true;
                i++;
            } while (i <= 14 && check == false);
            if (check == true) {
                Form5 f5 = new Form5();
                f5.food_cnt = food_cnt;
                Hide();
                f5.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Το καλάθι σας είναι άδειο. Παρακαλώ επιλέξτε προϊόν.", "Άδειο καλάθι");
        }
    //τέλος
    }
}
