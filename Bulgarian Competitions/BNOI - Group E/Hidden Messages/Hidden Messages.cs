using System;
using System.Collections.Generic;

class HiddenMessages
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<char[]> codeTable = new List<char[]>();
        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            codeTable.Add(new char[] { input[0], input[2] });
        }

        string message = Console.ReadLine();
        string result = String.Empty;
        for (int i = 0; i < message.Length; i++)
        {
            for (int j = 0; j < codeTable.Count; j++)
            {
                if (codeTable[j][1] == message[i])
                {
                    result += codeTable[j][0];
                    break;
                }
            }
        }

        Console.WriteLine(result);
    }
}