namespace ClickAtHome
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.movementNumberLabel0 = new System.Windows.Forms.Label();
            this.reason0 = new System.Windows.Forms.ComboBox();
            this.destTextBox0 = new System.Windows.Forms.TextBox();
            this.meansOfTransport0 = new System.Windows.Forms.ComboBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.mapPagesLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timeMaskedTextBox0 = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.signOutLabel = new System.Windows.Forms.LinkLabel();
            this.startScreenLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.nextMapButton = new System.Windows.Forms.PictureBox();
            this.previousMapButton = new System.Windows.Forms.PictureBox();
            this.coffeeButton = new System.Windows.Forms.PictureBox();
            this.addMovementButton = new System.Windows.Forms.PictureBox();
            this.mapBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextMapButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousMapButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMovementButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // movementNumberLabel0
            // 
            this.movementNumberLabel0.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.movementNumberLabel0.Location = new System.Drawing.Point(12, 59);
            this.movementNumberLabel0.Name = "movementNumberLabel0";
            this.movementNumberLabel0.Size = new System.Drawing.Size(40, 23);
            this.movementNumberLabel0.TabIndex = 21;
            this.movementNumberLabel0.Text = "1.";
            // 
            // reason0
            // 
            this.reason0.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.reason0.FormattingEnabled = true;
            this.reason0.Items.AddRange(new object[] {
            "ΕΡΓΑΣΙΑ",
            "ΙΑΤΡΟΣ/ΦΑΡΜΑΚΕΙΟ",
            "ΑΓΑΘΑ ΠΡΩΤΗΣ ΑΝΑΓΚΗΣ",
            "ΤΡΑΠΕΖΑ",
            "ΠΑΡΟΧΗ ΒΟΗΘΕΙΑΣ/ΣΥΝΟΔΕΙΑ ΜΑΘΗΤΗ",
            "ΤΕΛΕΤΗ/ΕΠΙΚΟΙΝΩΝΙΑ ΔΙΑΖΕΥΓΜΕΝΩΝ",
            "ΣΩΜΑΤΙΚΗ ΑΣΚΗΣΗ/ΚΑΤΟΙΚΙΔΙΟ"});
            this.reason0.Location = new System.Drawing.Point(570, 63);
            this.reason0.Name = "reason0";
            this.reason0.Size = new System.Drawing.Size(230, 24);
            this.reason0.TabIndex = 20;
            this.reason0.Text = "ΛΟΓΟΣ ΜΕΤΑΚΙΝΗΣΗΣ";
            this.reason0.SelectedIndexChanged += new System.EventHandler(this.comboSelectedIndexChanged);
            this.reason0.Leave += new System.EventHandler(this.comboLeave);
            // 
            // destTextBox0
            // 
            this.destTextBox0.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.destTextBox0.Location = new System.Drawing.Point(58, 63);
            this.destTextBox0.Name = "destTextBox0";
            this.destTextBox0.Size = new System.Drawing.Size(200, 21);
            this.destTextBox0.TabIndex = 15;
            this.destTextBox0.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.destTextBox0.Enter += new System.EventHandler(this.TextBox_Enter);
            this.destTextBox0.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // meansOfTransport0
            // 
            this.meansOfTransport0.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.meansOfTransport0.FormattingEnabled = true;
            this.meansOfTransport0.Items.AddRange(new object[] {
            "ΠΕΡΠΑΤΗΜΑ",
            "ΠΟΔΗΛΑΤΟ",
            "ΑΥΤΟΚΙΝΗΤΟ/ΜΟΤΟΣΥΚΛΕΤΑ",
            "ΜΜΜ"});
            this.meansOfTransport0.Location = new System.Drawing.Point(354, 63);
            this.meansOfTransport0.Name = "meansOfTransport0";
            this.meansOfTransport0.Size = new System.Drawing.Size(200, 24);
            this.meansOfTransport0.TabIndex = 19;
            this.meansOfTransport0.Text = "ΜΕΣΟ ΜΕΤΑΚΙΝΗΣΗΣ";
            this.meansOfTransport0.SelectedIndexChanged += new System.EventHandler(this.comboSelectedIndexChanged);
            this.meansOfTransport0.Leave += new System.EventHandler(this.comboLeave);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TopLabel.Location = new System.Drawing.Point(12, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(0, 21);
            this.TopLabel.TabIndex = 22;
            // 
            // mapPagesLabel
            // 
            this.mapPagesLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.mapPagesLabel.Location = new System.Drawing.Point(1123, 598);
            this.mapPagesLabel.Name = "mapPagesLabel";
            this.mapPagesLabel.Size = new System.Drawing.Size(64, 40);
            this.mapPagesLabel.TabIndex = 17;
            this.mapPagesLabel.Text = "0/0";
            this.mapPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeMaskedTextBox0
            // 
            this.timeMaskedTextBox0.Location = new System.Drawing.Point(274, 64);
            this.timeMaskedTextBox0.Mask = "00:00";
            this.timeMaskedTextBox0.Name = "timeMaskedTextBox0";
            this.timeMaskedTextBox0.Size = new System.Drawing.Size(64, 20);
            this.timeMaskedTextBox0.TabIndex = 18;
            this.timeMaskedTextBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeMaskedTextBox0.ValidatingType = typeof(System.DateTime);
            this.timeMaskedTextBox0.TextChanged += new System.EventHandler(this.timeMaskedTextBox_TextChanged);
            this.timeMaskedTextBox0.Enter += new System.EventHandler(this.timeMaskedTextBox_Enter);
            this.timeMaskedTextBox0.Validated += new System.EventHandler(this.timeMaskedTextBox_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // signOutLabel
            // 
            this.signOutLabel.AutoSize = true;
            this.signOutLabel.BackColor = System.Drawing.Color.Transparent;
            this.signOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.signOutLabel.Location = new System.Drawing.Point(1290, 9);
            this.signOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(91, 16);
            this.signOutLabel.TabIndex = 78;
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
            this.startScreenLabel.Location = new System.Drawing.Point(1184, 9);
            this.startScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startScreenLabel.Name = "startScreenLabel";
            this.startScreenLabel.Size = new System.Drawing.Size(96, 16);
            this.startScreenLabel.TabIndex = 77;
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
            this.linkLabel3.Location = new System.Drawing.Point(1389, 9);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(59, 16);
            this.linkLabel3.TabIndex = 76;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Βοήθεια";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // nextMapButton
            // 
            this.nextMapButton.BackgroundImage = global::ClickAtHome.Properties.Resources.nextMapButton;
            this.nextMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextMapButton.Location = new System.Drawing.Point(1193, 598);
            this.nextMapButton.Name = "nextMapButton";
            this.nextMapButton.Size = new System.Drawing.Size(40, 40);
            this.nextMapButton.TabIndex = 26;
            this.nextMapButton.TabStop = false;
            this.nextMapButton.Click += new System.EventHandler(this.nextMapButton_Click);
            this.nextMapButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.nextMapButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // previousMapButton
            // 
            this.previousMapButton.BackgroundImage = global::ClickAtHome.Properties.Resources.previousMapButton;
            this.previousMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousMapButton.Location = new System.Drawing.Point(1077, 598);
            this.previousMapButton.Name = "previousMapButton";
            this.previousMapButton.Size = new System.Drawing.Size(40, 40);
            this.previousMapButton.TabIndex = 25;
            this.previousMapButton.TabStop = false;
            this.previousMapButton.Click += new System.EventHandler(this.previousMapButton_Click);
            this.previousMapButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.previousMapButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // coffeeButton
            // 
            this.coffeeButton.BackgroundImage = global::ClickAtHome.Properties.Resources.coffeeButton;
            this.coffeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coffeeButton.Location = new System.Drawing.Point(1079, 644);
            this.coffeeButton.Name = "coffeeButton";
            this.coffeeButton.Size = new System.Drawing.Size(154, 90);
            this.coffeeButton.TabIndex = 24;
            this.coffeeButton.TabStop = false;
            this.coffeeButton.Click += new System.EventHandler(this.coffeeButton_Click);
            this.coffeeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.coffeeButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // addMovementButton
            // 
            this.addMovementButton.BackgroundImage = global::ClickAtHome.Properties.Resources.addMovementButton;
            this.addMovementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addMovementButton.Location = new System.Drawing.Point(816, 62);
            this.addMovementButton.Name = "addMovementButton";
            this.addMovementButton.Size = new System.Drawing.Size(25, 25);
            this.addMovementButton.TabIndex = 23;
            this.addMovementButton.TabStop = false;
            this.addMovementButton.Click += new System.EventHandler(this.addMovement);
            this.addMovementButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.addMovementButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // mapBox
            // 
            this.mapBox.BackgroundImage = global::ClickAtHome.Properties.Resources.mapBoxEmptyRect;
            this.mapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapBox.Location = new System.Drawing.Point(879, 62);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(561, 522);
            this.mapBox.TabIndex = 16;
            this.mapBox.TabStop = false;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1452, 746);
            this.Controls.Add(this.signOutLabel);
            this.Controls.Add(this.startScreenLabel);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.movementNumberLabel0);
            this.Controls.Add(this.reason0);
            this.Controls.Add(this.destTextBox0);
            this.Controls.Add(this.meansOfTransport0);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.mapPagesLabel);
            this.Controls.Add(this.timeMaskedTextBox0);
            this.Controls.Add(this.nextMapButton);
            this.Controls.Add(this.previousMapButton);
            this.Controls.Add(this.coffeeButton);
            this.Controls.Add(this.addMovementButton);
            this.Controls.Add(this.mapBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarantine Planner";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextMapButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousMapButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMovementButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movementNumberLabel0;
        private System.Windows.Forms.ComboBox reason0;
        private System.Windows.Forms.TextBox destTextBox0;
        private System.Windows.Forms.ComboBox meansOfTransport0;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label mapPagesLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox0;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox nextMapButton;
        private System.Windows.Forms.PictureBox previousMapButton;
        private System.Windows.Forms.PictureBox coffeeButton;
        private System.Windows.Forms.PictureBox addMovementButton;
        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.LinkLabel signOutLabel;
        private System.Windows.Forms.LinkLabel startScreenLabel;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}