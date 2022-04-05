using System;

namespace TachDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập số phần tử mảng: n = ");    n = int.Parse(Console.ReadLine());
            a = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhập phần tử " + (i + 1) + " :");
                a[i] = int.Parse(Console.ReadLine());
            }    
            Tach(a,n);
        }

        public static void Tach(int[] a, int n)
        {
            int j = 0, k = 0;
            int[] b = new int[n];
            int[] c = new int[n];
            for(int i=0; i<n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[j++] = a[i];
                }
                else c[k++] = a[i];
            }
            Console.Write("\nMảng chẵn: ");
            for (int i=0; i<j; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Mảng lẻ: ");
            for (int i=0; i<k; i++)
            {
                Console.Write(c[i] + " ");
            }    
        }
    }
}
