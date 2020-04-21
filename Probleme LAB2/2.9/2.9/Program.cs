using System;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            long givenNumber;
            givenNumber = Convert.ToInt64(Console.ReadLine());
            bool lastEvenNumber = false;
            while(!lastEvenNumber )
            {
                if((givenNumber%10)%2 == 0)
                {
                    lastEvenNumber = true;
                    Console.WriteLine(givenNumber % 10);
                }
                else
                {
                    givenNumber = givenNumber / 10; 
                }
            }
        }
    }
}
