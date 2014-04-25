using System;
using System.Linq;

class House
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int h = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        Enumerable.Range(1, h + b).ToList().ForEach(i => Console.WriteLine((i <= h) ? 
            new string(' ', h - i) + new string('/', i) + new string('\\', i) : 
            new string(' ', h - b) + new string('=', 2 * b)));
    }
}
