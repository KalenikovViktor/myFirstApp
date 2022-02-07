using System;

namespace classwork.lesson_3_condition_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 0;
            double y = 0;
            string input;
            double result = 0;
            bool isParse = false;
            //МОГУ СДЕЛАТЬ ЧТОБЫ ПРИ НЕВЕРНОМ ВВОДЕ ПРОГРАММА ЗАВЕРШАЛАСЬ,
            //НО ПОМОЕМУ ЭТО НЕАДЕКВАТНО, БУДЕТ ПРОСИТЬ ПОВТОРНО ВВЕСТИ ЧИСЛО
            do
            {
                Console.Write("Enter value of X:");
                input = Console.ReadLine();
                if (double.TryParse(input, out x))
                {
                    isParse = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Need input numbers!!!");
                    Console.ResetColor();
                }
            }
            while (!isParse);
            isParse = false;
            do
            {
                Console.Write("Enter value of Y:");
                input = Console.ReadLine();
                if (double.TryParse(input, out y))
                {
                    isParse = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Need input numbers!!!");
                    Console.ResetColor();
                }
            }
            while (!isParse);
            bool wrong = false;
            do
            {
                wrong = false;
                Console.WriteLine("Что сделать?\n1-сложение\n2-вычитание\n3-умножение\n4-деление\n0-выход");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        result = x + y;
                        break;
                    case "2":
                        result = x - y;
                        break;
                    case "3":
                        result = x * y;
                        break;
                    case "4":
                        //Проверка деления на ноль
                        if (y==0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n!!!На ноль делить нельзя!!!\n");
                            Console.ResetColor();
                            continue;
                        }
                        result = x / y;
                        break;
                    case "0":
                        break;
                    default:
                        wrong = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n!!!Введен неверный вариант!!!\n");
                        Console.ResetColor();
                        break;

                }
                if (!wrong && input != "0")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\nТвой ответ: {result}\n------------------------------\n");
                    Console.ResetColor();
                }
            } while (wrong || input!="0");
        }
    }
}
