using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form13 : Form
    {
        public Form12.Movement movement;
        public Form12 prevform;

        public Form13(Form12 f, Form12.Movement m, String time)
        {
            InitializeComponent();
            timeMaskedTextBox.Text = time;
            sendButton.BackColor = SystemColors.Window;
            cancelButton.BackColor = SystemColors.Window;
            movement = m;
            prevform = f;
    }

    //Send Order
    private void sendButton_Click(object sender, EventArgs e)
        {
            if (orderIsOk()){
                movement.setOrder(); 
                prevform.setOrderIcon(prevform.currentMovement); 
                MessageBox.Show("Η παραγγελία σας ολοκληρώθηκε με επιτυχία!"); 
                Close();     
            }
        }

        //Cancel Order
        private void cancelButton_Click(object sender, EventArgs e){    Close();    }

        private bool orderIsOk()
        {
            return !isError_inTextBox(nameTextBox) && !isError_inRichTextBox(orderRichTextBox) && !isError_inMaskedTextBox(timeMaskedTextBox); //Is true if there are no errors in any field
        }

        private void timeMaskedTextBox_TextChanged(object sender, EventArgs e){     isError_inMaskedTextBox(sender);    }

        ///////////////////////////////
        ///     ERROR CHECKERS      ///
        ///////////////////////////////
        private bool isError_inMaskedTextBox(object sender)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            if (TimeSpan.TryParse(maskedTextBox.Text, out var dummyOutput)){ //Is true if the text int he masked textbox is a valid time
                errorProvider.Clear();
                maskedTextBox.ForeColor = Color.Black;
                return false;
            }
            errorProvider.SetError(maskedTextBox, "Μη έγκυρη μορφή ώρας!");
            maskedTextBox.ForeColor = Color.Red;
            return true;
        }
        private bool isError_inTextBox(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrWhiteSpace(nameTextBox.Text)){
                errorProvider.SetError(textBox, "Μη έγκυρο ονοματεπώνυμο!");
                return true;
            }
            errorProvider.Clear();
            return false;
        }
        private bool isError_inRichTextBox(object sender)
        {
            RichTextBox textBox = sender as RichTextBox;
            if (String.IsNullOrEmpty(orderRichTextBox.Text) || String.IsNullOrWhiteSpace(orderRichTextBox.Text)){
                errorProvider.SetError(textBox, "Μη έγκυρη παραγγελία!");
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private void Form13_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
