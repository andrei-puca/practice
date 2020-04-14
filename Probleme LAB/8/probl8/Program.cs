using System;
using System.Collections.Generic;


namespace probl8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            List<int> termsList = new List<int>();
            number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0 ; i <= number; i++ )
            {
                if (i != 0)
                    termsList.Add(i);
            }
            int[] myNumbers = termsList.ToArray();
            Array.Sort(myNumbers);
            for(int i = 0; i < myNumbers.Length; i++)
            {
                Console.Write($"{myNumbers[i]} ");
            }
            Console.WriteLine();
            Array.Reverse(myNumbers);

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.Write($"{myNumbers[i]} ");
            }

        }
    }
}
