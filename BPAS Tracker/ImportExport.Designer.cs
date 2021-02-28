
namespace BPAS_Tracker
{
    partial class ImportExport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Open = new FontAwesome.Sharp.IconButton();
            this.SelectedFile = new System.Windows.Forms.TextBox();
            this.WindowName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveLocalBS = new FontAwesome.Sharp.IconButton();
            this.SaveLocalBP = new FontAwesome.Sharp.IconButton();
            this.Email = new FontAwesome.Sharp.IconButton();
            this.IncludeImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.SelectedFile);
            this.panel1.Controls.Add(this.WindowName);
            this.panel1.Location = new System.Drawing.Point(186, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 273);
            this.panel1.TabIndex = 0;
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Open.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Open.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Open.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Open.IconSize = 51;
            this.Open.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Open.Location = new System.Drawing.Point(0, 93);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(246, 52);
            this.Open.TabIndex = 0;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // SelectedFile
            // 
            this.SelectedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SelectedFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedFile.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SelectedFile.Location = new System.Drawing.Point(0, 168);
            this.SelectedFile.Name = "SelectedFile";
            this.SelectedFile.ReadOnly = true;
            this.SelectedFile.Size = new System.Drawing.Size(246, 25);
            this.SelectedFile.TabIndex = 6;
            this.SelectedFile.Text = "Select a file...";
            // 
            // WindowName
            // 
            this.WindowName.AutoSize = true;
            this.WindowName.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.WindowName.Location = new System.Drawing.Point(65, 13);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(113, 40);
            this.WindowName.TabIndex = 1;
            this.WindowName.Text = "Import";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.SaveLocalBS);
            this.panel2.Controls.Add(this.SaveLocalBP);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.IncludeImagesCheckBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(589, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 273);
            this.panel2.TabIndex = 1;
            // 
            // SaveLocalBS
            // 
            this.SaveLocalBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SaveLocalBS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.SaveLocalBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLocalBS.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveLocalBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SaveLocalBS.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.SaveLocalBS.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SaveLocalBS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveLocalBS.IconSize = 52;
            this.SaveLocalBS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveLocalBS.Location = new System.Drawing.Point(123, 79);
            this.SaveLocalBS.Name = "SaveLocalBS";
            this.SaveLocalBS.Size = new System.Drawing.Size(123, 66);
            this.SaveLocalBS.TabIndex = 10;
            this.SaveLocalBS.Text = "Blood sugar";
            this.SaveLocalBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveLocalBS.UseVisualStyleBackColor = false;
            this.SaveLocalBS.Click += new System.EventHandler(this.SaveLocalBS_Click);
            // 
            // SaveLocalBP
            // 
            this.SaveLocalBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SaveLocalBP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.SaveLocalBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLocalBP.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveLocalBP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SaveLocalBP.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.SaveLocalBP.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SaveLocalBP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveLocalBP.IconSize = 52;
            this.SaveLocalBP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveLocalBP.Location = new System.Drawing.Point(0, 79);
            this.SaveLocalBP.Name = "SaveLocalBP";
            this.SaveLocalBP.Size = new System.Drawing.Size(123, 66);
            this.SaveLocalBP.TabIndex = 9;
            this.SaveLocalBP.Text = "Blood pressure";
            this.SaveLocalBP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveLocalBP.UseVisualStyleBackColor = false;
            this.SaveLocalBP.Click += new System.EventHandler(this.SaveLocalBP_Click);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Email.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Email.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.Email.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Email.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Email.IconSize = 52;
            this.Email.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Email.Location = new System.Drawing.Point(0, 168);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(246, 52);
            this.Email.TabIndex = 8;
            this.Email.UseVisualStyleBackColor = false;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // IncludeImagesCheckBox
            // 
            this.IncludeImagesCheckBox.AutoSize = true;
            this.IncludeImagesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncludeImagesCheckBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeImagesCheckBox.Location = new System.Drawing.Point(3, 226);
            this.IncludeImagesCheckBox.Name = "IncludeImagesCheckBox";
            this.IncludeImagesCheckBox.Size = new System.Drawing.Size(189, 19);
            this.IncludeImagesCheckBox.TabIndex = 6;
            this.IncludeImagesCheckBox.Text = "Include chart images in e-mail";
            this.IncludeImagesCheckBox.UseVisualStyleBackColor = true;
            this.IncludeImagesCheckBox.CheckStateChanged += new System.EventHandler(this.IncludeImagesCheckBox_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BPAS_Tracker.Properties.Resources.Export;
            this.pictureBox2.Location = new System.Drawing.Point(650, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BPAS_Tracker.Properties.Resources.Import;
            this.pictureBox1.Location = new System.Drawing.Point(239, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1073, 558);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportExport";
            this.Text = "ImportExport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectedFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox IncludeImagesCheckBox;
        private FontAwesome.Sharp.IconButton Open;
        private FontAwesome.Sharp.IconButton Email;
        private FontAwesome.Sharp.IconButton SaveLocalBP;
        private FontAwesome.Sharp.IconButton SaveLocalBS;
    }
}