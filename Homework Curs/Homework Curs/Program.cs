using System;
using System.Collections.Generic;

namespace Homework_Curs

{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> parts = new List<double>();

            
            string[] students = new string[3] { "Ana", "Maria" , "Dan" };
            double[] grades = new double[] { 1, 2, 3, 
                                            4, 5, 6, 
                                            7, 8, 9 };

            
            double sum = 0;
            double count = 0;
            double arithmeticMean;
            int i;
            foreach (var grade in grades)
            {
                sum = sum + grade;
                count++;
                if (count == 3)
                {
                    arithmeticMean = sum / count;
                    parts.Add(arithmeticMean);
                    count = 0;
                    sum = 0;
                }
            }
            for(i=0; i < students.Length; i++ )
            {
                Console.WriteLine($"The student {students[i]} has the arithmetic mean {parts[i]}");
            }
        }
    }
}
