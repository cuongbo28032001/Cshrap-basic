using System;

namespace CuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for(int i = 1; i <= 9; i++)
            {
                Console.Write("Bảng " + i);
                for(int j=1; j<=9; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }    
            }
        }
    }
}
