using System;

class _248
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        long R =
            (B == 2 ? A % C :
            (B == 4 ? A + C :
            (B == 8 ? (long)A * C : 0)));

        Console.WriteLine("{0}\n{1}", R % 4 == 0 ? R / 4 : R % 4, R);
    }
}