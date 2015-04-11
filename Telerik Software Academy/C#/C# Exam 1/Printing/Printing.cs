using System;

class Printing
{
    static void Main()
    {
        Console.WriteLine("{0:F2}", (int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) / 500m) * decimal.Parse(Console.ReadLine()));
    }
}