using System;

class FishGlobe
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Console.WriteLine(int.Parse(input[0]) * Math.Pow(2, int.Parse(input[1]) / 2));
    }
}