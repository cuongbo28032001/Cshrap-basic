using System;

namespace OOP
{
    class Person
    {
        public int age;
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public void checkAge()
        {
            if (age >= 18)
            {
                Console.WriteLine("Bạn đủ tuổi bầu cử");
            }
            else Console.WriteLine("Bạn con nhỏ");
        }

        public void Input()
        {
            Console.Write("Nhập id: "); id = Console.ReadLine();
            Console.Write("Nhập name: "); name = Console.ReadLine();
            Console.Write("Nhập age: "); age = int.Parse(Console.ReadLine());
            Console.Write("Nhập email: "); email = Console.ReadLine();
            Console.Write("Nhập address: "); address = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("id: " + id + "  name: " + name + "  age: " + age + "  email: " + email + "  address: " + address);
        }
    }
}