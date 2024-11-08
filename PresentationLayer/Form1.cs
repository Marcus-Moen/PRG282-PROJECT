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
        static FileHandler handler = new FileHandler();
        Functions f = new Functions();
        public static string key;
        List<StudentLogic> students = null;
      
       

         public Form1()
        {
            InitializeComponent();
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
            
            Update update = new Update();

            update.updateStudents(txtID.Text,txtName.Text,int.Parse(txtAge.Text),cmbCourse.Text,handler,key);
            
            List<StudentLogic> students = handler.read(key);
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
            
            List<StudentLogic> students = handler.read(key);
            dgvDetails.DataSource = students;
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<StudentLogic> student = new List<StudentLogic>();

            string id="";
            string name="";
            int age = 0;
            string course = "";

            id = txtID.Text;
            name = txtName.Text;
            age = int.Parse(txtAge.Text);
            course = cmbCourse.SelectedItem.ToString();

            

           student = f.addStudent(student,id,name,age,course,handler);

            handler.write(student,key);

            dgvDetails.DataSource = student;

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
                        List<StudentLogic> students = handler.read(key);

                        // Filter out the student to be deleted
                        students = students.Where(s => s.StuID != studentId).ToList();

                        // Save the updated list back to the file
                        handler.write(students,key);

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

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
            key = txtbPass.Text;
            students = handler.read(key);
            dgvDetails.DataSource=students;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (f.check(txtbPass.Text) == true)
            {
                key = txtbPass.Text;
               handler.write(students,key);
                students = handler.read(key);
                dgvDetails.DataSource = students;

            }
            else
            {
                MessageBox.Show("Please enter in a password with length 16 or 24 or 32 char long");
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
