using System;
using System.Text;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Nhập n >= 0");
                    Console.Write("n = ");
                }
            } while (n < 0);
            Console.WriteLine(n+ "! = " + GiaiThua(n));
             
        }

        public static int GiaiThua(int n)
        {
            if(n==0 || n==1)
            {
                return 1;
            }
            else
            {
                int result = 1;
                for(int i=1; i<=n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}
