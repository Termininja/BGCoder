using System;
using System.Collections.Generic;

class SumOfPrimes
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        List<int> primes = new List<int>();
        for (int i = 2; i < sum; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) primes.Add(i);
        }

        int count = 0;
        for (int i = 0; i < primes.Count; i++)
        {
            for (int j = 0; j < primes.Count; j++)
            {
                if (primes[i] + primes[j] == sum) count++;
            }
        }

        Console.WriteLine(count / 2 + (count % 2 == 0 ? 0 : 1));
    }
}
