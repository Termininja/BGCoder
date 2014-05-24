using System;
using System.Linq;

class WholePoints
{
    static void Main()
    {
        string[] A = Console.ReadLine().Split(' ');
        string[] B = Console.ReadLine().Split(' ');
        int Ax = int.Parse(A[0]);
        int Ay = int.Parse(A[1]);
        int Bx = int.Parse(B[0]);
        int By = int.Parse(B[1]);

        if (Bx < Ax) { Ax = -Ax; Bx = -Bx; }

        Console.WriteLine(2 + (
            from n
            in Enumerable.Range(Ax + 1, Bx - Ax - 1)
            where ((Ay - ((double)(n - Ax) * (double)(Ay - By)) / (Bx - Ax)) % 1 == 0)
            select n).Count());
    }
}