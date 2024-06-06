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
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 38)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    if (n % 5 >= 3) 
                    {
                        n = n + (5 - n % 5);
                    }
                    Console.WriteLine(n);
                }

                t--;
            }
        }
    }
}
