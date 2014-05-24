using System;
using System.Linq;
using System.Numerics;

class BinaryPasswords
{
    static void Main()
    {
        Console.WriteLine((BigInteger)Math.Pow(2, Console.ReadLine().Count(m => m == '*')));
    }
}