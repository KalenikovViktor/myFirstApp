using System;

namespace lesson_5_arrays
{
    internal class Program
    {
        static void ShowArray(int[] arr, string str = "")
        {
            Console.Write(str);
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
        static int[] SortSelection(int[] arr)
        {
            int buf;
            for (int y = 0; y < arr.Length; y++)
            {
                int minID = y;
                for (int i = y + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[minID])
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
        static int[] SortBubble(int[] arr)
        {
            int buf;
            for (int y = 0; y < arr.Length; y++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i + 1] < arr[i])
                    {
                        buf = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = buf;
                    }
                }
            }
            return arr;
        }
        static int[] SortInsertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int buf = arr[i];
                int y = i - 1;
                for (; y >= 0 && arr[y] > buf; y--)
                {
                    arr[y + 1] = arr[y];
                }
                arr[y + 1] = buf;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = { rnd.Next(99), rnd.Next(99), rnd.Next(99), rnd.Next(99), rnd.Next(99) };
            Console.Write("");
            ShowArray(CopyArray(arr), "Origin array:        ");
            ShowArray(SortSelection(CopyArray(arr)), "Sorted by Selection: ");
            //ShowArray(CopyArray(arr), "Origin array: ");
            ShowArray(SortBubble(CopyArray(arr)), "Sorted by Bubble:    ");
            //ShowArray(CopyArray(arr), "Origin array: ");
            ShowArray(SortInsertion(CopyArray(arr)), "Sorted by Insertion: ");
        }
    }
}
