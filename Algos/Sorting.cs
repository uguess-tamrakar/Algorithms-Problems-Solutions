public class Sorting
{
    private static void Swap(int[] arr, int firstIdx, int secondIdx)
    {
        var temp = arr[firstIdx];
        arr[firstIdx] = arr[secondIdx];
        arr[secondIdx] = temp;
    }

    public static int[] SelectionSort(int[] arr)
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

    public static int[] InsertionSort(int[] arr)
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

    public int[] QuickSort(int[] arr)
    {
        QuickSortRecursive(arr, 0, arr.Length - 1);
        return arr;
    }

    private void QuickSortRecursive(int[] arr, int startIdx, int endIdx)
    {
        if (startIdx < endIdx)
        {
            int partitionIdx = Partition(arr, startIdx, endIdx);
            QuickSortRecursive(arr, startIdx, partitionIdx - 1);
            QuickSortRecursive(arr, partitionIdx + 1, endIdx);
        }
    }

    private static int Partition(int[] arr, int startIdx, int endIdx)
    {
        int pivot = arr[endIdx];
        var q = startIdx;
        var j = startIdx + 1;
        while (j < endIdx)
        {
            if (arr[j] <= pivot)
            {
                Swap(arr, q, j);
                q++;
            }
            j++;
        }
        Swap(arr, q, endIdx);
        return q;
    }

    public int[] MergeSort(int[] arr)
    {
        MergeSortRecursive(arr, 0, arr.Length - 1);
        return arr;
    }

    private static void MergeSortRecursive(int[] arr, int start, int end)
    {
        if (end > start)
        {
            int mid = (start + end) / 2;
            MergeSortRecursive(arr, start, mid);
            MergeSortRecursive(arr, mid + 1, end);
            Merge(arr, start, mid, end);
        }
    }

    private static void Merge(int[] arr, int start, int mid, int end)
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