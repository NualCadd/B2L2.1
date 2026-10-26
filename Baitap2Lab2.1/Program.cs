
using System;
using System.Collections.Generic;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Nhap n (n > 0): ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            List<int> ds = new List<int>();
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                ds.Add(rd.Next(100));
            }

            Console.WriteLine("Day so ban dau:");
            Console.WriteLine(string.Join(", ", ds));

            ds.Sort();

            Console.WriteLine("Day so sau khi sap xep tang dan:");
            Console.WriteLine(string.Join(", ", ds));

            Console.ReadKey();
        }
    }
}
