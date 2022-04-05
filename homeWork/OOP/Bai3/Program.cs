using System;

namespace Bai3
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SV01");
            Student s2 = new Student("SV02", "Quoc Cuong", 10);
            Console.WriteLine("Student 1 id: " + s1.id);
            Console.WriteLine("Student 2 id: " + s2.id + " name: " + s2.name + " mark: " + s2.mark + " scholarship: " + s2.scholaship);

        }
    }
}
