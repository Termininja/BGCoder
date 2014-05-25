using System;
using System.Linq;

class RightWord
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = int.Parse(line[j]);
            }
        }

        int points = 0;
        int[] primeDiagonal = new int[N];
        int[] secondDiagonal = new int[N];
        for (int i = 0; i < N; i++)
        {
            int[] rows = new int[N];
            int[] cols = new int[N];
            for (int j = 0; j < N; j++)
            {
                rows[j] = matrix[i, j];
                cols[j] = matrix[j, i];
                if (i == j) primeDiagonal[i] = matrix[i, j];
                if (i + j == N - 1) secondDiagonal[i] = matrix[i, j];
            }
            points += FindSequence(rows, "row");
            points += FindSequence(cols, "col");
        }

        points += FindSequence(primeDiagonal, "diagonal1");
        points += FindSequence(secondDiagonal, "diagonal2");
        Console.WriteLine(points);
    }

    static int FindSequence(int[] array, string type)
    {
        var unique = array.Distinct().ToArray();
        Array.Sort(unique);
        int result = 0;
        int count = 1;
        for (int i = 1; i < unique.Length; i++)
        {
            if (unique[i] == unique[i - 1] + 1) count++;
            else
            {
                result += Points(count, type);
                count = 1;
            }
        }

        return result + Points(count, type);
    }

    static int Points(int count, string type)
    {
        switch (count)
        {
            case 1: return 0;
            case 2: return (type == "row") ? 10 : ((type == "col") ? 20 : 30);
            case 3: return (type == "row") ? 40 : ((type == "col") ? 50 : 60);
            case 4: return (type == "row") ? 70 : ((type == "col") ? 80 : 90);
            case 5: return (type == "row") ? 100 : ((type == "col") ? 110 : 120);
            default: return (type == "row") ? 150 : ((type == "col") ? 160 : 170);
        }
    }
}