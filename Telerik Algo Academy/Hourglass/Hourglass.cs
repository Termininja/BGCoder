using System;

class Hourglass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine((i <= N / 2) ?
                new string('.', i) + new string('*', N - 2 * i) + new string('.', i) :
                new string('.', N - i - 1) + new string('*', 2 * i + 2 - N) + new string('.', N - i - 1));
        }
    }
}