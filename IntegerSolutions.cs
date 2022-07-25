public class IntegerSolutions
{
    public int ReverseInteger(int x)
    {
        if (!Int32.TryParse(x.ToString(), out int result)) return 0;
        string integer = x < 0 ? (x * -1).ToString() : x.ToString();

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < integer.Length; i++)
        {
            stack.Push(integer[i]);
        }

        string reverse = x < 0 ? "-" : string.Empty;
        char first = stack.Pop();
        reverse += first == '0' ? string.Empty : first;
        while (stack.Count > 0)
        {
            reverse += stack.Pop();
        }

        return Int32.TryParse(reverse, out int ret) ? ret : 0;
    }
}