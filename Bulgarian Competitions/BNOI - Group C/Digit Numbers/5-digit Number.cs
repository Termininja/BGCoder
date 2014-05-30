using System;

class DigitNumbers
{
    static void Main()
    {
        Console.WriteLine(SearchNumber(int.Parse(Console.ReadLine())));
    }

    static int SearchNumber(int n)
    {
        int count = 0;
        for (int i = 10000; i < 100000; i++)
        {
            int mid = (i / 100) % 10;
            if (i / 10000 + mid == (i / 1000) % 10 && mid + i % 10 == (i / 10) % 10)
            {
                count++;
                if (i == n) return count;
            }
        }

        return 0;
    }
}