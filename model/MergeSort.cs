using System;

public class MergeSort
{
	int[] A;
	int start;
	int end;

	public MergeSort(int[] A, int start, int end)
	{
		this.A = new int[];
		this.start = start;
		this.mid = end;
	}

	public void MSort(int [] A, int start, int end)
    {
		return MSort(A[0],start,mid);

    }

	private void MSort(int[] A, int start, int end)
    {
        if(start==end)
        {
			return A[i];
        }
        else
        {
			int m = (start + mid) / 2;

			MSort(A, start, m);

            if (start < m)
            {
                return start;
            }
            else
            {
                return MSort(A, start, m);
            }

            MSort(A, m + 1, end);

            if (end < m)
            {
                return end;
            }
            else
            {
                return MSort(A, start, m);
            }
        }
    }
}
