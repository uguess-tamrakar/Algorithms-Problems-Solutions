namespace Algorithms
{
    public class BinarySearch
    {
        public static int SearchRecursive(int low, int high, int[] arr, int target)
        {
            if (high >= low)
            {
                int mid = (high + low) / 2;
                int current = arr[mid];
                if (current == target) return mid;
                else
                {
                    if (current > target)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                    return SearchRecursive(low, high, arr, target);
                }
            }
            return -1;
        }

        public static int FindMinimumInRotatedSortedArray(List<int> arr)
        {
            // compare to first element and apply feasible function
            if (arr.Count == 0) return -1;
            int firstEle = arr[0];
            List<bool> boolArr = arr.ConvertAll((val) => firstEle > val);

            // Now perform first occurrence search
            int idx = FindMinimumInRotatedSortedArrayRecursive(0, boolArr.Count - 1, boolArr);
            return arr[idx];
        }

        private static int FindMinimumInRotatedSortedArrayRecursive(int low, int high, List<bool> arr)
        {
            if (high >= low)
            {
                int mid = (high + low) / 2;
                bool current = arr[mid];
                if (current)
                {
                    high = mid - 1;
                    int idx = FindMinimumInRotatedSortedArrayRecursive(low, high, arr);
                    return idx == -1 ? mid : idx;
                }
                else
                {
                    low = mid + 1;
                    return FindMinimumInRotatedSortedArrayRecursive(low, high, arr);
                }
            }
            return -1;
        }

        public static int PeakOfMountainArray(List<int> arr)
        {
            if (arr.Count < 3) return -1;
            int high = arr.Count - 1;
            int low = 0;

            while (high > low)
            {
                int mid = (high + low) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return low;
        }
    }
}