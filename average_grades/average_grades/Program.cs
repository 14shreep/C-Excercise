using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrGrades = new int[] { 78, 89, 90, 76, 98, 65 };

            int total = 0;
            int gradeCount = 0;
            double average = 0.0;

           
            foreach (int grade in arrGrades)
            {
                total = total + grade; // add each grade value to total
                gradeCount++;          // increment counter for use in average
            }

            average = total / gradeCount;   // calculate average of grades
            Console.WriteLine(average);

        }
    }
}
