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

        public static void inparr(ref long[] arr)
        {
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt64);
        }

        public static void inparr(ref int[,] arr)
        {
            int[] iarr = new int[arr.GetLength(0)];
            int n = (int)Math.Sqrt(arr.Length);
            //Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                inparr(ref iarr);
                for (int j = 0; j < n; j++) 
                {
                    arr[i, j] = iarr[j];
                }

            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            inparr(ref arr);
            int a, b;
            a = b = 0;
            for (int i = 0; i < n; i++)
            {
                a += arr[i, i];
                b += arr[i, n - i - 1];
            }
            Console.WriteLine(Math.Abs(a - b));
        }
    }
}
