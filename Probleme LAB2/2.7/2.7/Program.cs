using System;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber;
            int maxDigit = int.MinValue;

            givenNumber = Convert.ToInt32(Console.ReadLine());

            while(givenNumber > 0)
            {
                if ((givenNumber % 10) > maxDigit)
                {
                    maxDigit = givenNumber % 10;
                    givenNumber = givenNumber / 10;
                }
                else
                {
                    givenNumber = givenNumber / 10;
                }
            }
            Console.WriteLine(maxDigit);
        }
    }
}
