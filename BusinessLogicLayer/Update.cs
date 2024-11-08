using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using StudentManagementSystem.DataAccessLayer;

namespace StudentManagementSystem.BusinessLogicLayer
{
    internal class Update
    {
       

        public void updateStudents(string id, string name, int age, string course,FileHandler fileHandler,string key)
        {
            var students = fileHandler.read(key);
            bool studentExists = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StuID == id)
                {
                    students[i].StuName = name;
                    students[i].StuAge = age; 
                    students[i].StuCourse = course;
                    studentExists = true;
                    break;
                }
            }

            if (!studentExists) 
            {
                MessageBox.Show($"Student With ID {id} Does Not Exist");
            }

            fileHandler.write(students,key);
        }

    }
}
