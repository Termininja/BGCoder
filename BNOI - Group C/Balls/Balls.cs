using System;
using System.Collections.Generic;
using System.Linq;

class Balls
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<long> boxes = new List<long>();

        int k = int.Parse(input[1]);
        for (int i = 0; i < k; i++) boxes.Add(long.Parse(Console.ReadLine()));
        Console.WriteLine(long.Parse(input[0]) - boxes.Distinct().Count());
    }
}