using System;

class Average
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);
        Console.WriteLine((((m % 2 != 0) ? m + 1 : m) + ((n % 2 != 0) ? n - 1 : n)) / 2);
    }
}