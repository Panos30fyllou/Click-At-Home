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
            this.movementNumberLabel = new System.Windows.Forms.Label();
            this.reason0 = new System.Windows.Forms.ComboBox();
            this.destTextBox0 = new System.Windows.Forms.TextBox();
            this.meansOfTransport0 = new System.Windows.Forms.ComboBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.mapPagesLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timeMaskedTextBox0 = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nextMapButton = new System.Windows.Forms.PictureBox();
            this.previousMapButton = new System.Windows.Forms.PictureBox();
            this.coffeeButton = new System.Windows.Forms.PictureBox();
            this.addMovementButton = new System.Windows.Forms.PictureBox();
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextMapButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousMapButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMovementButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // movementNumberLabel
            // 
            this.movementNumberLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.movementNumberLabel.Location = new System.Drawing.Point(16, 45);
            this.movementNumberLabel.Name = "movementNumberLabel";
            this.movementNumberLabel.Size = new System.Drawing.Size(40, 23);
            this.movementNumberLabel.TabIndex = 21;
            this.movementNumberLabel.Text = "1.";
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
            this.reason0.Location = new System.Drawing.Point(574, 49);
            this.reason0.Name = "reason0";
            this.reason0.Size = new System.Drawing.Size(230, 24);
            this.reason0.TabIndex = 20;
            this.reason0.Text = "ΛΟΓΟΣ ΜΕΤΑΚΙΝΗΣΗΣ";
            // 
            // destTextBox0
            // 
            this.destTextBox0.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.destTextBox0.Location = new System.Drawing.Point(62, 49);
            this.destTextBox0.Name = "destTextBox0";
            this.destTextBox0.Size = new System.Drawing.Size(200, 21);
            this.destTextBox0.TabIndex = 15;
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
            this.meansOfTransport0.Location = new System.Drawing.Point(358, 49);
            this.meansOfTransport0.Name = "meansOfTransport0";
            this.meansOfTransport0.Size = new System.Drawing.Size(200, 24);
            this.meansOfTransport0.TabIndex = 19;
            this.meansOfTransport0.Text = "ΜΕΣΟ ΜΕΤΑΚΙΝΗΣΗΣ";
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TopLabel.Location = new System.Drawing.Point(12, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(0, 22);
            this.TopLabel.TabIndex = 22;
            // 
            // mapPagesLabel
            // 
            this.mapPagesLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.mapPagesLabel.Location = new System.Drawing.Point(1146, 576);
            this.mapPagesLabel.Name = "mapPagesLabel";
            this.mapPagesLabel.Size = new System.Drawing.Size(64, 50);
            this.mapPagesLabel.TabIndex = 17;
            this.mapPagesLabel.Text = "0/0";
            this.mapPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeMaskedTextBox0
            // 
            this.timeMaskedTextBox0.Location = new System.Drawing.Point(278, 50);
            this.timeMaskedTextBox0.Mask = "00:00";
            this.timeMaskedTextBox0.Name = "timeMaskedTextBox0";
            this.timeMaskedTextBox0.Size = new System.Drawing.Size(64, 20);
            this.timeMaskedTextBox0.TabIndex = 18;
            this.timeMaskedTextBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeMaskedTextBox0.ValidatingType = typeof(System.DateTime);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // nextMapButton
            // 
            this.nextMapButton.BackgroundImage = global::ClickAtHome.Properties.Resources.nextMapButton;
            this.nextMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextMapButton.Location = new System.Drawing.Point(1216, 576);
            this.nextMapButton.Name = "nextMapButton";
            this.nextMapButton.Size = new System.Drawing.Size(50, 50);
            this.nextMapButton.TabIndex = 26;
            this.nextMapButton.TabStop = false;
            // 
            // previousMapButton
            // 
            this.previousMapButton.BackgroundImage = global::ClickAtHome.Properties.Resources.previousMapButton;
            this.previousMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousMapButton.Location = new System.Drawing.Point(1090, 576);
            this.previousMapButton.Name = "previousMapButton";
            this.previousMapButton.Size = new System.Drawing.Size(50, 50);
            this.previousMapButton.TabIndex = 25;
            this.previousMapButton.TabStop = false;
            // 
            // coffeeButton
            // 
            this.coffeeButton.BackgroundImage = global::ClickAtHome.Properties.Resources.coffeeButton;
            this.coffeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.coffeeButton.Location = new System.Drawing.Point(1069, 629);
            this.coffeeButton.Name = "coffeeButton";
            this.coffeeButton.Size = new System.Drawing.Size(217, 118);
            this.coffeeButton.TabIndex = 24;
            this.coffeeButton.TabStop = false;
            // 
            // addMovementButton
            // 
            this.addMovementButton.BackgroundImage = global::ClickAtHome.Properties.Resources.addMovementButton;
            this.addMovementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addMovementButton.Location = new System.Drawing.Point(820, 48);
            this.addMovementButton.Name = "addMovementButton";
            this.addMovementButton.Size = new System.Drawing.Size(25, 25);
            this.addMovementButton.TabIndex = 23;
            this.addMovementButton.TabStop = false;
            // 
            // mapBox
            // 
            this.mapBox.BackgroundImage = global::ClickAtHome.Properties.Resources.mapBoxEmptyRect;
            this.mapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapBox.Location = new System.Drawing.Point(891, 48);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(561, 522);
            this.mapBox.TabIndex = 16;
            this.mapBox.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.linkLabel1.Location = new System.Drawing.Point(1290, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 16);
            this.linkLabel1.TabIndex = 78;
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
            this.linkLabel2.Location = new System.Drawing.Point(1184, 9);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(96, 16);
            this.linkLabel2.TabIndex = 77;
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
            this.linkLabel3.Location = new System.Drawing.Point(1389, 9);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(59, 16);
            this.linkLabel3.TabIndex = 76;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Βοήθεια";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1464, 793);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.movementNumberLabel);
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

        private System.Windows.Forms.Label movementNumberLabel;
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}