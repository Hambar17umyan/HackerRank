using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            inparr(ref arr);
            int m, d;
            int[] inp = new int[2];
            inparr(ref inp);
            d = inp[0];
            m = inp[1];
            int res = 0;
            int[] prefix = new int[n];
            prefix = arr;
            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                    prefix[i] += prefix[i - 1];
                if (i == m - 1)
                {
                    if (prefix[i] == d)
                        res++;
                }
                else if (i > m - 1)
                {
                    if (prefix[i] - prefix[i - m] == d)
                        res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
