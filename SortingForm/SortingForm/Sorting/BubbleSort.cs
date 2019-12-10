using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingForm.Sorting
{
    class BubbleSort
    {

        public static int[] PreformBubbleSortAscending(int[] arrayToSort)
        {
            arrayToSort = (int[])(arrayToSort.Clone());

            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                for (int j = 0; j < arrayToSort.Length - 1; j++)
                {
                    if (j != arrayToSort.Length - 1 && arrayToSort[j] > arrayToSort[j + 1])
                    {
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }
                }

            }

            return arrayToSort;


        }

        public static int[] FasterBubbleSortAscending(int[] arrayToSort)
        {
            arrayToSort = (int[])(arrayToSort.Clone());
            int totalSwaps; //If no swaping occurs, the array is sorted  

            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                 totalSwaps = 0;

                for (int j = 0; j < arrayToSort.Length - 1; j++)
                {
                    if (j != arrayToSort.Length - 1 && arrayToSort[j] > arrayToSort[j + 1])
                    {
                        totalSwaps++;
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }
                }

                if (totalSwaps == 0)
                {
                    break;
                }

            }

            return arrayToSort;


        }

    }
}
