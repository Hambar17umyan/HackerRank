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
        public static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
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
            int[] inp = new int[4];
            inparr(ref inp);
            int x1, v1, x2, v2;
            x1 = inp[0];
            v1 = inp[1];
            x2 = inp[2];
            v2 = inp[3];

            if (x1 > x2) 
            {
                if (v1 >= v2) 
                {
                    Console.WriteLine("NO");
                    return;
                }
                if ((x1 - x2) % (v2 - v1) == 0) 
                {
                    Console.WriteLine("YES");
                    return;
                }
                Console.WriteLine("NO");
                return;
            }
            else if(x1 == x2)
                Console.WriteLine("YES");
            else
            {
                swap(ref x1, ref x2);
                swap(ref v1, ref v2);
                if (v1 >= v2)
                {
                    Console.WriteLine("NO");
                    return;
                }
                if ((x1 - x2) % (v2 - v1) == 0)
                {
                    Console.WriteLine("YES");
                    return;
                }
                Console.WriteLine("NO");
                return;
            }
        }
    }
}
