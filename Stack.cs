public class Stack
{
    private Stack<int> _stack = new Stack<int>();
    private int _min;

    public int getMin() => _min;

    public int pop()
    {
        int x = _stack.Pop();
        _min = _stack.Min();
        return x;
    }

    public void push(int x)
    {
        _stack.Push(x);
        _min = Math.Min(_min, x);
    }
}