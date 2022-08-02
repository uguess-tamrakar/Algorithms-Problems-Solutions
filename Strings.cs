using System.Text;
using System.Text.RegularExpressions;

public class Strings
{
    public List<int> MatchingStrings(List<string> strings, List<string> queries)
    {
        Dictionary<string, int> stringWeights = new Dictionary<string, int>();
        foreach (var s in strings)
        {
            if (stringWeights.ContainsKey(s)) stringWeights[s]++;
            else stringWeights.Add(s, 1);
        }

        List<int> counts = new List<int>();
        foreach (var query in queries)
        {
            if (stringWeights.ContainsKey(query)) counts.Add(stringWeights[query]);
            else counts.Add(0);
        }

        return counts;
    }

    public string TimeConversion(string s)
    {
        string[] timeElements = s.Split(':');
        string AMPM = timeElements[timeElements.Length - 1].Substring(2);
        int hourElement = int.Parse(timeElements[0]);

        if (AMPM.Equals("AM", StringComparison.OrdinalIgnoreCase))
        {
            if (hourElement == 12)
            {
                timeElements[0] = "00";
            }
        }
        else if (AMPM.Equals("PM", StringComparison.OrdinalIgnoreCase))
        {
            if (hourElement != 12)
            {
                timeElements[0] = (hourElement + 12).ToString();
            }
        }

        return string.Join(':', timeElements).Remove(8);
    }

    public void CheckMagazine(List<string> magazine, List<string> note)
    {
        var dict = new Dictionary<string, int>();
        foreach (var word in magazine)
        {
            if (dict.ContainsKey(word)) dict[word]++;
            else dict.Add(word, 1);
        }

        bool valid = true;
        foreach (var word in note)
        {
            if (dict.ContainsKey(word) && dict[word] > 0)
            {
                dict[word]--;
            }
            else
            {
                valid = false;
            }
        }

        Console.WriteLine(valid ? "Yes" : "No");
    }

    public int MakeCharactersAlternate(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        int deletions = 0;
        char lastUnique = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == lastUnique)
            {
                deletions++;
            }
            else
            {
                lastUnique = s[i];
            }
        }
        return deletions;
    }

    public int SherlockAndAnagrams(string s)
    {
        var refs = new Dictionary<string, int>();
        var total = 0;

        for (int start = 0; start < s.Length; start++)
        {
            for (int length = 1; length <= s.Length - start; length++)
            {
                var subStr = new string(s.Substring(start, length).OrderBy(c => c).ToArray());
                if (refs.ContainsKey(subStr))
                {
                    total += refs[subStr];
                    refs[subStr] += 1;
                }
                else
                    refs[subStr] = 1;
            }
        }

        return total;
    }

    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        List<string> reversed = new();

        foreach (string word in words)
        {
            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            reversed.Add(reversedWord);
        }

        return string.Join(' ', reversed);
    }

    public bool AreBracketsBalanced(string s)
    {
        if (s.Length % 2 != 0) return false;
        char[] openBracs = { '[', '{', '(' };
        char[] closingBracs = { ']', '}', ')' };

        Stack<char> stack = new Stack<char>();

        foreach (char c in s.ToCharArray())
        {
            if (openBracs.Contains(c))
            {
                stack.Push(c);
            }
            else if (closingBracs.Contains(c))
            {
                if (stack.Count == 0) return false;
                char current = stack.Peek();
                if ((current == '[' && c == ']') || (current == '{' && c == '}') || (current == '(' && c == ')')) stack.Pop();
                else return false;
            }
        }

        return stack.Count == 0;
    }

    public int MakeAnagram(string a, string b)
    {
        List<char> chars = new List<char>(a.ToCharArray());
        int notMatched = 0;
        foreach (var c in b)
        {
            if (chars.Contains(c))
            {
                chars.Remove(c);
            }
            else notMatched++;
        }

        return notMatched + chars.Count;
    }

    public string CommonStrings(string s1, string s2)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < s1.Length; i++)
        {
            if (!dict.ContainsKey(s1[i]))
            {
                dict.Add(s1[i], i);
            }
        }

        StringBuilder common = new StringBuilder();
        foreach (char s in s2)
        {
            if (dict.ContainsKey(s)) common.Append(s);
        }
        return common.ToString();
    }

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