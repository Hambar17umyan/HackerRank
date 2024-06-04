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
            int[] ints = new int[n];
            inparr(ref ints);
            decimal ng, ps, zr;
            ng = ps = zr = 0;
            for(int i = 0; i < n; i++)
            {
                if (ints[i] > 0)
                    ps++;
                else if (ints[i] < 0)
                    ng++;
                else if (ints[i] == 0)
                    zr++;
            }
            ps /= n;
            ng /= n;
            zr /= n;
            dig(ref ps, 6);
            dig(ref ng, 6);
            dig(ref zr, 6);

            Console.WriteLine(ps);
            Console.WriteLine(ng);
            Console.WriteLine(zr);
        }
    }
}
