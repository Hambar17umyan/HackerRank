using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
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

        public static int comparr(int[,] arr1, int[,] arr2)
        {
            int res = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res += Math.Abs(arr1[i, j] - arr2[i, j]);
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            int[] inp = new int[3];
            int[,] matrix = new int[3, 3];

            inparr(ref inp);
            matrix[0, 0] = inp[0];
            matrix[0, 1] = inp[1];
            matrix[0, 2] = inp[2];

            inparr(ref inp);
            matrix[1, 0] = inp[0];
            matrix[1, 1] = inp[1];
            matrix[1, 2] = inp[2];

            inparr(ref inp);
            matrix[2, 0] = inp[0];
            matrix[2, 1] = inp[1];
            matrix[2, 2] = inp[2];

            int[,] newmat = new int[3, 3];
            int[,] rmat = new int[3, 3];
            int res = int.MaxValue;
            int k;
            for (int sum = 1; sum <= 27; sum++)
            {
                for (newmat[0, 0] = 1; newmat[0, 0] <= 9; newmat[0, 0]++)
                {
                    for (newmat[0, 1] = 1; newmat[0, 1] <= 9; newmat[0, 1]++)
                    {
                        for (newmat[1, 0] = 1; newmat[1, 0] <= 9; newmat[1, 0]++)
                        {
                            for (newmat[1, 1] = 1; newmat[1, 1] <= 9; newmat[1, 1]++)
                            {
                                HashSet<int> set = new HashSet<int>();
                                k = sum - newmat[0, 0] - newmat[0, 1];
                                newmat[0, 2] = k;
                                if (k <= 0 || k >= 10)
                                {
                                    continue;
                                }

                                k = sum - newmat[1, 0] - newmat[1, 1];
                                newmat[1, 2] = k;
                                if (k <= 0 || k >= 10)
                                {
                                    continue;
                                }

                                k = sum - newmat[1, 0] - newmat[0, 0];
                                newmat[2, 0] = k;
                                if (k <= 0 || k >= 10)
                                {
                                    continue;
                                }

                                k = sum - newmat[1, 1] - newmat[0, 1];
                                newmat[2, 1] = k;
                                if (k <= 0 || k >= 10)
                                {
                                    continue;
                                }

                                k = sum - newmat[0, 2] - newmat[1, 2];
                                newmat[2, 2] = k;
                                if (k <= 0 || k >= 10)
                                {
                                    continue;
                                }

                                if (newmat[0, 0] + newmat[1, 1] + newmat[2, 2] != sum)
                                    continue;
                                if (newmat[0, 2] + newmat[1, 1] + newmat[2, 0] != sum)
                                    continue;


                                set.Add(newmat[0, 0]);
                                set.Add(newmat[0, 1]);
                                set.Add(newmat[0, 2]);
                                set.Add(newmat[1, 0]);
                                set.Add(newmat[1, 1]);
                                set.Add(newmat[1, 2]);
                                set.Add(newmat[2, 0]);
                                set.Add(newmat[2, 1]);
                                set.Add(newmat[2, 2]);

                                if (set.Count < 9)
                                    continue;

                                k = comparr(newmat, matrix);
                                if (res > k)
                                {
                                    res = k;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(res);
        }
    }
}
