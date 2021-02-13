using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form10 : Form
    {
        String[] msgs =
        {
            "ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ",
            "ΑΠΑΓΟΡΕΎΕΤΑΙ Η ΕΙΣΟΔΟΣ\nΗ θερμοκρασία του σώματός σας είναι οριακά πάνω από το επιτρεπτό όριο. Αυτό μπορεί να οφείλεται σε σωματική κόπωση ή τις περιβαλλοντικές συνθήκες. Ξεκουραστείτε για λίγα λεπτά και επαναλάβετε την θερμομέτρηση για να σας επιπτραπεί η είσοδος. Αν η θερμοκρασία σας είναι και πάλι άνω του ορίου θα πρέπει να μείνετε σπίτι σας για ξεκούραση",
            "ΑΠΑΓΟΡΕΎΕΤΑΙ Η ΕΙΣΟΔΟΣ\nΗ θερμοκρασία του σώματός σας είναι υψηλή. Συνιστάται λήψη αντιπυρετικών και ξεκούραση. Το κοντινότερο φαρμακείο βρίσκεται στην οδό: \nΓρ. Λαμπράκη 80",
            "ΑΠΑΓΟΡΕΎΕΤΑΙ Η ΕΙΣΟΔΟΣ\nΗ θερμοκρασία του σώματός σας είναι πολύ υψηλή. Συνιστάται επίσκεψη σε ιατρό ή νοσοκομείο. Το κοντινότερο νοσοκομείο βρίσκεται στην οδό: \nΛεωφόρος Αφεντούλη και Ζαννή",
            "\n\n\nΠαρακαλώ απενεργοποιήστε το θερμόμετρο πατώντας το κουμπί 'ON/OFF'"
        };

        String[] quotes = {
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
            statusOn = statusOn ? false : true;
            if (statusOn)
                turnOn();
            else
                turnOff();
        }

        private void blinkTimerTick(Object sender, EventArgs e)
        {
            sec++;
            blink();
            Cursor = Cursors.WaitCursor;
            if (sec == 10)
            {
                topLabel.Text = null;
                blinkTimer.Stop();
                autoTurnOffTimer.Start();
                showTemp();
            }
        }

        private void autoTurnOffTimerTick(Object sender, EventArgs e)
        {
            turnOff();
        }


        private void blink()
        {
            onOffButton.BackgroundImage = sec % 2 == 0 ? Properties.Resources.OnOffBlue : onOffButton.BackgroundImage = Properties.Resources.OnOff;
            if (sec % 2 == 0)
                pickRandomQuote();
        }

        private Point getPoint(int x)
        {
            return new Point(x, pointer.Location.Y);
        }

        private Point newPointerLocation(double bodyTemp)
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
        private void showTemp()
        {
            Random rnd = new Random();
            double bodyTemp = rnd.Next(34, 40) + Math.Round(rnd.NextDouble(), 2);
            TempLabel.Text = bodyTemp.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            pointer.Location = newPointerLocation(bodyTemp);
            pointer.Visible = true;
            if (bodyTemp < 37)
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
            Cursor = Cursors.Default;
        }

        private void turnOn()
        {
            thermometerAnalog.BackgroundImage = Properties.Resources.Thermometer;
            blink();
            blinkTimer.Start();
        }

        private void turnOff()
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

        private void onOffButton_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void onOffButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pickRandomQuote()
        {
            Random rnd = new Random();
            topLabel.Text = quotes[rnd.Next(0, 3)];
        }
        private void startScreenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        private void signOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }
    }
}
