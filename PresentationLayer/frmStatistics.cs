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
        public frmStatistics()
        {
            InitializeComponent();
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();



            // Set up a new pie chart series
            Series series = new Series("Sales")
            {
                ChartType = SeriesChartType.Pie,       // Set chart type to Pie
                IsValueShownAsLabel = true,            // Show labels on chart
                Label = "#PERCENT{P0}"                 // Display as percentage, no decimal places
            };

        }
    }
}
