using System;

class Marbles
{
    static void Main()
    {
        string str = Console.ReadLine() + " ";
        int start = -1;
        int count = 2;
        while (str.IndexOf("RRR") >= 0 || str.IndexOf("GGG") >= 0 || str.IndexOf("BBB") >= 0 || str.IndexOf("YYY") >= 0)
        {
            for (int i = 2; i < str.Length; i++)
            {
                if (str[i] == str[i - 1] && str[i - 1] == str[i - 2])
                {
                    if (start == -1) start = i - 2;
                    count++;
                }
                else if (start >= 0)
                {
                    str = str.Remove(start, count);
                    i = start + 1;
                    start = -1;
                    count = 2;
                }
            }
        }

        Console.WriteLine((str.Trim() == "") ? "EMPTY" : str.Trim());
    }
}