using System;

namespace _14
{
    class Program
    {
        public static void Main(String[] args)
        {
            bool checkPerfectSquare = false;
            int i, j;
            int firstNumber = 0;
            int secondNumber = 0;
            int holdNumber;
            int givenNumber = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= givenNumber; i++)
            {
                for (j = 1; j <= givenNumber; j++)
                    if (i * i + j * j == givenNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                        checkPerfectSquare = true;
                        break;
                    }
            }
            if (checkPerfectSquare)
            {
                if (firstNumber > secondNumber)
                {
                    holdNumber = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = holdNumber;
                }
                Console.WriteLine($"The number can be wrote as {firstNumber}^2 + {secondNumber}^2");
            }
            else
            {
                Console.WriteLine("NO");
            }
         }
    }
}
