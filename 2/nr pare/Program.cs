using System;

namespace nr_pare
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck;
            numberToCheck = Convert.ToInt32(Console.ReadLine());
            if (numberToCheck % 2 == 0)
                Console.WriteLine("este par");
            else
                Console.WriteLine("este impar");
        }
    }
}
