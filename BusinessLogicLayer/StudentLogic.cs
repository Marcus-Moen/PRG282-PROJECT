﻿using StudentManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        Functions f = new Functions();
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
        public string format(string key)
        {

           return f.EncryptData(StuID,key) + "," + f.EncryptData(StuName,key) + "," + f.EncryptData(StuAge.ToString(),key) + "," + f.EncryptData(StuCourse, key);
          
        }

  
    }
}
