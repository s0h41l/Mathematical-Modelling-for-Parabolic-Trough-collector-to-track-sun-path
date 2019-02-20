using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Grapher
{
    public partial class Main : Form
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
        public int time { get; set; }
        public double angleOfTilt { get; set; }
        public double hourAngle { get; set; }
        public double daysFrom { get; set; }
        public double daysTo { get; set; }
        List<double> noOfHousrsBWSunriseAndSunSet = new List<double>();
        List<double> declinationAngle = new List<double>();
        List<double> elevationAngle = new List<double>();
        List<double> azimuthAngle = new List<double>();
        List<double> zenithAngle = new List<double>();
        List<double> incidenceAngle = new List<double>();
        

        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBoxDaysTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDaysFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxCity.Text == "Quetta")
            {
                latitude = 30.18;
                longitude = 66.98;
            }

            if (comboBoxCity.Text == "Sedu Sharif")
            {
                latitude = 34.75;
                longitude = 72.36;
            }
            if (comboBoxCity.Text == "Muzaffarabad")
            {
                latitude = 34.36;
                longitude = 73.47;
            }

            if (comboBoxCity.Text == "Rawalpindi")
            {
                latitude = 33.56;
                longitude = 73.02;
            }
            if (comboBoxCity.Text == "Rohri")
            {
                latitude = 27.67;
                longitude = 68.89;
            }
            if (comboBoxCity.Text == "Karachi")
            {
                latitude = 24.86;
                longitude = 67.00;
            }
            if (comboBoxCity.Text == "Faislabad")
            {
                latitude = 31.45;
                longitude = 73.14;
            }
            if (comboBoxCity.Text == "Hub")
            {
                latitude = 24.01;
                longitude = 66.82;
            }
            if (comboBoxCity.Text == "Kot Addu")
            {
                latitude = 30.46;
                longitude = 70.96;
            }
            if (comboBoxCity.Text == "Lahore")
            {
                latitude = 31.52;
                longitude = 74.36;
            }
            if (comboBoxCity.Text == "Bahawalpur")
            {
                latitude = 29.35;
                longitude = 71.69;
            }

            if (comboBoxCity.Text == "Multan")
            {
                latitude = 30.16;
                longitude = 71.52;
            }
            if (comboBoxCity.Text == "Muzaffargarh")
            {
                latitude = 30.07;
                longitude = 71.18;
            }
            if (comboBoxCity.Text == "Khanpur")
            {
                latitude = 28.63;
                longitude = 70.66;
            }
            if (comboBoxCity.Text == "Sialkot")
            {
                latitude = 32.49;
                longitude = 74.52;
            }
            if (comboBoxCity.Text == "Murree")
            {
                latitude = 33.91;
                longitude = 73.39;
            }


            hourAngle = 15*(Convert.ToDouble(textBoxTime.Text)-12);
            angleOfTilt = 45;
            daysFrom = Convert.ToDouble(numericUpDownFrom.Value);
            daysTo = Convert.ToDouble(numericUpDownTo.Value);



            chart1.ChartAreas[0].Axes[0].Title = "n";
            chart1.ChartAreas[0].Axes[1].Title = "Incidence Angle";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].LegendText = "Grapher";


            chart2.ChartAreas[0].Axes[0].Title = "n";
            chart2.ChartAreas[0].Axes[1].Title = "Declination Angle";
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart2.Series[0].LegendText = "Grapher";

            chart3.ChartAreas[0].Axes[0].Title = "n";
            chart3.ChartAreas[0].Axes[1].Title = "Elevation Angle";
            chart3.Series[0].ChartType = SeriesChartType.Line;
            chart3.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart3.Series[0].LegendText = "Grapher";

            chart4.ChartAreas[0].Axes[0].Title = "n";
            chart4.ChartAreas[0].Axes[1].Title = "Azimuth Angle";
            chart4.Series[0].ChartType = SeriesChartType.Line;
            chart4.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart4.Series[0].LegendText = "Grapher";

            chart5.ChartAreas[0].Axes[0].Title = "n";
            chart5.ChartAreas[0].Axes[1].Title = "Zenith Angle";
            chart5.Series[0].ChartType = SeriesChartType.Line;
            chart5.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart5.Series[0].LegendText = "Grapher";


            for (int n=Convert.ToInt16(numericUpDownFrom.Value);n<=Convert.ToInt16(numericUpDownTo.Value); n++)
            {
                double decAngle =23.5*Math.Sin((360*(284+n)/365)*Math.PI/180);
                //MessageBox.Show(decAngle.ToString());
                //double noOfHours = (2/15) * Math.Acos(-0.2475);
                //MessageBox.Show(noOfHours.ToString());
                //noOfHousrsBWSunriseAndSunSet.Add(noOfHours);
                double elevAngle = Math.Asin((Math.Sin(decAngle*((Math.PI)/180))*Math.Sin((latitude)*(Math.PI/180)))+((Math.Cos(decAngle*(Math.PI/180))*Math.Cos((latitude*(Math.PI/180)))*Math.Cos((hourAngle)*(Math.PI/180)))))*180/Math.PI;
                elevationAngle.Add(elevAngle);
                double azimAngle = Math.Acos((Math.Sin((decAngle-latitude)*Math.PI/180)*Math.Cos(hourAngle*Math.PI/180))/Math.Cos(elevAngle*Math.PI/180))*180/Math.PI;
                elevationAngle.Add(azimAngle);
                double zenAngle = 90 - elevAngle;
                zenithAngle.Add(zenAngle);
                double A = Math.Sin(latitude * Math.PI / 180) * Math.Cos(angleOfTilt * Math.PI / 180);
                double B = Math.Cos(latitude * Math.PI / 180) * Math.Sin(angleOfTilt * Math.PI / 180) * Math.Cos(azimAngle * Math.PI / 180);
                double C = Math.Sin(angleOfTilt * Math.PI / 180) * (Math.Sin(azimAngle * Math.PI / 180));
                double D = Math.Cos(latitude * Math.PI / 180) * Math.Cos(angleOfTilt * Math.PI / 180);
                double E = Math.Sin(latitude * Math.PI / 180) * Math.Sin(angleOfTilt * Math.PI / 180) * Math.Cos(azimAngle * Math.PI / 180);
                double incidenceAng = Math.Acos(((A - B) * Math.Sin(decAngle * Math.PI / 180)) + (((C * Math.Sin(hourAngle * Math.PI / 180)) + ((D + E) * Math.Cos(hourAngle * Math.PI / 180))*Math.Cos(decAngle*Math.PI/180))))*180/Math.PI;
                incidenceAngle.Add(incidenceAng);
                chart1.Series[0].Points.Add(new DataPoint(n,incidenceAng));
                chart2.Series[0].Points.Add(new DataPoint(n, decAngle));
                chart3.Series[0].Points.Add(new DataPoint(n, elevAngle));
                chart4.Series[0].Points.Add(new DataPoint(n, azimAngle));
                chart5.Series[0].Points.Add(new DataPoint(n, zenAngle));


            }
                        
         
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
