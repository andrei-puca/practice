using System;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber;
            int count = 0;
            givenNumber = Convert.ToInt32(Console.ReadLine());

            while(givenNumber > 0)
            {
                    count++;
                    givenNumber = givenNumber / 10;
            }
            Console.WriteLine(count);
        }
    }
}
