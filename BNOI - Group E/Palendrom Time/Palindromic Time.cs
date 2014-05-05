using System;

class PalindromicTime
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(':');
        Console.WriteLine(PTime(int.Parse(input[0]), int.Parse(input[1])));
    }

    static string PTime(int hour, int minuntes)
    {
        bool first = true;
        for (int h = hour; h <= 23; h++)
        {
            for (int m = minuntes; m <= 59; m++)
            {
                string H = h.ToString().PadLeft(2, '0');
                string M = m.ToString().PadLeft(2, '0');
                if (H == M[1].ToString() + M[0].ToString() && !first)
                {
                    return H + ":" + M;
                }
                first = false;
            }

            minuntes = 0;
            if (h == 23) h = -1;
        }
        return "";
    }
}