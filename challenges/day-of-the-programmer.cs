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
            if(n < 1918)
            {
                if (n % 4 == 0) 
                {
                    Console.WriteLine($"12.09.{n}");
                }
                else
                {
                    Console.WriteLine($"13.09.{n}");
                }
            }
            else if(n > 1918)
            {
                if (n % 4 == 0 && n % 100 != 0)
                {
                    Console.WriteLine($"12.09.{n}");
                }
                else if (n % 400 == 0) 
                {
                    Console.WriteLine($"12.09.{n}");
                }
                else
                {
                    Console.WriteLine($"13.09.{n}");
                }
            }
            else
            {
                Console.WriteLine($"26.09.{n}");
            }
        }
    }
}
