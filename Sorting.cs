public class Sorting
{
    private void Swap(int[] arr, int firstIdx, int secondIdx)
    {
        var temp = arr[firstIdx];
        arr[firstIdx] = arr[secondIdx];
        arr[secondIdx] = temp;
    }

    public int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int minIdx = i;
            int minVal = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < minVal)
                {
                    minIdx = j;
                    minVal = arr[j];
                }
            }

            if (i != minIdx)
            {
                Swap(arr, i, minIdx);
            }
        }

        return arr;
    }

    public int[] InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int j = i - 1;
            int current = arr[i];
            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = current;
        }

        return arr;
    }

    public int[] MergeSort(int[] arr)
    {
        MergeSortRecursive(arr, 0, arr.Length - 1);
        return arr;
    }

    private void MergeSortRecursive(int[] arr, int start, int end)
    {
        if (end > start)
        {
            int mid = (start + end) / 2;
            MergeSortRecursive(arr, start, mid);
            MergeSortRecursive(arr, mid + 1, end);
            Merge(arr, start, mid, end);
        }
    }

    private void Merge(int[] arr, int start, int mid, int end)
    {
        int[] left = new int[mid - start + 1];
        int[] right = new int[end - mid];

        var i = 0;
        var j = 0;
        var k = start;

        while (k <= mid) left[i++] = arr[k++];
        while (k <= end) right[j++] = arr[k++];

        i = j = 0;
        k = start;
        while (i < left.Length && j < right.Length)
        {
            arr[k++] = left[i] > right[j] ? right[j++] : left[i++];
        }

        while (i < left.Length) arr[k++] = left[i++];
        while (j < right.Length) arr[k++] = right[j++];
    }
}