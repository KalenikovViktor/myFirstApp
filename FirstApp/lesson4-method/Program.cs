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
        static double Max(params double[] numbers)
        {
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
        static double Min(params double[] numbers)
        {
            return numbers.Min();
        }
        static bool IsSumOdd(double x, double y, out double sum)
        {
            sum = x + y;
            return sum % 2 == 0;
        }
        static void Repeat(string str, int length)
        {
            if (length == 0)
            {
                Console.WriteLine();
                return;
            }
            Console.Write(str);
            Repeat(str, length - 1);
        }
        static double[] RandomGenerator(int n)
        {
            Random rnd = new Random();
            int[] numbersInt = new int[n];
            double[] numbersFP = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbersInt[i] = rnd.Next(1,10);
                numbersFP[i] = rnd.NextDouble();
                numbersFP[i] += numbersInt[i];
            }
            return numbersFP;
        }
        static void Main(string[] args)
        {
            double[] numbers = RandomGenerator(5);
            double sum = 0;
            double maxfrom2 = Max(numbers[0], numbers[1]);
            double minfrom2 = Min(numbers[0], numbers[1]);
            double maxfrom3 = Max(numbers[0], numbers[1], numbers[2]);
            double minfrom3 = Min(numbers[0], numbers[1], numbers[2]);
            double maxfrom4 = Max(numbers[0], numbers[1], numbers[2], numbers[3]);
            double minfrom4 = Min(numbers[0], numbers[1], numbers[2], numbers[3]);
            double maxfrom5 = Max(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            double minfrom5 = Min(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            double maxfrom5v2 = Max(numbers);
            double minfrom5v2 = Min(numbers);
            bool isOdd = IsSumOdd(numbers[0], numbers[1], out sum);
            string str = "something|";
            int num = (int)numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine($"Maximum among 2 numbers: {maxfrom2}");
            Console.WriteLine($"Minimum among 2 numbers: {minfrom2}");
            Console.WriteLine($"Maximum among 3 numbers: {maxfrom3}");
            Console.WriteLine($"Minimum among 3 numbers: {minfrom3}");
            Console.WriteLine($"Maximum among 4 numbers: {maxfrom4}");
            Console.WriteLine($"Minimum among 4 numbers: {minfrom4}");
            Console.WriteLine($"Maximum among 5 numbers: {maxfrom5}");
            Console.WriteLine($"Minimum among 5 numbers: {minfrom5}");
            Console.WriteLine($"Maximum among 5 numbers v2: {maxfrom5v2}");
            Console.WriteLine($"Minimum among 5 numbers v2: {minfrom5v2}");
            Console.WriteLine($"Sum is odd? {isOdd}");
            Console.WriteLine($"Sum is: {sum}");
            Repeat(str, num);
        }
    }
}
