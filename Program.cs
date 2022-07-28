﻿// See https://aka.ms/new-console-template for more information
using static BinarySearchTree;
using static Solutions;

Console.WriteLine();

BinarySearchTree bst = new BinarySearchTree();
DynamicProgramming dp = new DynamicProgramming();
Strings stringSolutions = new Strings();
Integers integerSolutions = new Integers();
ArraysLists arraySolutions = new ArraysLists();
Miscellaneous misc = new Miscellaneous();

string[] problems = Enum.GetNames(typeof(PracticeProblem));

for (int i = 0; i < problems.Length; i++)
{
    Console.WriteLine($"{i + 1}. {problems[i]}");
}

Console.WriteLine();
int input = askForInput();
Console.WriteLine();

string output = string.Empty;
string problem = problems[input - 1];

switch (problem)
{
    case nameof(Solutions.TwoSum):
        int[] twoSumResult = Solutions.TwoSum(new int[] { 3, 2, 4 }, 5);
        output = $"[{string.Join(", ", twoSumResult)}]";
        break;
    case nameof(Solutions.LeftRotation):
        List<int> leftRotationResult = Solutions.LeftRotation(new List<int> { 1, 2, 3, 4, 5 }, 4);
        output = $"[{string.Join(", ", leftRotationResult)}]";
        break;
    case nameof(Solutions.PlusMinus):
        List<string> plusMinusResult = Solutions.PlusMinus(new List<int> { 1, 1, 0, -1, -1, -1 });
        output = $"[{string.Join(", ", plusMinusResult)}]";
        break;
    case nameof(Solutions.Staircase):
        Solutions.Staircase(6);
        break;
    case nameof(Solutions.ArrayMinMaxSum):
        long[] arrayMinMaxSumResult = Solutions.ArrayMinMaxSum(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
        output = $"[{string.Join(", ", arrayMinMaxSumResult)}]";
        break;
    case nameof(Solutions.BirthdayCakeCandles):
        int bccResult = Solutions.BirthdayCakeCandles(new List<int> { 3, 2, 1, 3 });
        output = bccResult.ToString();
        break;
    case nameof(Solutions.GradingStudents):
        List<int> gradingStudentsResult = GradingStudents(new List<int> { 1, 2, 3, 4, 5 });
        output = $"[{string.Join(", ", gradingStudentsResult)}]";
        break;
    case nameof(Solutions.AddTwoNumbers):
        ListNode? addTwoNumbersResult = Solutions.AddTwoNumbers(
            new ListNode(2, new ListNode(4, new ListNode(3))),
            new ListNode(5, new ListNode(6, new ListNode(8))));
        output = $"[{string.Join(", ", addTwoNumbersResult)}]";
        break;
    case nameof(IsPalindrome):
        bool isPalindromeResult = IsPalindrome(121);
        output = $"{string.Join(", ", isPalindromeResult)}";
        break;
    case nameof(ZigzagConversion):
        string zigzagResult = ZigzagConversion("A", 2);
        output = $"{string.Join(", ", zigzagResult)}";
        break;
    case nameof(MinimumLengthEncoding):
        int mleResult = MinimumLengthEncoding(new string[] { "time", "me", "bell" });
        output = $"{string.Join(", ", mleResult)}";
        break;
    case nameof(LongestPalindrome):
        string lpResult = LongestPalindrome("abba");
        output = $"{string.Join(", ", lpResult)}";
        break;
    case nameof(GenerateParenthesis):
        IList<string> gpResult = GenerateParenthesis(3);
        output = $"[{string.Join(", ", gpResult)}]";
        break;
    case nameof(GeneratePermutationsI):
        IList<string> permuIResult = GeneratePermutationsI("abc");
        output = $"[{string.Join(", ", permuIResult)}]";
        break;
    case nameof(GeneratePermutationsII):
        IList<string> permuIIResult = GeneratePermutationsII("abcd");
        output = $"[{string.Join(", ", permuIIResult)}]";
        break;
    case nameof(GenerateListPermutations):
        var listPermResults = GenerateListPermutations(new int[] { 1, 3, 2 });
        output = "[";
        foreach (var result in listPermResults)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case nameof(SearchRange):
        var searchRange = SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6);
        output = $"[{string.Join(", ", searchRange)}]";
        break;
    case nameof(bst.InOrderTraversal):
        TreeNode node = new TreeNode(10);
        node.Left = new TreeNode(20);
        node.Left.Left = new TreeNode(40);
        node.Left.Right = new TreeNode(60);
        node.Right = new TreeNode(30);
        node.Right.Left = new TreeNode(50);
        var bstResult = bst.InOrderTraversal(node);
        output = $"[{string.Join(", ", bstResult)}]";
        break;
    case nameof(bst.PreOrderTraversal):
        TreeNode bst1 = new TreeNode(6);
        bst1.Left = new TreeNode(3);
        bst1.Left.Right = new TreeNode(1);
        bst1.Right = new TreeNode(2);
        bst1.Right.Left = new TreeNode(2);
        var bst1Result = bst.PreOrderTraversal(bst1);
        output = $"[{string.Join(", ", bst1Result)}]";
        break;
    case nameof(bst.PostOrderTraversal):
        TreeNode bst2 = new TreeNode(19);
        bst2.Left = new TreeNode(10);
        bst2.Left.Left = new TreeNode(11);
        bst2.Left.Right = new TreeNode(13);
        bst2.Right = new TreeNode(8);
        var bst2Result = bst.PostOrderTraversal(bst2);
        output = $"[{string.Join(", ", bst2Result)}]";
        break;
    case nameof(bst.BreadthFirstTraversalI):
        TreeNode bft = new TreeNode(1);
        bft.Left = new TreeNode(2);
        bft.Left.Left = new TreeNode(4);
        bft.Left.Right = new TreeNode(5);
        bft.Right = new TreeNode(3);
        var bftResult = bst.BreadthFirstTraversalI(bft);
        output = $"[{string.Join(", ", bftResult)}]";
        break;
    case nameof(bst.LevelOrderTraversal):
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
    case nameof(bst.BottomUpLevelOrderTraversal):
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
    case nameof(bst.BottomUpBreadthFirstTraversal):
        TreeNode bubft = new TreeNode(1);
        bubft.Left = new TreeNode(2);
        bubft.Right = new TreeNode(3);
        bubft.Left.Left = new TreeNode(4);
        bubft.Left.Right = new TreeNode(5);
        var bubftResult = bst.BottomUpBreadthFirstTraversal(bubft);
        output = $"[{string.Join(", ", bubftResult)}]";
        break;
    case nameof(bst.BinaryTreeMinimumDepthI):
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
    case nameof(bst.BinaryTreeMinimumDepthII):
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
    case nameof(bst.NumberOfUniqueBinarySearchTrees):
        int numBST = bst.NumberOfUniqueBinarySearchTrees(4);
        output = numBST.ToString();
        break;
    case nameof(dp.PalindromePartioning):
        output = "[";
        IList<IList<string>> dpResults = dp.PalindromePartioning("poop");
        foreach (var result in dpResults)
        {
            output += $"[{string.Join(", ", result)}]";
        }
        output += "]";
        break;
    case nameof(stringSolutions.LongestSubstringWithNonRepeatingChars):
        int longest = stringSolutions.LongestSubstringWithNonRepeatingChars("gang");
        output = longest.ToString();
        break;
    case nameof(integerSolutions.ReverseIntegerI):
        int reversed = integerSolutions.ReverseIntegerI(-2147483648);
        output = reversed.ToString();
        break;
    case nameof(arraySolutions.FindMedianSortedArrays):
        double median = arraySolutions.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 4 });
        output = median.ToString();
        break;
    case nameof(arraySolutions.MoveUniquesToFront):
        int numUniques = arraySolutions.MoveUniquesToFront(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
        output = numUniques.ToString();
        break;
    case nameof(stringSolutions.ReverseString):
        char[] reversedChars = stringSolutions.ReverseString(new char[] { 'h', 'a', 'n', 'n', 'a', 'H' });
        output = $"[{string.Join(", ", reversedChars)}]";
        break;
    case nameof(bst.BinaryTreeMaximumDepth):
        int maxDepth = bst.BinaryTreeMaximumDepth(new TreeNode(1, null, new TreeNode(2, new TreeNode(3))));
        output = maxDepth.ToString();
        break;
    case nameof(arraySolutions.MergeAndSortArrays):
        int[] merged = arraySolutions.MergeAndSortArrays(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        output = $"[{string.Join(", ", merged)}]";
        break;
    case nameof(dp.NumberOfWaysClimbStairs):
        int climbStairs = dp.NumberOfWaysClimbStairs(1);
        output = climbStairs.ToString();
        break;
    case nameof(arraySolutions.ShuffleArray):
        int[] shuffled = arraySolutions.ShuffleArray(new int[] { 1, 2, 3, 4, 5 });
        output = $"[{string.Join(", ", shuffled)}]";
        break;
    case nameof(arraySolutions.FizzBuzz):
        IList<string> fizzbuzz = arraySolutions.FizzBuzz(0);
        output = $"[{string.Join(", ", fizzbuzz)}]";
        break;
    case nameof(misc.IsValidParenthesis):
        bool isValid = misc.IsValidParenthesis("){");
        output = isValid.ToString();
        break;
    case nameof(ArraysLists.MaxStockProfit):
        int maxProfit = arraySolutions.MaxStockProfit(new int[] { 1, 2, 3, 4, 5 });
        output = maxProfit.ToString();
        break;
    case nameof(Integers.ReverseIntegerII):
        int reversedInt = integerSolutions.ReverseIntegerII(900000);
        output = reversedInt.ToString();
        break;
    case nameof(DynamicProgramming.MaxProfitInStock):
        int maxStockProfit = dp.MaxProfitInStock(new int[] { 7, 1, 5, 3, 6, 4 });
        output = maxStockProfit.ToString();
        break;
    case nameof(BinarySearchTree.IsValidBST):
        bool isValidBST = bst.IsValidBST(new TreeNode(5, new TreeNode(1), new TreeNode(9, new TreeNode(6), new TreeNode(10, new TreeNode(7)))));
        output = isValidBST.ToString();
        break;
    case nameof(Strings.IsPalindromeString):
        bool isPalindromeString = stringSolutions.IsPalindromeString("race a car");
        output = isPalindromeString.ToString();
        break;
}
Console.WriteLine($"Result for {problems[input - 1]} problem is: {output}");
Console.WriteLine();

int askForInput()
{
    int input = handleEmptyInput();
    while (input < 1 || input > problems.Length)
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