using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQuocCuong_B6_Phieu2
{
    class Truck:IVehiciles
    {
        double truckLoad { get; set; }

        public Truck():base()
        {
        }

        public Truck(string id, string maker, string model, int year, double price, double truckLoad) : base(id, maker, model, year, price)
        {
            this.truckLoad = truckLoad;
        }
        public override void InPut()
        {
            base.InPut();
            Console.Write("Nhập tải trọng: "); truckLoad = double.Parse(Console.ReadLine());
        }

        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine("TRUCKLOAD = " + truckLoad);
        }
    }
}
