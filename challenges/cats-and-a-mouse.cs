using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    internal class Program
    {
        public static void inparr(ref int[] arr)
        {
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        }

        public static void inparr(ref long[] arr)
        {
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt64);
        }

        static void Main(string[] args)
        {
            int[] inp = new int[3];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x, y, z;
                inparr(ref inp);
                x = inp[0];
                y = inp[1];
                z = inp[2];

                int a, b;
                a = Math.Abs(x - z);
                b = Math.Abs(y - z);
                if (a > b)
                {
                    Console.WriteLine("Cat B");
                }
                else if (a < b)
                {
                    Console.WriteLine("Cat A");
                }
                else
                {
                    Console.WriteLine("Mouse C");
                }
            }
        }
    }
}
