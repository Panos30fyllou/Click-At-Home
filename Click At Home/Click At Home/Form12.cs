using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form12 : Form
    {
        public int numberOfMovements = 0;
        public int currentMovement = 0;
        private List<Movement> movementList = new List<Movement>();
        private List<TextBox> desttxtboxes = new List<TextBox>();
        private List<MaskedTextBox> timemaskedtxtboxes = new List<MaskedTextBox>();
        private List<ComboBox> reasoncomboboxes = new List<ComboBox>();
        private List<ComboBox> meanscomboboxes = new List<ComboBox>();

        private class Movement
        {
            private String destination;
            private String time;
            private String means;
            private String reason;
            Image map;

            public Movement(String dst, String tm, String mns, String rsn, Image mp)
            {
                destination = dst;
                time = tm;
                means = mns;
                reason = rsn;
                map = mp;
            }

            public Image getMap(){return map;}
        }

        public Form12()
        {
            InitializeComponent();
            desttxtboxes.Add(destTextBox0);
            timemaskedtxtboxes.Add(timeMaskedTextBox0);
            meanscomboboxes.Add(meansOfTransport0);
            reasoncomboboxes.Add(reason0);

            TopLabel.Text = "Συμπληρώστε τα ακόλουθα πεδία.\nΓια να προσθέσετε νέα διαδρομή, πατήστε το κουμπί '+'";
            destTextBox0.Text = "ΠΡΟΟΡΙΣΜΟΣ";
            destTextBox0.ForeColor = Color.Gray;
            timeMaskedTextBox0.ForeColor = Color.Gray;
            updateMapPagesLabel();
        }

        private void addMovement(object sender, EventArgs e)
        {
            TextBox desttxtbox = desttxtboxes[numberOfMovements] as TextBox;
            MaskedTextBox timemaskedtxtbox = timemaskedtxtboxes[numberOfMovements] as MaskedTextBox;
            ComboBox meansoftrans = meanscomboboxes[numberOfMovements] as ComboBox;
            ComboBox reas = reasoncomboboxes[numberOfMovements] as ComboBox;

            if (!String.IsNullOrEmpty(desttxtbox.Text.Trim()) && timemaskedtxtbox.MaskCompleted && meansoftrans.SelectedIndex >= 0 && reas.SelectedIndex >= 0) {
                PictureBox addButton = sender as PictureBox;
                numberOfMovements++;
                currentMovement = numberOfMovements;
                duplicateFields(addButton.Location.Y);
                addButton.Location = new Point(addButton.Location.X, addButton.Location.Y + 30);
                updateMapPagesLabel();
                createMovement(desttxtbox.Text.Trim(), timemaskedtxtbox.Text.ToString(), meansoftrans.SelectedItem.ToString(), reas.SelectedItem.ToString());
                updateMap();
            }
            else
                errorProvider.SetError(addMovementButton, "Ελλειπή στοιχεία");
        }

        private void duplicateFields(int Y)
        {
            duplicateLabel(movementNumberLabel, Y);
            duplicateDestTextBox(destTextBox0, Y);
            duplicateTimeMaskedTextBox(timeMaskedTextBox0, Y);
            duplicateMeansOfTransport(meansOfTransport0, Y);
            duplicateReason(reason0, Y);
        }

        ///////////////////////////////////
        ///     Duplication Functions   ///
        ///////////////////////////////////
        private void duplicateLabel(Label bluePrintLabel, int Y)
        {
            Label label = new Label();
            Controls.Add(label);
            label.Location = new Point(bluePrintLabel.Location.X, Y + 30);
            label.Size = bluePrintLabel.Size;
            label.Font = new Font(bluePrintLabel.Font.Name, bluePrintLabel.Font.Size, FontStyle.Bold);
            label.Text = (numberOfMovements + 1).ToString() + ".";
            label.Show();
            label.Name = "label" + movementNumberLabel.ToString();
        }

        private void duplicateDestTextBox(TextBox bluePrintDestTextBox, int Y)
        {
            TextBox textbox = new TextBox();
            Controls.Add(textbox);
            desttxtboxes.Add(textbox);
            textbox.Location = new Point(bluePrintDestTextBox.Location.X, Y + 30);
            textbox.Size = bluePrintDestTextBox.Size;
            textbox.Font = new Font(bluePrintDestTextBox.Font.Name, bluePrintDestTextBox.Font.Size);
            textbox.ForeColor = Color.Gray;
            textbox.Text = "ΠΡΟΟΡΙΣΜΟΣ";
            textbox.Enter += new EventHandler(TextBox_Enter);
            textbox.Leave += new EventHandler(TextBox_Leave);
            textbox.Show();
            textbox.Name = "destTextBox" + movementNumberLabel.ToString();
            textbox.Name = "destTextBox" + movementNumberLabel.ToString();
        }
        private void duplicateTimeMaskedTextBox(MaskedTextBox bluePrintMaskedTimeTextBox, int Y)
        {
            MaskedTextBox textbox = new MaskedTextBox();
            Controls.Add(textbox);
            timemaskedtxtboxes.Add(textbox);
            textbox.Location = new Point(bluePrintMaskedTimeTextBox.Location.X, Y + 30);
            textbox.Size = bluePrintMaskedTimeTextBox.Size;
            textbox.Font = new Font(bluePrintMaskedTimeTextBox.Font.Name, bluePrintMaskedTimeTextBox.Font.Size);
            textbox.TextAlign = HorizontalAlignment.Center;
            textbox.ForeColor = Color.Gray;
            textbox.Text = "ΩΡΑ";
            textbox.Mask = "00:00";
            textbox.Enter += new EventHandler(timeMaskedTextBox_Enter);
            textbox.TextChanged += new EventHandler(timeMaskedTextBox_TextChanged);
            textbox.Validated += new EventHandler(timeMaskedTextBox_Validated);
            textbox.Show();
            textbox.Name = "timeMaskedTextBox" + movementNumberLabel.ToString();
        }

        private void duplicateMeansOfTransport(ComboBox bluePrintMeansOfTransport, int Y){  duplicateComboBox(bluePrintMeansOfTransport, Y, "ΜΕΣΟ ΜΕΤΑΚΙΝΗΣΗΣ");    }

        private void duplicateReason(ComboBox bluePrintReason, int Y){  duplicateComboBox(bluePrintReason, Y, "ΛΟΓΟΣ ΜΕΤΑΚΙΝΗΣΗΣ"); }

        private void duplicateComboBox(ComboBox bluePrintReason, int Y, String text)
        {
            ComboBox comboBox = new ComboBox();
            Controls.Add(comboBox);
            comboBox.Location = new Point(bluePrintReason.Location.X, Y + 30);
            comboBox.Size = bluePrintReason.Size;
            comboBox.Font = new Font(bluePrintReason.Font.Name, bluePrintReason.Font.Size);
            comboBox.Text = text;
            comboBox.Leave += new EventHandler(comboLeave);
            comboBox.Leave += new EventHandler(comboSelectedIndexChanged);
            for (int i = 0; i < bluePrintReason.Items.Count; i++)
                comboBox.Items.Add(bluePrintReason.Items[i].ToString());
            comboBox.Show();
            if (text.Equals("ΛΟΓΟΣ ΜΕΤΑΚΙΝΗΣΗΣ"))
                reasoncomboboxes.Add(comboBox);
            else if (text.Equals("ΜΕΣΟ ΜΕΤΑΚΙΝΗΣΗΣ"))
                meanscomboboxes.Add(comboBox);
        }

        /////////////////////////////
        ///     TextBox Events    ///
        /////////////////////////////

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("ΠΡΟΟΡΙΣΜΟΣ") || textBox.Text.Equals("ΩΡΑ")){
                textBox.Text = null;
                textBox.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (String.IsNullOrEmpty(textBox.Text) || String.IsNullOrWhiteSpace(textBox.Text)){
                if (textBox.Location.X == destTextBox0.Location.X){
                    textBox.Text = "ΠΡΟΟΡΙΣΜΟΣ";
                    textBox.ForeColor = Color.Gray;
                }
                else if (textBox.Location.X == timeMaskedTextBox0.Location.X){
                    textBox.Text = "ΩΡΑ";
                    textBox.ForeColor = Color.Gray;
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.ForeColor = (textBox.Text.Equals("ΠΡΟΟΡΙΣΜΟΣ") || textBox.Text.Equals("ΩΡΑ")) ? Color.Gray : Color.Black;
        }

        ///////////////////////////////////
        ///     MaskedTextBox Events    ///
        ///////////////////////////////////
        private void timeMaskedTextBox_Enter(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            maskedTextBox.ForeColor = Color.Black;
        }

        private void timeMaskedTextBox_Validated(object sender, EventArgs e){   checkForError_inMaskedTextBox(sender);  }

        private void timeMaskedTextBox_TextChanged(object sender, EventArgs e){ checkForError_inMaskedTextBox(sender);  }

        ///////////////////////////////
        ///     ComboBox Events     ///
        ///////////////////////////////
        private void comboLeave(object sender, EventArgs e){    checkForError_inComboBox(sender);   }

        private void comboSelectedIndexChanged(object sender, EventArgs e){     checkForError_inComboBox(sender);   }

        ///////////////////////////////
        ///     Error Checkers      ///
        ///////////////////////////////
        private void checkForError_inComboBox(object sender)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedIndex < 0)     errorProvider.SetError(comboBox, "Απαραίτητο Πεδίο");
            else                                errorProvider.Clear();
        }

        private void checkForError_inMaskedTextBox(object sender)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            if (TimeSpan.TryParse(maskedTextBox.Text, out var dummyOutput)){ //Is true if the text int he masked textbox is a valid time
                errorProvider.Clear();
                maskedTextBox.ForeColor = Color.Black;
            }
            else {
                errorProvider.SetError(maskedTextBox, "Μη έγκυρη μορφή ώρας");
                maskedTextBox.ForeColor = Color.Red;
            }
        }

        private void createMovement(String dest, String time, String means, String reason)//Creates an instance of a Movement and adds it in the movementList
        {
            if (reason.Equals("ΕΡΓΑΣΙΑ"))
                movementList.Add(new Movement(dest, time, means, reason, (Image)Properties.Resources.mapBoxWork));
            else if (reason.Equals("ΙΑΤΡΟΣ/ΦΑΡΜΑΚΕΙΟ"))
                movementList.Add(new Movement(dest, time, means, reason, (Image)Properties.Resources.mapBoxPh));
            else if (reason.Equals("ΑΓΑΘΑ ΠΡΩΤΗΣ ΑΝΑΓΚΗΣ"))
                movementList.Add(new Movement(dest, time, means, reason, (Image)Properties.Resources.mapBoxSM));
            else if (reason.Equals("ΤΡΑΠΕΖΑ"))
                movementList.Add(new Movement(dest, time, means, reason, (Image)Properties.Resources.mapBoxBank));
            else if (reason.Equals("ΠΑΡΟΧΗ ΒΟΗΘΕΙΑΣ/ΣΥΝΟΔΕΙΑ ΜΑΘΗΤΗ"))
                movementList.Add(new Movement(dest, time, means, reason, (Image)Properties.Resources.mapBoxRandom));
            else if (reason.Equals("ΤΕΛΕΤΗ/ΕΠΙΚΟΙΝΩΝΙΑ ΔΙΑΖΕΥΓΜΕΝΩΝ"))
                movementList.Add(new Movement(dest, time, means, reason, (Image)Properties.Resources.mapBoxRandom));
            else if (reason.Equals("ΣΩΜΑΤΙΚΗ ΑΣΚΗΣΗ/ΚΑΤΟΙΚΙΔΙΟ"))
                movementList.Add(new Movement(dest, time, means, reason, (Image)Properties.Resources.mapBoxExercise));
        }

        private void updateMap(){   mapBox.BackgroundImage = movementList[currentMovement - 1].getMap();    }

        private void updateMapPagesLabel(){ if (currentMovement > 0) mapPagesLabel.Text = currentMovement.ToString() + "/" + numberOfMovements.ToString();  }

        private String mapPager_Turn(int by)
        {
            if      (by == -1) { currentMovement--;     return currentMovement.ToString() + "/" + numberOfMovements.ToString(); }
            else if (by == 1) { currentMovement++;      return currentMovement.ToString() + "/" + numberOfMovements.ToString(); }
            else return null;
        }

        private void previousMapButton_Click(object sender, EventArgs e)
        {
            if (currentMovement > 1) {
                mapPagesLabel.Text = mapPager_Turn(-1);
                updateMap();
                //updateMapPagesLabel();
            }
        }

        private void nextMapButton_Click(object sender, EventArgs e)
        {
            if (currentMovement < numberOfMovements) {
                mapPagesLabel.Text = mapPager_Turn(1);
                updateMap();
                //wefupdateMapPagesLabel();
            }
        }

        private void coffeeButton_Click(object sender, EventArgs e) {   if (currentMovement >= 1)  new Form13(timemaskedtxtboxes[currentMovement - 1].Text).ShowDialog();  }

        private void button_MouseHover(object sender, EventArgs e){ Cursor = Cursors.Hand;  }

        private void button_MouseLeave(object sender, EventArgs e){ Cursor = Cursors.Default;   }

        private void startScreenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Form2().ShowDialog();
            Close();
        }

        private void signOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Form1().ShowDialog();
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
