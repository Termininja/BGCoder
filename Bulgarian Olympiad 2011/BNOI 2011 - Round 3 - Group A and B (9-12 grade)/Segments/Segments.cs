using System;
using System.Collections.Generic;

class Segments
{
    static List<int[,]> S = new List<int[,]>();
    static int maxCount = 0;

    static void Main()
    {
        // Input
        string[] input = Console.ReadLine().Split(' ');

        // The number of the segments
        int n = int.Parse(input[0]);

        // End point coordinates for each segment
        for (int i = 0; i < n; i++)
        {
            S.Add(new int[,] {
                { int.Parse(input[4 * i + 1]), int.Parse(input[4 * i + 2]) },
                { int.Parse(input[4 * i + 3]), int.Parse(input[4 * i + 4]) }
            });
        }

        // Find the maximal number of all intersected segments
        for (int i = 0; i < S.Count - 1; i++)
        {
            for (int j = i + 1; j < S.Count; j++)
            {
                // Find all possible intersections
                LineIntersecttions(S[i][0, 0], S[i][0, 1], S[j][0, 0], S[j][0, 1]);
                LineIntersecttions(S[i][0, 0], S[i][0, 1], S[j][1, 0], S[j][1, 1]);
                LineIntersecttions(S[i][1, 0], S[i][1, 1], S[j][0, 0], S[j][0, 1]);
                LineIntersecttions(S[i][1, 0], S[i][1, 1], S[j][1, 0], S[j][1, 1]);
            }
        }

        // Print the final result
        Console.WriteLine((n == 1) ? 1 : maxCount);
    }

    // Find all intersections between many lines
    static void LineIntersecttions(float x1, float y1, float x2, float y2)
    {
        float[,] line = { { x1, y1 }, { x2, y2 } };

        // Start of the line
        PointCoord(ref x1, ref y1, x2, y2, -1);

        // End of the line
        PointCoord(ref x2, ref y2, x1, y1, 1);

        int count = 0;
        foreach (var s in S)
        {
            bool isIntersect = false;
            float CmR = (s[0, 0] - x1) * (y2 - y1) - (s[0, 1] - y1) * (x2 - x1);
            float RxS = (x2 - x1) * (s[1, 1] - s[0, 1]) - (y2 - y1) * (s[1, 0] - s[0, 0]);

            if (CmR == 0f) isIntersect = ((s[0, 0] - x1 < 0f) != (s[0, 0] - x2 < 0f)) || ((s[0, 1] - y1 < 0f) != (s[0, 1] - y2 < 0f));
            else if (RxS == 0f) isIntersect = false;
            else
            {
                float t = ((s[0, 0] - x1) * (s[1, 1] - s[0, 1]) - (s[0, 1] - y1) * (s[1, 0] - s[0, 0])) * (1f / RxS);
                float u = CmR * (1f / RxS);

                isIntersect = (t >= 0f) && (t <= 1f) && (u >= 0f) && (u <= 1f);
            }

            if (isIntersect) count++;
        }

        // Is the current count the max count
        if (count >= maxCount) maxCount = count;
    }

    // Find the end point of the line over some segment
    static void PointCoord(ref float x1, ref float y1, float x2, float y2, int sign)
    {
        float y = y1 - ((1000 * sign - x1) * (y1 - y2) / (x2 - x1));
        if (-1000 <= y && y <= 1000)
        {
            x1 = 1000 * sign;
            y1 = y;
        }
        else if (y > 1000)
        {
            x1 -= ((1000 - y1) * (x1 - x2) / (y2 - y1));
            y1 = 1000;
        }
        else if (y < -1000)
        {
            x1 -= ((-1000 - y1) * (x1 - x2) / (y2 - y1));
            y1 = -1000;
        }
    }
}
