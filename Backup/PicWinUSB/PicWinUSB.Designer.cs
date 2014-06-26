namespace PicWinUSB
{
    partial class PicWinUSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicWinUSB));
            this.led = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.led2 = new System.Windows.Forms.Button();
            this.led3 = new System.Windows.Forms.Button();
            this.led4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // led
            // 
            this.led.Location = new System.Drawing.Point(12, 209);
            this.led.Name = "led";
            this.led.Size = new System.Drawing.Size(105, 23);
            this.led.TabIndex = 0;
            this.led.Text = "Toggle LED1";
            this.led.UseVisualStyleBackColor = true;
            this.led.Click += new System.EventHandler(this.led_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 163);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // led2
            // 
            this.led2.Location = new System.Drawing.Point(179, 209);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(105, 23);
            this.led2.TabIndex = 3;
            this.led2.Text = "Toggle LED2";
            this.led2.UseVisualStyleBackColor = true;
            this.led2.Click += new System.EventHandler(this.led2_click);
            // 
            // led3
            // 
            this.led3.Location = new System.Drawing.Point(12, 249);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(105, 23);
            this.led3.TabIndex = 4;
            this.led3.Text = "Toggle LED3";
            this.led3.UseVisualStyleBackColor = true;
            this.led3.Click += new System.EventHandler(this.led3_click);
            // 
            // led4
            // 
            this.led4.Location = new System.Drawing.Point(179, 249);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(105, 23);
            this.led4.TabIndex = 5;
            this.led4.Text = "Toggle LED4";
            this.led4.UseVisualStyleBackColor = true;
            this.led4.Click += new System.EventHandler(this.led4_click);
            // 
            // PicWinUSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 327);
            this.Controls.Add(this.led4);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.led);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicWinUSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PICtool v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button led;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button led2;
        private System.Windows.Forms.Button led3;
        private System.Windows.Forms.Button led4;
    }
}

