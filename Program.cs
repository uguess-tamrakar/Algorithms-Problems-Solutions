// See https://aka.ms/new-console-template for more information
using static BinarySearchTree;
using static Solutions;

Console.WriteLine();

BinarySearchTree bst = new BinarySearchTree();
DP dp = new DP();
Strings stringSolutions = new Strings();
Integers integerSolutions = new Integers();
ArraysLists arraySolutions = new ArraysLists();
Miscellaneous misc = new Miscellaneous();

string[] solutions = {
    nameof(Solutions.TwoSum),
    nameof(Solutions.LeftRotation),
    nameof(Solutions.PlusMinus),
    nameof(Solutions.Staircase),
    nameof(Solutions.ArrayMinMaxSum),
    nameof(Solutions.BirthdayCakeCandles),
    nameof(Solutions.GradingStudents),
    nameof(Solutions.AddTwoNumbers),
    nameof(Solutions.IsPalindrome),
    nameof(Solutions.ZigzagConversion),
    nameof(Solutions.MinimumLengthEncoding),
    nameof(Solutions.LongestPalindrome),
    nameof(Solutions.GenerateParenthesis),
    nameof(Solutions.GeneratePermutationsI),
    nameof(Solutions.GeneratePermutationsII),
    nameof(Solutions.GenerateListPermutations),
    nameof(Solutions.SearchRange),
    nameof(BinarySearchTree.InOrderTraversal),
    nameof(BinarySearchTree.PreOrderTraversal),
    nameof(BinarySearchTree.PostOrderTraversal),
    nameof(BinarySearchTree.BreadthFirstTraversalI),
    nameof(BinarySearchTree.LevelOrderTraversal),
    nameof(BinarySearchTree.BottomUpLevelOrderTraversal),
    nameof(BinarySearchTree.BottomUpBreadthFirstTraversal),
    nameof(BinarySearchTree.BinaryTreeMinimumDepthI),
    nameof(BinarySearchTree.BinaryTreeMinimumDepthII),
    nameof(BinarySearchTree.NumberOfUniqueBinarySearchTrees),
    nameof(dp.PalindromePartioning),
    nameof(stringSolutions.LongestSubstringWithNonRepeatingChars),
    nameof(integerSolutions.ReverseInteger),
    nameof(arraySolutions.FindMedianSortedArrays),
    nameof(ArraysLists.MoveUniquesToFront),
    nameof(Strings.ReverseString),
    nameof(bst.BinaryTreeMaximumDepth),
    nameof(arraySolutions.MergeAndSortArrays),
    nameof(dp.NumberOfWaysClimbStairs),
    nameof(arraySolutions.ShuffleArray),
    nameof(arraySolutions.FizzBuzz),
    nameof(Miscellaneous.IsValidParenthesis)
};

for (int i = 0; i < solutions.Length; i++)
{
    Console.WriteLine($"{i + 1}. {solutions[i]}");
}

Console.WriteLine();
int input = askForInput();
Console.WriteLine();

string output = string.Empty;

switch (input)
{
    case 1:
        int[] twoSumResult = Solutions.TwoSum(new int[] { 3, 2, 4 }, 5);
        output = $"[{string.Join(", ", twoSumResult)}]";
        break;
    case 2:
        List<int> leftRotationResult = Solutions.LeftRotation(new List<int> { 1, 2, 3, 4, 5 }, 4);
        output = $"[{string.Join(", ", leftRotationResult)}]";
        break;
    case 3:
        List<string> plusMinusResult = Solutions.PlusMinus(new List<int> { 1, 1, 0, -1, -1, -1 });
        output = $"[{string.Join(", ", plusMinusResult)}]";
        break;
    case 4:
        Solutions.Staircase(6);
        break;
    case 5:
        long[] arrayMinMaxSumResult = Solutions.ArrayMinMaxSum(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
        output = $"[{string.Join(", ", arrayMinMaxSumResult)}]";
        break;
    case 6:
        int bccResult = Solutions.BirthdayCakeCandles(new List<int> { 3, 2, 1, 3 });
        output = bccResult.ToString();
        break;

    case 7:
        List<int> gradingStudentsResult = GradingStudents(new List<int> { 1, 2, 3, 4, 5 });
        output = $"[{string.Join(", ", gradingStudentsResult)}]";
        break;

    case 8:
        ListNode? addTwoNumbersResult = Solutions.AddTwoNumbers(
            new ListNode(2, new ListNode(4, new ListNode(3))),
            new ListNode(5, new ListNode(6, new ListNode(8))));
        output = $"[{string.Join(", ", addTwoNumbersResult)}]";
        break;
    case 9:
        bool isPalindromeResult = IsPalindrome(121);
        output = $"{string.Join(", ", isPalindromeResult)}";
        break;
    case 10:
        string zigzagResult = ZigzagConversion("A", 2);
        output = $"{string.Join(", ", zigzagResult)}";
        break;
    case 11:
        int mleResult = MinimumLengthEncoding(new string[] { "time", "me", "bell" });
        output = $"{string.Join(", ", mleResult)}";
        break;
    case 12:
        string lpResult = LongestPalindrome("abba");
        output = $"{string.Join(", ", lpResult)}";
        break;
    case 13:
        IList<string> gpResult = GenerateParenthesis(3);
        output = $"[{string.Join(", ", gpResult)}]";
        break;
    case 14:
        IList<string> permuIResult = GeneratePermutationsI("abc");
        output = $"[{string.Join(", ", permuIResult)}]";
        break;
    case 15:
        IList<string> permuIIResult = GeneratePermutationsII("abcd");
        output = $"[{string.Join(", ", permuIIResult)}]";
        break;
    case 16:
        var listPermResults = GenerateListPermutations(new int[] { 1, 3, 2 });
        output = "[";
        foreach (var result in listPermResults)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case 17:
        var searchRange = SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6);
        output = $"[{string.Join(", ", searchRange)}]";
        break;
    case 18:
        TreeNode node = new TreeNode(10);
        node.Left = new TreeNode(20);
        node.Left.Left = new TreeNode(40);
        node.Left.Right = new TreeNode(60);
        node.Right = new TreeNode(30);
        node.Right.Left = new TreeNode(50);
        var bstResult = bst.InOrderTraversal(node);
        output = $"[{string.Join(", ", bstResult)}]";
        break;
    case 19:
        TreeNode bst1 = new TreeNode(6);
        bst1.Left = new TreeNode(3);
        bst1.Left.Right = new TreeNode(1);
        bst1.Right = new TreeNode(2);
        bst1.Right.Left = new TreeNode(2);
        var bst1Result = bst.PreOrderTraversal(bst1);
        output = $"[{string.Join(", ", bst1Result)}]";
        break;
    case 20:
        TreeNode bst2 = new TreeNode(19);
        bst2.Left = new TreeNode(10);
        bst2.Left.Left = new TreeNode(11);
        bst2.Left.Right = new TreeNode(13);
        bst2.Right = new TreeNode(8);
        var bst2Result = bst.PostOrderTraversal(bst2);
        output = $"[{string.Join(", ", bst2Result)}]";
        break;
    case 21:
        TreeNode bft = new TreeNode(1);
        bft.Left = new TreeNode(2);
        bft.Left.Left = new TreeNode(4);
        bft.Left.Right = new TreeNode(5);
        bft.Right = new TreeNode(3);
        var bftResult = bst.BreadthFirstTraversalI(bft);
        output = $"[{string.Join(", ", bftResult)}]";
        break;
    case 22:
        TreeNode lot = new TreeNode(3);
        lot.Left = new TreeNode(9);
        lot.Right = new TreeNode(20);
        lot.Right.Left = new TreeNode(15);
        lot.Right.Right = new TreeNode(7);
        var lotResult = bst.LevelOrderTraversal(lot);
        output = "[";
        foreach (var result in lotResult)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case 23:
        TreeNode bulot = new TreeNode(3);
        bulot.Left = new TreeNode(9);
        bulot.Right = new TreeNode(20);
        bulot.Right.Left = new TreeNode(15);
        bulot.Right.Right = new TreeNode(7);
        var bulotResult = bst.BottomUpLevelOrderTraversal(bulot);
        output = "[";
        foreach (var result in bulotResult)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case 24:
        TreeNode bubft = new TreeNode(1);
        bubft.Left = new TreeNode(2);
        bubft.Right = new TreeNode(3);
        bubft.Left.Left = new TreeNode(4);
        bubft.Left.Right = new TreeNode(5);
        var bubftResult = bst.BottomUpBreadthFirstTraversal(bubft);
        output = $"[{string.Join(", ", bubftResult)}]";
        break;
    case 25:
        TreeNode btmd = new TreeNode(0);
        btmd.Left = new TreeNode(2);
        btmd.Right = new TreeNode(4);
        btmd.Left.Left = new TreeNode(1);
        btmd.Left.Left.Left = new TreeNode(5);
        btmd.Left.Left.Right = new TreeNode(1);
        btmd.Right.Left = new TreeNode(3);
        btmd.Right.Left.Right = new TreeNode(6);
        btmd.Right.Right = new TreeNode(-1);
        btmd.Right.Right.Right = new TreeNode(8);
        var btmdResult = bst.BinaryTreeMinimumDepthI(btmd);
        output = btmdResult.ToString();
        break;
    case 26:
        TreeNode btmd1 = new TreeNode(0);
        btmd1.Left = new TreeNode(2);
        btmd1.Right = new TreeNode(4);
        btmd1.Left.Left = new TreeNode(1);
        btmd1.Left.Left.Left = new TreeNode(5);
        btmd1.Left.Left.Right = new TreeNode(1);
        btmd1.Right.Left = new TreeNode(3);
        btmd1.Right.Left.Right = new TreeNode(6);
        btmd1.Right.Right = new TreeNode(-1);
        btmd1.Right.Right.Right = new TreeNode(8);
        var btmd1Result = bst.BinaryTreeMinimumDepthII(btmd1);
        output = btmd1Result.ToString();
        break;
    case 27:
        int numBST = bst.NumberOfUniqueBinarySearchTrees(4);
        output = numBST.ToString();
        break;
    case 28:
        output = "[";
        IList<IList<string>> dpResults = dp.PalindromePartioning("poop");
        foreach (var result in dpResults)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case 29:
        int longest = stringSolutions.LongestSubstringWithNonRepeatingChars("gang");
        output = longest.ToString();
        break;
    case 30:
        int reversed = integerSolutions.ReverseInteger(-2147483648);
        output = reversed.ToString();
        break;
    case 31:
        double median = arraySolutions.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 4 });
        output = median.ToString();
        break;
    case 32:
        int numUniques = arraySolutions.MoveUniquesToFront(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
        output = numUniques.ToString();
        break;
    case 33:
        char[] reversedChars = stringSolutions.ReverseString(new char[] { 'h', 'a', 'n', 'n', 'a', 'H' });
        output = $"[{string.Join(", ", reversedChars)}]";
        break;
    case 34:
        int maxDepth = bst.BinaryTreeMaximumDepth(new TreeNode(1, null, new TreeNode(2, new TreeNode(3))));
        output = maxDepth.ToString();
        break;
    case 35:
        int[] merged = arraySolutions.MergeAndSortArrays(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        output = $"[{string.Join(", ", merged)}]";
        break;
    case 36:
        int climbStairs = dp.NumberOfWaysClimbStairs(1);
        output = climbStairs.ToString();
        break;
    case 37:
        int[] shuffled = arraySolutions.ShuffleArray(new int[] { 1, 2, 3, 4, 5 });
        output = $"[{string.Join(", ", shuffled)}]";
        break;
    case 38:
        IList<string> fizzbuzz = arraySolutions.FizzBuzz(0);
        output = $"[{string.Join(", ", fizzbuzz)}]";
        break;
    case 39:
        bool isValid = misc.IsValidParenthesis("){");
        output = isValid.ToString();
        break;
}

Console.WriteLine($"Result for {solutions[input - 1]} problem is: {output}");
Console.WriteLine();

int askForInput()
{
    int input = handleEmptyInput();
    while (input < 1 || input > solutions.Length)
    {
        Console.Write("Invalid entry. ");
        input = handleEmptyInput();
    }

    return input;
}

int handleEmptyInput()
{
    string? strResponse;
    do
    {
        Console.Write("Select a problem from above: ");
        strResponse = Console.ReadLine();
    } while (string.IsNullOrEmpty(strResponse));

    int response = int.Parse(strResponse);
    return response;
}