
namespace BPAS_Tracker
{
    partial class Home
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TrendLabel = new System.Windows.Forms.Label();
            this.GraphLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SlideShowBS = new System.Windows.Forms.PictureBox();
            this.SlideShowBP = new System.Windows.Forms.PictureBox();
            this.AverageBSPicture = new FontAwesome.Sharp.IconPictureBox();
            this.Trend2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageBSPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trend2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Trend2);
            this.panel1.Controls.Add(this.iconPictureBox4);
            this.panel1.Controls.Add(this.TrendLabel);
            this.panel1.Controls.Add(this.GraphLabel);
            this.panel1.Controls.Add(this.AverageBSPicture);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 414);
            this.panel1.TabIndex = 2;
            // 
            // TrendLabel
            // 
            this.TrendLabel.AutoSize = true;
            this.TrendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TrendLabel.Location = new System.Drawing.Point(115, 317);
            this.TrendLabel.Name = "TrendLabel";
            this.TrendLabel.Size = new System.Drawing.Size(183, 24);
            this.TrendLabel.TabIndex = 9;
            this.TrendLabel.Text = "Follow your trends";
            // 
            // GraphLabel
            // 
            this.GraphLabel.AutoSize = true;
            this.GraphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GraphLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.GraphLabel.Location = new System.Drawing.Point(115, 14);
            this.GraphLabel.Name = "GraphLabel";
            this.GraphLabel.Size = new System.Drawing.Size(186, 24);
            this.GraphLabel.TabIndex = 8;
            this.GraphLabel.Text = "Visualize your data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BPAS_Tracker.Properties.Resources.GraphExample;
            this.pictureBox1.Location = new System.Drawing.Point(26, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SlideShowBS
            // 
            this.SlideShowBS.Location = new System.Drawing.Point(449, 271);
            this.SlideShowBS.Name = "SlideShowBS";
            this.SlideShowBS.Size = new System.Drawing.Size(590, 221);
            this.SlideShowBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlideShowBS.TabIndex = 1;
            this.SlideShowBS.TabStop = false;
            // 
            // SlideShowBP
            // 
            this.SlideShowBP.Location = new System.Drawing.Point(449, 27);
            this.SlideShowBP.Name = "SlideShowBP";
            this.SlideShowBP.Size = new System.Drawing.Size(590, 221);
            this.SlideShowBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlideShowBP.TabIndex = 0;
            this.SlideShowBP.TabStop = false;
            // 
            // AverageBSPicture
            // 
            this.AverageBSPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AverageBSPicture.ForeColor = System.Drawing.Color.Green;
            this.AverageBSPicture.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
            this.AverageBSPicture.IconColor = System.Drawing.Color.Green;
            this.AverageBSPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AverageBSPicture.IconSize = 41;
            this.AverageBSPicture.Location = new System.Drawing.Point(119, 344);
            this.AverageBSPicture.Name = "AverageBSPicture";
            this.AverageBSPicture.Size = new System.Drawing.Size(45, 41);
            this.AverageBSPicture.TabIndex = 15;
            this.AverageBSPicture.TabStop = false;
            // 
            // Trend2
            // 
            this.Trend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Trend2.ForeColor = System.Drawing.Color.Gray;
            this.Trend2.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.Trend2.IconColor = System.Drawing.Color.Gray;
            this.Trend2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Trend2.IconSize = 41;
            this.Trend2.Location = new System.Drawing.Point(190, 344);
            this.Trend2.Name = "Trend2";
            this.Trend2.Size = new System.Drawing.Size(45, 41);
            this.Trend2.TabIndex = 18;
            this.Trend2.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 41;
            this.iconPictureBox4.Location = new System.Drawing.Point(256, 344);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(45, 41);
            this.iconPictureBox4.TabIndex = 19;
            this.iconPictureBox4.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1073, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SlideShowBS);
            this.Controls.Add(this.SlideShowBP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageBSPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trend2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SlideShowBP;
        private System.Windows.Forms.PictureBox SlideShowBS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TrendLabel;
        private System.Windows.Forms.Label GraphLabel;
        private FontAwesome.Sharp.IconPictureBox AverageBSPicture;
        private FontAwesome.Sharp.IconPictureBox Trend2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
    }
}