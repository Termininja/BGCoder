using System;

class Piknik
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        float n = (int.Parse(input[0]) * 0.4f) / float.Parse(input[1] + "." + input[2]);
        Console.WriteLine((n % 1 > 0) ? (int)(n) + 1 : (int)(n));
    }
}
