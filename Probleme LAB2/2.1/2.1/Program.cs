using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfElements;
            int max = int.MinValue;
            int min = int.MaxValue;
            numberOfElements =  Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];

                }
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(max * min);
        }
    }
}
