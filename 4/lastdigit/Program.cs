using System;

namespace lastdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            int lastDigit = sum % 10;
            Console.WriteLine(sum);
            Console.WriteLine(lastDigit);
        }
    }
}
