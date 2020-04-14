using System;

namespace things
{
    class Program
    {
        static void Main(string[] args)
        {

            int lenght;
            int numberToRead;
            int max = Int32.MinValue;
            lenght = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= lenght; i++)
            {
                numberToRead = Convert.ToInt32(Console.ReadLine());
                if (numberToRead > max)
                    max = numberToRead;
            }

            Console.WriteLine(max);
        }
    }
}
