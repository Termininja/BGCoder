using System;

class TheHorror
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = 0;
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0 && char.IsDigit(input[i]))
            {
                count++;
                sum += int.Parse(input[i].ToString());
            }
        }

        Console.WriteLine("{0} {1}", count, sum);
    }
}