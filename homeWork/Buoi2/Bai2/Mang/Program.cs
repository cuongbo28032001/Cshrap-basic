using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập kích thước mảng = ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Input_Array(n, A);
            Output_Array(n,A);
            Find_Max_and_Min(n, A);
            Console.WriteLine("Sum = " + Sum(A));
        }
        public static void Input_Array(int n, int[] A)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                A[i] = int.Parse(Console.ReadLine());
            }    
        }

        public static void Output_Array(int n, int[] A)
        {
            Console.Write("Mảng vùa nhập: ");
            /*for (int i=0; i<n; i++)
            {
                Console.Write(A[i] + "  ");
            }    */
            foreach(int i in A)
            {
                Console.Write(i + "  ");
            }    
        }

        public static void Find_Max_and_Min(int n, int[] A)
        {
            int Max = A[0];
            int Min = A[0];
            for(int i=0;i<n-1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if (A[i] <= A[j])
                    {
                        Max = A[j];
                    }
                    else Max = A[i];
                }    
            }
            Console.WriteLine("\nMax = " + Max);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] >= A[j])
                    {
                        Min = A[j];
                    }
                    else Min = A[i];
                }
            }
            Console.WriteLine("Min = " + Min);
        }
        public static int Sum(int[] A)
        {
            int sum = 0;
            foreach(int i in A)
            {
                sum += i;
            }
            return sum;
        }
        
    }
}
