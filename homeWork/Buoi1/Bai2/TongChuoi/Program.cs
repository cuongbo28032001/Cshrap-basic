using System;

namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, S1 = 0;
            float S2=0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                S1 += i;
                S2 += (float)1/i;
            }
            Console.WriteLine("S1 = " + S1 + "\tS2 = " + S2);
        }
    }
}
