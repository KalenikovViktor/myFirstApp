using System;

namespace lesson_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            string str2="";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    str2+=char.ToLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    str2+=char.ToUpper(str[i]);
                }
            }
            Console.WriteLine(str2);
        }
    }
}
