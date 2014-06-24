using System;
using System.Collections.Generic;
using System.Linq;

class Lottery
{
    static void Main()
    {
        try
        {
            var set = new HashSet<char>();
            Console.WriteLine(Console.ReadLine().ToList().Where(m => !set.Add(m)).Last());
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("No");
        }
    }
}