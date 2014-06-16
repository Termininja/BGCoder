using System;

class Pull
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double x1 = 0;
        double y1 = 0;
        for (int n = 0; n < N; n++)
        {
            string[] input = Console.ReadLine().Split(' ');
            double F = double.Parse(input[2]);
            x1 += F * double.Parse(input[0]);
            y1 += F * double.Parse(input[1]);
        }

        Console.WriteLine("{0} {1}", -x1, -y1);
    }
}