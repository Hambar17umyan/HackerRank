using System;
using System.Collections.Generic;
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

        public static Tuple<int, int> comp(int[] a, int[] b)
        {
            int n1, n2;
            n1 = n2 = 0;
            for (int i = 0; i < 3; i++) 
            {
                if (a[i] > b[i])
                    n1++;
                else if (a[i] < b[i])
                    n2++;
            }
            return Tuple.Create(n1, n2);
        }

        static void Main(string[] args)
        {
            int n = 3;
            int[] a = new int[n];
            int[] b = new int[n];
            inparr(ref a);
            inparr(ref b);
            Tuple<int, int>t = comp(a, b);
            Console.WriteLine($"{t.Item1} {t.Item2}");
        }
    }
}
