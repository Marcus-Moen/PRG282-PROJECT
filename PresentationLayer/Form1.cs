using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using StudentManagementSystem.BusinessLogicLayer;
using StudentManagementSystem.DataAccessLayer;
using StudentManagementSystem.PresentationLayer;

namespace StudentManagementSystem
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            FileHandler handler = new FileHandler();
            List<StudentLogic> students = handler.read();
            dgvDetails.DataSource = students;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            
            this.Hide();
            login.ShowDialog();

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            
            dgvDetails.DataSource = search.searchStudents(txtSearch.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            Update update = new Update();

            update.updateStudents(txtID.Text,txtName.Text,int.Parse(txtAge.Text),cmbCourse.Text);
            
            List<StudentLogic> students = handler.read();
            dgvDetails.DataSource = students;
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header
            if (e.ColumnIndex >= 0 && e.RowIndex >=0)
            {
                // Get the values from the clicked row
                var row = dgvDetails.Rows[e.RowIndex];

                
                txtID.Text = row.Cells["stuID"].Value?.ToString(); 
                txtName.Text = row.Cells["stuName"].Value?.ToString();
                txtAge.Text = row.Cells["stuAge"].Value?.ToString();
                cmbCourse.Text = row.Cells["stuCourse"].Value?.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            
        }

        private void dgvDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDetails.Rows[e.RowIndex];


                txtID.Text = row.Cells["stuID"].Value?.ToString();
                txtName.Text = row.Cells["stuName"].Value?.ToString();
                txtAge.Text = row.Cells["stuAge"].Value?.ToString();
                cmbCourse.Text = row.Cells["stuCourse"].Value?.ToString();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            List<StudentLogic> students = handler.read();
            dgvDetails.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
             frmStatistics statistics = new frmStatistics();
            this.Hide();
            statistics.ShowDialog();
        }
    }
}
