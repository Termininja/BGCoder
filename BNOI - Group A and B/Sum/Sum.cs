using System;
using System.Linq;
using System.Numerics;

class Sum
{
    static void Main()
    {
        var num = Console.ReadLine().ToList();

        // Smallest number
        string min = string.Join("", num.OrderBy(i => i).ToArray());
        int zeros = 0;
        for (; min[0] == '0'; zeros++) min = min.Remove(0, 1);
        min = min.Insert(1, new string('0', zeros));

        // Biggest number
        string max = string.Join("", num.OrderByDescending(i => i).ToArray());

        Console.WriteLine(BigInteger.Parse(min) + BigInteger.Parse(max));
    }
}