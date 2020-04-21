using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int givenNumber;
            int count = 0;
         
            givenNumber = Convert.ToInt32(Console.ReadLine());

            for(int index = 2; index <= givenNumber; index+=2)
            {
                if(givenNumber%index == 0)
                {
                    count++;
                    Console.Write(index + " ");           
                }
            }
            Console.WriteLine($"\nYour number have {count} even divisors");
            
        }
    }
}
