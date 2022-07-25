public class DP
{
    public int NumberOfWaysClimbStairs(int n)
    {
        if (n < 3) return n;
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 2;

        int i = 3;
        while (i <= n)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
            i++;
        }

        return dp[n];
    }

    public IList<IList<string>> PalindromePartioning(string s)
    {
        IList<IList<string>> results = new List<IList<string>>();
        dfs(results, new List<string>(), 0, s);
        return results;
    }

    private void dfs(IList<IList<string>> results, List<string> current, int start, string s)
    {
        if (start >= s.Length) results.Add(new List<string>(current));
        for (int end = start; end < s.Length; end++)
        {
            if (IsPalindrome(s.Substring(start, end - start + 1)))
            {
                current.Add(s.Substring(start, end - start + 1));
                dfs(results, current, end + 1, s);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s)
    {
        if (s.Length == 1) return true;
        int mid = (s.Length - 1) / 2;
        int left = s.Length % 2 == 0 ? mid : mid - 1;
        int right = mid + 1;

        while (left >= 0 && right < s.Length)
        {
            if (s[left] != s[right]) return false;
            left--;
            right++;
        }

        return true;
    }
}