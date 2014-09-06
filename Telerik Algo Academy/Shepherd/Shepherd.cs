using System;
using System.Collections.Generic;

class Shepherd
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int numberOfFences = int.Parse(input[0]);
        int numberOfSheep = int.Parse(input[1]);

        List<double[]> fences = new List<double[]>();
        for (int f = 0; f < numberOfFences; f++)
        {
            string[] fence = Console.ReadLine().Split(' ');
            fences.Add(new double[] {
                double.Parse(fence[0]),
                double.Parse(fence[1]),
                double.Parse(fence[2]),
                double.Parse(fence[3])
            });
        }

        int count = 0;
        for (int s = 0; s < numberOfSheep; s++)
        {
            string[] sheep = Console.ReadLine().Split(' ');
            double Ax = double.Parse(sheep[0]);
            double Ay = double.Parse(sheep[1]);

            bool isOut = true;
            for (int f = 0; f < fences.Count; f++)
            {
                if (Ax < Math.Max(fences[f][0], fences[f][2]) &&
                    Ax > Math.Min(fences[f][0], fences[f][2]) &&
                    Ay < Math.Max(fences[f][1], fences[f][3]) &&
                    Ay > Math.Min(fences[f][1], fences[f][3]))
                {
                    isOut = false;
                    break;
                }
            }

            if (!isOut) count++;
        }

        Console.WriteLine(count);
    }
}