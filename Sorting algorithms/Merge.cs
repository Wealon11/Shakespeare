using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakespeare.Sorting_algorithms
{
   public class Merge
    {
        public static void mergeSort(String[] names)
        {
            if (names.Length > 2)
            {
                String[] left = new String[names.Length / 2];
                String[] right = new String[names.Length - names.Length / 2];

                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = names[i];
                }

                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = names[i + names.Length / 2];
                }

                mergeSort(left);
                mergeSort(right);
                merge(names, left, right);
            }
        }

        public static void merge(String[] names, String[] left, String[] right)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (b >= right.Length || (a < left.Length && left[a].CompareTo(right[b]) < 0))
                {
                    names[i] = left[a];
                    a++;
                }
                else
                {
                    names[i] = right[b];
                    b++;
                }
            }
        }
    }
}
