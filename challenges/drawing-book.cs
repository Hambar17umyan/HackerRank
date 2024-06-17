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
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int res1, res2;
            res1 = k / 2;
            if (n % 2 == 0)
            {
                k = n - k + 1;
                res2 = k / 2;
            }
            else
            {
                if (n == k)
                    res2 = 0;
                else
                {
                    k = n - k;
                    res2 = k / 2;
                }
            }
            Console.WriteLine(Math.Min(res1, res2));
        }
    }
}
