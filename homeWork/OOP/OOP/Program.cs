using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Person p = new Person();

            //--> Gọi phương thức trong class
            p.Input();
            p.checkAge();
            p.Output();

        }
    }
}
