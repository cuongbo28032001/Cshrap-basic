using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, P, S;
            Console.WriteLine("Nhap 3 canh cua tam giac");
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            do
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    Console.WriteLine("Nhap lai kich thuoc 3 canh thoa man tam giac");
                    Console.Write("a = ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = float.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    c = float.Parse(Console.ReadLine());
                }
                else
                {
                    P = a + b + c;
                    S = (float)Math.Sqrt((P / 2) * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
                    Console.WriteLine("Chu vi: " + P + " Dien tich: " + S);
                }

            } while (a + b <= c || a + c <= b || b + c <= a);
        }
    }
}
