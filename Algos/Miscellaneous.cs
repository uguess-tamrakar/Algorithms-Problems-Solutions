public class Miscellaneous
{
    public static bool IsValidParenthesis(string s)
    {
        if (s.Length % 2 != 0) return false;
        char[] openParens = { '[', '{', '(' };
        char[] closeParens = { ']', '}', ')' };
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (openParens.Contains(c))
            {
                stack.Push(c);
            }
            else if (closeParens.Contains(c))
            {
                if (stack.Count > 0)
                {
                    char prev = stack.Peek();
                    if (
                        prev == '(' && c == ')' ||
                        prev == '{' && c == '}' ||
                        prev == '[' && c == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}