using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(FindLast(num, (int)Math.Sqrt(num) + 1));
    }

    static int FindLast(int num, int i)
    {
        if (num <= 3) return 1;
        while (true)
        {
            if (IsPrime(--i))
            {
                for (int j = num; j > 0; j--)
                {
                    if (j % i == 0 && (IsPrime(j / i) || j / i == 4)) return j;
                }
            }
        }
    }

    static bool IsPrime(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}