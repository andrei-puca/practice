using System;
using System.Collections.Generic;

namespace _2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> mirrorNumber = new List<double>();
            int givenNumber;
            givenNumber = Convert.ToInt32(Console.ReadLine());

            while (givenNumber > 0)
            {
                mirrorNumber.Add(givenNumber % 10);
                givenNumber = givenNumber / 10;
            
            }

            foreach (var digit in mirrorNumber)
                Console.Write(digit);
        }
    }
}
