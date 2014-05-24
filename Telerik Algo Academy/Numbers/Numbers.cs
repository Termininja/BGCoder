using System;

class Numbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int P = int.Parse(input[2]);
        int Q = int.Parse(input[3]);

        int count = 0;
        for (int i = A; i <= B; i++) if (i % P == Q) count++;
        Console.WriteLine(count);
    }
}