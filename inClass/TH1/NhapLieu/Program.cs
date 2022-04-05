using System;

namespace NhapLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,k;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("n = ");
            n = double.Parse(Console.ReadLine());
            while (1.0>n || n>100.0)
            {
                Console.Write("n = ");
                n = double.Parse(Console.ReadLine());
            }

            do
            {
                Console.Write("k = ");
                k = double.Parse(Console.ReadLine());
            } while (k < 1.0 || k > 100.0);
        }
    }
}
