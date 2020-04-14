using System;

namespace numar_mai_mare_ca
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int secondNumber = 0;
            int firstToDisplay = 0;
            number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                    firstToDisplay = i;
            }
            Console.WriteLine(firstToDisplay);
            Console.WriteLine(firstToDisplay - 2);

        }
    }
}
