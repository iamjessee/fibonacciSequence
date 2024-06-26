﻿namespace FibonacciSequence

{
    class Program
    {
        static void Main(string[] args)
        {   // 0 1 1 2 3 5 8 13 21...
            // creates int variables
            int a = 0;
            int b = 0;
            int n = 0;

            // counts how many numbers you write in Fibonacci
            for (int i = 0; i <= 20; i++)
            {
                // this writes 1 in the first space
                if (a == 0)
                {
                    a = 1;
                }
                else
                {
                    // this takes spot 0 and 1 to added them together for the next spot
                    n = a + b;
                    // shuffles through Fibonacci to give a & b new values for the next loop pass 
                    b = a;
                    a = n;
                }
                // writes value of n 
                Console.Write(n + " ");
            }
        }
    }
}