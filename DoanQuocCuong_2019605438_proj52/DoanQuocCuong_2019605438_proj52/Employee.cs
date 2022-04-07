using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQuocCuong_2019605438_proj52
{
    class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int workingdays { get; set; }
        public const int PRICE = 50;
        public double salary
        {
            get
            {
                return this.workingdays * PRICE;
            }
        }
        
        public void inPut()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập id nhân viên: "); id = Console.ReadLine();
            Console.Write("Nhập tên nhân viên: "); name = Console.ReadLine();
            Console.Write("Nhập tuổi nhân viên: "); age = int.Parse(Console.ReadLine());
            Console.Write("Nhập ngày làm việc: "); workingdays = int.Parse(Console.ReadLine());
        }

       

        public void outPut()
        {
            Console.WriteLine("ID = "+this.id + "  NAME = " + this.name + "  AGE = " +  this.age + "  WORKINGDAYS = " + this.workingdays + "  SALARY = " + this.salary);
        }

    }
}
