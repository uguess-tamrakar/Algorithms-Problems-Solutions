public class ArraysLists
{
    public List<int> SubArraySum(int[] arr, int s)
    {
        int running = arr[0];
        int left = 0;

        for (int right = 1; right <= arr.Length; right++)
        {
            while (running > s && left < right - 1)
            {
                running -= arr[left++];
            }

            if (running == s) return new List<int> { left + 1, right };

            if (right < arr.Length) running += arr[right];
        }

        return new List<int> { -1 };
    }

    public int FindTotalPower(List<int> power)
    {
        int totalPower = 0;

        List<int> pres = new List<int>();
        pres.Add(0);
        for (int i = 1; i < power.Count + 1; i++)
        {
            pres.Add(pres[i - 1] + power[i - 1]);
        }

        int[][] dp = new int[power.Count + 1][];
        dp[0] = new int[power.Count + 1];
        Array.Fill<int>(dp[0], int.MaxValue);

        for (int i = 1; i < power.Count + 1; i++)
        {
            dp[i] = new int[power.Count + 1];
            Array.Fill<int>(dp[i], int.MaxValue);
            dp[i][i] = power[i - 1];
        }

        for (int i = 1; i < power.Count + 1; i++)
        {
            dp[0][i] = Math.Min(dp[0][i - 1], power[i - 1]);
        }

        for (int i = 1; i < power.Count + 1; i++)
        {
            for (int j = i; j < power.Count + 1; j++)
            {
                if (i == j)
                {
                    totalPower += dp[i][j] * power[i - 1];
                }
                else
                {
                    dp[i][j] = Math.Min(dp[i][j - 1], dp[i - 1][j]);
                    totalPower += dp[i][j] * (pres[j] - pres[i - 1]);
                }
            }
        }

        return (totalPower % (100000000 + 7));
    }

    public int MaxSetSize(List<int> riceBags)
    {
        int maxSetSize = -1;

        List<int> orderedRiceBags = riceBags.OrderBy(item => item).Distinct().ToList();
        Dictionary<int, int> dp = new Dictionary<int, int>();

        for (int i = 0; i < orderedRiceBags.Count; i++)
        {
            int current = orderedRiceBags[i];
            double sqrt = Math.Sqrt(current);
            int lastPerfect = sqrt % 1 == 0 ? (int)sqrt : -1;

            int currentSetSize = 1;
            if (lastPerfect != -1 && dp.ContainsKey(lastPerfect))
            {
                currentSetSize += dp[lastPerfect];
            }
            dp.Add(current, currentSetSize);
            maxSetSize = Math.Max(maxSetSize, currentSetSize);
        }

        return maxSetSize > 1 ? maxSetSize : -1;
    }

    public long Candies(int n, List<int> arr)
    {
        long[] minCandies = new long[arr.Count];

        minCandies[0] = 1;
        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i] > arr[i - 1]) minCandies[i] = minCandies[i - 1] + 1;
            else minCandies[i] = 1;
        }

        for (int j = arr.Count - 2; j >= 0; j--)
        {
            if (arr[j] > arr[j + 1]) minCandies[j] = Math.Max(minCandies[j], minCandies[j + 1] + 1);
        }

        return minCandies.Sum();
    }

    public List<int> FrequencyQueries(List<List<int>> queries)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        int maxFreq = 0;

        for (int i = 0; i < queries.Count; i++)
        {
            int query = queries[i][0];
            int value = queries[i][1];
            if (query == 1)
            {
                if (frequencies.ContainsKey(value)) frequencies[value]++;
                else frequencies.Add(value, 1);
                maxFreq = Math.Max(maxFreq, frequencies[value]);
            }
            else if (query == 2)
            {
                if (frequencies.ContainsKey(value) && frequencies[value] > 0)
                {
                    frequencies[value]--;
                }
            }
            else if (query == 3)
            {
                if (frequencies.ContainsValue(value) && value <= maxFreq)
                {
                    result.Add(1);
                }
                else result.Add(0);
            }
        }

        return result;
    }

    public long CountTriplets(List<long> arr, long r)
    {
        long count = 0;

        // brute force
        // for (int i = 0; i < arr.Count - 2; i++)
        // {
        //     long compare1 = arr[i] * r;

        //     for (int j = i + 1; j < arr.Count - 1; j++)
        //     {
        //         if (arr[j] == compare1)
        //         {
        //             long compare2 = compare1 * r;
        //             for (int k = j + 1; k < arr.Count; k++)
        //             {
        //                 if (arr[k] == compare2)
        //                 {
        //                     count++;
        //                 }
        //             }
        //         }
        //     }
        // }

        // optimal solution
        Dictionary<long, long> right = new Dictionary<long, long>();
        Dictionary<long, long> left = new Dictionary<long, long>();

        foreach (var item in arr)
        {
            if (right.ContainsKey(item)) right[item]++;
            else right.Add(item, 1);
        }

        for (int i = 0; i < arr.Count; i++)
        {
            long cLeft = 0, cRight = 0;
            long mid = arr[i];
            right[mid]--;

            if (left.ContainsKey(mid / r) && mid % r == 0)
            {
                cLeft = left[mid / r];
            }

            if (right.ContainsKey(mid * r)) cRight = right[mid * r];

            count += cLeft * cRight;
            if (left.ContainsKey(mid)) left[mid]++;
            else left.Add(mid, 1);
        }

        return count;
    }

    public long ArrayManipulation(int n, List<List<int>> queries)
    {
        long[] arr = new long[n + 2];

        for (int i = 0; i < queries.Count; i++)
        {
            // Brute force
            // for (int j = 0; j < arr.Length; j++)
            // {
            //     int k = queries[i][2];
            //     if (j >= queries[i][0] && j <= queries[i][1])
            //     {
            //         arr[j] = arr[j] + k;
            //     }
            // }

            int k = queries[i][2];
            arr[queries[i][0]] += k;
            arr[queries[i][1] + 1] -= k;
        }

        for (int i = 1; i < arr.Length; i++)
        {
            arr[i] = arr[i] + arr[i - 1];
        }

        long max = long.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            max = Math.Max(arr[i], max);
        }

        return max;
    }

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

    public List<int> CountClosedInventory(string s, List<int> startIndices, List<int> endIndices)
    {
        List<int> numItems = new List<int>(startIndices.Count);

        // brute force
        // for (int i = 0; i < startIndices.Count; i++)
        // {
        //     int startIndex = startIndices[i];
        //     int endIndex = endIndices[i];
        //     int totalInventory = 0;
        //     int numInventory = 0;
        //     bool compartmentOpen = false;
        //     for (int j = startIndex - 1; j < endIndex; j++)
        //     {
        //         if (compartmentOpen == false && s[j] == '|')
        //         {
        //             compartmentOpen = true;
        //         }
        //         else if (compartmentOpen == true)
        //         {
        //             if (s[j] == '*')
        //             {
        //                 numInventory++;
        //             }
        //             else if (s[j] == '|')
        //             {
        //                 totalInventory += numInventory;
        //                 numInventory = 0;
        //             }
        //         }
        //     }
        //     numItems.Add(totalInventory);
        // }

        // optimized
        int[] stars = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                int previous = i > 0 ? stars[i - 1] : 0;
                stars[i] = previous + 1;
            }
            else
            {
                stars[i] = i > 0 ? stars[i - 1] : 0;
            }
        }

        /* -- end set starts */

        int[] closestLeftPipes = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '|')
            {
                closestLeftPipes[i] = i;
            }
            else
            {
                closestLeftPipes[i] = i > 0 ? closestLeftPipes[i - 1] : -1;
            }
        }

        /* end set closestLeftPipe */

        int[] closestRightPipes = new int[s.Length];

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '|')
            {
                closestRightPipes[i] = i;
            }
            else
            {
                closestRightPipes[i] = i < (s.Length - 1) ? closestRightPipes[i + 1] : -1;
            }
        }

        /* end set closestRightPipe */

        for (int i = 0; i < endIndices.Count; i++)
        {
            int start = startIndices[i];
            int end = endIndices[i];

            int startingPipe = closestRightPipes[start - 1];
            int endingPipe = closestLeftPipes[end - 1];

            if (closestLeftPipes[closestLeftPipes.Length - 1] == -1)
            {
                numItems.Add(0);
            }
            else if (startingPipe < 0)
            {
                numItems.Add(0);
            }
            else if (startingPipe >= endingPipe)
            {
                numItems.Add(0);
            }
            else
            {
                numItems.Add(stars[endingPipe] - stars[startingPipe]);
            }
        }

        return numItems;
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