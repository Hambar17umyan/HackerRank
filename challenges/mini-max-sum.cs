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
            int n = 5;
            long[] arr = new long[n];
            inparr(ref arr);
            Array.Sort(arr);
            
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                //Console.WriteLine(arr[i]);
            }
            Console.Write(sum - arr[n - 1]);
            Console.Write(' ');
            Console.Write(sum - arr[0]);
        }
    }
}
