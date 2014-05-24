using System;
using System.Numerics;

class Tribonachi
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        BigInteger t1 = BigInteger.Parse(input[0]);
        BigInteger t2 = BigInteger.Parse(input[1]);
        BigInteger t3 = BigInteger.Parse(input[2]);
        int N = int.Parse(input[3]);

        BigInteger ti = N == 1 ? t1 : (N == 2 ? t2 : (N == 3 ? t3 : 0));
        for (int i = 4; i <= N; i++, t1 = t2, t2 = t3, t3 = ti) ti = t1 + t2 + t3;
        Console.WriteLine(ti);
    }
}