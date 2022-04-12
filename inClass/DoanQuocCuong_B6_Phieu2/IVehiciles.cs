using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQuocCuong_B6_Phieu2
{
    class IVehiciles : IVehicile, IComparable
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public IVehiciles()
        {
        }

        public IVehiciles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public IVehiciles(string id)
        {
            this.id = id;
        }

        public virtual void InPut()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập id: "); id = Console.ReadLine();
            Console.Write("Nhập hãng: ");   maker = Console.ReadLine();
            Console.Write("Nhập kiểu: ");   model = Console.ReadLine();
            Console.Write("Nhập năm sản xuất: ");   year = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá: ");    price = double.Parse(Console.ReadLine());
        }

        public static String Tieude()
        {
            return String.Format("{0,-20}{1,-17}{2,-12}{3,15}{4,10}", "ID", "MAKER","MODEL","YEAR","PRICE");
        }
        public virtual void OutPut()
        {
            Console.WriteLine("ID = " + id);
            Console.WriteLine("MAKER = " + maker);
            Console.WriteLine("MODEL = " + model);
            Console.WriteLine("YEAR = " + year);
            Console.WriteLine("PRICE = " + price);
        }

        public override bool Equals(object obj)
        {
            IVehiciles v = (IVehiciles)obj;
            return (this.id.Equals(v.id));
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,-17}{2,-12}{3,15}{4,10}", id, maker,model, year, price);
        }

        public int CompareTo(object obj)
        {
            IVehiciles temp = (IVehiciles)obj;
            return (this.price.CompareTo(temp.price));
        }
    }

    class CompareToYear : IComparer<IVehiciles>
    {
        public int Compare(IVehiciles x, IVehiciles y)
        {
            return (x.year - y.year);
        }
    }
}
