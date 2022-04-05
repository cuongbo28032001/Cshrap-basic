using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string pt;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập vào 2 số thực: ");
            Console.Write("a = ");  a = double.Parse(Console.ReadLine());
            Console.Write("b = ");  b = double.Parse(Console.ReadLine());
            Console.Write("Nhập 1 phép toán: ");    pt = Console.ReadLine();
            if (pt == "+")
            {
                Console.Write(a + " + " + b + " = " + (a + b));
            }
            else if (pt == "-")
            {
                Console.Write(a + " - " + b + " = " + (a - b));
            }
            else if (pt == "*")
            {
                Console.Write(a + " * " + b + " = " + (a * b));
            }
            else if (pt == "/")
            {
                Console.Write(a + " / " + b + " = " + (a / b));
            }
            else Console.Write("Chuỗi nhập vào không phải là 1 phép toán");
        }
    }
}
