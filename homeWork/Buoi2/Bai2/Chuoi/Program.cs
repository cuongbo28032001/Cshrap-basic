using System;
using System.Collections.Generic;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập chuỗi: ");
            str = Console.ReadLine();
            Show_in_line(str);
            Show_Word_in_Line(str);
            Show_Word(str);
        }

        public static void Show_in_line(string str)
        {
            Console.WriteLine("\n-------------------------------");
            foreach(var item in str)
            {
                Console.WriteLine(item);
            }    
        }

        public static void Show_Word_in_Line(string str)
        {
            Console.WriteLine("\n\n----------------------------------");
            str = str.Trim();
            while(str.IndexOf("  ")!=-1)
            {
                str = str.Replace("  ", " ");
            }
            string[] strcp = str.Split(' ');
            foreach(var item in strcp)
            {
                Console.WriteLine(item);
            }    
        }

        public static void Show_Word(string str)
        {
            int count;
            Console.WriteLine("\n\n----------------------------------");
            str = str.Trim();
            while (str.IndexOf("  ") != -1)
            {
                str = str.Replace("  ", " ");
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
          
            foreach (char ch in str.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }
            Console.ReadKey();
        }

    }
}
