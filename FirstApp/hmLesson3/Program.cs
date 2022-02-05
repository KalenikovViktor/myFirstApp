using System;

namespace hmLesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            int y=0;
            string input;
            bool isParse = false;
            do
            {
                Console.Write("Enter value of X:");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out int buf))
                {
                    isParse = true;
                    x = Int32.Parse(input);
                }
                else
                {
                    Console.WriteLine("Need input integer numbers");
                }
            }
            while (!isParse);
            isParse = false;
            do
            {
                Console.Write("Enter value of Y:");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out int buf))
                {
                    isParse = true;
                    y = Int32.Parse(input);
                }
                else
                {
                    Console.WriteLine("Need input integer numbers");
                }
            }
            while (!isParse);
            double result1 = -6 * Math.Pow(x, 2) + 5 * Math.Pow(x, 2) - 10 * x + 15;
            double result2 = Math.Abs(x) * Math.Sin(x);
            double result3 = 2 * Math.PI * x;
            double result4 = Math.Max(x, y);
           Console.WriteLine($"-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15 = {result1}");
            Console.WriteLine($"abs(x) * sin(x) = {result2 }");
            Console.WriteLine($"2 * pi * x = {result3}");
            Console.WriteLine($"max(x, y) = {result4}\n");

            DateTime today = DateTime.Today;
            DateTime pastNY = new DateTime(2022, 1, 1);
            DateTime futureNY = new DateTime(2023, 1, 1);
            Console.WriteLine($"{(today - pastNY).ToString("%d")} days passed from New Year");
            Console.WriteLine($"{(futureNY - today).ToString("%d")} days left to New Year");
        }
    }
}
