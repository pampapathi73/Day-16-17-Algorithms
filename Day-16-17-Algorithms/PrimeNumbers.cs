using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_17_Algorithms
{
    internal class PrimeNumbers
    {
        internal static void Print()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers Between 1 To 1000: ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.Read();
        }
    }
}
