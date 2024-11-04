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

            private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                // Retrieve the student ID of the selected row
                var selectedRow = dgvDetails.SelectedRows[0];
                string studentId = selectedRow.Cells["stuID"].Value?.ToString();

                if (!string.IsNullOrEmpty(studentId))
                {
                    // Confirm deletion
                    var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Use the FileHandler class to remove the student from the file
                        FileHandler handler = new FileHandler();
                        List<StudentLogic> students = handler.read();

                        // Filter out the student to be deleted
                        students = students.Where(s => s.StuID != studentId).ToList();

                        // Save the updated list back to the file
                        handler.write(students);

                        // Refresh DataGridView
                        dgvDetails.DataSource = null;  // Clear the DataSource first
                        dgvDetails.DataSource = students;

                        MessageBox.Show("Student deleted successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }


        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
