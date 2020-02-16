using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
   public class QuickSort
    {
        // Arr is an array of integer type
        // start and end are the starting and ending index of current array
        public void quickSort(int[] arr, int begin, int end)
        {   
            if (begin < end)
            {
                //determines the index where the array needs to be partitionate in order to start sorting
                int partitionIndex = partition(arr, begin, end);
                
                //calls quicksort itself to make sure whole array is going to be sorted
                quickSort(arr, begin, partitionIndex - 1);
                quickSort(arr, partitionIndex + 1, end);
            }
        }
        /* This function takes last element as pivot, places the pivot element at its correct position in sorted
           array, and places all smaller (smaller than pivot) to left of pivot and all greater elements to right
        of pivot */
        private int partition(int[] arr, int begin, int end)
        {
            //element to be placed at the right position
            int pivot = arr[end];
            //index of the smaller element
            int i = (begin - 1);

            for (int j = begin; j < end; j++)
            {
                //if current element is smaller than the pivot
                if (arr[j] <= pivot)
                {
                    //increments index of the smaller element
                    i++;

                    int swapTem = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swapTem;
                }
            }

            int swapTemp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = swapTemp;

            return i + 1;
        }
    }
}