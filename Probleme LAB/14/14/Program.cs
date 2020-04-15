using System;

namespace _14
{
    class Program
    {
        // function to check if there exist two 
        // numbers sum of whose squares is n 
        static bool sumSquare(int n)
        {
            for (long i = 1; i * i <= n; i++)
                for (long j = 1; j * j <= n; j++)
                    if (i * i + j * j == n)
                    {
                        Console.Write(i + "^2 + "
                                        + j + "^2");
                        return true;
                    }
            return false;
        }

        // Driver Code 
        public static void Main(String[] args)
        {
            int n = 25;
            if (sumSquare(n))
                Console.Write("\nYes");
            else
                Console.Write("\nNo");
        }
    }
}
// This code is contributed by Smitha Dinesh Semwal. 
