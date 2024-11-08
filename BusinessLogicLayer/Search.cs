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
            //Get list of all the students
            List<StudentLogic> students = fileHandler.read(key);
            List<StudentLogic> studentFound = new List<StudentLogic>();
            bool found = false;

            //loop through the students
            for (int i = 0; i < students.Count; i++) 
            {
                //If the student is found, break and make found true
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
                return students; //returns all students
            }
            else
            {
                //returns list of found students
                return studentFound;
            }

            
        }
    }
}
