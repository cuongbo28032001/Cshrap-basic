using System;
using System.Collections.Generic;

namespace DoanQuocCuong_B6_Phieu2
{
    class Program
    {
        static List<IVehiciles> li = new List<IVehiciles>();
        static void Main(string[] args)
        {   
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int choose;
            do
            {
                Console.WriteLine("\n\t\t\t"+ @"-------------MENU-------------
                    1. Nhập dữ liệu. 
                    2. Hiển thị dữ liệu.
                    3. Tìm kiếm theo id
                    4. Tìm kiếm theo maker.
                    5. Sắp xếp theo price.
                    6. Sắp xếp theo year.
                    7. Kết thúc");
                Console.Write("\nNhập lựa chọn của bạn: "); choose = int.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        EnterInfo();
                        break;
                    case 2:
                        ShowList();
                        break;
                    case 3:
                        FindByID();
                        break;
                    case 4:
                        FindByMaker();
                        break;
                    case 5:
                        SortByPrice();
                        break;
                    case 6:
                        SortByYear();
                        break;
                    case 7:
                        Console.WriteLine("__________<3___BYE___<3_________");
                        return;
                }    
           } while (choose != 7);
        }
        static void EnterInfo()
        {
            li.Add(new Car("Veh1", "Mercedes", "BMW Serie 5", 2017, 20000, "Black"));
            li.Add(new Car("Veh2", "Kawashaki", "Kawashaki", 2016, 30000, "Blue"));
            li.Add(new Car("Veh3", "Mercedes", "BMW Serie 4", 2018, 25000, "Red"));
            li.Add(new Truck("Veh4", "Kindai", "KD Serie 3", 2015, 21000, 70));
            li.Add(new Truck("Veh5", "Honda", "BMW Serie 5", 2014, 15000, 85));
            li.Add(new Truck("Veh6", "Mercedes", "BMW Serie 6", 2019, 22000, 67));
        }

        static void ShowList()
        {
            Console.WriteLine(IVehiciles.Tieude());
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
        }
        static void FindByID()
        {
            Console.Write("Nhập ID cần tìm: "); string id = Console.ReadLine();
            IVehiciles temp = new IVehiciles(id);
            int index = li.IndexOf(temp);
            if (index == -1)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                IVehiciles.Tieude();
                Console.WriteLine(li[index]);
            }      
        }
        static void FindByMaker()
        {
            Console.Write("Nhập maker cần tìm: "); string maker = Console.ReadLine();
            List<IVehiciles> liTemp = new List<IVehiciles>();
            foreach (var item in li)
            {
                if(item.maker.Equals(maker))
                {
                    liTemp.Add(item);
                }    
            }
            if (liTemp.Count > 0)
            {
                IVehiciles.Tieude();
                foreach (var item in liTemp)
                {
                    Console.WriteLine(item);
                }
            }
            else Console.WriteLine("Không có");
        }

        static void SortByPrice()
        {
            Console.WriteLine("----------Danh sách trước sắp xếp--------------");
            IVehiciles.Tieude();
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            li.Sort();
            Console.WriteLine("----------Danh sách sau sắp xếp--------------");
            IVehiciles.Tieude();
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
        }

        static void SortByYear()
        {
            Console.WriteLine("----------Danh sách trước sắp xếp--------------");
            IVehiciles.Tieude();
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            li.Sort(new CompareToYear());
            Console.WriteLine("----------Danh sách sau sắp xếp--------------");
            IVehiciles.Tieude();
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
        }
    }
}
