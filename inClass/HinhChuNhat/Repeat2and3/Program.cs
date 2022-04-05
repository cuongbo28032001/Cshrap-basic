using System;
using System.Text;

namespace Repeat2and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Nhập n >= 0");
                    Console.Write("n = ");
                }
            } while (n < 0);
            Console.WriteLine(n + "! = " + GiaiThua(n));
            Console.Write(n + " Số Fibonaci đầu tiên: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonaci(i));
                Console.Write("\t");
            }
        }
        public static int GiaiThua(int n)
        {
            if(n<=1)
            {
                return 1;
            }
            return n * GiaiThua(n - 1);
        }

        public static int Fibonaci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Fibonaci(n - 1) + Fibonaci(n - 2);
        }
    }
}
