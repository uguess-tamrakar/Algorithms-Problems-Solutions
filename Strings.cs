using System.Text.RegularExpressions;

public class Strings
{
    public bool IsPalindromeString(string s)
    {
        string sanitized = Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty);
        int mid = sanitized.Length / 2;
        int left = mid - 1;
        int right = sanitized.Length % 2 == 0 ? mid : mid + 1;

        while (left >= 0 && right < sanitized.Length)
        {
            if (char.ToLower(sanitized[left]) != char.ToLower(sanitized[right])) return false;
            left--;
            right++;
        }
        return true;
    }

    public char[] ReverseString(char[] s)
    {
        if (s.Length < 2) return s;
        int mid = s.Length / 2;
        int left = mid - 1;
        int right = (s.Length % 2 == 0) ? mid : mid + 1;

        while (left >= 0)
        {
            char leftChar = s[left];
            char rightChar = s[right];
            s[left--] = rightChar;
            s[right++] = leftChar;
        }

        return s;
    }

    private void SwapArrayItems(int[] nums, int left, int right)
    {
        int leftItem = nums[left];
        int rightItem = nums[right];
        nums[right] = leftItem;
        nums[left] = rightItem;
    }

    public int LongestSubstringWithNonRepeatingChars(string s)
    {
        if (s == null || s.Length == 0) return 0;
        if (s.Length == 1) return 1;

        int left, right, longest;
        left = right = longest = 0;
        HashSet<char> uniques = new HashSet<char>();

        while (right < s.Length)
        {
            if (uniques.Contains(s[right]))
            {
                uniques.Remove(s[left]);
                left++;
            }
            else
            {
                uniques.Add(s[right]);
                right++;
                longest = Math.Max(longest, uniques.Count);
            }
        }

        return longest;
    }

    private void FindLongestRecursive(string s, ref int max, int start)
    {
        int longest = 1; // single letter is longest by default
        string unique = s[start].ToString();

        for (int i = start + 1; i < s.Length; i++)
        {
            unique = s.Substring(start, i - start);
            if (unique.Contains(s[i]))
            {
                FindLongestRecursive(s, ref max, start + 1);
                break;
            }
            else
            {
                longest++;
                max = Math.Max(max, longest);
            }
        }
    }
}