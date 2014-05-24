using System;
using System.Linq;

class Words
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').Where(m => m.Length > 1).OrderBy(m => m.Length).ThenBy(m => m[0]).ToArray();
        Console.WriteLine("{0} {1}", input.Last().Length, input.Where(m => m.Length == input.Last().Length).ToArray().First());
    }
}