using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Class1
    {
        ///static void Main(string[] args)
       /// {
          ///  int[] mas = new int[] { 1, 3, 4, 5, 6, 6, 8, 2, 5, 9, 0 };
           /// Console.WriteLine(string.Join(",", sort(mas)));
            ///Console.ReadKey();

      ///  }
        public static int[] sort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return merge(sort(massive.Take(mid_point).ToArray()), sort(massive.Skip(mid_point).ToArray()));
        }
        public static int[] merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b] && b < mass2.Length)
                       merged[i] = mass2[b++];
                    else
                       merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
            }
            return merged;
        }
    }
}
