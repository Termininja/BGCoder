using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        var product = Console.ReadLine();
        var transformations = 0;
        while (product.ToString().Length > 1)
        {
            product = GetProduct(product).ToString();
            transformations++;
            if (transformations == 10)
            {
                Console.WriteLine(product);
                return;
            }
        }

        Console.WriteLine("{0}\n{1}", transformations, product);
    }

    private static BigInteger GetProduct(string input)
    {
        BigInteger product = 1;
        for (int i = 1; i < input.Length; i++)
        {
            var sum = 0;
            for (int j = 0; j < input.Length - i; j++)
            {
                if (j % 2 == 0) sum += input[j] - '0';
            }

            product *= sum;
        }

        return product;
    }
}