using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_UCLN
{
    class UCLN
    {
        public int a { get; set; }
        public int b { get; set; }
        public void inPut()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập số thứ nhất: "); a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: "); b = int.Parse(Console.ReadLine());
        }

        public int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
    }

    
}
