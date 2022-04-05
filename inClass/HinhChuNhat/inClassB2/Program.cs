using System;
using System.Text;

namespace inClassB2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Chiều rộng: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Chiều dài: ");
                b = double.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Nhập kích thước là các số dương");
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.Write("Chiều rộng: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Chiều dài: ");
                    b = double.Parse(Console.ReadLine());
                }
            } while (a <= 0 || b <= 0);
            Console.WriteLine("Chu vi = " + ChuVi(a, b));
            Console.WriteLine("Diện tích = " + Dientich(a, b));
        }
        public static double ChuVi(double a, double b)
        {
            return (a + b) * 2;
        }
       public static double Dientich(double a, double b)
        {
            return a * b;
        }
    }
}
