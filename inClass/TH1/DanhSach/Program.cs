using System;
using System.Collections.Generic;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> list = new List<float>();
            int n = 0;
            Console.Write("Nhap so phan tu mang: ");        n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cac phan tu mang: ");
            for (int i = 0; i < n; i++)
            {
                float a;
                Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
                a = float.Parse(Console.ReadLine());
                list.Add(a);
            } 
                
            
            Console.Write("\nMang vua nhap la: ");
            foreach (float a in list)
            {
                Console.Write(a + " ");
            }
            list.Sort();

            Console.Write("\nMang sau sap xep la: ");
            foreach (float a in list)
            {
                Console.Write(a + " ");
            }

            foreach (float a in list.ToArray())
            {
                if (a < 0)
                {
                    list.Remove(a);
                }    
            }
            Console.Write("\nMang sau xoa la: ");
            foreach (float a in list)
            {
                Console.Write(a + " ");
            }
            float x;
            Console.Write("\nNhap x = ");     x = float.Parse(Console.ReadLine());
            foreach(float a in list.ToArray())
            {
                if(a>x)
                {
                    list.Insert(list.IndexOf(a), x);
                }    
            }
            Console.Write("Mang sau them la: ");
            foreach (float a in list)
            {
                Console.Write(a + " ");
            }
        }
    }
}
