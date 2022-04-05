using System;
using System.Collections.Generic;

namespace ThanhPho
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] x;
            List<string> ThanhPho = new List<string>();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập số thành phố: "); n = int.Parse(Console.ReadLine());
            x = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập tên n thành phố trực thuộc trung ương " + (i + 1) + " : ");
                x[i] = Console.ReadLine();
                ThanhPho.Add(x[i]);
            }
            Sort_By_Name(ThanhPho,n);
        }
        public static void Sort_By_Name(List<string> ThanhPho, int n)
        {
            int x = ThanhPho.Count;
            string[] temp = new string[x];
            for (int i=0; i<x; i++)
            {
                string[] str2 = ThanhPho[i].Split(' ');
                for (int j=0; j<str2.Length; j++)
                {
                    temp[i] = str2[str2.Length-1];
                }    
            }
           for(int i=0; i<x; i++)
            {
                for(int j=0; j<temp[i].Length; j++)
                {
                    if(temp[i].CompareTo(temp[j])<0)
                        {
                        string temp1 = temp[i];
                        temp[i] = temp[j];
                        temp[j] = temp1;
                        string temp2 = ThanhPho[i];
                        ThanhPho[i] = ThanhPho[j];
                        ThanhPho[j] = temp2;
                    }
                }    
            }
            ThanhPho.Sort();
           foreach(var item in ThanhPho)
            {
                Console.WriteLine(item);
            }    
        }
    }
}
