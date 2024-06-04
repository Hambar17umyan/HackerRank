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

        public static int findsum(int[] arr)
        {
            int res = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                res += arr[i];
            }
            return res;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            inparr(ref arr);
            Console.WriteLine(findsum(arr));
        }
    }
}
