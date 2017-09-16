using System;

class _369
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        long R =
            (B == 3 ? A + C :
            (B == 6 ? (long)A * C :
            (B == 9 ? A % C : 0)));

        Console.WriteLine("{0}\n{1}", R % 3 == 0 ? R / 3 : R % 3, R);
    }
}