using System;
using StudentManagementSystem.BusinessLogicLayer;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Shapes;

namespace StudentManagementSystem.DataAccessLayer
{
    internal class FileHandler
    {
        public string path = AppDomain.CurrentDomain.BaseDirectory + @"\StudentDetails.txt";
        public string sumPath = AppDomain.CurrentDomain.BaseDirectory + @"\Summary.txt";
        public List<StudentLogic> read()
        {
            List<StudentLogic> students = new List<StudentLogic>();
            string[] LineParts;
            
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                    while ((line = sr.ReadLine()) != null)
                {
                    LineParts = line.Split(',');
                    students.Add(new StudentLogic(LineParts[0], LineParts[1], int.Parse(LineParts[2]), LineParts[3]));

                }
            }
            return students;
        }
        public void write(List<StudentLogic> students)
        {

            using (StreamWriter sw = new StreamWriter(path))
            {
                
                for (int i = 0; i < students.Count; i++) 
                {

                    sw.WriteLine(students[i].format());
                }
            }
        }

        public void writeSummary(string output)
        {

            using (StreamWriter sw = new StreamWriter(sumPath))
            {          

                    sw.WriteLine(output);    
            }
        }
    }
}
