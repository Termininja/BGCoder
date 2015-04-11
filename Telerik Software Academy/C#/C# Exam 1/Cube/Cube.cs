using System;

class Cube
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        Console.WriteLine(new string(' ', N - 1) + new string(':', N));
        for (int i = 0; i < N - 2; i++)
        {
            Console.WriteLine(new string(' ', N - 2 - i) + ":" + new string('/', N - 2) + ":" + new string('X', i) + ":");
        }

        Console.WriteLine(new string(':', N) + new string('X', N - 2) + ":");
        for (int i = 0; i < N - 2; i++)
        {
            Console.WriteLine(":" + new string(' ', N - 2) + ":" + new string('X', N - 3 - i) + ":");
        }

        Console.WriteLine(new string(':', N));
    }
}