using System;
using System.Collections.Generic;

namespace Bai2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Circle circle = new Circle();
            circle.radius = 5;
            Console.WriteLine("Bán kính: " + circle.radius);
            Console.WriteLine("Chu vi: " + circle.Area() + "  Diện tích: " + circle.Perimeter());
        }

    }
}
