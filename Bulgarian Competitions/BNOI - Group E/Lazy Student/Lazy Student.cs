using System;
using System.Text;

class LazyStudent
{
    static void Main()
    {
        Console.ReadLine();
        Console.WriteLine((new StringBuilder()).Append(Console.ReadLine())
            .Replace(" ", "").Replace("a", "").Replace("b", "")
            .Replace("d", "").Replace("e", "").Replace("g", "")
            .Replace("o", "").Replace("p", "").Replace("q", ""));
    }
}