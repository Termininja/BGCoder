using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class Frames
{
    static SortedSet<string> result = new SortedSet<string>();

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var frames = new Frame[n];
        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            frames[i] = new Frame(input[0], input[1]);
        }

        GetPermutations(frames, 0);

        Console.WriteLine(result.Count());
        var output = new StringBuilder();
        foreach (var item in result)
        {
            output.AppendLine(item);
        }

        Console.WriteLine(output.ToString().Trim());
    }

    static void GetPermutations(Frame[] arr, int k)
    {
        if (k >= arr.Length)
        {
            result.Add(string.Join(" | ", arr));
        }
        else
        {
            GetPermutations(arr, k + 1);

            SwapFrame(ref arr[k]);
            GetPermutations(arr, k + 1);
            SwapFrame(ref arr[k]);

            for (int i = k + 1; i < arr.Length; i++)
            {
                Swap(ref arr[k], ref arr[i]);
                GetPermutations(arr, k + 1);

                SwapFrame(ref arr[k]);
                GetPermutations(arr, k + 1);
                SwapFrame(ref arr[k]);

                Swap(ref arr[k], ref arr[i]);
            }
        }
    }

    static void SwapFrame(ref Frame frame)
    {
        int oldW = frame.w;
        frame.w = frame.h;
        frame.h = oldW;
    }

    static void Swap<T>(ref T first, ref T second)
    {
        T oldFirst = first;
        first = second;
        second = oldFirst;
    }
}

struct Frame
{
    public int w;
    public int h;

    public Frame(int w, int h)
    {
        this.w = w;
        this.h = h;
    }

    public override string ToString()
    {
        return "(" + this.w + ", " + this.h + ")";
    }
}
