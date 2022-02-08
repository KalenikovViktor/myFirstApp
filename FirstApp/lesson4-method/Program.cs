using System;
using System.Linq;

namespace lesson4_method
{
    internal class Program
    {
        //static void Coloring(string str, ConsoleColor color)
        //{
        //    Console.ForegroundColor = color;
        //    Console.WriteLine(str);
        //    Console.ResetColor();
        //}
        //static double[] CheckInput()
        //{
        //    double x = 0;
        //    double y = 0;
        //    bool isParse = false;
        //    string input;
        //    double[] outputMas;
        //    do
        //    {
        //        Console.Write("Enter value of X:");
        //        input = Console.ReadLine();
        //        if (double.TryParse(input, out x))
        //        {
        //            isParse = true;
        //        }
        //        else
        //        {
        //            Coloring("!!!Need input numbers!!!", ConsoleColor.Red);
        //        }
        //    }
        //    while (!isParse);
        //    isParse = false;
        //    do
        //    {
        //        Console.Write("Enter value of Y:");
        //        input = Console.ReadLine();
        //        if (double.TryParse(input, out y))
        //        {
        //            isParse = true;
        //        }
        //        else
        //        {
        //            Coloring("!!!Need input numbers!!!", ConsoleColor.Red);
        //        }
        //    }
        //    while (!isParse);
        //    outputMas = new double[] { x, y };
        //    return outputMas;
        //}
        static double Max(double x, double y)
        {
            return Math.Max(x, y);
        }
        static double Max(double x, double y, double z)
        {
            double[] numbers = { x, y, z };
            return numbers.Max();
        }
        static double Max(double x, double y, double z, double q)
        {
            double[] numbers = { x, y, z, q };
            return numbers.Max();
        }
        static double Min(double x, double y)
        {
            return Math.Min(x, y);
        }
        static double Min(double x, double y, double z)
        {
            double[] numbers = { x, y, z };
            return numbers.Min();
        }
        static double Min(double x, double y, double z, double q)
        {
            double[] numbers = { x, y, z, q };
            return numbers.Min();
        }
        static bool isSumOdd(double x, double y, out double sum)
        {
            bool isOdd = false;
            sum = x + y;
            if (sum % 2 == 0)
            {
                isOdd = true;
            }
            return isOdd;
        }
        static void Repeat(string str, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(str);
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            double[] numbers = {3, 3.5, 5, 5.2 };
            double sum = 0;
            double maxfrom2 = Max(numbers[0], numbers[1]);
            double minfrom2 = Min(numbers[0], numbers[1]);
            double maxfrom3 = Max(numbers[0], numbers[1], numbers[2]);
            double minfrom3 = Min(numbers[0], numbers[1], numbers[2]);
            double maxfrom4 = Max(numbers[0], numbers[1], numbers[2], numbers[3]);
            double minfrom4 = Min(numbers[0], numbers[1], numbers[2], numbers[3]);

            bool isOdd = isSumOdd(numbers[0], numbers[1], out sum);
            string str = "something|";
            int num = 3;
            Console.WriteLine($"Maximum among 2 numbers: {maxfrom2}");
            Console.WriteLine($"Minimum among 2 numbers: {minfrom2}");
            Console.WriteLine($"Maximum among 3 numbers: {maxfrom3}");
            Console.WriteLine($"Minimum among 3 numbers: {minfrom3}");
            Console.WriteLine($"Maximum among 4 numbers: {maxfrom4}");
            Console.WriteLine($"Minimum among 4 numbers: {minfrom4}");
            Console.WriteLine($"Sum is odd? {isOdd}");
            Console.WriteLine($"Sum is: {sum}");
            Repeat(str, num);
        }
    }
}
