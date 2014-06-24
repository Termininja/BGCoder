using System;
using System.Linq;

class MiniPoker
{
    static void Main()
    {
        dynamic[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[5];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        Array.Sort(numbers);
        bool isSeq = true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1) isSeq = false;
        }

        Console.WriteLine((isSeq) ? String.Join(" ", numbers) : numbers.Max().ToString());
    }
}