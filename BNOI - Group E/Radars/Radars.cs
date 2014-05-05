using System;
using System.Linq;

class Radars
{
    static void Main()
    {
        Console.ReadLine();
        long[] input = Console.ReadLine().Split(' ').Select(m => long.Parse(m)).OrderBy(m => m).ToArray();
        long Pmax = 0;
        for (int i = 1; i < input.Length - 1; i++)
        {
            long P = (input.Last() - input[i]) * (input[i] - input.First());
            if (P > Pmax) Pmax = P;
        }

        Console.WriteLine(Pmax);
    }
}