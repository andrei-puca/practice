using System;

namespace probl6
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrDim = 5;
            int[] arr = new int[arrDim];
            int i;
            int sum = 0;
         
            Console.Write("Input 5 elements in the array :\n");
            for (i = 0; i < arrDim; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr, 0, 5);
            
            Console.Write("\nThe biggest three elements in array are: ");
            for (i = arrDim - 3; i < arrDim; i++)
            {
                Console.Write("{0}  ", arr[i]);
                sum = sum + arr[i]; 

            }
            Console.Write("\n");
            Console.WriteLine($"The sum of the biggest three numbers is: {sum}");
            
        }
    }
}
