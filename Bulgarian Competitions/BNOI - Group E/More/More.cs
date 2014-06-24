using System;
using System.Linq;

class More
{
    static void Main()
    {
        Console.ReadLine()
            .GroupBy(m => m)
            .Where(m => m.Count() > 1)
            .Select(m => new { ch = m.First(), count = m.Count() })
            .OrderBy(m => m.ch).ToList()
            .ForEach(i => Console.WriteLine(i.ch + " " + i.count));
    }
}