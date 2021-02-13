using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAtHome
{
    public partial class Form11 : Form
    {
        static Device bedlamp1 = new Device("bedLamp1", true, Properties.Resources.bedLamp1On, "Το φωτιστικό1 στην κρεβατοκάμαρα άναψε", "Το φωτιστικό1 στην κρεβατοκάμαρα έσβησε");
        static Device bedlamp2 = new Device("bedLamp2", true, Properties.Resources.bedLamp2On, "Το φωτιστικό2 στην κρεβατοκάμαρα άναψε", "Το φωτιστικό2 στην κρεβατοκάμαρα έσβησε");
        static Device kidsbedlamp = new Device("kidsBedLamp", false, Properties.Resources.kidsBedLampOff, "Το φωτιστικό στο παιδικό δωμάτιο άναψε", "Το φωτιστικό στο παιδικό δωμάτιο έσβησε");
        static Device tv = new Device("tv", false, Properties.Resources.tvOff, "Η τηλεόραση άναψε", "Η τηλεόραση έσβησε");
        static Device bathroom1 = new Device("bathroom1", false, Properties.Resources.bathroom1Off, "Το φως στο μικρό μπάνιο άναψε", "Το φως στο μικρό μπάνιο έσβησε");
        static Device bathroom2 = new Device("bathroom2", false, Properties.Resources.bathroom2Off, "Το φως στο μεγάλο μπάνιο άναψε", "Το φως στο μεγάλο μπάνιο έσβησε");
        static Device cofeemaker = new Device("coffeeMaker", false, Properties.Resources.coffeeMakerOff, "Η καφετιέρα ενεργοποιήθηκε", "Η καφετιέρα γέμισε");
        static Device aircondition = new Device("airCondition", false, Properties.Resources.airConditionOff, "Το κλιματιστικό ενεργοποιήθηκε στους ", "Το κλιματιστικό απενεργοποιήθηκε");

        List<Device> deviceList = new List<Device> { bedlamp1, bedlamp2, kidsbedlamp, tv, bathroom1, bathroom2, cofeemaker, aircondition };
        public class Device
        {
            public string name;
            public string grPhraseOn;
            public string grPhraseOff;
            private bool ison;
            private Image image;
            public Device(string nm, bool on, Image img, string phraseOn, string phraseOff)
            {
                name = nm;
                ison = on;
                image = img;
                grPhraseOn = phraseOn;
                grPhraseOff = phraseOff;
            }

            public bool isOn() { return ison; }
            public Image getImage() { return image; }

            public void turnOff() { ison = false; image = (Image)Properties.Resources.ResourceManager.GetObject(name + "Off"); }
            public void turnOn() { ison = true; image = (Image)Properties.Resources.ResourceManager.GetObject(name + "On"); }
            public void hover() { if (ison) image = (Image)Properties.Resources.ResourceManager.GetObject(name + "OnHover"); else image = (Image)Properties.Resources.ResourceManager.GetObject(name + "OffHover"); }
            public void leave() { if (ison) image = (Image)Properties.Resources.ResourceManager.GetObject(name + "On"); else image = (Image)Properties.Resources.ResourceManager.GetObject(name + "Off"); }
        }
        public Form11()
        {
            InitializeComponent();
            airConditionComboController.SelectedIndex = 0;
        }

        private void deviceClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string name = button.Name.Replace("Button", "");
            foreach (Device device in deviceList)
                if (device.name.Equals(name))
                {
                    if (!device.name.Equals("coffeeMaker"))
                    {
                        if (device.isOn())
                            device.turnOff();
                        else
                            device.turnOn();
                        richTextBox1.Text += (device.isOn() ? (device.name.Equals("airCondition") ? device.grPhraseOn + airCondionLabel.Text + " στην λειτουργία " + airConditionComboController.Text : device.grPhraseOn) : device.grPhraseOff) + Environment.NewLine;
                    }
                    else
                    {
                        if (cofeemaker.isOn()) {    cofeemaker.turnOff();   richTextBox1.Text += "Η καφετιέρα άδειασε" +        Environment.NewLine; }
                        else {                      coffeeTimer.Start();    richTextBox1.Text += "Η καφετιέρα ενεργοποιήθηκε" + Environment.NewLine; }
                    }
                    button.BackgroundImage = device.getImage();
                    if (device.name.Equals("airCondition"))
                    {
                        airCondionLabel.Visible =               device.isOn() ? true : false;
                        airConditionUpDownController.Enabled =  device.isOn() ? true : false;
                        airConditionComboController.Enabled =   device.isOn() ? true : false;
                        airCondionLabel.ForeColor = airConditionComboController.SelectedItem.ToString().Equals("ΖΕΣΤΟ") ? Color.OrangeRed : Color.Cyan;
                    }
                }
        }

        private void deviceLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            Button button = sender as Button;
            string name = button.Name.Replace("Button", "");
            foreach (Device device in deviceList)
                if (device.name.Equals(name))
                {
                    device.leave();
                    button.BackgroundImage = device.getImage();
                }
        }

        private void deviceHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            Button button = sender as Button;
            string name = button.Name.Replace("Button", "");
            foreach (Device device in deviceList)
                if (device.name.Equals(name))
                {
                    device.hover();
                    button.BackgroundImage = device.getImage();
                }
        }

        private void airConditionController_ValueChanged(object sender, EventArgs e)
        {
            airCondionLabel.Text = airConditionUpDownController.Value.ToString() + "°C";
            richTextBox1.Text += "Το κλιματιστικό ρυθμίστηκε στους " + airConditionUpDownController.Value.ToString() + "°C" + Environment.NewLine;
        }
        private void airConditionComboController_SelectionChangeCommitted(object sender, EventArgs e)
        {
            airCondionLabel.ForeColor = airConditionComboController.SelectedItem.ToString().Equals("ΖΕΣΤΟ") ? Color.OrangeRed : Color.Blue;
            richTextBox1.Text += "Το κλιματιστικό μπήκε στην λειτουργία " + airConditionComboController.SelectedItem.ToString() + Environment.NewLine;
        }

        private void coffeeTimer_Tick(object sender, EventArgs e)
        {
            coffeeTimer.Stop();
            cofeemaker.turnOn();
            coffeeMakerButton.BackgroundImage = cofeemaker.getImage();
            richTextBox1.Text += "Η καφετιέρα γέμισε και απενεργοποιήθηκε αυτόματα" + Environment.NewLine;
        }

        private void airCondionLabel_Click(object sender, EventArgs e)
        {
            airConditionButton.PerformClick();
        }

        private void airCondionLabel_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            aircondition.hover();
            airConditionButton.BackgroundImage = aircondition.getImage();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            new Form2().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            new Form1().Show();
        }
    }
}
