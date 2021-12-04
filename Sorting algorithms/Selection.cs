using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakespeare.Sorting_algorithms
{
    public class Selection
    {
        public static void selectionSort(string[] array)
        {
    
            for (int j = 0; j < array.Length - 1; j++)
            {
                
                int min = j;
                for (int k = j + 1; k < array.Length; k++) {

                    if (array[k].CompareTo(array[min]) < 0)
                    {
                        min = k;
                    }
                }

                   
                string temp = array[j];
                array[j] = array[min];
                array[min] = temp;
            }
        }



    }
}
