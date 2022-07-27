public class ArraysLists
{
    public int MaxStockProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] < prices[i])
            {
                maxProfit += prices[i] - prices[i - 1];
            }
        }
        return maxProfit;
    }

    public IList<string> FizzBuzz(int n)
    {
        IList<string> result = new List<string>();
        int i = 1;
        while (i <= n)
        {
            bool divBy3 = i % 3 == 0;
            bool divBy5 = i % 5 == 0;

            if (divBy3 && divBy5)
            {
                result.Add("FizzBuzz");
            }
            else if (divBy3)
            {
                result.Add("Fizz");
            }
            else if (divBy5)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add($"{i}");
            }
            i++;
        }

        return result;
    }

    public int[] ShuffleArray(int[] x)
    {
        int[] nums = (int[])x.Clone();
        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            int randIndex = rand.Next(i, nums.Length);
            int temp = nums[i];
            nums[i] = nums[randIndex];
            nums[randIndex] = temp;
        }

        return nums;
    }

    public int[] MergeAndSortArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int mLastIndex = m - 1;
        int nLastIndex = n - 1;
        int ultimateIndex = m + n - 1;

        // iterate from the back to avoid swapping
        while (mLastIndex >= 0 && nLastIndex >= 0)
        {
            nums1[ultimateIndex--] = nums1[mLastIndex] > nums2[nLastIndex] ? nums1[mLastIndex--] : nums2[nLastIndex--];
        }

        while (nLastIndex >= 0)
        {
            nums1[ultimateIndex--] = nums2[nLastIndex--];
        }

        return nums1;
    }

    public int MoveUniquesToFront(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;

        int n = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[n] != nums[i])
            {
                n++;
                nums[n] = nums[i];
            }
        }

        return n + 1;
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> sorted = new List<int>(nums1);
        sorted.AddRange(nums2);
        sorted.Sort();

        int mid = sorted.Count / 2;
        if (sorted.Count % 2 == 1)
        {
            return sorted[mid];
        }

        int left = mid - 1;
        int right = mid;
        return (double)(sorted[left] + sorted[right]) / 2;
    }
}