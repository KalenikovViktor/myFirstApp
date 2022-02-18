using System;
using System.Text;

namespace HW_lesson_7_strings
{
    internal class Program
    {
        enum OrderBy
        {
            Asc,
            Desc,
        }
        static void ShowArray(char[] arr, string str = "")
        {
            foreach (char item in arr)
            {
                if (item == '\0')
                {
                    break;
                }
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static string Sort(string str, OrderBy order = OrderBy.Asc)
        {
            char buf;
            char[] strCh = str.ToLower().ToCharArray();
            for (int y = 0; y < str.Length; y++)
            {
                int minID = y;
                for (int i = y + 1; i < strCh.Length; i++)
                {
                    if (order == OrderBy.Asc && strCh[i] < strCh[minID])
                    {
                        minID = i;
                    }
                    else if (order == OrderBy.Desc && strCh[i] > strCh[minID])
                    {
                        minID = i;
                    }
                }
                if (minID != y)
                {
                    buf = strCh[minID];
                    strCh[minID] = strCh[y];
                    strCh[y] = buf;
                }
            }
            return str = new string(strCh);
        }
        static bool Compare(string str, string str2)
        {
            return str == str2;
        }
        static int[] Analyze(string str)
        {
            int[] result = new int[3];
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    result[0] += 1;
                }
                else if (char.IsDigit(str[i]))
                {
                    result[1] += 1;
                }
                else
                {
                    result[2] += 1;
                }
            }
            return result;
        }
        static char[] Duplicate(string str)
        {
            char[] strCh= new char[str.Length/2+1];
            int z=0;
            bool hasAlready = false;
            str=str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                for (int y = i+1; y < str.Length-1; y++)
                {
                    if (str[i] == str[y])
                    {
                        hasAlready = false;
                        foreach (var item in strCh)
                        {
                            if (item == '\0')
                            {
                                break;
                            }
                            else if (item==str[i])
                            {
                                hasAlready = true;
                                break;
                            }
                        }
                        if (!hasAlready)
                        {
                        strCh[z] = str[i];
                        z++;
                        }
                    }
                }
            }
            return strCh;
        }
        static void Main(string[] args)
        {
            string str = "hgfhfgzGFD";
            string str2 = "hgfhfgzGFD";
            string str3 = "JHghv=-123";
            int[] resultAnalyze = Analyze(str3);
            Console.WriteLine($"Строка {str} == {str2} ?\n {Compare(str, str2)}\n");
            Console.WriteLine($"Строка {str} == {str3} ?\n {Compare(str, str3)}\n");
            Console.WriteLine($"В строке {str3}\n{resultAnalyze[0]} букв, {resultAnalyze[1]} цифр(ы), {resultAnalyze[2]} символ(ов)\n");
            Console.WriteLine($"Отсортированная строка {str}\n {Sort(str)}\n");
            Console.WriteLine($"В строке {str} повторяются такие символы:");
            ShowArray(Duplicate(str));
        }
    }
}
