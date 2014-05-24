using System;

class FourDimensionalSpeed
{
    static void Main()
    {
        string[] A = Console.ReadLine().Split(' ');
        string[] B = Console.ReadLine().Split(' ');

        Console.WriteLine("{0:f2}", (Math.Sqrt(
            Math.Pow(int.Parse(A[0]) - int.Parse(B[0]), 2) +
            Math.Pow(int.Parse(A[1]) - int.Parse(B[1]), 2) +
            Math.Pow(int.Parse(A[2]) - int.Parse(B[2]), 2))
            ) / (Math.Abs(int.Parse(B[3]) - int.Parse(A[3]))));
    }
}