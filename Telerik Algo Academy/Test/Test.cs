using System;

class Test
{
    static void Main()
    {
        string u = Console.ReadLine();
        string t = Console.ReadLine();
        string g = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < u.Length; i++)
        {
            if (t[i] != u[i]) count++;
            if (g[i] != u[i]) count++;
            if (t[i] != u[i] && g[i] != u[i] && t[i] != g[i]) count--;
        }
        Console.WriteLine(count);
    }
}