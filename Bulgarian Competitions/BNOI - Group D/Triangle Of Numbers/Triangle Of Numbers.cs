using System;

class TriangleOfNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        long row = 0;
        while (row++ >= 0)
        {
            double position = (row + 1 - Math.Sqrt(row * row + 2 * row + 1 - 4 * a)) / 2;
            if (position % 1 == 0) break;
        }

        long sum = (row % 2 == 0) ? 0 : row * (row + 2) / 4 + 1;
        for (int col = 1; col <= row / 2; col++)
        {
            sum += 2 * col * (row + 1 - col);
        }

        Console.WriteLine(sum);
    }
}