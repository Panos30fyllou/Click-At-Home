using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string txt_path = Application.StartupPath + @"\user.txt";

        //κουμπί Σύνδεσης
        private void button2_Click(object sender, EventArgs e)
        {
            bool isEmail = Regex.IsMatch(textBox1.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Το πεδίο textbox3 είναι εμφανές μόνο όταν ο χρήστης έχει ξεχάσει τον κωδικό του. Το κουμπί button2 έχει δύο χρήσεις.
            //Όταν είναι εμφανές ο χρήστης πατάει το κουμπί επειδη έχει ζητήσει νέο κωδικό και θέλει να επιστρέψει στην αρχική σελίδα.
            //Όταν δεν είναι εμφανές ο χρήστης πατάει το κουμπί επειδή θέλει να συνδεθεί στο λογαριασμό του.
            if (textBox3.Visible == false)
            {
                //Αν τα πεδία είναι σωστά συμπληρωμένα πραγματοποιείται η σύνδεση και ανοίγει η νέα φόρμα , αλλιώς εμφανίζεται μήνυμα λάθους.
                if (isEmail == false || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                {
                    if (isEmail == false || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                        errorProvider1.SetError(textBox1, "Λανθασμένη μορφή e-mail.");
                    if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                        errorProvider2.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό.");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "");
                    errorProvider2.SetError(textBox2, "");
                    //νεα φορμα
                    string subMail = textBox1.Text.Substring(0, textBox1.Text.IndexOf("@"));
                    File.WriteAllText(txt_path, subMail);
                    Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    Close();
                }
            }
            else
            {
                //Αν τα πεδία είναι σωστά συμπληρωμένα πραγματοποιείται επιστροφή στην αρχική σελίδα , αλλιώς εμφανίζεται μήνυμα λάθους.
                if ((String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text)) || (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text)) || (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text)) || textBox2.Text != textBox3.Text)
                {
                    if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                        errorProvider1.SetError(textBox1, "Το πεδίο ενδέχεται να είναι κενό.");
                    if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                        errorProvider2.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό.");
                    if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
                        errorProvider3.SetError(textBox3, "Το πεδίο ενδέχεται να είναι κενό.");
                    if (textBox2.Text != textBox3.Text)
                        errorProvider3.SetError(textBox3, "Ο κωδικός δεν είναι ίδιος.");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "");
                    errorProvider2.SetError(textBox2, "");
                    errorProvider3.SetError(textBox3, "");
                    textBox3.Visible = false;
                    button2.Text = "Σύνδεση";
                    linkLabel1.Visible = true;
                    textBox1.Text = "E-mail";
                    textBox2.Text = "Κωδικός";
                    textBox3.Text = "Επιβεβαίωση κωδικού";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Μόλις πατήσει ο χρήστης τον σύνδεσμο για αλλαγή κωδικού γίνεται έλεγχος σωστής μορφής του e-mail ώστε να σταλθεί ο κωδικός επιβεβαίωσης 
            bool isEmail = Regex.IsMatch(textBox1.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Εάν η μορφή του e-mail είναι σωστή τότε εμφανίζονται και κρύβονται τα απαραίτητα πεδία , καθώς και ενημερωτικό μήνυμα για τον κωδικό επιβεβαίωσης.
            //Εάν δεν είνια σωστή τότε εμφανίζεται μήνυμα σφάλματος
            if (isEmail == true)
            {
                errorProvider1.SetError(textBox1, "");
                textBox3.Visible = true;
                linkLabel1.Visible = false;
                button2.Text = "Επιστροφή";
                textBox1.Text = "Κωδικός επιβεβαίωσης";
                textBox2.Text = "Νέος κωδικός";
                MessageBox.Show("'Εχει σταλθεί κωδικός επιβεβαίωσης στο e-mail σας.");
            }
            else
                errorProvider1.SetError(textBox1, "Λανθασμένη μορφή e-mail.");
        }

        //Το πεδίο textbox4 είναι εμφανές μόνο όταν ο χρήστης φτιάχνει νέο λογαριασμό. Το κουμπί button3 έχει δύο χρήσεις.
        //Όταν είναι εμφανές ο χρήστης πατάει το κουμπί επειδη θέλει να ολοκληρώσει τη διαδικασία δημιουργίας λογαριασμού.
        //Όταν δεν είναι εμφανές ο χρήστης πατάει το κουμπί επειδή θέλει να δημιουργήσει λογαριασμό.
        private void button3_Click(object sender, EventArgs e)
        {
            //Όταν το κουμπί δεν είναι εμφανές τότε εμφανίζονται τα απαραίτητα πεδία για τη δημιουργία λογαριασμού.
            if (textBox4.Visible == false)
            {
                textBox4.Visible = true;
                textBox3.Visible = true;
                button2.Visible = false;
                label2.Visible = true;
                label1.Visible = false;
                linkLabel1.Visible = false;
            }
            else
            {
                //Όταν δεν είναι εμφανές και ο χρήστης δεν έχει εισάγει σωστά τα στοιχεία του γίνονται έλεγχοι ώστε να βρεθεί το 
                //λάθος και εμφανίζονται τα κατάλληλα μηνύματα.
                bool isEmail = Regex.IsMatch(textBox1.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (isEmail == false || (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text)) || (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text)) || (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text)) || (String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrWhiteSpace(textBox4.Text)) || (textBox3.Text != textBox4.Text) )
                {
                    if (isEmail == false || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                        errorProvider1.SetError(textBox1, "Λανθασμένη μορφή e-mail.");
                    else
                        errorProvider1.SetError(textBox1, "");
                    //Πεδίο κωδικού
                    if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                        errorProvider2.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό.");
                    else
                        errorProvider2.SetError(textBox2, "");
                    //Πεδίο επανάλψης κωδικού
                    if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
                        errorProvider2.SetError(textBox3, "Το πεδίο ενδέχεται να είναι κενό.");
                    else
                        errorProvider3.SetError(textBox3, "");
                    //Πεδίο ονόματος χρήστη
                    if (String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrWhiteSpace(textBox4.Text))
                        errorProvider2.SetError(textBox4, "Το πεδίο ενδέχεται να είναι κενό.");
                    else
                        errorProvider4.SetError(textBox4, "");
                    if (textBox3.Text != textBox4.Text)
                        errorProvider4.SetError(textBox4, "Ο κωδικός δεν είναι ο ίδιος");
                }
                else
                {
                    //Εάν δεν βρεθεί λάθος τότε ο λογαριασμός δημιουργήται και ο χρήστης επιστρέφει στην αρχική σελίδα.
                    errorProvider1.SetError(textBox1, "");
                    errorProvider2.SetError(textBox2, "");
                    errorProvider3.SetError(textBox3, "");
                    errorProvider4.SetError(textBox4, "");

                    textBox4.Visible = false;
                    textBox3.Visible = false;
                    button2.Visible = true;
                    label2.Visible = false;
                    label1.Visible = true;
                    linkLabel1.Visible = true;
                    textBox1.Text = "E-mail";
                    textBox2.Text = "Κωδικός";
                }
            }

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "E-mail" || textBox1.Text == "Κωδικός επιβεβαίωσης")
                textBox1.Text = "";
        }

        //Εάν το κείμενο του textbox είναι το default κείμενο τότε θα διαγραφεί όταν πατήσει ο χρήστης πάνω του
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Κωδικός" || textBox2.Text == "Νέος κωδικός")
                textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Επιβεβαίωση κωδικού")
                textBox3.Text = "";
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "Όνομα χρήστη")
                textBox4.Text = "";
        }

        //Βοήθεια
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //τέλος
    }
}
