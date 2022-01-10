using System;

namespace ex5
{
    class Program
    {
        static void Tinh(int[] a,int n,int x)
        {
            double d = 0;
            for(int i=0;i<=n;i++)
                d+=a[i]*Math.Pow(x,i);
            Console.WriteLine("gia tri la {0}", d);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n+1];
            for (int i = 0; i <=n; i++)
            {
                Console.Write("Nhap he so thu {0}:", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap x:");
            int x = int.Parse(Console.ReadLine());
            Tinh(a, n, x);
        }
    }
}
