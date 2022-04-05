using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int i;
            Console.Write( n + " so dau tien cua day so Fibonacci: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(Fibonaci(i));
                Console.Write("\t");
            }
        }
        public static int Fibonaci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;
            if(n<0)
            {
                return -1;
            }
       else if (n == 0 || n == 1) {
        return n;
    } else {
        for (i = 2; i<n; i++) {
            f0 = f1;
            f1 = fn;
            fn = f0 + f1;
        }
    }
    return fn;
        }
    }
}
