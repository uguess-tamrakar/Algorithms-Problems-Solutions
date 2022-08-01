public class Stacks
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

public class QueueUsingStacks<T>
{
    private Stack<T> s1 = new Stack<T>();
    private Stack<T> s2 = new Stack<T>();

    public T Enqueue(T x)
    {
        Stack<T>
    }
}