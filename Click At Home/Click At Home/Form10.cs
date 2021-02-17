using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form10 : Form
    {
        String[] msgs = {                                       //Messages that appear according to body temperature.
            "ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ",
            "ΑΠΑΓΟΡΕΎΕΤΑΙ Η ΕΙΣΟΔΟΣ\nΗ θερμοκρασία του σώματός σας είναι οριακά πάνω από το επιτρεπτό όριο. Αυτό μπορεί να οφείλεται σε σωματική κόπωση ή τις περιβαλλοντικές συνθήκες. Ξεκουραστείτε για λίγα λεπτά και επαναλάβετε την θερμομέτρηση για να σας επιπτραπεί η είσοδος. Αν η θερμοκρασία σας είναι και πάλι άνω του ορίου θα πρέπει να μείνετε σπίτι σας για ξεκούραση",
            "ΑΠΑΓΟΡΕΎΕΤΑΙ Η ΕΙΣΟΔΟΣ\nΗ θερμοκρασία του σώματός σας είναι υψηλή. Συνιστάται λήψη αντιπυρετικών και ξεκούραση. Το κοντινότερο φαρμακείο βρίσκεται στην οδό: \nΓρ. Λαμπράκη 80",
            "ΑΠΑΓΟΡΕΎΕΤΑΙ Η ΕΙΣΟΔΟΣ\nΗ θερμοκρασία του σώματός σας είναι πολύ υψηλή. Συνιστάται επίσκεψη σε ιατρό ή νοσοκομείο. Το κοντινότερο νοσοκομείο βρίσκεται στην οδό: \nΛεωφόρος Αφεντούλη και Ζαννή",
            "\n\n\nΠαρακαλώ απενεργοποιήστε το θερμόμετρο πατώντας το κουμπί 'ON/OFF'"
        };

        String[] quotes = {                                     //Messages that appear randomly while the user waits for the procedure to complete.
            "Στην υποθερμία η θερμοκρασία του σώματος κυμαίνεται κάτω από 35,5 βαθμούς Κελσίου",
            "O πυρετός είναι ένα από τα πιο συνηθισμένα ιατρικά συμπτώματα",
            "Η αύξηση σωματικής θερμοκρασίας βοηθά τον οργανισμό να σκοτώσει λοιμωγόνους ιούς και βακτήρια",
            "Η φυσιολογική θερμοκρασία του σώματος είναι γύρω στους 37°C"
        };
        int sec;
        private bool statusOn = false;
        public Form10()
        {
            InitializeComponent();
            blinkTimer.Tick += new EventHandler(blinkTimerTick);
            autoTurnOffTimer.Tick += new EventHandler(autoTurnOffTimerTick);
        }

        private void onOffClick(object sender, EventArgs e)
        {
            sec = 0;
            statusOn = statusOn ? false : true;                 //If the thermometer is on, then set it the bool isOn to false. Else set it to true.
            if (statusOn)   turnOn();                           //If the bool isOn is true, call the turnOn function. Else call the turnOff. 
            else            turnOff();
        }

        private void blinkTimerTick(Object sender, EventArgs e) //Timer ticks every second (1000ms)
        {
            sec++;                                              //Counter for seconds
            blink();                                            
            Cursor = Cursors.WaitCursor;
            if (sec == 10) {                                    //When 10 seconds have passed since the thermometer was turned on
                topLabel.Text = null;                           //Clear the random messages that appear on top left label
                blinkTimer.Stop();                              //Stop the timer that allows the On/Off button to blink
                autoTurnOffTimer.Start();                       //Start the timer that will turn off the thermometer after one minute
                showTemp();                                     //Show the results to the user
            }
        }

        private void autoTurnOffTimerTick(Object sender, EventArgs e)   //Timer ticks every minute (60000ms). If this timer ticks, the user has not interacted with the thermometer for 1 minute
        {
            autoTurnOffTimer.Stop();                                    //The timer stops
            turnOff();                                                  //The thermometer turns off
        }


        private void blink()
        {
            onOffButton.BackgroundImage = sec % 2 == 0 ? Properties.Resources.OnOffBlue : onOffButton.BackgroundImage = Properties.Resources.OnOff; //Every 2 seconds set the On/Off button's background to blue to simulate a blinking effect.
            if (sec % 2 == 0)   pickRandomQuote();                                                                                                  //Every 2 seconds show a random medical fact.
        }

        private Point getPoint(int x)                           //Returns a point which is where the pointer of the analog thermometer will appear based on the X coordinate given.                   
        {
            return new Point(x, pointer.Location.Y);
        }

        private Point newPointerLocation(double bodyTemp)       //Returns the point where the pointer of the analog thermometer will appear to match with the digital one's result, using the functin getPoint.
        {
            if (bodyTemp <= 37)
                return getPoint(270);
            else if (bodyTemp <= 38)
                return getPoint(370);
            else if (bodyTemp <= 39)
                return getPoint(470);
            else
                return getPoint(570);
        }
        private void showTemp()                                                                             //Calculates a temperature and shows the results to the user.
        {
            Random rnd = new Random();
            double bodyTemp = rnd.Next(34, 40) + Math.Round(rnd.NextDouble(), 2);                           //The double bodyTemp is the sum of a random integer from 34 to 40 and a random double from 0 to 1 rounded in 2 decimal places.
            TempLabel.Text = bodyTemp.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            pointer.Location = newPointerLocation(bodyTemp);                                                //Sets the analog thermometer's pointer location based on the bodyTemp result.
            pointer.Visible = true;                                                                         //Makes the pointer visible to the user.
            if (bodyTemp < 37)                                                                              //Certain instructions appear according to the bodyTemp result.
                InfoLabel.Text = msgs[0] + msgs[4];
            else if (bodyTemp <= 37.5 && bodyTemp >= 37)
                InfoLabel.Text = msgs[1] + msgs[4];
            else if (bodyTemp < 40)
            {
                InfoLabel.Text = msgs[2] + msgs[4];
                mapBox.BackgroundImage = Properties.Resources.MapBoxFull;
            }
            else
            {
                InfoLabel.Text = msgs[3] + msgs[4];
                mapBox.BackgroundImage = Properties.Resources.MapBoxFullHospital;
            }
            Cursor = Cursors.Default;                                                                       //Cursor is back on default.
        }

        private void turnOn()                                                                               //Turns on the thermometer and starts the procedure.
        {
            thermometerAnalog.BackgroundImage = Properties.Resources.Thermometer;                           //Changes the background of the analog thermometer.
            blink();                                                                                        //The blinking of the On/Off button starts.
            blinkTimer.Start();                                                                             //The blinkTimer that controls the blink effect starts.
        }

        private void turnOff()                                                                              //Turns off the thermometer. Every timer stops, all controls clear and the topLabel shows instructions.
        {
            blinkTimer.Stop();                                                                              
            autoTurnOffTimer.Stop();
            pointer.Visible = false;
            onOffButton.BackgroundImage = Properties.Resources.OnOff;
            thermometerAnalog.BackgroundImage = Properties.Resources.ThermometerEmpty;
            mapBox.BackgroundImage = Properties.Resources.MapBoxEmpty;
            TempLabel.Text = null;
            InfoLabel.Text = null;
            topLabel.Text = "Για να θερμομετρηθείτε πατήστε το κουμπί 'ON/OFF' και περιμένετε";
        }

        private void onOffButton_MouseHover(object sender, EventArgs e)                                     //Sets Cursor to hand when the cursor hovers over the On/Off button.                         
        {
            Cursor = Cursors.Hand;
        }

        private void onOffButton_MouseLeave(object sender, EventArgs e)                                     //Sets Cursor to the default when the cursor leaves the On/Off button.   
        {
            Cursor = Cursors.Default;
        }

        private void pickRandomQuote()                                                                      //Sets the topLabels text to a random fact from the array of medical facts.
        {
            topLabel.Text = quotes[new Random().Next(0, 3)];
        }
        private void startScreenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)           //Hides the form, opens a start screen form and closes this one.
        {
            Hide();
            new Form2().ShowDialog();
            Close();
        }

        private void signOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)               //Hides the form, opens a sign in screen form and closes this one.
        {
            Hide();
            new Form1().ShowDialog();
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "C:\\Program Files (x86)\\Adobe\\Acrobat Reader DC\\Reader\\AcroRd32.exe";
            process.StartInfo.Arguments = "/A \"page=12\" \"Εγχειρίδιο Χρήστη.pdf";
            process.Start();
        }
    }
}
