
namespace BPAS_Tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonImportExport = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSugar = new System.Windows.Forms.Button();
            this.ButtonPressure = new System.Windows.Forms.Button();
            this.ButtonAddValues = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateAndTime = new System.Windows.Forms.Label();
            this.FormLoader = new System.Windows.Forms.Panel();
            this.WindowName = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ActiveButtonPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 695);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ActiveButtonPanel);
            this.panel4.Controls.Add(this.ButtonImportExport);
            this.panel4.Controls.Add(this.ButtonExit);
            this.panel4.Controls.Add(this.ButtonSugar);
            this.panel4.Controls.Add(this.ButtonPressure);
            this.panel4.Controls.Add(this.ButtonAddValues);
            this.panel4.Controls.Add(this.HomeButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 515);
            this.panel4.TabIndex = 6;
            // 
            // ButtonImportExport
            // 
            this.ButtonImportExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonImportExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonImportExport.FlatAppearance.BorderSize = 0;
            this.ButtonImportExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImportExport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImportExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonImportExport.Image = global::BPAS_Tracker.Properties.Resources.importexport;
            this.ButtonImportExport.Location = new System.Drawing.Point(0, 300);
            this.ButtonImportExport.Name = "ButtonImportExport";
            this.ButtonImportExport.Size = new System.Drawing.Size(241, 75);
            this.ButtonImportExport.TabIndex = 0;
            this.ButtonImportExport.Text = " Import / Export data";
            this.ButtonImportExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonImportExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonImportExport.UseVisualStyleBackColor = true;
            this.ButtonImportExport.Click += new System.EventHandler(this.ButtonImportExport_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonExit.Location = new System.Drawing.Point(0, 440);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(241, 75);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSugar
            // 
            this.ButtonSugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSugar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSugar.FlatAppearance.BorderSize = 0;
            this.ButtonSugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSugar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonSugar.Image = global::BPAS_Tracker.Properties.Resources.sugar;
            this.ButtonSugar.Location = new System.Drawing.Point(0, 225);
            this.ButtonSugar.Name = "ButtonSugar";
            this.ButtonSugar.Size = new System.Drawing.Size(241, 75);
            this.ButtonSugar.TabIndex = 2;
            this.ButtonSugar.Text = "  Show sugar levels";
            this.ButtonSugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSugar.UseVisualStyleBackColor = true;
            this.ButtonSugar.Click += new System.EventHandler(this.ButtonSugar_Click);
            // 
            // ButtonPressure
            // 
            this.ButtonPressure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPressure.FlatAppearance.BorderSize = 0;
            this.ButtonPressure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPressure.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonPressure.Image = global::BPAS_Tracker.Properties.Resources.pressure;
            this.ButtonPressure.Location = new System.Drawing.Point(0, 150);
            this.ButtonPressure.Name = "ButtonPressure";
            this.ButtonPressure.Size = new System.Drawing.Size(241, 75);
            this.ButtonPressure.TabIndex = 1;
            this.ButtonPressure.Text = "  Show blood pressure";
            this.ButtonPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPressure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonPressure.UseVisualStyleBackColor = true;
            this.ButtonPressure.Click += new System.EventHandler(this.ButtonPressure_Click);
            // 
            // ButtonAddValues
            // 
            this.ButtonAddValues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAddValues.FlatAppearance.BorderSize = 0;
            this.ButtonAddValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddValues.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonAddValues.Image = global::BPAS_Tracker.Properties.Resources.add;
            this.ButtonAddValues.Location = new System.Drawing.Point(0, 75);
            this.ButtonAddValues.Name = "ButtonAddValues";
            this.ButtonAddValues.Size = new System.Drawing.Size(241, 75);
            this.ButtonAddValues.TabIndex = 3;
            this.ButtonAddValues.Text = "  Add values";
            this.ButtonAddValues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddValues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAddValues.UseVisualStyleBackColor = true;
            this.ButtonAddValues.Click += new System.EventHandler(this.ButtonAddValues_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HomeButton.Image = global::BPAS_Tracker.Properties.Resources.Home2;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(241, 75);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.Text = " Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 174);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BPAS_Tracker.Properties.Resources.LogoVers1;
            this.pictureBox1.Location = new System.Drawing.Point(91, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(22, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BPAS Tracker";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.DateAndTime);
            this.panel2.Controls.Add(this.FormLoader);
            this.panel2.Controls.Add(this.WindowName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 695);
            this.panel2.TabIndex = 1;
            // 
            // DateAndTime
            // 
            this.DateAndTime.AutoSize = true;
            this.DateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateAndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DateAndTime.Location = new System.Drawing.Point(759, 63);
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.Size = new System.Drawing.Size(0, 26);
            this.DateAndTime.TabIndex = 2;
            // 
            // FormLoader
            // 
            this.FormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FormLoader.Location = new System.Drawing.Point(0, 137);
            this.FormLoader.Name = "FormLoader";
            this.FormLoader.Size = new System.Drawing.Size(1073, 558);
            this.FormLoader.TabIndex = 1;
            // 
            // WindowName
            // 
            this.WindowName.AutoSize = true;
            this.WindowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WindowName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.WindowName.Location = new System.Drawing.Point(68, 56);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(97, 33);
            this.WindowName.TabIndex = 0;
            this.WindowName.Text = "Home";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ActiveButtonPanel
            // 
            this.ActiveButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ActiveButtonPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ActiveButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ActiveButtonPanel.Name = "ActiveButtonPanel";
            this.ActiveButtonPanel.Size = new System.Drawing.Size(8, 75);
            this.ActiveButtonPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.Panel FormLoader;
        private System.Windows.Forms.Label DateAndTime;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button ButtonImportExport;
        private System.Windows.Forms.Button ButtonSugar;
        private System.Windows.Forms.Button ButtonPressure;
        private System.Windows.Forms.Button ButtonAddValues;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel ActiveButtonPanel;
    }
}

