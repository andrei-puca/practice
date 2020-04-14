using System;
public class Fibonacci
{
    public static void Main()
    {
        int howManyFibonacciElements;
        int firstElement = 0;
        int secondElement = 1;
        int fibonacciElement;
        int index;

        Console.WriteLine("Introduce the number of Fibonacci elements to be displayed: ");
        howManyFibonacciElements = Convert.ToInt32(Console.ReadLine());
        Console.Write($"You have requested {howManyFibonacciElements} Fibonacci elements: \n");
        Console.Write("{0}    {1}  ", firstElement, secondElement);

        for (index = 3; index <= howManyFibonacciElements; index++)
        {
            fibonacciElement = firstElement + secondElement;
            Console.Write("  {0}  ", fibonacciElement);
            firstElement = secondElement;
            secondElement = fibonacciElement;
        }
        Console.Write("\n");
    }
}