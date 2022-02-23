using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HW_lesson_8_text
{
    internal class Program
    {
        enum SortBy
        {
            Name,
            Number
        }
        static void ColoringAndPrint(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        static string ReadBook(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception e)
            {
                ColoringAndPrint($"!!!{e.Message}!!!\n", ConsoleColor.Red);
                return null;
            }
        }
        static void ShowBook((string name, string lastName, int number)[] book)
        {
            foreach (var item in book)
            {
                if (item.name != null)
                {
                    Console.WriteLine($"{item.name} {item.lastName} which phone number is {item.number}");
                }
            }
            Console.WriteLine();
        }
        static void ShowBook((string name, string lastName, int number) book)
        {
            if (book.name != "")
            {
                Console.WriteLine($"{book.name} {book.lastName} which phone number is {book.number}");
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.WriteLine();
        }
        static (string, string, int)[] InsertInBook(string[] names)
        {
            Regex regex = new Regex(@"^(\w+);(\w*);(\d+)$");
            var book = new (string name, string lastName, int number)[names.Length];
            int z = 0;
            for (int i = 0; i < names.Length; i++)
            {
                var match = regex.Match(names[i]);
                if (match.Success)
                {
                    book[z].name = match.Groups[1].Value;
                    book[z].lastName = match.Groups[2].Value;
                    book[z++].number = int.Parse(match.Groups[3].Value);
                }
            }
            return book;
        }
        static (string, string, int)[] Searching((string name, string lastName, int number)[] book, string searchQuery)
        {
            int[] index = new int[book.Length];
            int resultLength = 0;
            //Console.WriteLine();
            for (int i = 0; i < book.Length; i++)
            {
                //Console.WriteLine(book[i].name+book.Length);
                if (book[i].name != null && (book[i].name.ToLower().Contains(searchQuery.ToLower()) || book[i].number.ToString().Contains(searchQuery)))
                {
                    //Console.WriteLine();
                    //Console.WriteLine(book[i].name);
                    index[resultLength++] = i;
                }
            }
            var resultBook = new (string name, string lastName, int number)[resultLength];
            for (int i = 0; i < resultLength; i++)
            {
                resultBook[i] = book[index[i]];
            }
            return resultBook;
        }
        static (string, string, int) BinarySearching((string name, string lastName, int number)[] book, string searchQuery)
        {
            int search = 0;
            var result = ("", "", 0);
            if (int.TryParse(searchQuery, out search))
            {
                for (int i = 0, y = book.Length - 1; i!=y ;)
                {
                    if (book[(i + y) / 2].number > search)
                    {
                        y = (i + y) / 2;
                    }
                    else if (book[(i + y) / 2].number < search)
                    {
                        i = (i + y) / 2;
                    }
                    else
                    {
                        result = book[(i + y) / 2];
                        break;
                    }
                }
            }
            return result;
        }
        static (string, string, int)[] SortByName((string name, string lastName, int number)[] book)
        {
            var buf = book[0];
            //var resultBook = new (string name, string lastName, int number)[book.Length];
            for (int i = 0; i < book.Length; i++)
            {
                int minID = i;
                for (int y = i + 1; y < book.Length - 1; y++)
                {
                    if (book[y].name.CompareTo(book[minID].name) == -1)
                    {
                        minID = y;
                    }
                }
                if (minID != i)
                {
                    buf = book[minID];
                    book[minID] = book[i];
                    book[i] = buf;
                }
            }
            return book;
        }
        static (string, string, int)[] SortByLastName((string name, string lastName, int number)[] book)
        {
            var buf = book[0];
            //var resultBook = new (string name, string lastName, int number)[book.Length];
            for (int i = 0; i < book.Length; i++)
            {
                int minID = i;
                for (int y = i + 1; y < book.Length - 1; y++)
                {
                    if (book[y].lastName.CompareTo(book[minID].lastName) == -1)
                    {
                        minID = y;
                    }
                }
                if (minID != i)
                {
                    buf = book[minID];
                    book[minID] = book[i];
                    book[i] = buf;
                }
            }
            return book;
        }
        static (string, string, int)[] SortByNumber((string name, string lastName, int number)[] book)
        {
            var buf = book[0];
            //var resultBook = new (string name, string lastName, int number)[book.Length];
            for (int i = 0; i < book.Length; i++)
            {
                int minID = i;
                for (int y = i + 1; y < book.Length - 1; y++)
                {
                    if (book[y].number < book[minID].number)
                    {
                        minID = y;
                    }
                }
                if (minID != i)
                {
                    buf = book[minID];
                    book[minID] = book[i];
                    book[i] = buf;
                }
            }
            return book;
        }
        static void Main(string[] args)
        {
            string filePath = "PhoneBook.csv";
            string content = ReadBook(filePath);
            string[] names = {""};
            try
            {
                names = content.Split("\r\n");
            }
            catch (Exception e)
            {
                ColoringAndPrint($"!!!{e.Message}!!!\n", ConsoleColor.Red);
            }
            var book = InsertInBook(names);
            string searchQuery = "e";
            string searchQuery2 = "661234579";

            ColoringAndPrint("Origin PhoneBook:", ConsoleColor.Blue);
            ShowBook(book);
            ColoringAndPrint($"Result of searching by \"{searchQuery}\":", ConsoleColor.Blue);
            ShowBook(Searching(book, searchQuery));
            ColoringAndPrint("PhoneBook Sorted by Number:", ConsoleColor.Blue);
            ShowBook(SortByNumber(book));
            ColoringAndPrint($"Result of binary searching by \"{searchQuery2}\":", ConsoleColor.Blue);
            ShowBook(BinarySearching(SortByNumber(book), searchQuery2));
            ColoringAndPrint("PhoneBook Sorted by Name:", ConsoleColor.Blue);
            ShowBook(SortByName(book));
            ColoringAndPrint("PhoneBook Sorted by Last Name:", ConsoleColor.Blue);
            ShowBook(SortByLastName(book));
        }
    }
}
