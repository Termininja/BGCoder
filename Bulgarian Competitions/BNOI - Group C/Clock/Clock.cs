using System;

class Clock
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(':');
        double alpha = 30 * Math.Abs(11 * int.Parse(input[1]) / 60d - int.Parse(input[0]));
        Console.WriteLine("{0:F3}", (alpha <= 180) ? alpha : 360 - alpha);
    }
}
