using System;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber;
            int count = 0;
            int sumOfDivisors = 0;

            givenNumber = Convert.ToInt32(Console.ReadLine());

            for (int index = 2; index <= givenNumber; index += 2)
            {
                if (givenNumber % index == 0)
                {
                    count++;
                    Console.Write(index + " ");
                    sumOfDivisors = sumOfDivisors + index;
                }
            }
            Console.WriteLine($"\nYour number have {count} even divisors");
            Console.WriteLine($"\nThe sum of even divisors is {sumOfDivisors}");
        }
    }
}
