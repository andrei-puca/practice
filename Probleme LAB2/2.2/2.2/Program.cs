using System;
using System.Collections.Generic;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oddDigits = new List<int>();
            int givenNumber;
            int multiplicationValue = 1;

            givenNumber = Convert.ToInt32(Console.ReadLine());

            while (givenNumber > 0)
            {
                if ((givenNumber % 10) % 2 != 0)
                {
                    oddDigits.Add(givenNumber % 10);
                    givenNumber = givenNumber / 10;
                }
                else
                {
                    givenNumber = givenNumber / 10;
                }
            }

            int[] array = oddDigits.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                multiplicationValue *= array[i];
            }
            Console.WriteLine(multiplicationValue);
        }
    }
}
