using System;

namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            float point;
            Console.Write("Input HS's name: ");
            name = Console.ReadLine();
            name = name.ToUpper();
            Console.Write("Input point's HS: ");
            point = float.Parse(Console.ReadLine());
            Console.WriteLine("\n------------------------------------------------------------\n");
            if(point >= 8 )
            {
                Console.WriteLine("HS's name: " + name + "\tRank: Gioi");
            }
            else if(6.5 <= point && 8 > point)
            {
                Console.WriteLine("HS's name: " + name + "\tRank: Kha");
            }
            else if (5 <= point && 6.5 > point)
            {
                Console.WriteLine("HS's name: " + name + "\tRank: Trung binh");
            }
            else Console.WriteLine("HS's name: " + name + "\tRank: Yeu");
        }
    }
}
