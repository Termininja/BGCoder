using System;
using System.Numerics;

class HelpDoge
{
    static void Main()
    {
        string[] NM = Console.ReadLine().Split(' ');
        int N = int.Parse(NM[0]);
        int M = int.Parse(NM[1]);
        BigInteger[,] field = new BigInteger[N, M];

        string[] food = Console.ReadLine().Split(' ');
        int foodX = int.Parse(food[0]);
        int foodY = int.Parse(food[1]);
        field[foodX, foodY] = -10;
        field[0, 0] = 1;

        int enemies = int.Parse(Console.ReadLine());
        for (int i = 0; i < enemies; i++)
        {
            string[] enemy = Console.ReadLine().Split(' ');
            int enemyX = int.Parse(enemy[0]);
            int enemyY = int.Parse(enemy[1]);
            field[enemyX, enemyY] = -1;
        }

        Console.WriteLine(FindFood(N, M, field));
    }

    private static BigInteger FindFood(int N, int M, BigInteger[,] field)
    {
        bool stop = false;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (field[i, j] == -10) stop = true;
                if (field[i, j] == 0 || field[i, j] == -10)
                {
                    BigInteger count = 0;
                    if (i > 0 && field[i - 1, j] >= 0) count += field[i - 1, j];
                    if (j > 0 && field[i, j - 1] >= 0) count += field[i, j - 1];

                    field[i, j] = count;
                    if (stop) return count;
                }
            }
        }

        return 1;
    }
}