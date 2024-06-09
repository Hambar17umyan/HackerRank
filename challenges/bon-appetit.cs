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
            int n, k;
            int[] inp = new int[2];
            inparr(ref inp);
            n = inp[0];
            k = inp[1];
            int[] arr = new int[n];
            inparr(ref arr);
            int b = int.Parse(Console.ReadLine());
            k = -arr[k];
            for (int i = 0; i < n; i++)
                k += arr[i];
            k /= 2;
            if (k != b)
                Console.WriteLine(b - k);
            else
                Console.WriteLine("Bon Appetit");
        }
    }
}
