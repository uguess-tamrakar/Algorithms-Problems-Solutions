public class BinarySearchTree
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public int NumberOfUniqueBinarySearchTrees(int n)
    {
        List<int> dp = new List<int>();
        dp.Add(1);
        dp.Add(1);
        // for (int level = 2; level <= n; level++)
        // {
        //     for (int root = 1; root <= level; root++)
        //     {
        //         dp[level] += dp[level - root] * dp[root - 1];
        //     }
        // }
        GetNumBSTRecursive(n, dp);

        return dp[n];
    }

    private int GetNumBSTRecursive(int n, List<int> dp)
    {
        if (dp.Count > n) return dp[n];
        int numTrees = 0;
        for (int i = 1; i <= n; i++)
        {
            numTrees += GetNumBSTRecursive(i - 1, dp) * GetNumBSTRecursive(n - i, dp);
        }
        dp.Add(numTrees);
        return numTrees;
    }

    public int BinaryTreeMinimumDepthI(Node root)
    {
        if (root == null) return 0;

        int result = 0;
        Queue<List<Node>> queue = new Queue<List<Node>>();
        queue.Enqueue(new List<Node> { root });

        while (queue.Count > 0)
        {
            List<Node> tempNodes = queue.Dequeue();
            result++;
            List<Node> newNodes = new List<Node>();
            foreach (var tempNode in tempNodes)
            {
                if (tempNode.Left == null && tempNode.Right == null) return result;
                if (tempNode.Left != null) newNodes.Add(tempNode.Left);
                if (tempNode.Right != null) newNodes.Add(tempNode.Right);
            }
            queue.Enqueue(newNodes);
        }

        return result;
    }

    public int BinaryTreeMinimumDepthII(Node root)
    {
        if (root == null) return 0;
        int minDepth = int.MaxValue;
        BinaryTreeDepthRecursive(root, 0, ref minDepth);
        return minDepth;
    }

    private void BinaryTreeDepthRecursive(Node? current, int currentDepth, ref int minDepth)
    {
        currentDepth++;
        if (current == null) return;
        if (current.Left == null && current.Right == null) minDepth = Math.Min(currentDepth, minDepth);
        if (currentDepth > minDepth) return;
        BinaryTreeDepthRecursive(current.Left, currentDepth, ref minDepth);
        BinaryTreeDepthRecursive(current.Right, currentDepth, ref minDepth);
    }

    public IList<IList<int>> BottomUpLevelOrderTraversal(Node root)
    {
        if (root == null) return new List<IList<int>> { };
        IList<IList<int>> results = new List<IList<int>>();
        TraverseLevelOrder(results, root, 0);
        return results.Reverse().ToList();
    }

    private void TraverseLevelOrder(IList<IList<int>> results, Node? current, int level)
    {
        if (current == null) return;
        if (level >= results.Count) results.Add(new List<int>());
        results[level].Add(current.Value);
        TraverseLevelOrder(results, current.Left, level + 1);
        TraverseLevelOrder(results, current.Right, level + 1);
    }

    public IList<IList<int>> LevelOrderTraversal(Node root)
    {
        if (root == null) return new List<IList<int>> { };

        IList<IList<int>> results = new List<IList<int>>();
        Queue<List<Node>> queue = new Queue<List<Node>>();
        queue.Enqueue(new List<Node> { root });

        while (queue.Count != 0)
        {
            List<int> result = new List<int>();
            List<Node> tempNodes = queue.Dequeue();
            List<Node> nexts = new List<Node>();

            foreach (var tempNode in tempNodes)
            {
                result.Add(tempNode.Value);
                if (tempNode.Left != null) nexts.Add(tempNode.Left);
                if (tempNode.Right != null) nexts.Add(tempNode.Right);
            }

            results.Add(result);
            if (nexts.Count > 0) queue.Enqueue(nexts);
        }

        return results;
    }

    public List<int> InOrderTraversal(Node root)
    {
        List<int> result = new();
        TraverseInOrder(result, root);
        return result;
    }

    public List<int> PreOrderTraversal(Node root)
    {
        List<int> result = new();
        TraversePreOrder(result, root);
        return result;
    }

    public List<int> PostOrderTraversal(Node root)
    {
        List<int> result = new();
        TraversePostOrder(result, root);
        return result;
    }

    public List<int> BreadthFirstTraversalI(Node root)
    {
        List<int> result = new();
        Queue<Node> queue = new();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            Node temp = queue.Dequeue();
            result.Add(temp.Value);
            if (temp.Left != null) queue.Enqueue(temp.Left);
            if (temp.Right != null) queue.Enqueue(temp.Right);
        }

        return result;
    }

    public List<int> BottomUpBreadthFirstTraversal(Node root)
    {
        List<int> result = new List<int>();
        Stack<Node> stack = new Stack<Node>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node temp = queue.Dequeue();
            stack.Push(temp);
            if (temp.Right != null) queue.Enqueue(temp.Right);
            if (temp.Left != null) queue.Enqueue(temp.Left);
        }

        while (stack.Count > 0)
        {
            result.Add(stack.Pop().Value);
        }

        return result;
    }

    private void TraverseInOrder(List<int> result, Node? current)
    {
        if (current == null) return;
        TraverseInOrder(result, current.Left);
        result.Add(current.Value);
        TraverseInOrder(result, current.Right);
    }

    private void TraversePreOrder(List<int> result, Node? current)
    {
        if (current == null) return;
        result.Add(current.Value);
        TraversePreOrder(result, current.Left);
        TraversePreOrder(result, current.Right);
    }

    private void TraversePostOrder(List<int> result, Node? current)
    {
        if (current == null) return;
        TraversePostOrder(result, current.Left);
        TraversePostOrder(result, current.Right);
        result.Add(current.Value);
    }
}