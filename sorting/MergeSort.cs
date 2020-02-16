using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    public class MergeSort
    {

		// Arr is an array of integer type
		// start and end are the starting and ending index of current array
		public void mergeSort(int[] Array, int start, int end)
		{
			if (start < end)
			{
				//middle index of the array
				int mid = (start + end) / 2;
				
				//divides array into two to make esier its comparation, then merges it to build the array again.
				mergeSort(Array, start, mid);
				mergeSort(Array, mid + 1, end);
				merge(Array, start, mid, end);
			}
		}

		private void merge(int[] Array, int start, int mid, int end)
		{
			// creates a temporal array
			int[] temporal = new int[end - start + 1];

			// centinels for both intervals and for temporal
			int i = start, j = mid + 1, k = 0;

			// traverse both arrays and in each iteration add smaller of both elements in temp 
			while (i <= mid && j <= end)
			{
				if (Array[i] <= Array[j])
				{
					temporal[k] = Array[i];
					k += 1; i += 1;
				}
				else
				{
					temporal[k] = Array[j];
					k += 1; j += 1;
				}
			}

			// add elements left in the first interval 
			while (i <= mid)
			{
				temporal[k] = Array[i];
				k += 1; i += 1;
			}

			// add elements left in the second interval 
			while (j <= end)
			{
				temporal[k] = Array[j];
				k += 1; j += 1;
			}

			// copy temp to original interval
			for (i = start; i <= end; i += 1)
			{
				Array[i] = temporal[i - start];
			}
		}
	}
}