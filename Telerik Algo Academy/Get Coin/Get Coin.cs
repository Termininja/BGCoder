using System;
using System.Linq;

class GetCoin
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();
        int max = int.MinValue;
        for (int i = 0; i < N - 1; i++)
        {
            int X1 = numbers[i];
            for (int j = i + 1; j < N; j++)
            {
                int X2 = numbers[j];
                if ((X1 ^ X2) % 2 == 0) max = Math.Max(max, Math.Abs((X2 * X2 - X1 * X1) / 4));
            }
        }

        Console.WriteLine(max);
    }
}