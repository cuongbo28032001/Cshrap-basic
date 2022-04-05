using System;
using System.Text;

namespace HeCoSo
{
    class Program
    {
        static void Main(string[] args)
        {
            He10ToOther();
        }
        public static void He10ToOther()
        {
            int n, b, rem, i = 1, sum = 0;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập số n = ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Nhập cơ số b = ");
                b = int.Parse(Console.ReadLine());
                if (n < 0 || b < 2)
                {
                    Console.WriteLine("Nhập lại n >0 và b >=2");
                    Console.Write("Nhập số n = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Nhập cơ số b = ");
                    b = int.Parse(Console.ReadLine());
                }
            } while (n < 0 || b < 2);
            int m = n;
            do
            {
                rem = m % b;
                sum = sum + (i * rem);
                m = m / b;
                i = i * 10;
            } while (m > 0);
            Console.WriteLine("Số "+ n + " từ hệ 10 sang hệ " + b + " = " + sum);
        }
    }
}
