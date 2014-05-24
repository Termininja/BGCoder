using System;

class Clock
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(':');
        int min = int.Parse(input[1]);
        double alpha = 360 * Math.Abs(min / 60d - (int.Parse(input[0]) / 12d + min / (60 * 12d)));
        Console.WriteLine("{0:F3}", (alpha <= 180) ? alpha : 360 - alpha);
    }
}
