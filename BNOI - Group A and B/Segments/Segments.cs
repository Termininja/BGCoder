using System;
using System.Collections.Generic;

class Segments
{
    static List<int[,]> S = new List<int[,]>();
    static int maxCount = 0;

    static void Main()
    {
        // Input
        string input = Console.ReadLine();
        while (input.IndexOf("  ") > 0) input = input.Replace("  ", " ");
        string[] str = input.Split(' ');

        // The number of the segments
        int n = (str.Length != 1) ? int.Parse(str[0]) : 0;

        // End point coordinates for each segment
        for (int i = 0; i < n; i++)
        {
            S.Add(new int[,] {
                { int.Parse(str[4 * i + 1]), int.Parse(str[4 * i + 2]) },
                { int.Parse(str[4 * i + 3]), int.Parse(str[4 * i + 4]) }
            });
        }

        // Find the maximal number of all intersected segments
        for (int i = 0; i < S.Count - 1; i++)
        {
            for (int j = i + 1; j < S.Count; j++)
            {
                // Find all possible intersections
                SegmentIntersections(S[i][0, 0], S[i][0, 1], S[j][0, 0], S[j][0, 1]);
                SegmentIntersections(S[i][0, 0], S[i][0, 1], S[j][1, 0], S[j][1, 1]);
                SegmentIntersections(S[i][1, 0], S[i][1, 1], S[j][0, 0], S[j][0, 1]);
                SegmentIntersections(S[i][1, 0], S[i][1, 1], S[j][1, 0], S[j][1, 1]);
            }
        }

        // Print the final result
        Console.WriteLine((n == 1) ? 1 : maxCount);
    }

    // Find all segment intersections
    static void SegmentIntersections(float x1, float y1, float x2, float y2)
    {
        // Expand the coordinates of the segment
        y1 -= (1000 + x1) * (y2 - y1) / (x2 - x1);
        x1 = -1000;
        y2 -= ((1000 - x2) * (y1 - y2) / (x2 - x1));
        x2 = 1000;

        int count = 0;
        foreach (var s in S)
        {
            float a = (s[0, 0] - x1) * (y2 - y1) - (s[0, 1] - y1) * (x2 - x1);
            float b = 1f / ((x2 - x1) * (s[1, 1] - s[0, 1]) - (y2 - y1) * (s[1, 0] - s[0, 0]));
            if ((a == 0f) ?
                ((s[0, 0] - x1 < 0f) != (s[0, 0] - x2 < 0f)) :
                (a * b >= 0f) && (a * b <= 1f)) count++;
        }

        // Is the current count the max count
        if (count >= maxCount) maxCount = count;
    }
}
