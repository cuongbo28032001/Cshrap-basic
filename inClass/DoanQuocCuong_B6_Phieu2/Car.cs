using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQuocCuong_B6_Phieu2
{
    class Car : IVehiciles
    {
        string color { get; set; }

        public Car():base()
        {
        }

        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }

        public override void InPut()
        {
            base.InPut();
            Console.Write("Nhập màu sắc: ");    color = Console.ReadLine();
        }

        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine("COLOR = " + color);
        }
    }
}
