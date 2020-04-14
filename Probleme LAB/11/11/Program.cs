using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        { 
            int givenNumber;
            int counter = 0;

            givenNumber = Convert.ToInt32(Console.ReadLine());

            while(givenNumber > 0)
            {
                if ((givenNumber % 10) % 2 == 0)
                    counter++;
                givenNumber = givenNumber / 10;
            }

            Console.WriteLine(counter);
        }
    }
}
