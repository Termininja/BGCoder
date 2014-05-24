using System;
using System.Collections.Generic;
using System.Linq;

class Buses
{
    static void Main()
    {
        string[] points = Console.ReadLine().Split(' ');
        int N = int.Parse(points[0]);
        List<int[]> Stops = new List<int[]>();
        for (int i = 0; i < N; i++)
        {
            string[] stop = Console.ReadLine().Split(' ');
            Stops.Add(new int[] { int.Parse(stop[0]), int.Parse(stop[1]), int.Parse(stop[2]) });
        }

        var routes = Stops.OrderBy(m => m[0]).ToList();

        Console.WriteLine(GetPrice(routes, int.Parse(points[1]), int.Parse(points[2])));
    }

    static int GetPrice(List<int[]> routes, int A, int B)
    {
        int price = 0;
        bool isRoute = false;
        foreach (var route in routes)
        {
            if (A >= route[0] && A < route[1])
            {
                isRoute = true;
                if (B >= route[0] && B < route[1]) return B - A;
                else price += TicketOrCard(route, A, false);
            }
            else if (B >= route[0] && B < route[1]) return price + TicketOrCard(route, B, true);
            else if (isRoute) price += route[2];
        }

        return price;
    }

    static int TicketOrCard(int[] route, int point, bool last)
    {
        int ticket = (last) ? point - route[0] : route[1] - point;
        return ticket < route[2] ? ticket : route[2];
    }
}