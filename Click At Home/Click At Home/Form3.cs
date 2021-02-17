using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Κάθε φορά που διαλέγει φίλτρο ,δηλαδή πατάει ένα radiobutton, η συνάρτηση radioButton_CheckedChanged ελέγχει μέσω της check_void() 
        //αν τα πεδία της διεύθυνσης έχουν συμπληρωθεί σωστά. Με τη σειρά της η check_void(), εάν τα στοιχεία είναι σωστά, καλεί την Image_change()
        // και εμφανίζει τυχαία τα εστιατόρια.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check_void();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check_void();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check_void();
        }

        //Η συνάρτηση check_void() χρησιμοποιείται για να ελέγξει εάν τα πεδία της διεύθυνσης είναι σωστά 
        //συμπληρωμένα και αν δεν είναι να εμφανίσει σχετικά μηνύματα λάθους.
        public void check_void()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider2.SetError(textBox2, "");
            errorProvider3.SetError(textBox3, "");

            //έλεγχος αν το πεδίο του αριθμού και του Τ.Κ είναι αριθμοί
            bool int1 = true, int2 = true;
            if (!Int32.TryParse(textBox2.Text, out int j)) 
                int1 = false;
            if (!Int32.TryParse(textBox3.Text, out int k))
                int2 = false;

            //Εάν εντοπιστεί κάποιο λάθος, η μεταβλητή check γίνεται false
            bool check = true;
            if ((String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text)) || (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text)) || (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text)) || int1 == false || int2 == false)
            {
                //Πεδίο διεύθυνσης
                if ((String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text)))
                {
                    errorProvider1.SetError(textBox1, "Το πεδίο ενδέχεται να είναι κενό.");
                    check = false;
                }
                else
                    errorProvider1.SetError(textBox1, "");

                //Πεδίο αριθμού
                if ((String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text)))
                {
                    errorProvider2.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό.");
                    check = false;
                }
                else if (int1 == false)
                {
                    errorProvider2.SetError(textBox2, "Το πεδίο πρέπει να περιέχει μόνο αριθμούς.");
                    check = false;
                }
                else
                    errorProvider2.SetError(textBox2, "");

                //Πεδίο T.K.
                if ((String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text)))
                {
                    errorProvider3.SetError(textBox3, "Το πεδίο ενδέχεται να είναι κενό.");
                    check = false;
                }
                else if (int2 == false)
                {
                    errorProvider3.SetError(textBox3, "Το πεδίο πρέπει να περιέχει μόνο αριθμούς.");
                    check = false;
                }
                else
                    errorProvider3.SetError(textBox3, "");
            }

            //Εάν η μεταβλητή check είναι true, δηλαδή δεν έχει εντοπιστεί κάποιο λάθος, θα κληθεί η συνάρτηση Image_change() ώστε να 
            //εμφανιστούν τα εστιατόρια, αλλιώς τα picturebox και τα label που περιέχουν τις πληροφορίες των εστιατορίων δεν θα είναι πλέον ορατά
            if (check == true)
                Image_change();
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        //
        public void Image_change()
        {
            string[] im = { "arab", "cof", "food", "fork", "gold", "home", "inst", "java", "leaf", "logo", "olive", "or", "red", "roka" };
            string[] label = { "Arabica House", "Coffee Shop", "FoodCircles", "ForkRoad", "GoldEatery", "Home Coffee", "Istanbul", "Java Bean", "Leaf Corner", "LeCafe", "Olive Garden", "Oregano", "Red Cafe", "Roka Restaurant" };

            int[] r = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            List<int> rand = new List<int>(r);

            Random rn = new Random();
            int rInt;

            for (int i = 0; i <= 5; i++)
            {
                do
                {
                    rInt = rn.Next(1, 14);
                } while (rand.Contains(rInt) == false);
                rand.Remove(rInt);
            }
            pictureBox1.BackgroundImage = (Image) Properties.Resources.ResourceManager.GetObject(im[rand[0]]);
            pictureBox2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[1]]);
            pictureBox3.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[2]]);
            pictureBox4.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[3]]);
            pictureBox5.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[4]]);
            pictureBox6.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(im[rand[5]]);

            label1.Text = label[rand[0]];
            label2.Text = label[rand[1]];
            label3.Text = label[rand[2]];
            label4.Text = label[rand[3]];
            label5.Text = label[rand[4]];
            label6.Text = label[rand[5]];

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
        }

        // Όταν πατηθεί κάποιο PictureBox , θα ανοίξει η επόμενη φόρμα και θα σταλθεί η εικόνα του PictureBox μαζί με το label του
        public Image pic_im;
        public string lab_txt;
        Form4 f4 = new Form4();
        string txt_path = Application.StartupPath + @"\user.txt";
        string add = Application.StartupPath + @"\address.txt";

        //Η συνάρτηση new_form() δέχεται σαν όρισμα ένα PictureBox και Label αν.αλογα με το Label που πατήθηκε
        //Στέλνει στη φόρμα 4 τη φωτογραφία και το όνομα του εστιατορίου που επέλεξε ο χρήστη,γράφει σε ένα αρχείο 
        //txt τη διέυθυνση του χρήστη και κλείνει τη φόρμα 3
        public void new_form(PictureBox pic, Label lab)
        {
            pic_im = pic.BackgroundImage;
            lab_txt = lab.Text;
            string address = textBox1.Text + " " + textBox2.Text;
            File.WriteAllText(add, address + Environment.NewLine);
            File.AppendAllText(add, textBox3.Text + Environment.NewLine);
            Hide();
            f4.pic_im = pic_im;
            f4.lab_txt = lab_txt;
            f4.ShowDialog();
        }

        //Όταν πατηθεί κάποιο label ο χρήστης επιθυμεί να μεταβεί σε νέα φόρμα με το συγκεκριμένο κατάστημα που έχει το label
        //Καλέιται η συνάρτηση new_form() ,η οποία δέχεται σαν όρισμα ένα PictureBox και Label αν.αλογα με το Label που πατήθηκε
        private void label1_Click(object sender, EventArgs e)
        {
            new_form(pictureBox1, label1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new_form(pictureBox2, label2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new_form(pictureBox3, label3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new_form(pictureBox4, label4);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new_form(pictureBox5, label5);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new_form(pictureBox6, label6);
        }

        //Κάθε φορά που αλλάζει το περιεχόμενο ενός textbox ,γίνεται έλεγχος για να εμφανιστεί το κατάλληλο μήνυμα λάθους ή αντίστοιχα να εξαφανιστεί.
        //Επίσης , εάν το κείμενο του textbox είναι το default κείμενο τότε θα διαγραφεί όταν πατήσει ο χρήστης πάνω του.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                errorProvider1.SetError(textBox1, "Το πεδίο ενδέχεται να είναι κενό.");
            else
                errorProvider1.SetError(textBox1, "");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool int1 = true;
            if (!Int32.TryParse(textBox2.Text, out int j))
                int1 = false;
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                errorProvider2.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό.");
            else if (int1 == false)
                errorProvider2.SetError(textBox2, "Το πεδίο πρέπει να περιέχει μόνο αριθμούς.");
            else
                errorProvider2.SetError(textBox2, "");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool int2 = true;
            if (!Int32.TryParse(textBox3.Text, out int k))
                int2 = false;
            if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
                errorProvider3.SetError(textBox3, "Το πεδίο ενδέχεται να είναι κενό.");
            else if (int2 == false)
                errorProvider3.SetError(textBox3, "Το πεδίο πρέπει να περιέχει μόνο αριθμούς.");
            else
                errorProvider3.SetError(textBox3, "");
        }

        //Έλεγχος εάν τα πεδία έχουν το αρχικό τους text να γίνουν κενά
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Διεύθυνση")
                textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Αριθμός")
                textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Τ.Κ.")
                textBox3.Text = "";
        }

        //Αρχική σελίδα
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        //Βοήθεια
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //Αποσύνδεση
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "C:\\Program Files (x86)\\Adobe\\Acrobat Reader DC\\Reader\\AcroRd32.exe";
            process.StartInfo.Arguments = "/A \"page=15\" \"Εγχειρίδιο Χρήστη.pdf";
            process.Start();
        }
        //τέλος
    }
}
