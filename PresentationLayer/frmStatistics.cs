using StudentManagementSystem.BusinessLogicLayer;
using StudentManagementSystem.DataAccessLayer;
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

namespace StudentManagementSystem.PresentationLayer
{
    public partial class frmStatistics : Form
    {
        FileHandler fh = new FileHandler();

        Functions f = new Functions();
        public frmStatistics()
        {
            InitializeComponent();
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {
            double[] values = new double[4];

            List<StudentLogic> student = new List<StudentLogic>();

            chart1.Series.Clear();


            // Set up a new pie chart series
            Series series = new Series("Totals")
            {
                ChartType = SeriesChartType.Pie,       // Set chart type to Pie
                IsValueShownAsLabel = true,            // Show labels on chart
                Label = "#PERCENT{P0}"                 // Display as percentage, no decimal places
            };


            values = f.percentageByCourse(student);

            series.Points.AddXY("Bachelor of Computing",values[0]);
            series.Points.AddXY("Diploma in IT",values[1]);
            series.Points.AddXY("Bachelor in IT",values[2]);
            series.Points.AddXY("Certificate: IT",values[3]);

            chart1.Series.Add(series);

            chart1.Legends.Clear();                       // Clear any existing legends
            Legend legend = new Legend
            {
                Docking = Docking.Right,                  // Position the legend on the right
                IsDockedInsideChartArea = false,          // Make sure it's outside of the pie chart area
                Title = "Course Types"                      // Optional: Add a title to the legend
            };

            foreach (var point in series.Points)
            {
                point.LegendText = point.AxisLabel;       // Set each legend item to show the x-value (category name)
            }

            chart1.Legends.Add(legend);                   // Add the legend to the chart

        }

        private void rbTwo_CheckedChanged(object sender, EventArgs e)
        {
          


            List<StudentLogic> student = fh.read();

            double[] total = f.averageAge(student);

            chart1.Series.Clear();
            

            // Set up a new bar chart series
            Series series = new Series("Average Ages")
            {
                ChartType = SeriesChartType.Column,       // Set chart type to bar
                IsValueShownAsLabel = true          // Show labels on chart            
            };


            series.Points.AddXY("Bachelor of Computing", total[0]);
            series.Points.AddXY("Diploma in IT", total[1]);
            series.Points.AddXY("Bachelor in IT", total[2]);
            series.Points.AddXY("Certificate: IT", total[3]);

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Course";
            chart1.ChartAreas[0].AxisY.Title = "Average Ages";

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
           
          

            List<StudentLogic> student = new List<StudentLogic>();
            string output = f.formatSummary(student);

            rtbSummary.Text = output;

            fh.writeSummary(output);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            this.Hide();
            login.ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            this.Hide();
            form.ShowDialog();
        }
    }
}
