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
            int mn, mx;
            mn = mx = arr[0];
            int res1, res2;
            res1 = res2 = 0;
            for(int i = 1; i<n; i++)
            {
                if (arr[i] > mx)
                {
                    mx = arr[i];
                    res1++;
                }
                if (arr[i] < mn)
                {
                    mn = arr[i];
                    res2++;
                }
            }
            Console.WriteLine($"{res1} {res2}");
        }
    }
}
