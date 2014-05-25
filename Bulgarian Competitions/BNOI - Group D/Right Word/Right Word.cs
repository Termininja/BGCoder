using System;
using System.Text.RegularExpressions;

class RightWord
{
    static void Main()
    {
        var words = Regex.Replace(Regex.Replace(Console.ReadLine(), @"[^\w\*]", ""), @"\*{2,}", "*").Split('*');
        int maxLength = 0;
        int maxPosition = 0;
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i].ToLower();
            int length = word.Length;
            if (length % 2 != 0)
            {
                bool isRightWord = true;
                for (int w = 1; w < length; w++)
                {
                    if (word[w - 1] > word[w])
                    {
                        isRightWord = false;
                        break;
                    }
                }

                if (isRightWord && length > maxLength)
                {
                    maxLength = length;
                    maxPosition = i + 1;
                }
            }
        }

        Console.WriteLine(maxPosition + " " + maxLength);
    }
}