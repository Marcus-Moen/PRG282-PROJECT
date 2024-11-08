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
using Krypton.Toolkit;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Animation;

namespace StudentManagementSystem.PresentationLayer
{
    public partial class frmStatistics : KryptonForm
    {
        FileHandler file = new FileHandler();
        Functions f = new Functions();
        List<StudentLogic> student = new List<StudentLogic>();

        private TextPrinter textPrinter;
        private  string key;
        
        public frmStatistics()
        {
            InitializeComponent();

            key = Form1.key;
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {
            double[] values = new double[4];

            
            student = file.read(key);

            chart1.Series.Clear();

            Functions f = new Functions(); 

            // Set up a new pie chart series
            Series series = new Series("Totals")
            {
                ChartType = SeriesChartType.Pie,       // Set chart type to Pie
                IsValueShownAsLabel = true,            // Show labels on chart
                Label = "#PERCENT{P0}"                 // Display as percentage, no decimal places
            };


            values = f.percentageByCourse(student,file);

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





            chart1.Invalidate();
            chart1.Update();

            chart1.Series.Clear();
            double[] total = f.averageAge(student, file);
            

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
            //Allows you to print the summary from a printer
            string output = f.formatSummary(student, file);

            textPrinter = new TextPrinter(output);

            textPrinter.Print();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Return to login form
            frmLogin login = new frmLogin();

            this.Hide();
            login.ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            //Return to Students Form
            Form1 form = new Form1();
            
            this.Hide();
            form.ShowDialog();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //lets you see a preview of the page that you want to print
            Functions f = new Functions();

            string output = f.formatSummary(student,file);

            textPrinter = new TextPrinter(output);

            textPrinter.ShowPrintPreview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saves summary to textfile
            string output = f.formatSummary(student, file);
            file.writeSummary(output);
            MessageBox.Show("Summary was saved to textfile");
        }
    }
}
