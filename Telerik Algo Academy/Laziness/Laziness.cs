using System;
using System.Text;

class Laziness
{
    static void Main()
    {
        Console.ReadLine();
        string[] range = Console.ReadLine().Split(' ');
        ushort A = ushort.Parse(range[0]);
        ushort B = ushort.Parse(range[1]);

        string input = Console.ReadLine();
        string[] array = input.Split(' ');

        string start = string.Join(" ", array, 0, A);
        string end = string.Join(" ", array, B + 1, array.Length - B - 1);

        int[] numbers = new int[B - A + 1];
        for (int j = 0, i = A; i <= B;)
        {
            numbers[j++] = int.Parse(array[i++]);
        }

        Array.Sort(numbers);

        StringBuilder result = new StringBuilder();
        result.Append(start + " ");
        int len = numbers.Length;
        for (int i = 0; i < len;)
        {
            result.Append(numbers[i++] + " ");
        }

        result.Append(end);
        Console.WriteLine(result.ToString().Trim());
    }
}