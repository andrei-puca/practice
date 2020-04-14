using System;


namespace interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int numberToCheck;
            int temp;
            firstNumber = Convert.ToInt32(Console.ReadLine());
            secondNumber = Convert.ToInt32(Console.ReadLine());
            numberToCheck = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;
            }

            if (numberToCheck >= firstNumber && numberToCheck <= secondNumber)
                Console.WriteLine("este in interval");
            else
                Console.WriteLine("nu este in interval");

    
        }
    }
}
