using StudentManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace StudentManagementSystem.BusinessLogicLayer
{
    internal class Functions
    {
        private string key = Form1.key;
        
        public int[] countCourse(List<StudentLogic> student,FileHandler file) 
        {
            student = file.read(key);

            int[] count = new int[4];

            int countBOC = 0;
            int countDIT = 0;
            int countBIT = 0;
            int countCIT = 0;

            foreach (var item in student)
            {
                if (item.StuCourse == "Bachelor of Computing")
                {
                    countBOC++;
                }

                if (item.StuCourse == "Diploma in IT")
                {
                    countDIT++;
                }

                if (item.StuCourse == "Bachelor in IT")
                {
                    countBIT++;
                }

                if (item.StuCourse == "Certificate: IT")
                {
                    countCIT++;
                }

            }

            count[0]=countBOC;
            count[1] =countDIT;
            count[2] =countBIT;
            count[3] =countCIT;

            return count;  
        }


        public double[] percentageByCourse(List<StudentLogic> student,FileHandler file)
        {
            double total = 0;


            int[] count = countCourse(student,file);

          

            double[] values = new double[4];

            foreach (int item in count)
            {
                total += item;
            }

            values[0] = count[0] / total;
            values[1] = count[1] / total;
            values[2] = count[2] / total;
            values[3] = count[3] / total;

            return values;

        }

        public double[] averageAge(List<StudentLogic> student, FileHandler file)
      {

            student = file.read(key);

            int[] count = countCourse(student, file);

            int tBOC = 0;
            int tDIT = 0;
            int tBIT = 0;
            int tCIT = 0;   

            double[] average = new double[4];

            foreach (var item in student)
            {
                if (item.StuCourse == "Bachelor of Computing")
                {
                    tBOC += item.StuAge;
                }
                else
                if (item.StuCourse == "Diploma in IT")
                {
                    tDIT += item.StuAge;
                }
                else
                if (item.StuCourse == "Bachelor in IT")
                {
                    tBIT += item.StuAge;
                }
                else
                if (item.StuCourse == "Certificate: IT")
                {
                    tCIT += item.StuAge;
                }
            }

            average[0] = tBOC / count[0];
            average[1] = tDIT / count[1];
            average[2] = tBIT / count[2];
            average[3] = tCIT/ count[3];
          
            return average;
        }

        public string formatSummary(List<StudentLogic> student, FileHandler file)
        {
          

            student = file.read(key);

            int[] Count = new int[4];

            Count = countCourse(student, file);

            int total = 0;

            double average = totalAverage(student, file);

            foreach (int item in Count)
            {
                total += item;
            }

            string output = $@"
Total number of students: {total}
Bachelor of Computing : {Count[0]},
Diploma in IT : {Count[1]},
Bachelor in IT {Count[2]},
Certificate: IT : {Count[3]}
Average age of the students: {average}";
            return output;

        }

        public double totalAverage(List<StudentLogic> student,FileHandler file)
        {
            double average = 0;

         

            student = file.read(key);

            int count = 0;

            int total = 0;


            foreach (var item in student)
            {
                total += item.StuAge;
                count++;
            }

            average = total/count;

            return average;
        }

        public List<StudentLogic> addStudent(List<StudentLogic> student,string ID, string name,int age ,string course,FileHandler file) 
        {

            student = file.read(key);


            student.Add(new StudentLogic(ID,name,age,course));

            return student;
           
        }

        public bool signin(List<User> users, string user, string pass)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Users == user && users[i].Pass == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateInput(string id, string age)
        {
            bool flag = true;

            FileHandler handler = new FileHandler();

            foreach (char c in age)
            {
                if (!char.IsDigit(c))
                {
                    flag = false;
                    MessageBox.Show("Age can only contain numbers");
                    break;
                }
            }

            List<StudentLogic> student = handler.read(key);

            foreach (var item in student)
            {
                if (item.StuID == id)
                {
                    flag = false;
                    MessageBox.Show("Duplicate IDS not allowed");
                }
            }

            return flag;

        }
        public bool check(string pass)
        {
            if (pass.Length == 16 || pass.Length == 24 || pass.Length == 32)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string EncryptData(string data, string encryptionKey)
        {


            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32)); // 256-bit key
                aes.IV = new byte[16]; // AES block size (128-bit)

                using (var memoryStream = new MemoryStream())
                using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (var writer = new StreamWriter(cryptoStream))
                {
                    writer.Write(data);
                    writer.Close();
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }


        }
        public string DecryptData(string encryptedData, string encryptionKey)
        {
            using (Aes aes = Aes.Create())
            {
                try
                {
                    aes.Key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32)); // 256-bit key
                    aes.IV = new byte[16];

                    using (var memoryStream = new MemoryStream(Convert.FromBase64String(encryptedData)))
                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (var reader = new StreamReader(cryptoStream))
                    {
                        return reader.ReadToEnd();
                    }

                }
                catch (CryptographicException ex)
                {
                    MessageBox.Show("wrong pass or corrupted ");
                    return null;
                    throw;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    return null;
                }

            }
        }


    }

        
    
}
