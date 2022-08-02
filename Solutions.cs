using System;
using System.Collections.Generic;
using System.Text;


public class Solutions
{
    public static int[] SearchRange(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
        {
            return new int[] { -1, -1 };
        }

        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (right + left) / 2;
            if (nums[mid] == target)
            {
                left = mid;
                right = mid;
                while (left >= 0 && nums[left] == target) left--;
                while (right < nums.Length && nums[right] == target) right++;
                return new int[] { left + 1, right - 1 };
            }
            else if (nums[mid] < target) left = mid + 1;
            else right = mid - 1;
        }

        return new int[] { -1, -1 };
    }

    public static IList<IList<int>> GenerateListPermutations(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return new List<IList<int>>();
        }
        else if (nums.Length == 1)
        {
            return new List<IList<int>> { new List<int>(nums) };
        }

        IList<IList<int>> results = new List<IList<int>>();
        PermuteNumsList(results, nums.ToList(), new List<int>());
        return results;
    }

    public static List<string> GeneratePermutationsII(string s)
    {
        List<string> result = new();

        string answer = string.Empty;
        Permute(result, s, answer);

        return result;
    }

    private static void PermuteNumsList(IList<IList<int>> results, List<int> nums, List<int> result)
    {
        if (nums.Count == 0)
        {
            results.Add(result);
            return;
        }

        for (int i = 0; i < nums.Count; i++)
        {
            int current = nums[i];
            List<int> remaining = new List<int>(nums);
            remaining.RemoveAt(i);
            PermuteNumsList(results, remaining, result.Append(current).ToList());
        }
    }

    private static void Permute(List<string> result, string s, string answer)
    {
        if (s.Length == 0)
        {
            result.Add(answer);
            return;
        }

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            // string left = s.Substring(0, i);
            // string right = s.Substring(i + 1);
            // string rest = left + right;
            string remaining = s.Remove(i, 1);
            Permute(result, remaining, answer + ch);
        }
    }

    public static List<string> GeneratePermutationsI(string s)
    {
        List<string> result = new();
        Permute(result, s, 0, s.Length - 1);
        return result;
    }

    private static void Permute(List<string> result, string s, int start, int end)
    {
        if (start == end)
        {
            result.Add(s);
        }

        for (int i = start; i <= end; i++)
        {
            s = swapChars(s, start, i);
            Permute(result, s, start + 1, end);
            s = swapChars(s, start, i);
        }
    }

    private static string swapChars(string s, int source, int dest)
    {
        char sourceChar = s[source];
        char destChar = s[dest];
        if (sourceChar != destChar)
        {
            return s.Remove(source, 1).Insert(source, destChar.ToString()).Remove(dest, 1).Insert(dest, sourceChar.ToString());
        }
        else
        {
            return s;
        }
    }

    public static IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new List<string>();
        backtrack(result, new StringBuilder(), 0, 0, n);
        return result;
    }

    private static void backtrack(List<string> result, StringBuilder current, int open, int close, int max)
    {
        if (current.Length == max * 2)
        {
            result.Add(current.ToString());
            return;
        }

        if (open < max)
        {
            current.Append("(");
            backtrack(result, current, open + 1, close, max);
            current.Remove(current.Length - 1, 1);
        }

        if (close < open)
        {
            current.Append(")");
            backtrack(result, current, open, close + 1, max);
            current.Remove(current.Length - 1, 1);
        }
    }

    /// <summary>
    /// Given a string s, return the longest palindromic substring in s.
    ///    Example 1:
    ///
    /// Input: s = "babad"
    /// Output: "bab"
    /// Explanation: "aba" is also a valid answer.
    /// Example 2:
    /// 
    /// Input: s = "cbbd"
    /// Output: "bb"
    /// 
    /// 
    /// 
    /// Constraints:
    /// 
    /// 1 <= s.length <= 1000
    /// s consist of only digits and English letters.
    /// </summary>
    /// <param name="s">input string</param>
    /// <returns></returns>
    public static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        int start = 0, end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int length1 = ExpandAroundCenter(s, i, i);
            int length2 = ExpandAroundCenter(s, i, i + 1);
            int length = Math.Max(length1, length2);

            if (length > end - start)
            {
                start = i - (length - 1) / 2;
                end = i + length / 2;
            }
        }

        return s.Substring(start, end - start + 1);
    }

    private static int ExpandAroundCenter(String s, int left, int right)
    {
        int expansion = left == right ? -1 : 0;
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
            expansion += 2;
        }
        return expansion;
    }

    public static int MinimumLengthEncoding(string[] words)
    {
        HashSet<string> uniqueWords = new HashSet<string>(words);
        foreach (string word in words)
        {
            for (int i = 1; i < word.Length; i++)
            {
                uniqueWords.Remove(word.Substring(i));
            }
        }

        int result = 0;
        foreach (string uniqueWord in uniqueWords)
        {
            result += uniqueWord.Length + 1;
        }

        return result;
    }

    public static string ZigzagConversion(string s, int numRows)
    {
        if (numRows == 1) return s;

        List<StringBuilder> rows = new List<StringBuilder>(numRows);

        for (int i = 0; i < numRows; i++)
        {
            rows.Add(new StringBuilder());
        }

        int charRowIndex = 0;
        bool increaseIndex = true;

        for (int i = 0; i < s.Length; i++)
        {
            rows[charRowIndex].Append(s[i]);

            if (charRowIndex == 0 || (charRowIndex < numRows - 1 && increaseIndex))
            {
                charRowIndex++;
                increaseIndex = true;
            }
            else
            {
                charRowIndex--;
                increaseIndex = false;
            }
        }

        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows)
        {
            result.Append(row.ToString());
        }

        return result.ToString();
    }

    public static bool IsPalindrome(int x)
    {
        if (x < 0 || (x > 0 && x % 10 == 0))
        {
            return false;
        }

        int revertedNumber = 0;
        while (x > revertedNumber)
        {
            revertedNumber = revertedNumber * 10 + x % 10;
            x /= 10;
        }

        return x == revertedNumber || x == revertedNumber / 10;
    }

    public static bool IsPalindromeUsingString(int x)
    {
        string input = x.ToString();
        int left;
        int right;
        if (input.Length % 2 == 0)
        {
            right = input.Length / 2;
            left = right - 1;
        }
        else
        {
            int mid = input.Length / 2;
            left = mid - 1;
            right = mid + 1;
        }

        while (left >= 0)
        {
            if (input[left] != input[right])
            {
                return false;
            }
            left--;
            right++;
        }

        return true;
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int leftOver = target - num;

            if (dict.ContainsKey(leftOver))
            {
                return new int[] { dict[leftOver], i };
            }

            dict.TryAdd(num, i);
        }

        return Array.Empty<int>();
    }

    public static int BirthdayCakeCandles(List<int> candles)
    {
        candles.Sort();
        int candleMaxIndex = candles.Count - 1;
        int maxHeight = candles[candleMaxIndex];
        int result = 0;
        while (candleMaxIndex >= 0 && candles[candleMaxIndex] == maxHeight)
        {
            result++;
            candleMaxIndex--;
        }

        return result;
    }

    public static long[] ArrayMinMaxSum(List<int> array)
    {
        array.Sort();
        List<long> minSumArray = new(array.Select(a => (long)a));
        minSumArray.RemoveAt(array.Count - 1);
        List<long> maxSumArray = new(array.Select(a => (long)a));
        maxSumArray.RemoveAt(0);
        return new long[] { minSumArray.Sum(), maxSumArray.Sum() };
    }

    public static void Staircase(int numStairs)
    {
        for (int i = 0; i < numStairs; i++)
        {
            int numHashes = i + 1;
            Console.WriteLine(new string('#', numHashes).PadLeft(numStairs));
        }
    }

    public static List<string> PlusMinus(List<int> arr)
    {
        decimal denominator = arr.Count;
        int posNumerator = 0;
        int negNumerator = 0;
        int zeroNumerator = 0;

        foreach (var num in arr)
        {
            if (num == 0) zeroNumerator++;
            else if (num > 0) posNumerator++;
            else negNumerator++;
        }

        return new List<string> { (posNumerator / denominator).ToString("N6"), (negNumerator / denominator).ToString("N6"), (zeroNumerator / denominator).ToString("N6") };
    }

    public static List<int> LeftRotation(List<int> nums, int rotation)
    {
        List<int> rotatedNums = new(nums);
        rotatedNums.RemoveRange(0, rotation);
        rotatedNums.AddRange(nums.GetRange(0, rotation));
        return rotatedNums;
    }

    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode temp = new ListNode(0);
        ListNode curr = temp;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
        }
        return temp.next;
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

