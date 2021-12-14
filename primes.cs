using System;

namespace primes
{
    class Program
    {
        static bool isPrime(int n)
        {
            bool prime = true;
            for(int i=2; i<n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }

        static int countPrimes(int a, int b)
        {
            int counter = 0;
            for(int i = a; i <= b; i++ )
            { 
                if(isPrime(i))
                {
                    counter++;
                }
            }
            return counter;
        }


        static void Main(string[] args)
        {
            for (int i = 100; i < 201; i++)
            {
                if (isPrime(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\n-----------");
            Console.WriteLine(countPrimes(100, 200));
            Console.ReadKey();
        }
    }
}
