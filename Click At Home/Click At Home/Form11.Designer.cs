namespace ClickAtHome
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.coffeeTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.airConditionComboController = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.airConditionUpDownController = new System.Windows.Forms.NumericUpDown();
            this.airCondionLabel = new System.Windows.Forms.Label();
            this.coffeeMakerButton = new System.Windows.Forms.Button();
            this.bathroom2Button = new System.Windows.Forms.Button();
            this.bathroom1Button = new System.Windows.Forms.Button();
            this.airConditionButton = new System.Windows.Forms.Button();
            this.kidsBedLampButton = new System.Windows.Forms.Button();
            this.tvButton = new System.Windows.Forms.Button();
            this.bedLamp2Button = new System.Windows.Forms.Button();
            this.bedLamp1Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.airConditionUpDownController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // coffeeTimer
            // 
            this.coffeeTimer.Interval = 5000;
            this.coffeeTimer.Tick += new System.EventHandler(this.coffeeTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1375, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "ΘΕΡΜΟΚΡΑΣΙΑ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1286, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "ΛΕΙΤΟΥΡΓΙΑ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(1286, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "ΚΛΙΜΑΤΙΣΜΟΣ";
            // 
            // airConditionComboController
            // 
            this.airConditionComboController.Enabled = false;
            this.airConditionComboController.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.airConditionComboController.FormattingEnabled = true;
            this.airConditionComboController.Items.AddRange(new object[] {
            "ΖΕΣΤΟ",
            "ΚΡΥΟ"});
            this.airConditionComboController.Location = new System.Drawing.Point(1287, 92);
            this.airConditionComboController.Name = "airConditionComboController";
            this.airConditionComboController.Size = new System.Drawing.Size(82, 24);
            this.airConditionComboController.TabIndex = 28;
            this.airConditionComboController.SelectionChangeCommitted += new System.EventHandler(this.airConditionComboController_SelectionChangeCommitted);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.richTextBox1.Location = new System.Drawing.Point(1286, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(486, 595);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // airConditionUpDownController
            // 
            this.airConditionUpDownController.Enabled = false;
            this.airConditionUpDownController.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.airConditionUpDownController.Location = new System.Drawing.Point(1378, 93);
            this.airConditionUpDownController.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.airConditionUpDownController.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.airConditionUpDownController.Name = "airConditionUpDownController";
            this.airConditionUpDownController.Size = new System.Drawing.Size(105, 21);
            this.airConditionUpDownController.TabIndex = 26;
            this.airConditionUpDownController.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.airConditionUpDownController.ValueChanged += new System.EventHandler(this.airConditionController_ValueChanged);
            // 
            // airCondionLabel
            // 
            this.airCondionLabel.AutoSize = true;
            this.airCondionLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.airCondionLabel.Location = new System.Drawing.Point(570, 69);
            this.airCondionLabel.Name = "airCondionLabel";
            this.airCondionLabel.Size = new System.Drawing.Size(41, 17);
            this.airCondionLabel.TabIndex = 25;
            this.airCondionLabel.Text = "20°C";
            this.airCondionLabel.Visible = false;
            this.airCondionLabel.Click += new System.EventHandler(this.airCondionLabel_Click);
            this.airCondionLabel.MouseHover += new System.EventHandler(this.airCondionLabel_MouseHover);
            // 
            // coffeeMakerButton
            // 
            this.coffeeMakerButton.BackgroundImage = global::ClickAtHome.Properties.Resources.coffeeMakerOff;
            this.coffeeMakerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.coffeeMakerButton.FlatAppearance.BorderSize = 0;
            this.coffeeMakerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coffeeMakerButton.Location = new System.Drawing.Point(791, 91);
            this.coffeeMakerButton.Name = "coffeeMakerButton";
            this.coffeeMakerButton.Size = new System.Drawing.Size(35, 50);
            this.coffeeMakerButton.TabIndex = 24;
            this.coffeeMakerButton.UseVisualStyleBackColor = true;
            this.coffeeMakerButton.Click += new System.EventHandler(this.deviceClick);
            this.coffeeMakerButton.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.coffeeMakerButton.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // bathroom2Button
            // 
            this.bathroom2Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bathroom2Button.BackgroundImage = global::ClickAtHome.Properties.Resources.bathroom2Off;
            this.bathroom2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bathroom2Button.FlatAppearance.BorderSize = 0;
            this.bathroom2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bathroom2Button.Location = new System.Drawing.Point(904, 54);
            this.bathroom2Button.Name = "bathroom2Button";
            this.bathroom2Button.Size = new System.Drawing.Size(233, 247);
            this.bathroom2Button.TabIndex = 23;
            this.bathroom2Button.UseVisualStyleBackColor = false;
            this.bathroom2Button.Click += new System.EventHandler(this.deviceClick);
            this.bathroom2Button.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.bathroom2Button.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // bathroom1Button
            // 
            this.bathroom1Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bathroom1Button.BackgroundImage = global::ClickAtHome.Properties.Resources.bathroom1Off;
            this.bathroom1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bathroom1Button.FlatAppearance.BorderSize = 0;
            this.bathroom1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bathroom1Button.Location = new System.Drawing.Point(182, 54);
            this.bathroom1Button.Name = "bathroom1Button";
            this.bathroom1Button.Size = new System.Drawing.Size(195, 140);
            this.bathroom1Button.TabIndex = 22;
            this.bathroom1Button.UseVisualStyleBackColor = false;
            this.bathroom1Button.Click += new System.EventHandler(this.deviceClick);
            this.bathroom1Button.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.bathroom1Button.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // airConditionButton
            // 
            this.airConditionButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.airConditionButton.BackgroundImage = global::ClickAtHome.Properties.Resources.airConditionOff;
            this.airConditionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.airConditionButton.FlatAppearance.BorderSize = 0;
            this.airConditionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airConditionButton.Location = new System.Drawing.Point(534, 65);
            this.airConditionButton.Name = "airConditionButton";
            this.airConditionButton.Size = new System.Drawing.Size(109, 39);
            this.airConditionButton.TabIndex = 21;
            this.airConditionButton.UseVisualStyleBackColor = false;
            this.airConditionButton.Click += new System.EventHandler(this.deviceClick);
            this.airConditionButton.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.airConditionButton.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // kidsBedLampButton
            // 
            this.kidsBedLampButton.BackgroundImage = global::ClickAtHome.Properties.Resources.kidsBedLampOff;
            this.kidsBedLampButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kidsBedLampButton.FlatAppearance.BorderSize = 0;
            this.kidsBedLampButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kidsBedLampButton.Location = new System.Drawing.Point(196, 609);
            this.kidsBedLampButton.Name = "kidsBedLampButton";
            this.kidsBedLampButton.Size = new System.Drawing.Size(40, 18);
            this.kidsBedLampButton.TabIndex = 20;
            this.kidsBedLampButton.UseVisualStyleBackColor = true;
            this.kidsBedLampButton.Click += new System.EventHandler(this.deviceClick);
            this.kidsBedLampButton.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.kidsBedLampButton.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // tvButton
            // 
            this.tvButton.BackgroundImage = global::ClickAtHome.Properties.Resources.tvOff;
            this.tvButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tvButton.FlatAppearance.BorderSize = 0;
            this.tvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tvButton.Location = new System.Drawing.Point(475, 406);
            this.tvButton.Name = "tvButton";
            this.tvButton.Size = new System.Drawing.Size(44, 127);
            this.tvButton.TabIndex = 19;
            this.tvButton.UseVisualStyleBackColor = true;
            this.tvButton.Click += new System.EventHandler(this.deviceClick);
            this.tvButton.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.tvButton.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // bedLamp2Button
            // 
            this.bedLamp2Button.BackgroundImage = global::ClickAtHome.Properties.Resources.bedLamp2On;
            this.bedLamp2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bedLamp2Button.FlatAppearance.BorderSize = 0;
            this.bedLamp2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bedLamp2Button.Location = new System.Drawing.Point(1083, 597);
            this.bedLamp2Button.Name = "bedLamp2Button";
            this.bedLamp2Button.Size = new System.Drawing.Size(35, 29);
            this.bedLamp2Button.TabIndex = 18;
            this.bedLamp2Button.UseVisualStyleBackColor = true;
            this.bedLamp2Button.Click += new System.EventHandler(this.deviceClick);
            this.bedLamp2Button.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.bedLamp2Button.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // bedLamp1Button
            // 
            this.bedLamp1Button.BackgroundImage = global::ClickAtHome.Properties.Resources.bedLamp1On;
            this.bedLamp1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bedLamp1Button.FlatAppearance.BorderSize = 0;
            this.bedLamp1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bedLamp1Button.Location = new System.Drawing.Point(1074, 429);
            this.bedLamp1Button.Name = "bedLamp1Button";
            this.bedLamp1Button.Size = new System.Drawing.Size(35, 35);
            this.bedLamp1Button.TabIndex = 17;
            this.bedLamp1Button.UseVisualStyleBackColor = true;
            this.bedLamp1Button.Click += new System.EventHandler(this.deviceClick);
            this.bedLamp1Button.MouseLeave += new System.EventHandler(this.deviceLeave);
            this.bedLamp1Button.MouseHover += new System.EventHandler(this.deviceHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClickAtHome.Properties.Resources.homeTopView720;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.linkLabel1.Location = new System.Drawing.Point(1616, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 16);
            this.linkLabel1.TabIndex = 81;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Αποσύνδεση";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.linkLabel2.Location = new System.Drawing.Point(1510, 9);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(96, 16);
            this.linkLabel2.TabIndex = 80;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Αρχική σελίδα";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            this.linkLabel3.Location = new System.Drawing.Point(1715, 9);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(59, 16);
            this.linkLabel3.TabIndex = 79;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Βοήθεια";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1784, 721);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.airConditionComboController);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.airConditionUpDownController);
            this.Controls.Add(this.airCondionLabel);
            this.Controls.Add(this.coffeeMakerButton);
            this.Controls.Add(this.bathroom2Button);
            this.Controls.Add(this.bathroom1Button);
            this.Controls.Add(this.airConditionButton);
            this.Controls.Add(this.kidsBedLampButton);
            this.Controls.Add(this.tvButton);
            this.Controls.Add(this.bedLamp2Button);
            this.Controls.Add(this.bedLamp1Button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Smart Home";
            ((System.ComponentModel.ISupportInitialize)(this.airConditionUpDownController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer coffeeTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox airConditionComboController;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown airConditionUpDownController;
        private System.Windows.Forms.Label airCondionLabel;
        private System.Windows.Forms.Button coffeeMakerButton;
        private System.Windows.Forms.Button bathroom2Button;
        private System.Windows.Forms.Button bathroom1Button;
        private System.Windows.Forms.Button airConditionButton;
        private System.Windows.Forms.Button kidsBedLampButton;
        private System.Windows.Forms.Button tvButton;
        private System.Windows.Forms.Button bedLamp2Button;
        private System.Windows.Forms.Button bedLamp1Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}