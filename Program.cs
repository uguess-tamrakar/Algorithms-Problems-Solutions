// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using static BinarySearchTree;
using static Solutions;

Console.WriteLine();

BinarySearchTree bst = new BinarySearchTree();
DynamicProgramming dp = new DynamicProgramming();
Strings stringSolutions = new Strings();
Integers integerSolutions = new Integers();
ArraysLists arraySolutions = new ArraysLists();
Matrix matrix = new Matrix();
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

Stopwatch watch = Stopwatch.StartNew();
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
    case nameof(dp.NumberOfWaysClimbStairsI):
        int climbStairs = dp.NumberOfWaysClimbStairsI(1);
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
    case nameof(ArraysLists.MinimumSwapsToOrder):
        int minSwaps = arraySolutions.MinimumSwapsToOrder(new int[] { 7, 1, 3, 2, 4, 5, 6 });
        output = minSwaps.ToString();
        break;
    case nameof(Strings.CommonStrings):
        output = stringSolutions.CommonStrings("hi", "world");
        break;
    case nameof(ArraysLists.BubbleSort):
        arraySolutions.BubbleSort(new List<int> { 4, 2, 3, 1 });
        break;
    case nameof(Strings.MakeAnagram):
        output = stringSolutions.MakeAnagram("cde", "abc").ToString();
        break;
    case nameof(Strings.AreBracketsBalanced):
        output = stringSolutions.AreBracketsBalanced("{{[[(())]]}}").ToString();
        break;
    case nameof(ArraysLists.MaxNonAdjacentSubsetSum):
        output = arraySolutions.MaxNonAdjacentSubsetSum(new int[] { -2, 1, 3, -4, 5 }).ToString();
        break;
    case nameof(ArraysLists.MinimumBribes):
        arraySolutions.MinimumBribes(new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 });
        break;
    case nameof(Strings.ReverseWords):
        output = stringSolutions.ReverseWords("Reverse these words");
        break;
    case nameof(dp.NumberOfWaysClimbStairsII):
        output = dp.NumberOfWaysClimbStairsII(7).ToString();
        break;
    case nameof(Strings.SherlockAndAnagrams):
        output = stringSolutions.SherlockAndAnagrams("kkkk").ToString();
        break;
    case nameof(BinarySearchTree.LowestCommonAncestor):
        output = bst.LowestCommonAncestor(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6))), 1, 7).ToString();
        break;
    case nameof(ArraysLists.MaxNumberOfToys):
        output = arraySolutions.MaxNumberOfToys(new List<int> { 1, 12, 5, 111, 200, 1000, 10 }, 50).ToString();
        break;
    case nameof(ArraysLists.WhatFlavors):
        arraySolutions.WhatFlavors(new List<int> { 1, 4, 5, 3, 2 }, 4);
        break;
    case nameof(Strings.MakeCharactersAlternate):
        output = stringSolutions.MakeCharactersAlternate("BABABABABA").ToString();
        break;
    case nameof(ArraysLists.LuckBalance):
        output = arraySolutions.LuckBalance(0, LuckBalanceInput()).ToString();
        break;
    case nameof(DynamicProgramming.Abbreviation):
        output = dp.Abbreviation("AaABCD", "ABCD");
        break;
    case nameof(Strings.CheckMagazine):
        stringSolutions.CheckMagazine(new List<string> { "two", "times", "three", "is", "not", "four" }, new List<string> { "two", "times", "two", "is", "four" });
        break;
    case nameof(Strings.TimeConversion):
        output = stringSolutions.TimeConversion("07:05:45PM");
        break;
    case nameof(ArraysLists.GradingStudents):
        var gradingStudentsResult = arraySolutions.GradingStudents(new List<int>() { 73, 67, 38, 33 });
        output = $"[{string.Join(", ", gradingStudentsResult)}]";
        break;
    case nameof(ArraysLists.CountClosedInventory):
        List<int> closedInventoryCount = arraySolutions.CountClosedInventory("*|**|**|*",
        new List<int> { 1, 1, 5 },
        new List<int> { 7, 5, 6 });
        output = $"[{string.Join(", ", closedInventoryCount)}]";
        break;
    case nameof(ArraysLists.ArrayManipulation):
        output = arraySolutions.ArrayManipulation(10, new List<List<int>>{
            new List<int>{ 1, 5, 3 },
            new List<int>{ 4, 8, 7 },
            new List<int>{ 6, 9, 1 }
        }).ToString();
        break;
    case nameof(ArraysLists.CountTriplets):
        {
            using StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "/CountTriplets.txt");
            string inputString = reader.ReadToEnd();
            List<long> entry = inputString.Split(' ').Select(item => long.Parse(item)).ToList();
            output = arraySolutions.CountTriplets(new List<long> { 1, 2, 2, 4 }, 2).ToString();
        }
        break;
    case nameof(ArraysLists.FrequencyQueries):
        {
            var fqInput1 = new List<List<int>>
            {
                new List<int>{ 1, 3 },
                new List<int>{ 2, 3 },
                new List<int>{ 3, 2 },
                new List<int>{ 1, 4 },
                new List<int>{ 1, 5 },
                new List<int>{ 1, 5 },
                new List<int>{ 1, 4 },
                new List<int>{ 3, 2 },
                new List<int>{ 2, 4 },
                new List<int>{ 3, 2 }
            };
            using StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "/FrequencyQueries.txt");
            string data = reader.ReadToEnd();
            List<List<int>> entry = data.Split("\n").Select(item => item.Split(' ').Select(item => int.Parse(item)).ToList()).ToList();
            List<int> fqResult = arraySolutions.FrequencyQueries(entry);
            output = $"[{string.Join(',', fqResult)}]";
        }
        break;
    case nameof(ArraysLists.Candies):
        {
            using StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "/Ranks.txt");
            string data = reader.ReadToEnd();
            var ranks = data.Split("\n").Select(item => int.Parse(item));
            output = arraySolutions.Candies(8, ranks.ToList()).ToString();
            break;
        }
    case nameof(Strings.SpecialSubstringCount):
        output = stringSolutions.SpecialSubstringCount("abcbaba").ToString();
        break;
    case nameof(ArraysLists.MaxSetSize):
        output = arraySolutions.MaxSetSize(new List<int> { 625, 4, 2, 5, 25, 3, 9 }).ToString();
        break;
    case nameof(ArraysLists.FindTotalPower):
        output = arraySolutions.FindTotalPower(new List<int> { 2, 3, 2, 1 }).ToString();
        break;
    case nameof(Matrix.FlipMatrixToMaximizeTopQuadrant):
        output = matrix.FlipMatrixToMaximizeTopQuadrant(new List<List<int>>
        {
            new List<int>{ 112, 42, 83, 119 },
            new List<int>{ 56, 125, 56, 49},
            new List<int>{ 15, 78, 101, 43},
            new List<int>{ 62, 98, 114, 108 }
        }).ToString();
        break;
    case nameof(Strings.SherlockValidString):
        output = stringSolutions.SherlockValidString("abcdefghhgfedecba").ToString();
        break;
    case nameof(Strings.LongestCommonSubsequence):
        {
            using StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "/LCSInput.txt");
            string data = reader.ReadToEnd();
            var lcsInput = data.Split("\n");
            output = stringSolutions.LongestCommonSubsequence(lcsInput[0], lcsInput[1]).ToString();
            break;
        }
}
watch.Stop();
Console.WriteLine($"Result for {problems[input - 1]} problem is: {output}");
Console.WriteLine($"The code execution time was: {watch.ElapsedTicks} ticks.");
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

List<List<int>> LuckBalanceInput() => new List<List<int>>{
new List<int> {9709, 1},
new List<int> {9704, 1},
new List<int> {9080, 1},
new List<int> {9060, 1},
new List<int> {9467, 1},
new List<int> {9847, 1},
new List<int> {9590, 1},
new List<int> {9225, 1},
new List<int> {9304, 1},
new List<int> {9527, 1},
new List<int> {9329, 1},
new List<int> {9962, 1},
new List<int> {9928, 1},
new List<int> {9525, 1},
new List<int> {9491, 1},
new List<int> {9993, 1},
new List<int> {9829, 1},
new List<int> {9153, 1},
new List<int> {9936, 1},
new List<int> {9899, 1},
new List<int> {9312, 1},
new List<int> {9862, 1},
new List<int> {9610, 1},
new List<int> {9502, 1},
new List<int> {9522, 1},
new List<int> {9359, 1},
new List<int> {9617, 1},
new List<int> {9431, 1},
new List<int> {9757, 1},
new List<int> {9292, 1},
new List<int> {9875, 1},
new List<int> {9041, 1},
new List<int> {9626, 1},
new List<int> {9656, 1},
new List<int> {9893, 1},
new List<int> {9442, 1},
new List<int> {9369, 1},
new List<int> {9282, 1},
new List<int> {9117, 1},
new List<int> {9245, 1},
new List<int> {9841, 1},
new List<int> {9715, 1},
new List<int> {9778, 1},
new List<int> {9150, 1},
new List<int> {9738, 1},
new List<int> {9699, 1},
new List<int> {9642, 1},
new List<int> {9517, 1},
new List<int> {9407, 1},
new List<int> {9675, 1},
new List<int> {9918, 1},
new List<int> {9031, 1},
new List<int> {9369, 1},
new List<int> {9935, 1},
new List<int> {9868, 1},
new List<int> {9934, 1},
new List<int> {9660, 1},
new List<int> {9931, 1},
new List<int> {9273, 1},
new List<int> {9168, 1},
new List<int> {9404, 1},
new List<int> {9017, 1},
new List<int> {9288, 1},
new List<int> {9532, 1},
new List<int> {9700, 1},
new List<int> {9291, 1},
new List<int> {9126, 1},
new List<int> {9782, 1},
new List<int> {9545, 1},
new List<int> {9076, 1},
new List<int> {9346, 1},
new List<int> {9018, 1},
new List<int> {9732, 1},
new List<int> {9032, 1},
new List<int> {9992, 1},
new List<int> {9630, 1},
new List<int> {9952, 1},
new List<int> {9885, 1},
new List<int> {9328, 1},
new List<int> {9419, 1},
new List<int> {9705, 1},
new List<int> {9611, 1},
new List<int> {9440, 1},
new List<int> {9907, 1},
new List<int> {9303, 1},
new List<int> {9449, 1},
new List<int> {9876, 1},
new List<int> {9335, 1},
new List<int> {9723, 1},
new List<int> {9698, 1},
new List<int> {9823, 1},
new List<int> {9070, 1},
new List<int> {9258, 1},
new List<int> {9102, 1},
new List<int> {9370, 1},
new List<int> {9788, 1},
new List<int> {9725, 1},
new List<int> {9811, 1},
new List<int> {9474, 1},
new List<int> {9602, 1}
};