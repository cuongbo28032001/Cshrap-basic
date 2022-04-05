using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao chuoi can kiem tra : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine(name + " la chuoi doi xung.");
            }
            else
            {
                Console.WriteLine(name + " khong phai chuoi doi xung");
            }
            Console.ReadKey();
        }
    }
}
