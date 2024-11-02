using StudentManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentManagementSystem.BusinessLogicLayer
{
    internal class StudentLogic
    {
        string stuID;
        string stuName;
        int stuAge;
        string stuCourse;
        public StudentLogic(string ID,string Name,int Age,string Course)
        {
            this.stuID = ID;
            this.stuName = Name;
            this.stuAge = Age;
            this.stuCourse = Course;
        }
        public string StuID
        {
            get { return stuID; }
            set { stuID = value; }
        }
        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }
        public int StuAge
        {
            get { return stuAge; }
            set { stuAge = value; }
        }
        public string StuCourse
        {
            get { return stuCourse; }
            set { stuCourse = value; }
        }
        public string format()
        {
            return StuID + "," + StuName + "," + StuAge.ToString() + "," + StuCourse;
        }

        public void totalByCourse(List<StudentLogic> student)
        {
            FileHandler fh = new FileHandler();

            student = fh.read();



            foreach (var item in student)
            {
                
            }

        }
    }
}
