using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            int[] inp = new int[2];

            int a, b;
            int s, t;
            int n, m;

            inparr(ref inp);
            s = inp[0];
            t = inp[1];

            inparr(ref inp);
            a = inp[0];
            b = inp[1];

            inparr(ref inp);
            n = inp[0];
            m = inp[1];

            int[] apples = new int[m];
            int[] oranges = new int[n];

            inparr(ref apples);
            inparr(ref  oranges);

            int res1 = 0;
            int res2 = 0;

            for(int i = 0; i < apples.Length; i++)
            {
                if (apples[i] + a >= s && apples[i] + a <= t)
                {
                    res1++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if (oranges[i] + b >= s && oranges[i] + b <= t)
                {
                    res2++;
                }
            }

            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}
