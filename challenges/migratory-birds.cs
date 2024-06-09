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
            int[] spot = new int[6];
            inparr(ref arr);
            int max = 0, res = 0;
            for (int i = 0; i < n; i++)
            {
                spot[arr[i]]++;
                if (spot[arr[i]] > max || (spot[arr[i]] == max && res > arr[i]))
                {
                    max = spot[arr[i]];
                    res = arr[i];
                }
            }
            Console.WriteLine(res);
        }
    }
}
