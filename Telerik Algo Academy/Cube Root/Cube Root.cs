using System;
using System.Numerics;

class CubeRoot
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger min = 0;
        BigInteger max = number;
        BigInteger guess = (max + min) / 2;
        while (true)
        {
            BigInteger check = guess * guess * guess;
            if (check == number) break;
            else if (check > number) max = guess;
            else min = guess;
            guess = (max + min) / 2;
        }

        Console.WriteLine(guess);
    }
}