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
            string time = Console.ReadLine();

            int h = int.Parse(time.Substring(0, 2));

            if (time[8] == 'A')
            {
                if(h == 12)
                {
                    h = 0;
                    Console.WriteLine($"{h}{h}:{time.Substring(3, 5)}");
                }
                else
                {
                    Console.WriteLine(time.Substring(0, 8));
                }
            }
            else
            {
                if (h == 12)
                {
                    Console.WriteLine($"{h}:{time.Substring(3, 5)}");
                }
                else
                {
                    h += 12;
                    Console.WriteLine($"{h}:{time.Substring(3, 5)}");
                }
            }

        }
    }
}
