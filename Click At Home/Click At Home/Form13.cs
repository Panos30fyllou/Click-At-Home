using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form13 : Form
    {
        public Form13(String time)
        {
            InitializeComponent();
            timeMaskedTextBox.Text = time;
            sendButton.BackColor = SystemColors.Window;
            cancelButton.BackColor = SystemColors.Window;
        }

        private bool orderIsOk()
        {

            if (!checkForError_inTextBox(nameTextBox) || !checkForError_inRichTextBox(orderRichTextBox) || !checkForError_inMaskedTextBox(timeMaskedTextBox))
                return false;
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (orderIsOk()){
                MessageBox.Show("Η παραγγελία σας ολοκληρώθηκε με επιτυχία");
                Close();
            }
        }

        private bool checkForError_inMaskedTextBox(object sender)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            if (TimeSpan.TryParse(maskedTextBox.Text, out var dummyOutput)){
                errorProvider.Clear();
                maskedTextBox.ForeColor = Color.Black;
                return true;
            }
            errorProvider.SetError(maskedTextBox, "Μη έγκυρη μορφή ώρας");
            maskedTextBox.ForeColor = Color.Red;
            return false;
        }
        private bool checkForError_inTextBox(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrWhiteSpace(nameTextBox.Text)){
                errorProvider.SetError(textBox, "Μη έγκυρο ονοματεπώνυμο");
                return false;
            }
            errorProvider.Clear();
            return true;
        }
        private bool checkForError_inRichTextBox(object sender)
        {
            RichTextBox textBox = sender as RichTextBox;
            if (String.IsNullOrEmpty(orderRichTextBox.Text) || String.IsNullOrWhiteSpace(orderRichTextBox.Text)){
                errorProvider.SetError(textBox, "Μη έγκυρη παραγγελία");
                return false;
            }
            errorProvider.Clear();
            return true;
        }

        private void timeMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForError_inMaskedTextBox(sender);
        }
    }
}
