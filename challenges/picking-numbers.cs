using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
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
            int[] arr = new int[n];
            inparr(ref arr);
            Array.Sort(arr);
            for (int len = n; len >= 2; len--)
            {
                for (int i = 0; i < n - len + 1; i++)
                {
                    int mn = int.MaxValue;
                    int mx = int.MinValue;
                    for (int j = i; j < i + len; j++)
                    {
                        mx = Math.Max(arr[j], mx);
                        mn = Math.Min(mn, arr[j]);
                    }
                    if(mx - mn <= 1)
                    {
                        Console.WriteLine(len);
                        return;
                    }
                }
            }
        }
    }
}
