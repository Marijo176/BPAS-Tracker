
namespace BPAS_Tracker
{
    partial class BloodSugar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrendLabel1 = new System.Windows.Forms.Label();
            this.AverageBSLabel = new System.Windows.Forms.Label();
            this.AverageBS2 = new System.Windows.Forms.Label();
            this.SortList = new System.Windows.Forms.ComboBox();
            this.AverageBSPicture = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageBSPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.chart1.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisX.LabelStyle.Format = "dd.MM.yyyy HH:mm:ss";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(105, 43);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 9;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Blood sugar";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(859, 420);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // TrendLabel1
            // 
            this.TrendLabel1.AutoSize = true;
            this.TrendLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrendLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TrendLabel1.Location = new System.Drawing.Point(568, 468);
            this.TrendLabel1.Name = "TrendLabel1";
            this.TrendLabel1.Size = new System.Drawing.Size(99, 31);
            this.TrendLabel1.TabIndex = 11;
            this.TrendLabel1.Text = "Trend:";
            // 
            // AverageBSLabel
            // 
            this.AverageBSLabel.AutoSize = true;
            this.AverageBSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AverageBSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AverageBSLabel.Location = new System.Drawing.Point(306, 468);
            this.AverageBSLabel.Name = "AverageBSLabel";
            this.AverageBSLabel.Size = new System.Drawing.Size(177, 31);
            this.AverageBSLabel.TabIndex = 7;
            this.AverageBSLabel.Text = "Average BS:";
            // 
            // AverageBS2
            // 
            this.AverageBS2.AutoSize = true;
            this.AverageBS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageBS2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AverageBS2.Location = new System.Drawing.Point(475, 468);
            this.AverageBS2.Name = "AverageBS2";
            this.AverageBS2.Size = new System.Drawing.Size(0, 31);
            this.AverageBS2.TabIndex = 12;
            // 
            // SortList
            // 
            this.SortList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SortList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SortList.FormattingEnabled = true;
            this.SortList.Items.AddRange(new object[] {
            "Last 30 values",
            "Last 7 days",
            "Last 30 days",
            "Show all values"});
            this.SortList.Location = new System.Drawing.Point(229, 16);
            this.SortList.Name = "SortList";
            this.SortList.Size = new System.Drawing.Size(438, 21);
            this.SortList.TabIndex = 13;
            this.SortList.SelectedIndexChanged += new System.EventHandler(this.SortList_SelectedIndexChanged);
            // 
            // AverageBSPicture
            // 
            this.AverageBSPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AverageBSPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AverageBSPicture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AverageBSPicture.IconColor = System.Drawing.SystemColors.ControlText;
            this.AverageBSPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AverageBSPicture.IconSize = 31;
            this.AverageBSPicture.Location = new System.Drawing.Point(662, 469);
            this.AverageBSPicture.Name = "AverageBSPicture";
            this.AverageBSPicture.Size = new System.Drawing.Size(45, 31);
            this.AverageBSPicture.TabIndex = 14;
            this.AverageBSPicture.TabStop = false;
            // 
            // BloodSugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1073, 558);
            this.Controls.Add(this.AverageBSPicture);
            this.Controls.Add(this.SortList);
            this.Controls.Add(this.AverageBS2);
            this.Controls.Add(this.TrendLabel1);
            this.Controls.Add(this.AverageBSLabel);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodSugar";
            this.Text = "BloodSugar";
            this.Load += new System.EventHandler(this.BloodSugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageBSPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label TrendLabel1;
        private System.Windows.Forms.Label AverageBSLabel;
        private System.Windows.Forms.Label AverageBS2;
        private System.Windows.Forms.ComboBox SortList;
        private FontAwesome.Sharp.IconPictureBox AverageBSPicture;
    }
}