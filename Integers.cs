public class Integers
{
    public int ReverseIntegerI(int x)
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

    public int ReverseIntegerII(int x)
    {
        if (x < 10 && x > -10) return x;
        int reversed = 0;
        while (x != 0)
        {
            int remainder = x % 10;
            if (reversed > Int32.MaxValue / 10 || (reversed > Int32.MaxValue / 10 && remainder > 7)) return 0;
            if (reversed < Int32.MinValue / 10 || (reversed < Int32.MinValue / 10 && remainder < -8)) return 0;
            reversed = reversed * 10 + remainder;
            x /= 10;
        }
        return reversed;
    }
}