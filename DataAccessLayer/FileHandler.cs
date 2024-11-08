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
         string path = AppDomain.CurrentDomain.BaseDirectory + @"\StudentDetails.txt";
         string sumPath = AppDomain.CurrentDomain.BaseDirectory + @"\Summary.txt";
         string logPath = AppDomain.CurrentDomain.BaseDirectory + @"\logins.txt";
         Functions functions = new Functions();
      
        public List<StudentLogic> read(string key)
        {
            List<StudentLogic> students = new List<StudentLogic>();
            string[] LineParts;
          
            //Read from the textfile while decrypting the data

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    LineParts = line.Split(',');
                    //If the student ID is not null then add student to list
                    if (functions.DecryptData(LineParts[0], key) != null)
                    {
                        //Add  student to list and decrypt values
                        students.Add(new StudentLogic(functions.DecryptData(LineParts[0], key), functions.DecryptData(LineParts[1], key), int.Parse(functions.DecryptData(LineParts[2], key)), functions.DecryptData(LineParts[3], key)));
                        
                    }
                }
            }
            return students;
        }
        public void write(List<StudentLogic> students,string key)
        {
            //Writes given list to file
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {

                        for (int i = 0; i < students.Count; i++)
                        {
                            //Writes to the file line by line and encrypts the data using the format(key) function
                            sw.WriteLine(students[i].format(key));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File not found");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error writing to file");
                throw;
            }

        }

        public void writeSummary(string output)
        {
            //Writes the summary to the Summary textfile
            using (StreamWriter sw = new StreamWriter(sumPath))
            {

                sw.WriteLine(output);
            }
        }
        public List<User> logins()
        {
            //Reads from the login file and makes User Objects, returns a list of User Objects
            List<User> users = new List<User>();
            string[] LineParts;
            using (StreamReader sr = new StreamReader(logPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    LineParts = line.Split(',');
                    users.Add(new User(LineParts[0], LineParts[1]));

                }
            }
            return users;
        }
    }
}
