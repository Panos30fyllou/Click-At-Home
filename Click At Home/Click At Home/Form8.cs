using System;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            richTextBox1.Text = string.Empty;
        }

        //Προηγούμενη σελίδα
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
            richTextBox1.Text += "Κλήση στην επαφή έκτακτης ανάγκης ..." + Environment.NewLine;
            
            if ((textBox1.Text == "Όνομα" || (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))) && (textBox2.Text == "Τηλέφωνο" || (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))))
            {
                richTextBox1.Text += "Δεν έχει συμπληρωθεί επαφή έκτακτης κλήσης" + Environment.NewLine;
                errorProvider1.SetError(textBox1, "Το πεδίο ενδέχεται να είναι κενό");
                errorProvider1.SetError(textBox2, "Το πεδίο ενδέχεται να είναι κενό");
            }
            else if ((textBox2.Text == "Τηλέφωνο" || (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))))
            {
                richTextBox1.Text += "Δεν έχει συμπληρωθεί τηλέφωνο επικοινωνίας για την επαφή με όνομα : " + textBox1.Text + "." + Environment.NewLine;
                errorProvider1.SetError(textBox2, "Το πεδίο είναι κενό");
            }
            else if ((textBox1.Text == "Όνομα" || (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))))
            {
                richTextBox1.Text += "Γίνεται κλήση του αριθμού " + textBox2.Text + ". Δεν έχει προστεθεί όνομα" + Environment.NewLine;
                errorProvider1.SetError(textBox1, "Το πεδίο είναι κενό");
            }
            else
                richTextBox1.Text += "Κλήση της επαφής : " + textBox1.Text + " με αριθμό : " + textBox2.Text + "." + Environment.NewLine;
        }


        private void radioButton2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox3, "");
            errorProvider1.SetError(textBox4, "");
            richTextBox1.Text += "Κλήση στην επαφή έκτακτης ανάγκης ..." + Environment.NewLine;
            
            if ((textBox3.Text == "Όνομα" || (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))) && (textBox4.Text == "Τηλέφωνο" || (String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrWhiteSpace(textBox4.Text))))
            {
                richTextBox1.Text += "Δεν έχει συμπληρωθεί επαφή επιβλέποντος γιατρού." + Environment.NewLine + Environment.NewLine;
                errorProvider1.SetError(textBox3, "Το πεδίο ενδέχεται να είναι κενό");
                errorProvider1.SetError(textBox4, "Το πεδίο ενδέχεται να είναι κενό");
            }
            else if ((textBox4.Text == "Τηλέφωνο" || (String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrWhiteSpace(textBox4.Text))))
            {
                richTextBox1.Text += "Δεν έχει συμπληρωθεί τηλέφωνο επικοινωνίας για την επαφή επιβλέποντος γιατρού : " + textBox3.Text + "." + Environment.NewLine + Environment.NewLine;
                errorProvider1.SetError(textBox4, "Το πεδίο είναι κενό");
            }
            else if ((textBox3.Text == "Όνομα" || (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))))
            {
                richTextBox1.Text += "Γίνεται κλήση του αριθμού " + textBox4.Text + ". Δεν έχει προστεθεί όνομα" + Environment.NewLine + Environment.NewLine;
                errorProvider1.SetError(textBox3, "Το πεδίο είναι κενό");
            }
            else
                richTextBox1.Text += "Κλήση της επαφής : " + textBox3.Text + " με αριθμό : " + textBox4.Text + "." + Environment.NewLine + Environment.NewLine;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        { 
            richTextBox1.Text += "Ένας υπάλληλος του Δήμου θα έρθει σύντομα σε επικοινωνία μαζί σας." + Environment.NewLine + Environment.NewLine ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(75,200);
            label6.Text = rInt.ToString() + " bmp";
            if (rInt > 160)
            {
                Form9 f9 = new Form9();
                timer1.Enabled = false;
                f9.emergency = this.textBox2.Text;
                f9.doctor = this.textBox4.Text;
                this.Hide();
                f9.ShowDialog();
            }
            else if ( rInt > 128 && rInt <= 150)
                richTextBox1.Text += "Οι παλμοί σας είναι πάνω απο το επιθυμητό στόχο αλλά μέσα στα φυσιολογικά όρια." + Environment.NewLine + Environment.NewLine;
        }

        //Σε περίπτωση που τα πεδία έχυν το αρχικό τους περιεχόμενο όταν πατηθούν, αυτό θα σβηστεί
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Όνομα")
                textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Τηλέφωνο")
                textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Όνομα")
                textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Τηλέφωνο")
                textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startScreenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //τέλος
    }
}
