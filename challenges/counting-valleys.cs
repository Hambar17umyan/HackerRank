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
            string s;
            s = Console.ReadLine();
            int res = 0;
            int level = 0;
            foreach (var i in s)
            {
                if(i == 'U')
                {
                    level++;
                    if(level == 0)
                    {
                        res++;
                    }
                }
                else
                {
                    level--;
                }
            }
            Console.WriteLine(res);
        }
    }
}
