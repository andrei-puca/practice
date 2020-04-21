using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n;
            int max = 0;
            int min = 9999;
           n =  Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i< array.Length; i++)
                if(array[i] > max)
                 {
                    max = array[i];
                   
                }
            for (int i = 0; i < array.Length; i++)
                if(array[i] < min)
                {
                    min = array[i];
                    
                }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(max * min);
        }
    }
}
