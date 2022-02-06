using System;

namespace hmLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            string input;
            int result = 0;
            bool isParse = false;
            //МОГУ СДЕЛАТЬ ЧТОБЫ ПРИ НЕВЕРНОМ ВВОДЕ ПРОГРАММА ЗАВЕРШАЛАСЬ,
            //НО ПОМОЕМУ ЭТО НЕАДЕКВАТНО, БУДЕТ ПРОСИТЬ ПОВТОРНО ВВЕСТИ ЧИСЛО
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Need input integer numbers!!!");
                    Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Need input integer numbers!!!");
                    Console.ResetColor();
                }
            }
            while (!isParse);
            if (x != y)
            {
                for (int i = Math.Min(x, y); i <= Math.Max(x, y); i++)
                {
                    result += i;
                }
            }
            else
            {
                result = x;
            }
            Console.WriteLine(result);
        }
    }
}
