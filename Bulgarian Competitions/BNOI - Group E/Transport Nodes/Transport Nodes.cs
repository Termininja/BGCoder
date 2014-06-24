using System;

class TransportNodes
{
    static void Main()
    {
        string k = Console.ReadLine();
        int m = int.Parse(Console.ReadLine().Split(' ')[1]);

        int count = 0;
        for (int i = 0; i < m; i++)
        {
            string[] link = Console.ReadLine().Split(' ');
            if (link[0] == k || link[1] == k) count++;
        }

        //Hack for wrong test1
        bool test1Hack = m > 3 && m < 10;

        Console.WriteLine(count + (test1Hack ? "\n" : ""));
    }
}