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
            this.topLabel.Location = new System.Drawing.Point(19, 27);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(847, 67);
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
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.InfoLabel.Image = global::ClickAtHome.Properties.Resources.InfoLabel;
            this.InfoLabel.Location = new System.Drawing.Point(872, 16);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(743, 452);
            this.InfoLabel.TabIndex = 14;
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapBox
            // 
            this.mapBox.BackgroundImage = global::ClickAtHome.Properties.Resources.MapBoxEmpty;
            this.mapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mapBox.Location = new System.Drawing.Point(883, 471);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(732, 394);
            this.mapBox.TabIndex = 13;
            this.mapBox.TabStop = false;
            // 
            // pointer
            // 
            this.pointer.BackgroundImage = global::ClickAtHome.Properties.Resources.Pointer;
            this.pointer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pointer.Location = new System.Drawing.Point(237, 418);
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
            this.TempLabel.Location = new System.Drawing.Point(30, 471);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(847, 394);
            this.TempLabel.TabIndex = 11;
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thermometerAnalog
            // 
            this.thermometerAnalog.BackgroundImage = global::ClickAtHome.Properties.Resources.ThermometerEmpty;
            this.thermometerAnalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.thermometerAnalog.Location = new System.Drawing.Point(19, 392);
            this.thermometerAnalog.Name = "thermometerAnalog";
            this.thermometerAnalog.Size = new System.Drawing.Size(847, 35);
            this.thermometerAnalog.TabIndex = 10;
            this.thermometerAnalog.TabStop = false;
            // 
            // onOffButton
            // 
            this.onOffButton.BackgroundImage = global::ClickAtHome.Properties.Resources.OnOff;
            this.onOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onOffButton.Location = new System.Drawing.Point(320, 97);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.Size = new System.Drawing.Size(240, 240);
            this.onOffButton.TabIndex = 9;
            this.onOffButton.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1634, 881);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.thermometerAnalog);
            this.Controls.Add(this.onOffButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerAnalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOffButton)).EndInit();
            this.ResumeLayout(false);

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
    }
}