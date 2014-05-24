using System;

class Message
{
    static void Main()
    {
        string[] HL = Console.ReadLine().Split(' ');
        int L = int.Parse(HL[0]);
        int H = int.Parse(HL[1]);
        int N = int.Parse(Console.ReadLine());

        string[,] matrix = new string[H, L];
        for (int i = 0; i < N; i++)
        {
            string[] message = Console.ReadLine().Split(' ');
            int x = int.Parse(message[0]);
            int y = int.Parse(message[1]);
            int w = int.Parse(message[2]);
            int h = int.Parse(message[3]);

            for (int heigth = 0; heigth < h; heigth++)
            {
                for (int width = 0; width < w; width++)
                {
                    matrix[heigth + y, width + x] = "*";
                }
            }
        }

        string[] note = Console.ReadLine().Split(' ');
        int noteWidth = int.Parse(note[0]);
        int noteHeigth = int.Parse(note[1]);

        int count = 0;
        for (int i = 0; i <= H - noteHeigth; i++)
        {
            for (int j = 0; j <= L - noteWidth; j++)
            {
                if (HasFreeSpace(matrix, noteWidth, noteHeigth, i, j))
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }

    static bool HasFreeSpace(string[,] matrix, int noteWidth, int noteHeigth, int i, int j)
    {
        for (int n = 0; n < noteHeigth; n++)
        {
            for (int m = 0; m < noteWidth; m++)
            {
                if (matrix[i + n, j + m] == "*")
                {
                    return false;
                }
            }
        }

        return true;
    }
}