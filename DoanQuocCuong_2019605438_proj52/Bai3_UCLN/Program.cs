using System;
using System.Collections.Generic;

namespace Bai3_UCLN
{
    class Program
    {
        static int n;
        static List<UCLN> list = new List<UCLN>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
           
            Console.Write("Nhập số đói tượng: "); n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                UCLN temp = new UCLN();
                Console.WriteLine("\t\tNhập đối tượng " + (i + 1));
                temp.inPut();
                list.Add(temp);
            }


            Console.WriteLine("\n\t\t\t--------------Danh sách vừa nhập và UCLN----------------");
            foreach(UCLN i in list)
            {
                Console.WriteLine("\t\t\t\t("+ i.a + ", " + i.b + ")" + " ---> UCLN = " + i.USCLN(i.a, i.b));
            }    
        }
    }
}
