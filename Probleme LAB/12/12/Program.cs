using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber;
            long numberToReach;
            long count = -1;

            firstNumber = Convert.ToInt32(Console.ReadLine());
            numberToReach = Convert.ToInt32(Console.ReadLine());

            for (long power = 0; power <= numberToReach; power++)
            {
                if(  (long)Math.Pow(firstNumber, power) <= numberToReach ) {

                    count++;
                    
                }
                else
                {
                        break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
