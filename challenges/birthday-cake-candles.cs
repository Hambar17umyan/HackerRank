using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

        public static void dig(ref decimal d, int n)
        {
            var prec = new NumberFormatInfo();
            prec.NumberDecimalDigits = n;
            string s = "0." + new string('0', n);
            s = d.ToString(s);
            d = decimal.Parse(s);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            inparr(ref arr);
            Array.Sort(arr);

            int res = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] == arr[i + 1])
                    res++;
                else break;
            }
            Console.WriteLine(res);
        }
    }
}
