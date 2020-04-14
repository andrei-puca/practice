using System;

namespace probl9
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int[] numere = new int[20];
            int i=0;
            int counter = 0;
            while (input != 0)
            {
                numere[i] = input;
                i++;
                input = Convert.ToInt32(Console.ReadLine());

            }
            for (int index = 0; index < i; index++)
            {
                if(numere[index]%2 == 0)
                {
                    counter++;
                }
            }
                Console.WriteLine($"In the previous list, we have {counter} even numbers");
        }
    }
}
