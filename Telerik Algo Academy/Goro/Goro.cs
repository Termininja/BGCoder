using System;

class Goro
{
    static int points = 0;

    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            if (num1 >= 1 && num1 >= num2 && num1 >= num3) Points(ref num1);
            else if (num2 >= 1 && num2 >= num3) Points(ref num2);
            else if (num3 >= 1) Points(ref num3);
            else break;
        }

        Console.WriteLine(points);
    }

    static void Points(ref int number)
    {
        points += number;
        number--;
    }
}