using System;

class TextToNumber
{
    static void Main()
    {
        var M = int.Parse(Console.ReadLine());
        long result = 0;
        foreach (var ch in Console.ReadLine().ToUpper())
        {
            if (ch == '@') break;
            result = char.IsDigit(ch) ? result * int.Parse(ch.ToString()) : (char.IsLetter(ch) ? result + (int)ch - 65 : result % M);
        }

        Console.WriteLine(result);
    }
}