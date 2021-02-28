namespace ClickAtHome
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.topLabel = new System.Windows.Forms.Label();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.autoTurnOffTimer = new System.Windows.Forms.Timer(this.components);
            this.signOutLabel = new System.Windows.Forms.LinkLabel();
            this.startScreenLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.pointer = new System.Windows.Forms.PictureBox();
            this.TempLabel = new System.Windows.Forms.Label();
            this.thermometerAnalog = new System.Windows.Forms.PictureBox();
            this.onOffButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerAnalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOffButton)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.topLabel.Location = new System.Drawing.Point(26, 34);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(653, 67);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "Για να θερμομετρηθείτε πατήστε το κουμπί \'ON/OFF\' και περιμένετε";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blinkTimer
            // 
            this.blinkTimer.Interval = 1000;
            // 
            // autoTurnOffTimer
            // 
            this.autoTurnOffTimer.Interval = 60000;
            // 
            // signOutLabel
            // 
            this.signOutLabel.AutoSize = true;
            this.signOutLabel.BackColor = System.Drawing.Color.Transparent;
            this.signOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.signOutLabel.Location = new System.Drawing.Point(1071, 18);
            this.signOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(91, 16);
            this.signOutLabel.TabIndex = 81;
            this.signOutLabel.TabStop = true;
            this.signOutLabel.Text = "Αποσύνδεση";
            this.signOutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signOutLabel_LinkClicked);
            // 
            // startScreenLabel
            // 
            this.startScreenLabel.AutoSize = true;
            this.startScreenLabel.BackColor = System.Drawing.Color.Transparent;
            this.startScreenLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startScreenLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.startScreenLabel.Location = new System.Drawing.Point(971, 18);
            this.startScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startScreenLabel.Name = "startScreenLabel";
            this.startScreenLabel.Size = new System.Drawing.Size(96, 16);
            this.startScreenLabel.TabIndex = 80;
            this.startScreenLabel.TabStop = true;
            this.startScreenLabel.Text = "Αρχική σελίδα";
            this.startScreenLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startScreenLabel_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Arial", 10.2F);
            this.linkLabel3.Location = new System.Drawing.Point(1166, 18);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(59, 16);
            this.linkLabel3.TabIndex = 79;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Βοήθεια";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.InfoLabel.Image = global::ClickAtHome.Properties.Resources.InfoLabel;
            this.InfoLabel.Location = new System.Drawing.Point(740, 53);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(485, 291);
            this.InfoLabel.TabIndex = 14;
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapBox
            // 
            this.mapBox.BackgroundImage = global::ClickAtHome.Properties.Resources.MapBoxEmpty;
            this.mapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mapBox.Location = new System.Drawing.Point(740, 370);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(485, 299);
            this.mapBox.TabIndex = 13;
            this.mapBox.TabStop = false;
            // 
            // pointer
            // 
            this.pointer.BackgroundImage = global::ClickAtHome.Properties.Resources.Pointer;
            this.pointer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pointer.Location = new System.Drawing.Point(270, 387);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(32, 25);
            this.pointer.TabIndex = 12;
            this.pointer.TabStop = false;
            this.pointer.Visible = false;
            // 
            // TempLabel
            // 
            this.TempLabel.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TempLabel.Image = global::ClickAtHome.Properties.Resources.tempLabel;
            this.TempLabel.Location = new System.Drawing.Point(38, 413);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(641, 274);
            this.TempLabel.TabIndex = 11;
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thermometerAnalog
            // 
            this.thermometerAnalog.BackgroundImage = global::ClickAtHome.Properties.Resources.ThermometerEmpty;
            this.thermometerAnalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.thermometerAnalog.Location = new System.Drawing.Point(30, 361);
            this.thermometerAnalog.Name = "thermometerAnalog";
            this.thermometerAnalog.Size = new System.Drawing.Size(639, 35);
            this.thermometerAnalog.TabIndex = 10;
            this.thermometerAnalog.TabStop = false;
            // 
            // onOffButton
            // 
            this.onOffButton.BackgroundImage = global::ClickAtHome.Properties.Resources.OnOff;
            this.onOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onOffButton.Location = new System.Drawing.Point(229, 104);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.Size = new System.Drawing.Size(240, 240);
            this.onOffButton.TabIndex = 9;
            this.onOffButton.TabStop = false;
            this.onOffButton.Click += new System.EventHandler(this.onOffClick);
            this.onOffButton.MouseLeave += new System.EventHandler(this.onOffButton_MouseLeave);
            this.onOffButton.MouseHover += new System.EventHandler(this.onOffButton_MouseHover);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1239, 681);
            this.Controls.Add(this.signOutLabel);
            this.Controls.Add(this.startScreenLabel);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.thermometerAnalog);
            this.Controls.Add(this.onOffButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Thermometer";
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerAnalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOffButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Timer blinkTimer;
        private System.Windows.Forms.Timer autoTurnOffTimer;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.PictureBox pointer;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.PictureBox thermometerAnalog;
        private System.Windows.Forms.PictureBox onOffButton;
        private System.Windows.Forms.LinkLabel signOutLabel;
        private System.Windows.Forms.LinkLabel startScreenLabel;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}