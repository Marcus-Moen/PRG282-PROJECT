using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
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
        public bool dataPasswordEntered = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Return to login form
            frmLogin login = new frmLogin();
            dataPasswordEntered = false;
            this.Hide();
            login.ShowDialog();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search(key);

            if (dataPasswordEntered)
            {
                //Searches for student and displays found student in the datagridView
                dgvDetails.DataSource = search.searchStudents(txtSearch.Text);
            }
            else
            {
                MessageBox.Show("Please enter data password before searching");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Update update = new Update();
            if (dataPasswordEntered)
            {
                //Updates Student and textfile
                if (CheckIfBlank() == true && validateDigit(txtAge.Text) == true) 
                {
                    update.updateStudents(txtID.Text, txtName.Text, int.Parse(txtAge.Text), cmbCourse.Text, handler, key);
                    txtID.ForeColor = Color.Black;
                    txtAge.ForeColor = Color.Black;
                    txtName.ForeColor = Color.Black;
                    cmbCourse.ForeColor = Color.Black;
                    List<StudentLogic> students = handler.read(key);
                    dgvDetails.DataSource = students;
                }
                
            }
            else
            {
                MessageBox.Show("Please enter data Password before updating data");
            }
            
        }


        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
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
            //Clears textboxes and inputs placeholders
            txtID.Text = "Enter Student ID";
            txtID.ForeColor = Color.Gray;

            txtName.Text = "Enter Student Name";
            txtName.ForeColor = Color.Gray;

            txtAge.Text = "Enter Student Age";
            txtAge.ForeColor = Color.Gray;

            cmbCourse.Text = "Choose A Course";
            cmbCourse.SelectedItem = null;
            cmbCourse.ForeColor = Color.Black;

        }

        private void dgvDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Check if selected row is not a heading to avoid errors
            if (e.RowIndex >= 0)
            {
                var row = dgvDetails.Rows[e.RowIndex];

                // Sets the text properties of the textboxes and combobox to the corresponding values from the DataGridView row,
                // handling potential null values with the null-conditional operator.
                txtID.Text = row.Cells["stuID"].Value?.ToString();
                txtName.Text = row.Cells["stuName"].Value?.ToString();
                txtAge.Text = row.Cells["stuAge"].Value?.ToString();
                cmbCourse.Text = row.Cells["stuCourse"].Value?.ToString();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (dataPasswordEntered)
            {
                List<StudentLogic> students = handler.read(key);
                dgvDetails.DataSource = students;
            }
            else
            {
                MessageBox.Show("Please enter data Password to view data");
            }
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = "";
            string name = "";
            string age = "";
            string course = "";

            bool flagBlank = true;
            bool flagvalidate = true;

            if (dataPasswordEntered)
            {
                List<StudentLogic> student = new List<StudentLogic>();
                student = handler.read(key);
                //If inputs arent blank
                if (flagBlank == CheckIfBlank())
                {
                    id = txtID.Text;
                    name = txtName.Text;
                    age = txtAge.Text;
                    course = cmbCourse.SelectedItem.ToString();
                    //Add student if ID is not the same as another student
                    if (flagvalidate == f.ValidateInput(id, age, handler, key))
                    {
                        student = f.addStudent(student, id, name, int.Parse(age), course, handler);
                        handler.write(student, key);
                        dgvDetails.DataSource = student;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter data Password before adding data");
            }
            
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //Changes to statistics form
            frmStatistics statistics = new frmStatistics();
            if (dataPasswordEntered)
            {
                this.Hide();
                statistics.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cannot Enter Statistics without entering data Password");
            }
            
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
                        handler.write(students, key);

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


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //checks the password and displays student details
            
            key = txtbPass.Text;
            students = handler.read(key);
            dgvDetails.DataSource = students;
            dataPasswordEntered = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //Checks if the data password has been entered
            if (dataPasswordEntered)
            {
                //Checks if new password is the correct length
                if (f.check(txtbPass.Text) == true)
                {
                    //Write to textfile and replacing old key with new key
                    List<StudentLogic> oldList = handler.read(key);
                    key = txtbPass.Text;
                    handler.write(oldList, key);
                    students = handler.read(key);
                    dgvDetails.DataSource = students;
                    MessageBox.Show($"Data Password has changed to: {txtbPass.Text}");
                }
                else
                {
                    MessageBox.Show("Please enter in a password with length 16 or 24 or 32 char long");
                }
            }
            else
            {
                MessageBox.Show("Enter Password before changing it");
            }
            
        }


        // Removes Placeholder text when entering textbox
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Enter Student ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "Enter Student ID";
                txtID.ForeColor = Color.Gray;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Enter Student Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Enter Student Name";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "Enter Student Age")
            {
                txtAge.Text = "";
                txtAge.ForeColor = Color.Black;
            }

        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                txtAge.Text = "Enter Student Age";
                txtAge.ForeColor = Color.Gray;
            }
        }

        //Checks for Blank values
        public bool CheckIfBlank()
        {
            bool flag = true;

            if (txtID.Text == "Enter Student ID")
            {
                flag = false;
                ChangeTextBoxColor(txtID);

            }

            if (txtName.Text == "Enter Student Name")
            {
                flag = false;
                ChangeTextBoxColor(txtName);

            }

            if (txtAge.Text == "Enter Student Age")
            {
                flag = false;
                ChangeTextBoxColor(txtAge);


            }

            if (cmbCourse.SelectedItem == null)
            {
                flag = false;
                ChangeComboBoxColor(cmbCourse);

            }


            if (flag == false)
            {
                MessageBox.Show("A field cannot be left blank");
            }

            return flag;
        }

        public bool validateDigit(string age)
        {
            //checks if all characters in a string are numbers
            bool digit = true;
            foreach (char c in age)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Age can only contain numbers");
                    digit = false;
                    break;

                }
            }

            return digit;
        }
        public void ChangeTextBoxColor(TextBox textBox)
        {
            // Store the original color
            Color originalColor = textBox.ForeColor;

            // Start a new thread to handle the temporary color change

            Thread thread = new Thread(() =>
            {
                // Change the ForeColor using Invoke to access the UI thread
                textBox.Invoke((MethodInvoker)(() => textBox.ForeColor = Color.Red));

                // Wait for the specified duration
                Thread.Sleep(3000);

                // Revert the color back to the original
                textBox.Invoke((MethodInvoker)(() => textBox.ForeColor = originalColor));
            });

            thread.Start();
        }

        public void ChangeComboBoxColor(ComboBox textBox)
        {
            // Store the original color
            Color originalColor = Color.Black;

            // Start a new thread to handle the temporary color change

            Thread thread = new Thread(() =>
            {
                // Change the ForeColor using Invoke to access the UI thread
                textBox.Invoke((MethodInvoker)(() => textBox.ForeColor = Color.Red));

                // Wait for the specified duration
                Thread.Sleep(3000);

                // Revert the color back to the original
                textBox.Invoke((MethodInvoker)(() => textBox.ForeColor = originalColor));
            });

            thread.Start();
        }
       




    }
}
