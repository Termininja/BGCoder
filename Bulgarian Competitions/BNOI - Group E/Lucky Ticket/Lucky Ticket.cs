using System;

class LuckyTicket
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int S = 0, s = 0, a = 0, b = 0, i = 0; i < 6; i++, n /= 10)
        {
            s = (i < 3) ? s + n % 10 : s - n % 10;
            if (i == 2)
            {
                S = s;
                b = n % 10;
            }
            if (i == 4) a = n % 10;
            if (i == 5) Console.WriteLine(s == 0 && a >= b ? S : ((s == 0) ? 32 : ((a >= b) ? 31 : 30)));
        }
    }
}
