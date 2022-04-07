using System;

namespace Bai2
{
    class Program
    {
        static Ptb2 PT = new Ptb2();

        static void inPut()
        {
            while(PT.a<=0)
            {
                Console.Write("Nhập hệ số a = "); PT.a = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhập hệ số b = "); PT.b = int.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số c = "); PT.c = int.Parse(Console.ReadLine());
        }

        static void outPut()
        {
            if(PT.b==0)
            {
                Console.WriteLine("\nPT bậc 2 vừa nhập: " + PT.a + "x^2 + "  + PT.c + " = 0");
            } 
            else if(PT.c ==0)
            {
                Console.WriteLine("PT bậc 2 vừa nhập: " + PT.a + "x^2 + " + PT.b + "x = 0 ");
            }    
            else Console.WriteLine("PT bậc 2 vừa nhập: " + PT.a + "x^2 + " + PT.b + "x + " + PT.c + " = 0");
        }

        static void Nghiem()
        {
            double delta = PT.b * PT.b - 4 * PT.a * PT.c;
            if (delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm: " + "X1 = {0}" + "   X2 = {1}" , ((-PT.b - Math.Sqrt(delta)) / 2 * PT.a) , ((-PT.b + Math.Sqrt(delta)) / 2 * PT.a));
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép: " + "X1 = X2 = {0}", -PT.b / 2 * PT.a);
                
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            inPut();
            outPut();
            Nghiem();
        }
    }
}
