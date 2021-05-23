using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            double lowGrade = double.MaxValue;
            double highGrade = double.MinValue;
            
            foreach (var number in grades)
            {
                if (number > highGrade)
                {
                    lowGrade = Math.Min(number, lowGrade);
                    highGrade = Math.Max(number, highGrade);
                    result += number;
                }
            }

            result /= grades.Count;
            Console.WriteLine($"Your total amount of grades was {grades.Count}");
            Console.WriteLine($"Your average grade score was {result:N1}");
            Console.WriteLine($"Your lowest score was {lowGrade}");
            Console.WriteLine($"Your highest score was {highGrade}");
        }

        private List<double> grades;
        private string name;
    }
}