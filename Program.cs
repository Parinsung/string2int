using System;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringToInt("abc573"));
            Console.WriteLine(StringToInt("a5b7c3"));
            Console.WriteLine(StringToInt("20XDCSA2120XDCSA212"));
        }

        static int StringToInt(string text)
        {
            int result = 0;
            foreach (var c in text)
            {
                if (Char.IsDigit(c))
                {
                    /// Can use long insert int (result) for check result value is out from max-integer or not
                    result = (result * 10) + (c - '0');
                }
            }
            return result;
        }
    }
}
