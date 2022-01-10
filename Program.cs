using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("nhap x:");
                int x = int.Parse(Console.ReadLine());
                double y = 2 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2 * x - 1;
                Console.WriteLine("y= {0}", y);
                Console.WriteLine("nhap \'1\' de ket thuc");
                a = int.Parse(Console.ReadLine());
            } while (a != 1);
           
        }
    }
}
