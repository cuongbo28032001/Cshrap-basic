using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập số phần tử mảng: n = "); n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử " + (i + 1) + " :");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nTổng phần tử lẻ: " + Sum(a, n));
        }

        public static int Sum(int[] a, int n)
        {
            int sum = 0;
            for(int i=0; i<n; i++)
            {
                if(a[i]%2 != 0)
                {
                    sum += a[i];
                }    
            }
            if(sum == 0 )
            {
                Console.WriteLine("\nMảng không có phần tử lẻ");
            }    
            return sum;
        }
    }
}
