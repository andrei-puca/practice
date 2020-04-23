using System;
using System.Collections.Generic;

namespace HomeworkCurs2

{
    class Program
    {
        static void Main(string[] args)
        {
            var noOfValues = 0;
            double sumOfAllValues = 0;
            int i, j;
            string studentName = "";
            int grade;
            int noOfGrades = 0;

            Console.WriteLine("Introduce the number of students:");
            int noOfStudents = Convert.ToInt32(Console.ReadLine());

            List<string> studentsName = new List<string>(noOfStudents);
            List<double> studentGrades = new List<double>(noOfGrades);
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (i = 0; i < noOfStudents; i++)
            {
                Console.WriteLine($"Add student {i + 1}");
                studentName = Console.ReadLine();
                Console.WriteLine("Introduce the number of grades:");
                noOfGrades = Convert.ToInt32(Console.ReadLine());
                for (j = 0; j < noOfGrades; j++)
                {
                    Console.WriteLine($"Add grade {j + 1} for student {studentName}");
                    grade = Convert.ToInt32(Console.ReadLine());
                    studentGrades.Add(grade);
                }
                students.Add(studentName, new List<double>(studentGrades));
                studentGrades.Clear();
            }

            foreach (KeyValuePair<string, List<double>> item in students)
            {
                foreach (var value in item.Value)
                {
                    sumOfAllValues = sumOfAllValues + value;
                    noOfValues++;
                }
                double arithmeticMean = Convert.ToDouble(sumOfAllValues / noOfValues);
                Console.WriteLine($"Student {item.Key } has the arithmetical mean equal to {arithmeticMean}");
                noOfValues = 0;
                sumOfAllValues = 0;
            }
        }
    }
}