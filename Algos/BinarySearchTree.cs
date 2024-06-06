public class BinarySearchTree
{
    public static int LowestCommonAncestor(TreeNode root, int v1, int v2)
    {
        if (root is null) return -1;

        if (v1 < root.Value && v2 < root.Value && root.Left != null)
        {
            return LowestCommonAncestor(root.Left, v1, v2);
        }

        if (v1 > root.Value && v2 > root.Value && root.Right != null)
        {
            return LowestCommonAncestor(root.Right, v1, v2);
        }
        return root.Value;
    }

    public static bool IsValidBST(TreeNode root)
    {
        return isValidRecursive(root, null, null);
    }

    private static bool isValidRecursive(TreeNode? current, int? low, int? high)
    {
        if (current == null) return true;
        if ((low != null && current.Value <= low) || high != null && current.Value >= high) return false;
        return isValidRecursive(current.Left, low, current.Value) && isValidRecursive(current.Right, current.Value, high);
    }

    public static int NumberOfUniqueBinarySearchTrees(int n)
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

    private static int GetNumBSTRecursive(int n, List<int> dp)
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

    public static int BinaryTreeMaximumDepth(TreeNode root)
    {
        int maxDepth = int.MinValue;
        BinaryTreeMaxDepthRecursive(root, 0, ref maxDepth);
        return maxDepth;
    }

    private static void BinaryTreeMaxDepthRecursive(TreeNode? current, int currentDepth, ref int maxDepth)
    {
        if (current == null) return;
        else
        {
            currentDepth++;
            maxDepth = Math.Max(maxDepth, currentDepth);
            BinaryTreeMaxDepthRecursive(current.Left, currentDepth, ref maxDepth);
            BinaryTreeMaxDepthRecursive(current.Right, currentDepth, ref maxDepth);
        }
    }

    public static int BinaryTreeMinimumDepthI(TreeNode root)
    {
        if (root == null) return 0;

        int result = 0;
        Queue<List<TreeNode>> queue = new Queue<List<TreeNode>>();
        queue.Enqueue(new List<TreeNode> { root });

        while (queue.Count > 0)
        {
            List<TreeNode> tempNodes = queue.Dequeue();
            result++;
            List<TreeNode> newNodes = new List<TreeNode>();
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

    public static int BinaryTreeMinimumDepthII(TreeNode root)
    {
        if (root == null) return 0;
        int minDepth = int.MaxValue;
        BinaryTreeMinDepthRecursive(root, 0, ref minDepth);
        return minDepth;
    }

    private static void BinaryTreeMinDepthRecursive(TreeNode? current, int currentDepth, ref int minDepth)
    {
        currentDepth++;
        if (current == null) return;
        if (current.Left == null && current.Right == null) minDepth = Math.Min(currentDepth, minDepth);
        if (currentDepth > minDepth) return;
        BinaryTreeMinDepthRecursive(current.Left, currentDepth, ref minDepth);
        BinaryTreeMinDepthRecursive(current.Right, currentDepth, ref minDepth);
    }

    public static IList<IList<int>> BottomUpLevelOrderTraversal(TreeNode root)
    {
        if (root == null) return new List<IList<int>> { };
        IList<IList<int>> results = new List<IList<int>>();
        TraverseLevelOrder(results, root, 0);
        return results.Reverse().ToList();
    }

    private static void TraverseLevelOrder(IList<IList<int>> results, TreeNode? current, int level)
    {
        if (current == null) return;
        if (level >= results.Count) results.Add(new List<int>());
        results[level].Add(current.Value);
        TraverseLevelOrder(results, current.Left, level + 1);
        TraverseLevelOrder(results, current.Right, level + 1);
    }

    public static IList<IList<int>> LevelOrderTraversal(TreeNode root)
    {
        if (root == null) return new List<IList<int>> { };

        IList<IList<int>> results = new List<IList<int>>();
        Queue<List<TreeNode>> queue = new Queue<List<TreeNode>>();
        queue.Enqueue(new List<TreeNode> { root });

        while (queue.Count != 0)
        {
            List<int> result = new List<int>();
            List<TreeNode> tempNodes = queue.Dequeue();
            List<TreeNode> nexts = new List<TreeNode>();

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

    public static List<int> InOrderTraversal(TreeNode root)
    {
        List<int> result = new();
        TraverseInOrder(result, root);
        return result;
    }

    public static List<int> PreOrderTraversal(TreeNode root)
    {
        List<int> result = new();
        TraversePreOrder(result, root);
        return result;
    }

    public static List<int> PostOrderTraversal(TreeNode root)
    {
        List<int> result = new();
        TraversePostOrder(result, root);
        return result;
    }

    public static List<int> BreadthFirstTraversalI(TreeNode root)
    {
        List<int> result = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            TreeNode temp = queue.Dequeue();
            result.Add(temp.Value);
            if (temp.Left != null) queue.Enqueue(temp.Left);
            if (temp.Right != null) queue.Enqueue(temp.Right);
        }

        return result;
    }

    public static List<int> BottomUpBreadthFirstTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode temp = queue.Dequeue();
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

    private static void TraverseInOrder(List<int> result, TreeNode? current)
    {
        if (current == null) return;
        TraverseInOrder(result, current.Left);
        result.Add(current.Value);
        TraverseInOrder(result, current.Right);
    }

    private static void TraversePreOrder(List<int> result, TreeNode? current)
    {
        if (current == null) return;
        result.Add(current.Value);
        TraversePreOrder(result, current.Left);
        TraversePreOrder(result, current.Right);
    }

    private static void TraversePostOrder(List<int> result, TreeNode? current)
    {
        if (current == null) return;
        TraversePostOrder(result, current.Left);
        TraversePostOrder(result, current.Right);
        result.Add(current.Value);
    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode(int value, TreeNode? left = null, TreeNode? right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}