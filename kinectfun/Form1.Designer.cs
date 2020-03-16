namespace kinectfun
{
    partial class Form1
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
            this.lbl_leftX = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_leftY = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_leftZ = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_rightZ = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_rightY = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_rightX = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_leftRaised = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_rightRaised = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_rightGripping = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_leftGripping = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_leftX
            // 
            this.lbl_leftX.AutoSize = true;
            this.lbl_leftX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftX.Location = new System.Drawing.Point(12, 9);
            this.lbl_leftX.Name = "lbl_leftX";
            this.lbl_leftX.Size = new System.Drawing.Size(44, 25);
            this.lbl_leftX.TabIndex = 3;
            this.lbl_leftX.Text = "X : ";
            // 
            // lbl_leftY
            // 
            this.lbl_leftY.AutoSize = true;
            this.lbl_leftY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftY.Location = new System.Drawing.Point(12, 34);
            this.lbl_leftY.Name = "lbl_leftY";
            this.lbl_leftY.Size = new System.Drawing.Size(45, 25);
            this.lbl_leftY.TabIndex = 4;
            this.lbl_leftY.Text = "Y : ";
            // 
            // lbl_leftZ
            // 
            this.lbl_leftZ.AutoSize = true;
            this.lbl_leftZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftZ.Location = new System.Drawing.Point(12, 59);
            this.lbl_leftZ.Name = "lbl_leftZ";
            this.lbl_leftZ.Size = new System.Drawing.Size(43, 25);
            this.lbl_leftZ.TabIndex = 5;
            this.lbl_leftZ.Text = "Z : ";
            // 
            // lbl_rightZ
            // 
            this.lbl_rightZ.AutoSize = true;
            this.lbl_rightZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightZ.Location = new System.Drawing.Point(12, 393);
            this.lbl_rightZ.Name = "lbl_rightZ";
            this.lbl_rightZ.Size = new System.Drawing.Size(43, 25);
            this.lbl_rightZ.TabIndex = 8;
            this.lbl_rightZ.Text = "Z : ";
            // 
            // lbl_rightY
            // 
            this.lbl_rightY.AutoSize = true;
            this.lbl_rightY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightY.Location = new System.Drawing.Point(12, 368);
            this.lbl_rightY.Name = "lbl_rightY";
            this.lbl_rightY.Size = new System.Drawing.Size(45, 25);
            this.lbl_rightY.TabIndex = 7;
            this.lbl_rightY.Text = "Y : ";
            // 
            // lbl_rightX
            // 
            this.lbl_rightX.AutoSize = true;
            this.lbl_rightX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightX.Location = new System.Drawing.Point(12, 343);
            this.lbl_rightX.Name = "lbl_rightX";
            this.lbl_rightX.Size = new System.Drawing.Size(44, 25);
            this.lbl_rightX.TabIndex = 6;
            this.lbl_rightX.Text = "X : ";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(327, 194);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 33);
            this.lbl_status.TabIndex = 9;
            // 
            // lbl_leftRaised
            // 
            this.lbl_leftRaised.AutoSize = true;
            this.lbl_leftRaised.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftRaised.Location = new System.Drawing.Point(12, 93);
            this.lbl_leftRaised.Name = "lbl_leftRaised";
            this.lbl_leftRaised.Size = new System.Drawing.Size(89, 25);
            this.lbl_leftRaised.TabIndex = 10;
            this.lbl_leftRaised.Text = "RAISED";
            // 
            // lbl_rightRaised
            // 
            this.lbl_rightRaised.AutoSize = true;
            this.lbl_rightRaised.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightRaised.Location = new System.Drawing.Point(12, 318);
            this.lbl_rightRaised.Name = "lbl_rightRaised";
            this.lbl_rightRaised.Size = new System.Drawing.Size(89, 25);
            this.lbl_rightRaised.TabIndex = 11;
            this.lbl_rightRaised.Text = "RAISED";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // lbl_rightGripping
            // 
            this.lbl_rightGripping.AutoSize = true;
            this.lbl_rightGripping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightGripping.Location = new System.Drawing.Point(11, 293);
            this.lbl_rightGripping.Name = "lbl_rightGripping";
            this.lbl_rightGripping.Size = new System.Drawing.Size(89, 25);
            this.lbl_rightGripping.TabIndex = 13;
            this.lbl_rightGripping.Text = "RAISED";
            // 
            // lbl_leftGripping
            // 
            this.lbl_leftGripping.AutoSize = true;
            this.lbl_leftGripping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftGripping.Location = new System.Drawing.Point(12, 118);
            this.lbl_leftGripping.Name = "lbl_leftGripping";
            this.lbl_leftGripping.Size = new System.Drawing.Size(88, 30);
            this.lbl_leftGripping.TabIndex = 14;
            this.lbl_leftGripping.Text = "RAISED";
            this.lbl_leftGripping.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.lbl_leftGripping);
            this.Controls.Add(this.lbl_rightGripping);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_rightRaised);
            this.Controls.Add(this.lbl_leftRaised);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_rightZ);
            this.Controls.Add(this.lbl_rightY);
            this.Controls.Add(this.lbl_rightX);
            this.Controls.Add(this.lbl_leftZ);
            this.Controls.Add(this.lbl_leftY);
            this.Controls.Add(this.lbl_leftX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbl_leftX;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_leftY;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_leftZ;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_rightZ;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_rightY;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_rightX;
        private System.Windows.Forms.Label lbl_status;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_leftRaised;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_rightRaised;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_rightGripping;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_leftGripping;
    }
}

