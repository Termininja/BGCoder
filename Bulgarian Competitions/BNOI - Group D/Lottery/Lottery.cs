using System;
using System.Linq;

class Lottery
{
    static void Main()
    {
        int k = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray()[1];
        int[] A = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();
        int[] MinMax = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();
        int min = MinMax[0];
        int len = MinMax[1] - min + 1;
        int[] result = new int[len];
        for (int a = 0; a < A.Length; a++)
        {
            int start = ((min % A[a] == 0) ? 0 : A[a] - min % A[a]);
            for (int i = start; i < len; i += A[a])
            {
                result[i]++;
            }
        }

        Console.WriteLine(result.Where(m => m == k).Count());
    }
}
