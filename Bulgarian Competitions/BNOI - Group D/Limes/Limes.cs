using System;

class Limes
{
    static void Main()
    {
        string[] NMXY = Console.ReadLine().Split(' ');
        int M = int.Parse(NMXY[1]);
        int X = int.Parse(NMXY[2]);
        int Y = int.Parse(NMXY[3]);
        Console.WriteLine((X - 1) * M + ((X % 2 == 0) ? M - Y : Y - 1));
    }
}