using System;

namespace lesson_4_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibanachi(3));
        }
        static int Fibanachi(int length)
        {
            int result = 1;
            for (int i = 1; i <=length; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
