using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public string emergency { get; set; }
        public string doctor { get; set; }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //Ο πρώτος timer ξεκινάει με το που ανοίξει η φόρμα και διαρκεί ένα λεπτό
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            richTextBox1.Text += "Γίνεται κλήση ασθενοφόρου στη τοποθεσία σας." + Environment.NewLine;
            if (Int32.TryParse(emergency, out int i))
                richTextBox1.Text += "Γίνεται κλήση της επαφής έκτακτης ανάγκης με αριθμό: " + emergency + "." + Environment.NewLine;
            else
                richTextBox1.Text += "Δεν υπάρχει επαφή έκτακτης ανάγκης." + Environment.NewLine;
            richTextBox1.Text += "";
            timer2.Start();

        }
        // Ο δεύτερος timer ξεκινάει όταν τελιώνει ο πρώτος και διαρκεί μισό λεπτό
        int c = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text += "Το ασθενοφόρο είναι στη διαδρομή προς τη τοποθεσία σας.";
            if (c == 1)
            {
                timer1.Stop();
                timer2.Stop();
                Hide();
                Form8 f8 = new Form8();
                f8.ShowDialog();
                Close();
            }
            c++;
        }
        //Όταν ο χρήστης πατήσει το κουμπί "Οχι" θα επιστρέψει στην αρχική φόρμα
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            Close();
        }

        //κουμπί Ναι
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            timer1.Enabled = false;
            button3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;

            richTextBox1.Text += "Μόλις τελειώσετε , πατήστε το κουμπί 'Τέλος' για να επιστρέψετε στην αρχική σελίδα. " + Environment.NewLine;
            if (Int32.TryParse(emergency,out int i) )
                checkBox2.Visible = true;
            else
                richTextBox1.Text += "Δεν υπάρχει επαφή έκτακτης ανάγκης." + Environment.NewLine;
            if (Int32.TryParse(doctor, out int j))
                checkBox3.Visible = true;
            else
                richTextBox1.Text += "Δεν υπάρχει επαφή επιβλέποντος γιατρού." + Environment.NewLine;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text += "Γίνεται κλήση ασθενοφόρου στη τοποθεσία σας." + Environment.NewLine;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text += "Γίνεται κλήση της επαφής έκτακτης ανάγκης με αριθμό: " + emergency + "." + Environment.NewLine;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text += "Γίνεται κλήση της επαφής επιβλέποντος γιατρού με αριθμό: " + doctor + "." + Environment.NewLine;
        }

        //κουμπί τέλος
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            Close();
        }

    }
}
