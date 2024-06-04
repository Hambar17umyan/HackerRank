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

        public static int solvemefirst()
        {
            int n1, n2;
            n1=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());
            return n1+n2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solvemefirst());
        }
    }
}
