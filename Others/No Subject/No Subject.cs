using System;
using System.Linq;

class NoSubject
{
    static void Main()
    {
        ConvertNumber(Console.ReadLine());
    }

    static void ConvertNumber(string n)
    {
        int l = n.Length;
        while (l-- > 0)
        {
            Console.Write(new string[][] { 
                new string[] { "", "0", "00", "000", "01", "1", "10", "100", "1000", "02" }, 
                new string[] { "", "2", "22", "222", "23", "3", "32", "322", "3222", "24" }, 
                new string[] { "", "4", "44", "444", "45", "5", "54", "544", "5444", "46" }, 
                new string[] { "", "6", "66", "666" } 
            }[l][int.Parse((new String(n.Reverse().ToArray()))[l].ToString())]);
        }
    }
}
