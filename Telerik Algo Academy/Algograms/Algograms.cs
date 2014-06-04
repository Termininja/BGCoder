using System;
using System.Linq;
using System.Collections.Generic;

class Algograms
{
    static void Main()
    {
        List<string> words = new List<string>();
        string word = Console.ReadLine();
        while (words[words.Count - 1] != "-1")
        {
            words.Add(SortString(Console.ReadLine()));
        }

        words.Sort();
        Console.WriteLine(words.GroupBy(m => m).Count());
    }

    static string SortString(string str)
    {
        char[] chars = str.ToArray();
        Array.Sort(chars);
        return new string(chars);
    }
}