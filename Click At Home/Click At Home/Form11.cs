using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ClickAtHome
{
    /// <summary>
    /// Instances of the Device class are created. They represent every device in the house. 
    /// They are stored in a List of Device objects named deviceList.
    /// </summary>
    public partial class Form11 : Form
    {

        ///////////////////////
        ///     DEVICES     ///
        ///////////////////////
        static Device bedlamp1 = new Device("bedLamp1", true, Properties.Resources.bedLamp1On, "Το φωτιστικό1 στην κρεβατοκάμαρα άναψε", "Το φωτιστικό1 στην κρεβατοκάμαρα έσβησε");
        static Device bedlamp2 = new Device("bedLamp2", true, Properties.Resources.bedLamp2On, "Το φωτιστικό2 στην κρεβατοκάμαρα άναψε", "Το φωτιστικό2 στην κρεβατοκάμαρα έσβησε");
        static Device kidsbedlamp = new Device("kidsBedLamp", false, Properties.Resources.kidsBedLampOff, "Το φωτιστικό στο παιδικό δωμάτιο άναψε", "Το φωτιστικό στο παιδικό δωμάτιο έσβησε");
        static Device tv = new Device("tv", false, Properties.Resources.tvOff, "Η τηλεόραση άναψε", "Η τηλεόραση έσβησε");
        static Device bathroom1 = new Device("bathroom1", false, Properties.Resources.bathroom1Off, "Το φως στο μικρό μπάνιο άναψε", "Το φως στο μικρό μπάνιο έσβησε");
        static Device bathroom2 = new Device("bathroom2", false, Properties.Resources.bathroom2Off, "Το φως στο μεγάλο μπάνιο άναψε", "Το φως στο μεγάλο μπάνιο έσβησε");
        static Device coffeemaker = new Device("coffeeMaker", false, Properties.Resources.coffeeMakerOff, "Η καφετιέρα ενεργοποιήθηκε", "Η καφετιέρα γέμισε");
        static Device aircondition = new Device("airCondition", false, Properties.Resources.airConditionOff, "Το κλιματιστικό ενεργοποιήθηκε στους ", "Το κλιματιστικό απενεργοποιήθηκε");
        static string airconditionMode = "ΖΕΣΤΟ";
        static int airconditionTemp = 20;
        List<Device> deviceList = new List<Device> { bedlamp1, bedlamp2, kidsbedlamp, tv, bathroom1, bathroom2, coffeemaker, aircondition };     //In this list, every device of the house is stored.
        
        ///////////////////////////
        ///     DEVICE CLASS    ///
        ///////////////////////////
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

            /// GETTERS
            public bool isOn() { return ison; }             
            public Image getImage() { return image; }

            //  FUNCTIONS
            public void turnOff() { ison = false; image =   (Image)Properties.Resources.ResourceManager.GetObject(name + "Off"); }  //Sets the bool ison to false and sets the background image to the on that the device is off.
            public void turnOn() { ison = true; image =     (Image)Properties.Resources.ResourceManager.GetObject(name + "On"); }   //Sets the bool ison to true and sets the background image to the on that the device is on.
            public void hover() { if (ison) image =         (Image)Properties.Resources.ResourceManager.GetObject(name + "OnHover");    else image = (Image)Properties.Resources.ResourceManager.GetObject(name + "OffHover"); }    //If the device is on, its background is set to the 'On' version of hover, otherwise to the 'Off' version of it.
            public void leave() { if (ison) image =         (Image)Properties.Resources.ResourceManager.GetObject(name + "On");         else image = (Image)Properties.Resources.ResourceManager.GetObject(name + "Off"); }         //If the device is on, its background is set to the 'On' version without hover, otherwise to the 'Off' one'
        }
        public Form11()
        {
            InitializeComponent();
            airConditionButton.BackgroundImage = aircondition.getImage();
            tvButton.BackgroundImage = tv.getImage();
            coffeeMakerButton.BackgroundImage = coffeemaker.getImage();
            bathroom1Button.BackgroundImage = bathroom1.getImage();
            bathroom2Button.BackgroundImage = bathroom2.getImage();
            bedLamp1Button.BackgroundImage = bedlamp1.getImage();
            bedLamp2Button.BackgroundImage = bedlamp2.getImage();
            kidsBedLampButton.BackgroundImage = kidsbedlamp.getImage();
            if (aircondition.isOn()) {
                airConditionComboController.Enabled = true;
                airConditionUpDownController.Enabled = true;
                airCondionLabel.Visible = true;
                airCondionLabel.ForeColor = airconditionMode.Equals("ΖΕΣΤΟ") ? Color.OrangeRed : Color.Blue; //If the aircondition's mode is 'Heat', set the label's forecolor to OrangeRed. Else change it to Blue.
            }
            airConditionUpDownController.Value = airconditionTemp;
            airConditionComboController.SelectedIndex = airconditionMode.Equals("ΖΕΣΤΟ") ? 0 : 1;
        }

        private void deviceClick(object sender, EventArgs e)    //When a device is clicked:
        {
            Button button = sender as Button;                   //Represents the sender as a Button named button.
            string name = button.Name.Replace("Button", "");    //To get the name of the device we remove the word "Button" from the button's name and store the result to the string 'name'. For example, for the tvButton we remove the Button and the variable name contains 'tv' which is the name of the object we will deal with.
            foreach (Device device in deviceList) {             //For every Device in the deviceList
                if (device.name.Equals(name)) {                 //If the object's name matches to the content of 'name'
                    if (!device.name.Equals("coffeeMaker")) {   //If the device is not the coffee maker
                        if (device.isOn())  device.turnOff();   //If the device is on, turn it off. Else turn it On.
                        else                device.turnOn();
                        richTextBox1.Text += (device.isOn() ? (device.name.Equals("airCondition") ? device.grPhraseOn + airCondionLabel.Text + " στην λειτουργία " + airConditionComboController.Text : device.grPhraseOn) : device.grPhraseOff) + Environment.NewLine; //If the device is on then add the grPhraseOn. Else add the grPhraseOff. But if it is on and the device is the aircondition then there are also information about it added, like the mode and the temperature.
                    }
                    else {                                      //If it is the coffee maker
                        if (coffeemaker.isOn()) {    coffeemaker.turnOff();   richTextBox1.Text += "Η καφετιέρα άδειασε" + Environment.NewLine; }         //If the coffee maker is on, turn it off and inform the user it is empty
                        else {                      coffeeTimer.Start();    richTextBox1.Text += "Η καφετιέρα ενεργοποιήθηκε" + Environment.NewLine; }  //If the coffee maker is off, start a timer of 5s and then turn it on and inform the user it is filled.
                    }
                    button.BackgroundImage = device.getImage(); //Update the background image with the new one
                    if (device.name.Equals("airCondition")) {   //If the device is the aircondition
                        airCondionLabel.Visible =               device.isOn() ? true : false;   //If the aircondition is on, make the label visible. Else not visible.
                        airConditionUpDownController.Enabled =  device.isOn() ? true : false;   //If the aircondition is on, make the controllers enabled. Else disable them.
                        airConditionComboController.Enabled =   device.isOn() ? true : false;
                        airCondionLabel.ForeColor = airConditionComboController.SelectedItem.ToString().Equals("ΖΕΣΤΟ") ? Color.OrangeRed : Color.Blue; //If the aircondition's mode is 'Heat', set the label's forecolor to OrangeRed. Else change it to Blue.
                    }
                }
            }
        }

        private void deviceLeave(object sender, EventArgs e)    //When the cursor leaves a device:
        {
            Cursor = Cursors.Default;                           //The cursor is set to the Default.
            Button button = sender as Button;                   //Represents the sender as a Button named button.
            string name = button.Name.Replace("Button", "");    //Stores device's name to 'name'
            foreach (Device device in deviceList)               //Finds the device in the deviceList by name
                if (device.name.Equals(name)) {
                    device.leave();                             //Calls the device's leave function to change the background image.
                    button.BackgroundImage = device.getImage(); //Updates the button's background image.
                }
        }

        private void deviceHover(object sender, EventArgs e)    //When the cursor hovers over a device:
        {
            Cursor = Cursors.Hand;                              //The cursor is set to Hand.
            Button button = sender as Button;                   //Represents the sender as a Button named button.
            string name = button.Name.Replace("Button", "");    //Stores device's name to 'name'
            foreach (Device device in deviceList)               //Finds the device in the deviceList by name
                if (device.name.Equals(name)) {
                    device.hover();                             //Calls the device's hover function to change the background image.
                    button.BackgroundImage = device.getImage(); //Updates the button's background image.
                }
        }

        private void airConditionController_ValueChanged(object sender, EventArgs e)                    //When the value of the temperature controller changes:
        {
            airconditionTemp = (int)airConditionUpDownController.Value;
            airCondionLabel.Text = airconditionTemp.ToString() + "°C";                                                                                  //Update the label of the aircondtion button with the new value.
            richTextBox1.Text += "Το κλιματιστικό ρυθμίστηκε στους " + airConditionUpDownController.Value.ToString() + "°C" + Environment.NewLine;      //Informs the user by adding a message to the richTextBox
        }
        private void airConditionComboController_SelectionChangeCommitted(object sender, EventArgs e)   //When the mode of the aircondition changes
        {
            airconditionMode = airConditionComboController.SelectedItem.ToString();
            airCondionLabel.ForeColor = airconditionMode.Equals("ΖΕΣΤΟ") ? Color.OrangeRed : Color.Blue;                                                //Update the forecolor of the aircondition button's label. If the mode is 'Heat' set 
            richTextBox1.Text += "Το κλιματιστικό μπήκε στην λειτουργία " + airConditionComboController.SelectedItem.ToString() + Environment.NewLine;  //Informs the user by adding a message to the richTextBox
        }

        private void coffeeTimer_Tick(object sender, EventArgs e)                                           //This timer ticks every 5s.                   
        {
            coffeeTimer.Stop();                                                                             //When the timer ticks, the timer stops
            coffeemaker.turnOn();                                                                           //The coffee maker is turned On.
            coffeeMakerButton.BackgroundImage = coffeemaker.getImage();                                     //The coffee maker button's background is updated.
            richTextBox1.Text += "Η καφετιέρα γέμισε και απενεργοποιήθηκε αυτόματα" + Environment.NewLine;  //Informs the user by adding a message to the richTextBox.
        }

        private void airConditionLabel_Click(object sender, EventArgs e){ airConditionButton.PerformClick();} //If the user clicks on the aircondition's label, since it is not clickable, he obviously wants to click on the airconditionButton, so a click of that button is performed.

        private void airConditionLabel_MouseHover(object sender, EventArgs e)       //If the user hovers over the aircondition's label, he also hovers over the airconditionButton so:
        {
            Cursor = Cursors.Hand;                                                  //The Cursor is set to Hand.
            aircondition.hover();                                                   //The hover function for the aircondition is called.
            airConditionButton.BackgroundImage = aircondition.getImage();           //The airconditionButton's background image is updated.
        }
        private void startScreenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)   //Hides the form, opens a start screen form and closes this one.
        {
            Hide();                                                                                 
            new Form2().ShowDialog();
            Close();
        }

        private void signOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)       //Hides the form, opens a sign in screen form and closes this one.
        {
            Hide();
            new Form1().ShowDialog();
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "C:\\Program Files (x86)\\Adobe\\Acrobat Reader DC\\Reader\\AcroRd32.exe";
            process.StartInfo.Arguments = "/A \"page=25\" \"Εγχειρίδιο Χρήστη.pdf";
            process.Start();
        }
    }
}