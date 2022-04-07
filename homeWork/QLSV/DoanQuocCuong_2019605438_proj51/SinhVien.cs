using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQuocCuong_2019605438_proj51
{
    public class SinhVien
    {
        public int soBaoDanh;
        protected string name;
        public string address;
        protected float toan;
        protected float ly;
        protected float hoa;
        protected float diemUutien;
        public float tongDiem
        {
            get
            {
                return toan + hoa + ly + diemUutien;
            }
        }

        public void NhapThongTin()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập sô báo danh: ");
            soBaoDanh = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();
            Console.Write("Nhập điểm toán: ");
            toan = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý: ");
            ly = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hóa: ");
            hoa = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm ưu tiên: ");
            diemUutien = int.Parse(Console.ReadLine());
        }

        public static string TieuDe()
        {
            return String.Format("{0,-20}{1,-17}{2,-12}{3,10}", "SOBAODANH", "TEN", "DIACHI", "TONGDIEM");
        }
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-20}{2,-12}{3,12}", soBaoDanh, name, address, tongDiem);
        }


        //Sắp xếp bằng .sort theo diem
        //public int CompareTo(object obj)
        //{
        //    SinhVien temp = (SinhVien)obj;
        //    return (int)(this.tongDiem - temp.tongDiem);
        //}
    }
}
    
