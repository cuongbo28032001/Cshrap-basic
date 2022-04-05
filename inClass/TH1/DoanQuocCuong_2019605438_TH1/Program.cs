using System;

namespace DoanQuocCuong_2019605438_TH1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập vào 2 số nguyên: ");
            Console.Write("a = ");  a = int.Parse(Console.ReadLine());
            Console.Write("b = ");  b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }
    }
}
