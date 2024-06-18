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
            int b, n, m;
            inparr(ref inp);
            b = inp[0];
            n = inp[1];
            m = inp[2];

            int[] a1, b1;
            a1 = new int[n];
            b1 = new int[m];
            inparr(ref a1);
            inparr(ref b1);
            int res = -1;
            foreach (int i in a1)
            {
                foreach (int j in b1)
                {
                    if (i + j <= b)
                        res = Math.Max(res, i + j);
                }
            }
            Console.WriteLine(res);
        }
    }
}
