public class ArraysLists
{
    public List<int> GradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            int currentGrade = grades[i];
            if (currentGrade > 37)
            {
                int nxtMultiple5 = ((currentGrade / 5) + 1) * 5;
                if (nxtMultiple5 - currentGrade < 3)
                {
                    grades[i] = nxtMultiple5;
                }
            }
        }

        return grades;
    }

    public int LuckBalance(int k, List<List<int>> contests)
    {
        if (contests.Count == 0) return 0;
        int luck = 0;

        List<List<int>> imps = contests.OrderByDescending(contest => contest[0]).ToList();
        for (int i = 0; i < imps.Count; i++)
        {
            if (imps[i][1] == 0)
            {
                luck += imps[i][0];
            }
            else if (k > 0 && imps[i][1] == 1)
            {
                luck += imps[i][0];
                k--;
            }
            else
            {
                luck -= imps[i][0];
            }
        }

        return luck;
    }

    public void WhatFlavors(List<int> cost, int money)
    {
        Dictionary<int, int> refs = new Dictionary<int, int>();
        for (int i = 0; i < cost.Count; i++)
        {
            if (cost[i] < money)
            {
                int remaining = money - cost[i];
                if (!refs.ContainsKey(remaining))
                {
                    refs.Add(cost[i], i);
                }
                else
                {
                    Console.WriteLine($"{refs[remaining] + 1} {i + 1}");
                    break;
                }
            }
        }
    }

    public int MinimumAbsoluteDifference(List<int> arr)
    {
        int min = int.MaxValue;
        arr.Sort();
        for (int i = 0; i < arr.Count - 1; i++)
        {
            min = Math.Min(min, Math.Abs(arr[i + 1] - arr[i]));
        }
        return min;
    }

    public int MaxNumberOfToys(List<int> prices, int k)
    {
        int result = 0;

        prices.Sort();
        while (k > prices[result])
        {
            k = k - prices[result];
            result++;
        }

        return result;
    }

    public void MinimumBribes(List<int> q)
    {
        // 2 1 5 3 4
        bool valid = true;
        int bribes = 0;
        for (int i = q.Count - 1; i >= 0; i--)
        {
            if (q[i] - (i + 1) > 2)
            {
                valid = false;
                break;
            }

            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
            {
                if (q[j] > q[i]) bribes++;
            }
        }

        Console.WriteLine(valid ? bribes : "Too chaotic");
    }

    public int MaxNonAdjacentSubsetSum(int[] arr)
    {
        if (arr.Length == 0) return 0;
        arr[0] = Math.Max(0, arr[0]);
        if (arr.Length == 1) return 1;
        arr[1] = Math.Max(arr[0], arr[1]);
        for (int i = 2; i < arr.Length; i++)
        {
            arr[i] = Math.Max(arr[i - 1], arr[i] + arr[i - 2]);
        }

        return arr[arr.Length - 1];
    }

    private List<int> _a = new();
    public void BubbleSort(List<int> a)
    {
        _a = a;
        int n = a.Count;
        int swaps = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    swap(a[j], a[j + 1]);
                    swaps++;
                }
            }
        }

        Console.WriteLine($"Array is sorted in {swaps} swaps.");
        Console.WriteLine($"First Element: {_a[0]}");
        Console.WriteLine($"Last Element: {_a[n - 1]}");
    }

    private void swap(int n1, int n2)
    {
        int swapIndex1 = _a.IndexOf(n1);
        int swapIndex2 = _a.IndexOf(n2);
        int temp = _a[swapIndex1];
        _a[swapIndex1] = _a[swapIndex2];
        _a[swapIndex2] = temp;
    }

    public int MinimumSwapsToOrder(int[] arr)
    {
        int swaps = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        // store each numbers with their current index in dictionary for faster lookup
        for (int i = 0; i < arr.Length; i++)
        {
            dict.Add(arr[i], i);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != i + 1)
            {
                int swapIndex = dict[i + 1];
                int temp = arr[i];
                arr[i] = arr[swapIndex];
                arr[swapIndex] = temp;
                dict[arr[swapIndex]] = swapIndex;
                swaps++;
            }
        }
        return swaps;
    }

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