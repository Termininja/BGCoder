using System;
using System.Collections.Generic;

class Tomcats
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int count = 0;
        List<int[]> numbers = new List<int[]>();
        for (int i = 0; i < input.Length - 1; i++)
        {
            int n = int.Parse(input[i]);
            bool diff = true;
            foreach (var num in numbers)
            {
                if (n == num[0])
                {
                    num[1]--;
                    diff = false;
                    if (num[1] == 0) numbers.Remove(num);
                    break;
                }
            }
            if (diff)
            {
                count += n + 1;
                if (n != 0) numbers.Add(new int[] { n, n });
            }
        }
        Console.WriteLine(count);
    }
}