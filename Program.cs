// See https://aka.ms/new-console-template for more information
using System.Reflection;
using Algorithms;
using static Algorithms.Solutions;
using static BinarySearchTree;

Console.WriteLine();

BinarySearchTree BST = new BinarySearchTree();
DP DP = new DP();
StringSolutions StringSols = new StringSolutions();
IntegerSolutions IntegerSols = new IntegerSolutions();
ArraysSolutions ArraySols = new ArraysSolutions();

string[] solutions = {
    nameof(TwoSum),
    nameof(LeftRotation),
    nameof(PlusMinus),
    nameof(Staircase),
    nameof(ArrayMinMaxSum),
    nameof(BirthdayCakeCandles),
    nameof(GradingStudents),
    nameof(AddTwoNumbers),
    nameof(IsPalindrome),
    nameof(ZigzagConversion),
    nameof(MinimumLengthEncoding),
    nameof(LongestPalindrome),
    nameof(GenerateParenthesis),
    nameof(GeneratePermutationsI),
    nameof(GeneratePermutationsII),
    nameof(GenerateListPermutations),
    nameof(SearchRange),
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
    nameof(DP.PalindromePartioning),
    nameof(StringSols.LongestSubstringWithNonRepeatingChars),
    nameof(IntegerSols.ReverseInteger),
    nameof(ArraySols.FindMedianSortedArrays),
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
        int[] twoSumResult = TwoSum(new int[] { 3, 2, 4 }, 5);
        output = $"[{string.Join(", ", twoSumResult)}]";
        break;
    case 2:
        List<int> leftRotationResult = LeftRotation(new List<int> { 1, 2, 3, 4, 5 }, 4);
        output = $"[{string.Join(", ", leftRotationResult)}]";
        break;
    case 3:
        List<string> plusMinusResult = PlusMinus(new List<int> { 1, 1, 0, -1, -1, -1 });
        output = $"[{string.Join(", ", plusMinusResult)}]";
        break;
    case 4:
        Staircase(6);
        break;
    case 5:
        long[] arrayMinMaxSumResult = ArrayMinMaxSum(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
        output = $"[{string.Join(", ", arrayMinMaxSumResult)}]";
        break;
    case 6:
        int bccResult = BirthdayCakeCandles(new List<int> { 3, 2, 1, 3 });
        output = bccResult.ToString();
        break;

    case 7:
        List<int> gradingStudentsResult = GradingStudents(new List<int> { 1, 2, 3, 4, 5 });
        output = $"[{string.Join(", ", gradingStudentsResult)}]";
        break;

    case 8:
        ListNode? addTwoNumbersResult = AddTwoNumbers(
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
        Node bst = new Node(10);
        bst.Left = new Node(20);
        bst.Left.Left = new Node(40);
        bst.Left.Right = new Node(60);
        bst.Right = new Node(30);
        bst.Right.Left = new Node(50);
        var bstResult = BST.InOrderTraversal(bst);
        output = $"[{string.Join(", ", bstResult)}]";
        break;
    case 19:
        Node bst1 = new Node(6);
        bst1.Left = new Node(3);
        bst1.Left.Right = new Node(1);
        bst1.Right = new Node(2);
        bst1.Right.Left = new Node(2);
        var bst1Result = BST.PreOrderTraversal(bst1);
        output = $"[{string.Join(", ", bst1Result)}]";
        break;
    case 20:
        Node bst2 = new Node(19);
        bst2.Left = new Node(10);
        bst2.Left.Left = new Node(11);
        bst2.Left.Right = new Node(13);
        bst2.Right = new Node(8);
        var bst2Result = BST.PostOrderTraversal(bst2);
        output = $"[{string.Join(", ", bst2Result)}]";
        break;
    case 21:
        Node bft = new Node(1);
        bft.Left = new Node(2);
        bft.Left.Left = new Node(4);
        bft.Left.Right = new Node(5);
        bft.Right = new Node(3);
        var bftResult = BST.BreadthFirstTraversalI(bft);
        output = $"[{string.Join(", ", bftResult)}]";
        break;
    case 22:
        Node lot = new Node(3);
        lot.Left = new Node(9);
        lot.Right = new Node(20);
        lot.Right.Left = new Node(15);
        lot.Right.Right = new Node(7);
        var lotResult = BST.LevelOrderTraversal(lot);
        output = "[";
        foreach (var result in lotResult)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case 23:
        Node bulot = new Node(3);
        bulot.Left = new Node(9);
        bulot.Right = new Node(20);
        bulot.Right.Left = new Node(15);
        bulot.Right.Right = new Node(7);
        var bulotResult = BST.BottomUpLevelOrderTraversal(bulot);
        output = "[";
        foreach (var result in bulotResult)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case 24:
        Node bubft = new Node(1);
        bubft.Left = new Node(2);
        bubft.Right = new Node(3);
        bubft.Left.Left = new Node(4);
        bubft.Left.Right = new Node(5);
        var bubftResult = BST.BottomUpBreadthFirstTraversal(bubft);
        output = $"[{string.Join(", ", bubftResult)}]";
        break;
    case 25:
        Node btmd = new Node(0);
        btmd.Left = new Node(2);
        btmd.Right = new Node(4);
        btmd.Left.Left = new Node(1);
        btmd.Left.Left.Left = new Node(5);
        btmd.Left.Left.Right = new Node(1);
        btmd.Right.Left = new Node(3);
        btmd.Right.Left.Right = new Node(6);
        btmd.Right.Right = new Node(-1);
        btmd.Right.Right.Right = new Node(8);
        var btmdResult = BST.BinaryTreeMinimumDepthI(btmd);
        output = btmdResult.ToString();
        break;
    case 26:
        Node btmd1 = new Node(0);
        btmd1.Left = new Node(2);
        btmd1.Right = new Node(4);
        btmd1.Left.Left = new Node(1);
        btmd1.Left.Left.Left = new Node(5);
        btmd1.Left.Left.Right = new Node(1);
        btmd1.Right.Left = new Node(3);
        btmd1.Right.Left.Right = new Node(6);
        btmd1.Right.Right = new Node(-1);
        btmd1.Right.Right.Right = new Node(8);
        var btmd1Result = BST.BinaryTreeMinimumDepthII(btmd1);
        output = btmd1Result.ToString();
        break;
    case 27:
        int numBST = BST.NumberOfUniqueBinarySearchTrees(4);
        output = numBST.ToString();
        break;
    case 28:
        output = "[";
        IList<IList<string>> dpResults = DP.PalindromePartioning("poop");
        foreach (var result in dpResults)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case 29:
        int longest = StringSols.LongestSubstringWithNonRepeatingChars("gang");
        output = longest.ToString();
        break;
    case 30:
        int reversed = IntegerSols.ReverseInteger(-2147483648);
        output = reversed.ToString();
        break;
    case 31:
        double median = ArraySols.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 4 });
        output = median.ToString();
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