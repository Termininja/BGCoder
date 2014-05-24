using System;

class SuperSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Console.WriteLine(Sum(int.Parse(input[0]), int.Parse(input[1])));
    }

    static int Sum(int k, int n)
    {
        int sum = 0;
        if (k == 0) sum = n;
        else for (int i = 1; i <= n; i++) sum += Sum(k - 1, i);
        return sum;
    }
}