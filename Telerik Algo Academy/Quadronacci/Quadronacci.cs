using System;
using System.Collections.Generic;
using System.Numerics;

class Quadronacci
{
    static void Main()
    {
        List<BigInteger> sequence = new List<BigInteger>();

        for (int i = 0; i < 4; i++) sequence.Add(int.Parse(Console.ReadLine()));
        int R = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        for (int i = 0; i < R * C; i++)
        {
            if (i > 3) sequence.Add(sequence[i - 1] + sequence[i - 2] + sequence[i - 3] + sequence[i - 4]);
            if (i != 0) Console.Write((i % C == 0) ? "\n" : " ");
            Console.Write(sequence[i]);
        }
    }
}