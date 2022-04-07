using System;
using System.Collections.Generic;

namespace DoanQuocCuong_2019605438_proj51
{
    class Program
    {
        static List<SinhVien> list = new List<SinhVien>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int choose;
            do
            {
                Console.WriteLine("\n\t\t1. Thêm 1 sinh viên vào danh sách");
                Console.WriteLine("\t\t2. Hiển thị danh sách");
                Console.WriteLine("\t\t3. Đưa ra các sinh viên có tổng điểm lớn hơn yêu cầu");
                Console.WriteLine("\t\t4. Đưa ra các sinh viên theo địa chỉ");
                Console.WriteLine("\t\t5. Tìm kiếm sinh viên theo số báo danh");
                Console.WriteLine("\t\t6. Thoát chương trình");
                Console.Write("\nNhập lựa chọn của bạn: "); choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Them_SinhVien();
                            break;
                        }
                    case 2:
                        {
                            Show_DS_SinhVien();
                            break;
                        }
                    case 3:
                        {
                            Show_By_TongDiem();
                            break;
                        }
                    case 4:
                        {
                            Show_By_DiaChi();
                            break;
                        }
                    case 5:
                        {
                            Find_By_ID();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("_________GOOD BYE <3 _________");
                            break;
                        }
                }
            } while (choose != 6);
        }

        static void Them_SinhVien()
        {
            SinhVien temp = new SinhVien();
            temp.NhapThongTin();
            list.Add(temp);
        }

        static void Xuat()
        {
            foreach (SinhVien i in list)
            {
                Console.WriteLine(i);
            }
        }
        static void Show_DS_SinhVien()
        {
            Console.WriteLine("\n\t\t-----------------Danh Sách vừa nhập-----------------");
            Console.WriteLine(SinhVien.TieuDe());
            Xuat();
        }

        static void Show_By_TongDiem()
        {
            Console.Write("\nNhập điểm tổng giới hạn: ");
            float diem = float.Parse(Console.ReadLine());

            //Sắp xếp theo điểm tb bằng .sort
            //list.Sort();

            //Boolean check = true;
            //foreach(SinhVien i in list)
            //{
            //    if(i.tongDiem >= diem)
            //    {
            //        check = true;
            //        break;
            //    }    
            //}    
            //if(!check)
            //{
            //    Console.WriteLine("Không có sinh viên nào có tổng điểm lớn hơn " + diem);
            //}
            //else
            //{
            //    Console.WriteLine("\n\t\t-----------------Danh Sách có tổng điểm lớn hơn " + diem + "----------------");
            //    Console.WriteLine(SinhVien.TieuDe());
            //    foreach(SinhVien i in list)
            //    {
            //        if(i.tongDiem >= diem)
            //        {
            //            Console.WriteLine(i);
            //        }    
            //    }    
            //}
            List<SinhVien> sv = list.FindAll(sv => sv.tongDiem >= diem);
            if(sv == null)
            {
                Console.WriteLine("Không có sinh viên nào có tổng điểm lớn hơn " + diem + "\n");
            }    
            else
            {
                Console.WriteLine("\n\t\t-----------------Danh Sách có tổng điểm lớn hơn " + diem + "----------------");
                Console.WriteLine(SinhVien.TieuDe());
                foreach(SinhVien i in sv)
                {
                    Console.WriteLine(i);
                }    
            }
        }

        static void Show_By_DiaChi()
        {
            Console.Write("\nNhập địa chỉ cần hiển thị: ");
            string dress = Console.ReadLine();
            List<SinhVien> sv = list.FindAll(sv => sv.address.Contains(dress));
            if (sv == null)
            {
                Console.WriteLine("Không có sinh viên có địa chỉ là " + dress + "\n");
            }
            else
            {
                Console.WriteLine("\n\t\t-----------------Danh Sách có địa chỉ " + dress + "----------------");
                Console.WriteLine(SinhVien.TieuDe());
                foreach(SinhVien i in sv)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void Find_By_ID()
        {
            Console.Write("\nNhập số báo danh cần tìm: ");
            int sBD =int.Parse(Console.ReadLine());
            SinhVien sv = list.Find(sv => sv.soBaoDanh == sBD);
            if (sv == null)
            {
                Console.WriteLine("Không có sinh viên có số báo danh " + sBD + "\n");
            }
            else
            {
                Console.WriteLine("\n\t\t-----------------Sinh viên có số báo danh " + sBD + "----------------");
                Console.WriteLine(SinhVien.TieuDe());
                Console.WriteLine(sv.ToString());
            }
        }
    }
}
