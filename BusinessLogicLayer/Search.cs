using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using StudentManagementSystem.BusinessLogicLayer;
using StudentManagementSystem.DataAccessLayer;

namespace StudentManagementSystem.BusinessLogicLayer
{

    internal class Search
    {
        FileHandler fileHandler = new FileHandler();
        string key;
        public Search(string key)
        {
            this.key = key;
        }
        public List<StudentLogic> searchStudents(string id)
        {
            List<StudentLogic> students = fileHandler.read(key);
            List<StudentLogic> studentFound = new List<StudentLogic>();
            bool found = false;
            for (int i = 0; i < students.Count; i++) 
            {
                if (students[i].StuID == id )
                {
                    studentFound.Add(students[i]);
                    found = true;
                    break;
                }
            }

            if (!found) 
            {
                MessageBox.Show($"Student with ID {id} not found");
                return students;
            }
            else
            {
                return studentFound;
            }

            
        }
    }
}
