using System;
using System.Numerics;

class Cubes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        long N = long.Parse(input[0]);
        long M = long.Parse(input[1]);
        long K = long.Parse(input[2]);

        BigInteger count = N * M * K;
        for (long i = Math.Max(N, Math.Max(M, K)); i >= 2; i--)
        {
            if (N % i == 0 && M % i == 0 && K % i == 0)
            {
                count /= (i * i * i);
                break;
            }
        }

        Console.WriteLine(count);
    }
}