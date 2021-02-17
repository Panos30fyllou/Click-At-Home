using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form6 : Form
    {
        public int[] food_cnt { get; internal set; }
        public Form6()
        {
            InitializeComponent();
        }

        string txt_path = Application.StartupPath + @"\user.txt";
        string add = Application.StartupPath + @"\address.txt";

        //Εμφανίζει τη διεύθυνση και τον Τ.Κ. που είχε συμπληρώσει ο χρήστης στη φόρμα 3
        private void Form6_Load(object sender, EventArgs e)
        {
            StreamReader Textfile = new StreamReader(add);
            string line;
            int i = 0;
            while ((line = Textfile.ReadLine()) != null)
            {
                if(i==0){
                    textBox3.Text = line;
                    i++;
                }
                else
                    textBox4.Text = line;
            }
            Textfile.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //επειδή οι έλεγχοι τις φόρμας είναι πολλοί τους χωρίζω σε δύο if εντολές
            bool if1 = true, if2 = true;
            if ( String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text)){
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                    errorProvider1.SetError(textBox1, "Το πεδίο ενδέχεται να είναι κενό.");
                if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                    errorProvider2.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό.");
                if1 = false;
            }
            else{
                errorProvider1.SetError(textBox1, ""); 
                errorProvider2.SetError(textBox2, "");
            }

            if(!maskedTextBox1.MaskFull  || !maskedTextBox2.MaskFull || !maskedTextBox3.MaskFull){
                if (!maskedTextBox1.MaskFull)
                    errorProvider3.SetError(maskedTextBox1, "Το πεδίο ενδέχεται να μην είναι ολοκληρωμένο.");
                if (!maskedTextBox2.MaskFull)
                    errorProvider4.SetError(maskedTextBox2, "Το πεδίο ενδέχεται να μην είναι ολοκληρωμένο.");
                if (!maskedTextBox3.MaskFull)
                    errorProvider5.SetError(maskedTextBox3, "Το πεδίο ενδέχεται να μην είναι ολοκληρωμένο.");
                if2 = false;
            }
            else{
                errorProvider3.SetError(maskedTextBox1, "");
                errorProvider4.SetError(maskedTextBox2, "");
                errorProvider5.SetError(maskedTextBox3, "");
            }

            if (if1 == true && if2 == true){
                Hide();
                new Form7().ShowDialog();
                Close();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllText(add, string.Empty);
            Hide();
            new Form2().ShowDialog();
            Close();
        }

        //Αποσύνδεση
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllText(txt_path, string.Empty);
            File.WriteAllText(add, string.Empty);
            Hide();
            new Form1().ShowDialog();
            Close();
        }

        //Προηγούμενη σελίδα
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form5().ShowDialog();
            Close();
        }

        //Προσωπικοί έλεγχοι για κάθε πεδίο , οι οποίοι ελέγχουν με κάθε αλλαγή του περιεχομένου του πεδίου αν πληρεί τις προϋποθέσεις
        //πεδίο ονόματος
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                errorProvider1.SetError(textBox1, "Το πεδίο ενδέχεται να είναι κενό.");
            else
                errorProvider1.SetError(textBox1, "");
        }

        //πεδίο επιθέτου
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                errorProvider2.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό.");
            else
                errorProvider2.SetError(textBox2, "");
        }

        //πεδίο αριθμού κάρτας
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!maskedTextBox1.MaskFull)
                errorProvider3.SetError(maskedTextBox1, "Το πεδίο ενδέχεται να μην είναι ολοκληρωμένο.");
            else
                errorProvider3.SetError(maskedTextBox1, "");
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!maskedTextBox1.MaskFull)
                errorProvider3.SetError(maskedTextBox1, "Το πεδίο περιέχει μη αποδεκτούς χαρακτήρες.");
            else
                errorProvider3.SetError(maskedTextBox1, "");
        }

        //πεδίο κωδικού κάρτας 
        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!maskedTextBox2.MaskCompleted)
                errorProvider4.SetError(maskedTextBox2, "Το πεδίο ενδέχεται να μην είναι ολοκληρωμένο.");
            else
                errorProvider4.SetError(maskedTextBox2, "");
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!maskedTextBox2.MaskCompleted)
                errorProvider4.SetError(maskedTextBox2, "Το πεδίο περιέχει μη αποδεκτούς χαρακτήρες.");
            else
                errorProvider4.SetError(maskedTextBox2, "");
        }

        //πεδίο ημερομηνίας λήξης
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!maskedTextBox3.MaskCompleted)
                errorProvider5.SetError(maskedTextBox3, "Το πεδίο περιέχει μη αποδεκτούς χαρακτήρες.");
            else
                errorProvider5.SetError(maskedTextBox3, "");
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (!maskedTextBox3.MaskCompleted)
                errorProvider5.SetError(maskedTextBox3, "Το πεδίο ενδέχεται να μην είναι ολοκληρωμένο.");
            else
                errorProvider5.SetError(maskedTextBox3, "");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "C:\\Program Files (x86)\\Adobe\\Acrobat Reader DC\\Reader\\AcroRd32.exe";
            process.StartInfo.Arguments = "/A \"page=21\" \"Εγχειρίδιο Χρήστη.pdf";
            process.Start();
        }
        //τέλος
    }
}
