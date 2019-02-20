namespace Grapher
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAngleOfTilt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Faislabad",
            "Hub",
            "Karachi",
            "Kot Addu",
            "Muzaffarabad",
            "Quetta",
            "Rawalpindi",
            "Rohri",
            "Sedu Sharif"});
            this.comboBoxCity.Location = new System.Drawing.Point(130, 56);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(239, 21);
            this.comboBoxCity.Sorted = true;
            this.comboBoxCity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(130, 87);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(239, 20);
            this.textBoxTime.TabIndex = 3;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "to";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxAngleOfTilt
            // 
            this.textBoxAngleOfTilt.Location = new System.Drawing.Point(130, 150);
            this.textBoxAngleOfTilt.Name = "textBoxAngleOfTilt";
            this.textBoxAngleOfTilt.Size = new System.Drawing.Size(239, 20);
            this.textBoxAngleOfTilt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Angle of tilt";
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(130, 120);
            this.numericUpDownFrom.Maximum = new decimal(new int[] {
            364,
            0,
            0,
            0});
            this.numericUpDownFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownFrom.TabIndex = 10;
            this.numericUpDownFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(262, 120);
            this.numericUpDownTo.Maximum = new decimal(new int[] {
            366,
            0,
            0,
            0});
            this.numericUpDownTo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownTo.TabIndex = 11;
            this.numericUpDownTo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(401, 19);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(359, 260);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea7.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart2.Legends.Add(legend7);
            this.chart2.Location = new System.Drawing.Point(789, 22);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(296, 257);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea8.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart3.Legends.Add(legend8);
            this.chart3.Location = new System.Drawing.Point(401, 308);
            this.chart3.Name = "chart3";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart3.Series.Add(series8);
            this.chart3.Size = new System.Drawing.Size(359, 300);
            this.chart3.TabIndex = 15;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea9.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart4.Legends.Add(legend9);
            this.chart4.Location = new System.Drawing.Point(785, 308);
            this.chart4.Name = "chart4";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart4.Series.Add(series9);
            this.chart4.Size = new System.Drawing.Size(300, 300);
            this.chart4.TabIndex = 16;
            this.chart4.Text = "chart4";
            // 
            // chart5
            // 
            chartArea10.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart5.Legends.Add(legend10);
            this.chart5.Location = new System.Drawing.Point(38, 308);
            this.chart5.Name = "chart5";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart5.Series.Add(series10);
            this.chart5.Size = new System.Drawing.Size(300, 300);
            this.chart5.TabIndex = 17;
            this.chart5.Text = "chart5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Baran Shafqat (2015-ME-01)\nZain ul Abadin (2015-ME-124)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 670);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Supervisor: Prof. Dr. Asif Mehmood Qureshi";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 698);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownTo);
            this.Controls.Add(this.numericUpDownFrom);
            this.Controls.Add(this.textBoxAngleOfTilt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Mathematical Modelling for Parabolic Trough Collector to Track Sun Path";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAngleOfTilt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

