using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis1.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }

        public double GetAverageGrade()
        {
            double sum = 0;

            for(int i = 0; i < Grades.Length; i++)
            {
                sum += Grades[i];
            }

            return sum / Grades.Length;
        }
        public string GetStatus()
        {
            string result = string.Empty;
            double average = GetAverageGrade();
            if (average >= 9)
                result = "Puiku";
            else if (average >= 7)
                result = "Gerai";
            else if (average >= 5)
                result = "Patenkinama";
            else
                result = "Nepatenkinama";

            return result;
        }
    }
}
