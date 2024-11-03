using StudentManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BusinessLogicLayer
{
    internal class Functions
    {

        public int[] countCourse(List<StudentLogic> student) 
        {
            FileHandler fh = new FileHandler();

            student = fh.read();

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


        public double[] percentageByCourse(List<StudentLogic> student)
        {
            double total = 0;


            int[] count = countCourse(student);

          

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

        public double[] averageAge(List<StudentLogic> student)
      {
            FileHandler fh = new FileHandler();

            student = fh.read();

            int[] count = countCourse(student);

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

        public string formatSummary(List<StudentLogic> student)
        {
            FileHandler fh = new FileHandler();

            student = fh.read();

            int[] Count = new int[4];

            Count = countCourse(student);

            int total = 0;

            double average = totalAverage(student);

            foreach (int item in Count)
            {
                total += item;
            }

            string output = $@"The total number of students are:{total}
                            There are {Count[0]} students in Bachelor of Computing,
                             {Count[1]} students in Diploma in IT,
                             {Count[2]} students in Bachelor in IT ,
                              {Count[3]} students in Certificate: IT
                              The average age of the students is : {average}";
            return output;

        }

        public double totalAverage(List<StudentLogic> student)
        {
            double average = 0;

            FileHandler fh = new FileHandler();

            student = fh.read();

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

    }
}
