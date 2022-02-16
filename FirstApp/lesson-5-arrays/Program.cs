using System;

namespace lesson_5_arrays
{
    internal class Program
    {
        static void Coloring(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        enum SortAlgorithmType
        {
            Selection,
            Bubble,
            Insertion
        }
        enum OrderBy
        {
            Asc,
            Desc
        }
        static void ShowArray(int[] arr, string str = "")
        {
            Coloring(str, ConsoleColor.Blue);
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static int[] CopyArray(int[] arr)
        {
            int[] copyArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                copyArr[i] = arr[i];
            }
            return copyArr;
        }
        static int[] SortSelection(int[] arr, OrderBy order)
        {
            int buf;
            for (int y = 0; y < arr.Length; y++)
            {
                int minID = y;
                for (int i = y + 1; i < arr.Length; i++)
                {
                    if (order == OrderBy.Asc && arr[i] < arr[minID])
                    {
                        minID = i;
                    }
                    else if (order == OrderBy.Desc && arr[i] > arr[minID])
                    {
                        minID = i;
                    }
                }
                if (minID != y)
                {
                    buf = arr[minID];
                    arr[minID] = arr[y];
                    arr[y] = buf;
                }
            }
            return arr;
        }
        static int[] SortBubble(int[] arr, OrderBy order)
        {
            int buf;
            for (int y = 0; y < arr.Length; y++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (order == OrderBy.Asc && arr[i + 1] < arr[i])
                    {
                        buf = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = buf;
                    }
                    else if (order == OrderBy.Desc && arr[i + 1] > arr[i])
                    {
                        buf = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = buf;
                    }
                }
            }
            return arr;
        }
        static int[] SortInsertion(int[] arr, OrderBy order)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int buf = arr[i];
                int y = i - 1;
                if (order == OrderBy.Asc)
                {
                    for (; y >= 0 && arr[y] > buf; y--)
                    {
                        arr[y + 1] = arr[y];
                    }
                }
                else if (order == OrderBy.Desc)
                {
                    for (; y >= 0 && arr[y] < buf; y--)
                    {
                        arr[y+1] = arr[y];
                    }
                }
                arr[y + 1] = buf;
            }
            return arr;
        }
        static int[] Sort(int[] arr, SortAlgorithmType type, OrderBy order = OrderBy.Asc)
        {
            switch (type)
            {
                case SortAlgorithmType.Selection:
                    return SortSelection(CopyArray(arr), order);
                case SortAlgorithmType.Bubble:
                    return SortBubble(CopyArray(arr), order);
                case SortAlgorithmType.Insertion:
                    return SortInsertion(CopyArray(arr), order);
                default:
                    return arr;
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = { rnd.Next(99), rnd.Next(99), rnd.Next(99), rnd.Next(99), rnd.Next(99) };
            Console.Write("");
            ShowArray(CopyArray(arr), "Origin array:");
            ShowArray(Sort(arr, SortAlgorithmType.Selection), "Sorted by Selection:");
            ShowArray(Sort(arr, SortAlgorithmType.Selection, OrderBy.Desc), "Sorted by Selection.Desc:");
            //ShowArray(CopyArray(arr), "Origin array: ");
            ShowArray(Sort(arr, SortAlgorithmType.Bubble), "Sorted by Bubble:");
            ShowArray(Sort(arr, SortAlgorithmType.Bubble, OrderBy.Desc), "Sorted by Bubble.Desc:");
            //ShowArray(CopyArray(arr), "Origin array: ");
            ShowArray(Sort(arr, SortAlgorithmType.Insertion), "Sorted by Insertion:");
            ShowArray(Sort(arr, SortAlgorithmType.Insertion, OrderBy.Desc), "Sorted by Insertion.Desc:");
        }
    }
}
