
namespace BPAS_Tracker
{
    partial class BloodPressure
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageBPLabel = new System.Windows.Forms.Label();
            this.AverageHRLabel = new System.Windows.Forms.Label();
            this.TrendLabel1 = new System.Windows.Forms.Label();
            this.TrendLabel2 = new System.Windows.Forms.Label();
            this.AverageSystolicLabel = new System.Windows.Forms.Label();
            this.AverageHRValue = new System.Windows.Forms.Label();
            this.SortList = new System.Windows.Forms.ComboBox();
            this.SlashLabel = new System.Windows.Forms.Label();
            this.AverageDiastolicLabel = new System.Windows.Forms.Label();
            this.AverageBPPicture = new FontAwesome.Sharp.IconPictureBox();
            this.AverageHRPicture = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageBPPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageHRPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisX.LabelStyle.Format = "dd.MM.yyyy HH:mm:ss";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(94, 48);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 9;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Systolic BP";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValuesPerPoint = 4;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerSize = 9;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Diastolic BP";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValuesPerPoint = 4;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 9;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Heart rate";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(859, 420);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // AverageBPLabel
            // 
            this.AverageBPLabel.AutoSize = true;
            this.AverageBPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AverageBPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AverageBPLabel.Location = new System.Drawing.Point(88, 471);
            this.AverageBPLabel.Name = "AverageBPLabel";
            this.AverageBPLabel.Size = new System.Drawing.Size(177, 31);
            this.AverageBPLabel.TabIndex = 1;
            this.AverageBPLabel.Text = "Average BP:";
            // 
            // AverageHRLabel
            // 
            this.AverageHRLabel.AutoSize = true;
            this.AverageHRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AverageHRLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AverageHRLabel.Location = new System.Drawing.Point(548, 471);
            this.AverageHRLabel.Name = "AverageHRLabel";
            this.AverageHRLabel.Size = new System.Drawing.Size(181, 31);
            this.AverageHRLabel.TabIndex = 2;
            this.AverageHRLabel.Text = "Average HR:";
            // 
            // TrendLabel1
            // 
            this.TrendLabel1.AutoSize = true;
            this.TrendLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrendLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TrendLabel1.Location = new System.Drawing.Point(390, 471);
            this.TrendLabel1.Name = "TrendLabel1";
            this.TrendLabel1.Size = new System.Drawing.Size(99, 31);
            this.TrendLabel1.TabIndex = 5;
            this.TrendLabel1.Text = "Trend:";
            // 
            // TrendLabel2
            // 
            this.TrendLabel2.AutoSize = true;
            this.TrendLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrendLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TrendLabel2.Location = new System.Drawing.Point(767, 471);
            this.TrendLabel2.Name = "TrendLabel2";
            this.TrendLabel2.Size = new System.Drawing.Size(99, 31);
            this.TrendLabel2.TabIndex = 6;
            this.TrendLabel2.Text = "Trend:";
            // 
            // AverageSystolicLabel
            // 
            this.AverageSystolicLabel.AutoSize = true;
            this.AverageSystolicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageSystolicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AverageSystolicLabel.Location = new System.Drawing.Point(254, 471);
            this.AverageSystolicLabel.Name = "AverageSystolicLabel";
            this.AverageSystolicLabel.Size = new System.Drawing.Size(0, 31);
            this.AverageSystolicLabel.TabIndex = 7;
            // 
            // AverageHRValue
            // 
            this.AverageHRValue.AutoSize = true;
            this.AverageHRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageHRValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AverageHRValue.Location = new System.Drawing.Point(718, 471);
            this.AverageHRValue.Name = "AverageHRValue";
            this.AverageHRValue.Size = new System.Drawing.Size(0, 31);
            this.AverageHRValue.TabIndex = 8;
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
            this.SortList.Location = new System.Drawing.Point(258, 13);
            this.SortList.Name = "SortList";
            this.SortList.Size = new System.Drawing.Size(438, 21);
            this.SortList.TabIndex = 9;
            this.SortList.SelectedIndexChanged += new System.EventHandler(this.SortList_SelectedIndexChanged);
            // 
            // SlashLabel
            // 
            this.SlashLabel.AutoSize = true;
            this.SlashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlashLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SlashLabel.Location = new System.Drawing.Point(308, 471);
            this.SlashLabel.Name = "SlashLabel";
            this.SlashLabel.Size = new System.Drawing.Size(23, 31);
            this.SlashLabel.TabIndex = 10;
            this.SlashLabel.Text = "/";
            // 
            // AverageDiastolicLabel
            // 
            this.AverageDiastolicLabel.AutoSize = true;
            this.AverageDiastolicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageDiastolicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AverageDiastolicLabel.Location = new System.Drawing.Point(324, 471);
            this.AverageDiastolicLabel.Name = "AverageDiastolicLabel";
            this.AverageDiastolicLabel.Size = new System.Drawing.Size(0, 31);
            this.AverageDiastolicLabel.TabIndex = 11;
            // 
            // AverageBPPicture
            // 
            this.AverageBPPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AverageBPPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AverageBPPicture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AverageBPPicture.IconColor = System.Drawing.SystemColors.ControlText;
            this.AverageBPPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AverageBPPicture.IconSize = 31;
            this.AverageBPPicture.Location = new System.Drawing.Point(484, 475);
            this.AverageBPPicture.Name = "AverageBPPicture";
            this.AverageBPPicture.Size = new System.Drawing.Size(45, 31);
            this.AverageBPPicture.TabIndex = 12;
            this.AverageBPPicture.TabStop = false;
            // 
            // AverageHRPicture
            // 
            this.AverageHRPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AverageHRPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AverageHRPicture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AverageHRPicture.IconColor = System.Drawing.SystemColors.ControlText;
            this.AverageHRPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AverageHRPicture.IconSize = 31;
            this.AverageHRPicture.Location = new System.Drawing.Point(860, 475);
            this.AverageHRPicture.Name = "AverageHRPicture";
            this.AverageHRPicture.Size = new System.Drawing.Size(45, 31);
            this.AverageHRPicture.TabIndex = 13;
            this.AverageHRPicture.TabStop = false;
            // 
            // BloodPressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1073, 558);
            this.Controls.Add(this.AverageHRPicture);
            this.Controls.Add(this.AverageBPPicture);
            this.Controls.Add(this.SlashLabel);
            this.Controls.Add(this.AverageDiastolicLabel);
            this.Controls.Add(this.SortList);
            this.Controls.Add(this.AverageHRValue);
            this.Controls.Add(this.AverageSystolicLabel);
            this.Controls.Add(this.TrendLabel2);
            this.Controls.Add(this.TrendLabel1);
            this.Controls.Add(this.AverageHRLabel);
            this.Controls.Add(this.AverageBPLabel);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodPressure";
            this.Text = "BloodPressure";
            this.Load += new System.EventHandler(this.BloodPressure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageBPPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageHRPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label AverageBPLabel;
        private System.Windows.Forms.Label AverageHRLabel;
        private System.Windows.Forms.Label TrendLabel1;
        private System.Windows.Forms.Label TrendLabel2;
        private System.Windows.Forms.Label AverageSystolicLabel;
        private System.Windows.Forms.Label AverageHRValue;
        private System.Windows.Forms.ComboBox SortList;
        private System.Windows.Forms.Label SlashLabel;
        private System.Windows.Forms.Label AverageDiastolicLabel;
        private FontAwesome.Sharp.IconPictureBox AverageBPPicture;
        private FontAwesome.Sharp.IconPictureBox AverageHRPicture;
    }
}