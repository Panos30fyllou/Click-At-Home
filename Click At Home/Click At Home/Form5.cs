using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public int[] food_cnt { get; internal set; }

        string[] lb_food = { "Τσάι Bubble", "Μπέργκερ", "Cappucinno", "Κρύα σοκολάτα", "Churos", "Φραπές", "Ντολμαδάκια", "Τηγανιτό ψάρι", "Ελληνικός", "Ζημαρικά", "Πίτσα", "Σούπα", "Σουβλάκι", "Tacos", "Τσάι" };
        double[] price = { 3.50, 7.00, 4.00, 4.00, 6.00, 3.50, 8.00, 8.90, 3.00, 5.50, 10.00, 5.00, 2.30, 6.00, 3.00 };
        double total;

        private void Form5_Load(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i <= 14; i++){
                if (food_cnt[i] > 0)
                    counter++;
            }
            total = New_Line();
            textBoxTotal.Location = new Point(textBox2.Location.X, numericUpDown1.Location.Y + counter * 34);
            textBoxTotal.Text = total.ToString() + " €";
            label5.Location = new Point(label5.Location.X, numericUpDown1.Location.Y + counter * 35);

            label6.Location = new Point(label6.Location.X, textBox1.Location.Y + counter * 34 + 50);
            richTextBox1.Location = new Point(richTextBox1.Location.X, textBox1.Location.Y + counter * 34 + 90);
            pictureBox1.Location = new Point(pictureBox1.Location.X, textBox1.Location.Y + counter * 34 + 240);
            button1.Location = new Point(button1.Location.X, pictureBox1.Location.Y);
        }

        public double New_Line()
        {
            int counter = 0;
            double total = 0;
            for (int i = 0; i <= 14; i++) {
                if (food_cnt[i] > 0 && counter > 0) {
                    //new line
                    new_TextBox(textBox1, counter * 34, lb_food[i]);
                    new_numericUpDown(numericUpDown1, counter * 34, food_cnt[i]);
                    new_TextBox(textBox2, counter * 34, (food_cnt[i] * price[i]).ToString());
                    total = total + food_cnt[i] * price[i];
                    counter++;
                }
                //Μέσα στην else if θα μπει μόνο στη πρώτη επανάληψη ώστε να γεμίσει τη πρώτη σειρά που υπαρχει ήδη στη φόρμα
                else if (food_cnt[i] > 0 && counter == 0) {
                    textBox1.Text = lb_food[i];
                    numericUpDown1.Value = food_cnt[i];
                    textBox2.Text = (food_cnt[i] * price[i]).ToString();
                    total = total + food_cnt[i] * price[i];
                    counter++;
                }
            }
            return total;
        }

        public void new_numericUpDown(NumericUpDown numUpDown, int W, int value)
        {
            NumericUpDown num = new NumericUpDown();
            Controls.Add(num);
            num.Location = new Point(numUpDown.Location.X, numUpDown.Location.Y + W);
            num.Size = numUpDown.Size;
            num.Cursor = numUpDown.Cursor;
            num.Font = new Font(numUpDown.Font.Name, numUpDown.Font.Size, FontStyle.Regular);
            num.Value = value;
            num.ValueChanged += new EventHandler(num_click);
            num.Name = "numericUpDown" + (W / 34 + 1).ToString();
            num.Show();
        }

        int cnt = 3;
        //Η πρώτη λίστα περιέχει όλα τα textbox που έχουν δημιουργηθεί και η δεύτερη όλα τα ονόματα των textbox
        List<TextBox> textbox_list = new List<TextBox>(); // πρώτη λίστα
        List<String> textbox = new List<String>();   //δεύτερη λίστα

        public void new_TextBox(TextBox txt, int W, string text)
        {
            TextBox box = new TextBox();
            box.Name = "textBox" + cnt.ToString();
            textbox_list.Add(box);
            textbox.Add(box.Name);
            Controls.Add(box);
            box.Location = new Point(txt.Location.X, txt.Location.Y + W);
            box.Size = txt.Size;
            box.Font = new Font(txt.Font.Name, txt.Font.Size, FontStyle.Regular);
            box.Text = text;
            box.Enabled = false;
            box.Show();
            cnt++;
        }

        public void num_click(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            //ο αριθμός του numericUpDown που πατήθηκε
            string name = (num.Name).Substring((num.Name).Length - 1);
            int number = Int32.Parse(name);
            //οι παρακάτω μεταβλητές θα κρατάνε σε κάθε επανάληξη τον αριθμό κάθε textbox που δημιουργήθηκε
            string nametxt;
            int numtxt;
            //η παρακάτω μεταβλητή είναι το περιεχόμενο του textbox που προηγήτε του numericUpDown που πατήθηκε
            string text;
            for (int i = 0; i < textbox_list.Count; i++){
                nametxt = (textbox[i]).Substring((textbox[i]).Length - 1);
                numtxt = Int32.Parse(nametxt);
                if ((number * 2 - 1) == numtxt){
                    text = textbox_list[i].Text;
                    int j = 0;
                    bool check = false;
                    do{
                        if (text == lb_food[j]){
                            total = total - price[j] * food_cnt[j] + price[j] * (Decimal.ToInt32(num.Value));
                            food_cnt[j] = Decimal.ToInt32(num.Value);
                            textbox_list[i + 1].Text = (price[j] * (Decimal.ToInt32(num.Value))).ToString();
                            textBoxTotal.Text = total.ToString() + " €";
                            check = true;
                        }
                        j++;
                    } while (check == false && j <= 14);
                }

            }
            //τελος
        }


        string txt_path = Application.StartupPath + @"\user.txt";
        string add = Application.StartupPath + @"\address.txt";
        //Αρχική σελίδα
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllText(add, string.Empty);
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        //Αποσύνδεση
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllText(txt_path, string.Empty);
            File.WriteAllText(add, string.Empty);
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        //Βοήθεια
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //Σε περίπτωση που πατηθεί το numericUpDown της πρώτης σειράς , η οποία δεν εμφανίζεται δυναμκά στη φόρμα
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int j = 0;
            bool check = false;
            do{
                if (text == lb_food[j]){
                    total = total - price[j] * food_cnt[j] + price[j] * (Decimal.ToInt32(numericUpDown1.Value));
                    food_cnt[j] = Decimal.ToInt32(numericUpDown1.Value);
                    textBox2.Text = (price[j] * (Decimal.ToInt32(numericUpDown1.Value))).ToString();
                    textBoxTotal.Text = total.ToString() + " €";
                    check = true;
                }
                j++;
            } while (check == false && j <= 14);
        }

        //Επιστροφή στη προηγούμενη σελίδα
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            Close();
        }

        //Άνοιγμα επόμενης σελίδας
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.food_cnt = food_cnt;
            Hide();
            f6.ShowDialog();
            Close();
        }
        //τέλος
    }
}
