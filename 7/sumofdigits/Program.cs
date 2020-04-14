using System;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int digit;
            int sum = 0;
            number = Convert.ToInt32(Console.ReadLine());
            
            while (number > 0)
            {
                digit = number % 10;
                sum = sum + digit;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
