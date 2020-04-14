using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            firstNumber = Convert.ToInt32(Console.ReadLine());
            secondNumber = Convert.ToInt32(Console.ReadLine());
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (((firstNumber + secondNumber) > thirdNumber) && ((firstNumber + thirdNumber) > secondNumber) && ((thirdNumber + secondNumber) > firstNumber))
                Console.WriteLine("This numbers can form a triangle");
            else
                Console.WriteLine("This numbers cannot form a triangle");
        }
    }
}
