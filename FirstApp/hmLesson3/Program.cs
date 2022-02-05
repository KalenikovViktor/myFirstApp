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

            Console.WriteLine($"-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15 = {-6 * Math.Pow(x, 2) + 5 * Math.Pow(x, 2) - 10 * x + 15}");
            Console.WriteLine($"abs(x) * sin(x) = { Math.Abs(x) * Math.Sin(x)}");
            Console.WriteLine($"2 * pi * x = {2 * Math.PI * x}");
            Console.WriteLine($"max(x, y) = {Math.Max(x, y)}\n");

            DateTime today = DateTime.Today;
            DateTime pastNY = new DateTime(2022, 1, 1);
            DateTime futureNY = new DateTime(2023, 1, 1);
            Console.WriteLine($"{(today - pastNY).ToString("%d")} days passed from New Year");
            Console.WriteLine($"{(futureNY - today).ToString("%d")} days left to New Year");
        }
    }
}
