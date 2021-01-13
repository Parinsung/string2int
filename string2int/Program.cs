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
                var data = CharToInt(c);
                if (data != null)
                {
                    result = (result * 10) + data.Value;
                }
            }
            return result;
        }
        static int? CharToInt(char c)
        {
            //Can use dictionary too if we have so many and complicated case
            switch (c)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    return null;
            }
        }
    }
}
