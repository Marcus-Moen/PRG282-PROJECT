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
using System.Windows.Media.Animation;


namespace StudentManagementSystem.BusinessLogicLayer
{
    internal class Functions
    {
        private string key = Form1.key;
        
        public int[] countCourse(List<StudentLogic> student,FileHandler file) 
        {
            //return a list of the students
            student = file.read(key);

            int[] count = new int[4];

            int countBOC = 0;
            int countDIT = 0;
            int countBIT = 0;
            int countCIT = 0;

            //count how much students take each course
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
            //return array of students in each course
            return count;  
        }


        public double[] percentageByCourse(List<StudentLogic> student,FileHandler file)
        {
            double total = 0;

            //Count how much students in each course
            int[] count = countCourse(student,file);

          

            double[] values = new double[4];

            foreach (int item in count)
            {
                total += item;
            }
            //Calculate what percentage of students take each course
            values[0] = count[0] / total;
            values[1] = count[1] / total;
            values[2] = count[2] / total;
            values[3] = count[3] / total;

            return values;

        }

        public double[] averageAge(List<StudentLogic> student, FileHandler file)
        {
            //Get student details
            student = file.read(key);

            int[] count = countCourse(student, file);

            int tBOC = 0;
            int tDIT = 0;
            int tBIT = 0;
            int tCIT = 0;

            double[] average = new double[4];

            // Calculate the total age for each course
            foreach (var item in student)
            {
                if (item.StuCourse == "Bachelor of Computing")
                {
                    tBOC += item.StuAge;
                }
                else if (item.StuCourse == "Diploma in IT")
                {
                    tDIT += item.StuAge;
                }
                else if (item.StuCourse == "Bachelor in IT")
                {
                    tBIT += item.StuAge;
                }
                else if (item.StuCourse == "Certificate: IT")
                {
                    tCIT += item.StuAge;
                }
            }

            // Check if Zero first to avoid division by zero error
            if (count[0] != 0)
            {
                average[0] = (double)tBOC / count[0];
            }
            else
            {
                average[0] = 0;
            }

            if (count[1] != 0)
            {
                average[1] = (double)tDIT / count[1];
            }
            else
            {
                average[1] = 0;
            }

            if (count[2] != 0)
            {
                average[2] = (double)tBIT / count[2];
            }
            else
            {
                average[2] = 0;
            }

            if (count[3] != 0)
            {
                average[3] = (double)tCIT / count[3];
            }
            else
            {
                average[3] = 0;
            }
            //return average age for each course
            return average;

        }

        public string formatSummary(List<StudentLogic> student, FileHandler file)
        {
            

            student = file.read(key);

            int[] Count = new int[4];

            //returns array of students in each course
            Count = countCourse(student, file);

            int total = 0;
            //returns the average age
            double average = totalAverage(student, file);

            //Get total number of students
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
            //Adds student to list
            student.Add(new StudentLogic(ID,name,age,course));

            return student;
           
        }

        public bool signin(List<User> users, string user, string pass)
        {
            //checks if the username and password is correct
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Users == user && users[i].Pass == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateInput(string id, string age,FileHandler file,string key)
        {
            bool flag = true;
            
            //Makes sure that age is a number
            foreach (char c in age)
            {
                if (!char.IsDigit(c))
                {
                    flag = false;
                    MessageBox.Show("Age can only contain numbers");
                    break;
                }
            }

            List<StudentLogic> student = file.read(key);

            //Makes sure that Student ID doesnt already exist
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
            //Checks if the data password is the correct length
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

            // Create an instance of the AES encryption algorithm.
            using (Aes aes = Aes.Create())
            {
                // Set the encryption key by converting the given encryptionKey string to a byte array.
                // PadRight(32) ensures the key is exactly 32 bytes (256 bits), the required length for AES-256.
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32)); // 256-bit key

                // Set the initialization vector (IV) to 16 bytes (128 bits), which is the block size for AES.
                aes.IV = new byte[16]; // AES block size (128-bit)

                // Create a memory stream to hold the encrypted data.
                using (var memoryStream = new MemoryStream())
                // Create a CryptoStream that will encrypt data written to the memory stream using the AES encryptor.
                using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                // Create a StreamWriter to write plain text data to the cryptoStream, which will encrypt it.
                using (var writer = new StreamWriter(cryptoStream))
                {
                    // Write the data (in plaintext) to the writer, which passes it through the cryptoStream for encryption.
                    writer.Write(data);


                    writer.Close();

                    // Convert the encrypted data in memoryStream to a Base64 string and return it as the result.
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }


        }
        public string DecryptData(string encryptedData, string encryptionKey)
        {
            // Create a new instance of the AES encryption algorithm
            using (Aes aes = Aes.Create())
            {
                try
                {
                    // Set the encryption key to a 256-bit value by padding or truncating the encryption key to 32 bytes (256 bits)
                    aes.Key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32)); // 256-bit key

                    // Initialize the initialization vector (IV) to a zeroed 16-byte array for AES
                    aes.IV = new byte[16];

                    // Open the encrypted data and create a memory stream from it
                    using (var memoryStream = new MemoryStream(Convert.FromBase64String(encryptedData)))
                    // Create a CryptoStream that will decrypt data from the memory stream using AES decryption
                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    // Create a StreamReader to read the decrypted data from the CryptoStream
                    using (var reader = new StreamReader(cryptoStream))
                    {
                        return reader.ReadToEnd();
                    }

                }
                catch (CryptographicException ex)
                {
                    MessageBox.Show("wrong pass or corrupted ");
                    return null;
                    
                    
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
