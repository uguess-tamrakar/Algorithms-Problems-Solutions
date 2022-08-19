// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using static BinarySearchTree;
using static Solutions;

Console.WriteLine();

BinarySearchTree bst = new BinarySearchTree();
DynamicProgramming dp = new DynamicProgramming();
Strings stringSolutions = new Strings();
Integers integerSolutions = new Integers();
LinkedLists linkedLists = new LinkedLists();
ArraysLists arraySolutions = new ArraysLists();
Matrix matrix = new Matrix();
Sorting sorter = new Sorting();
Miscellaneous misc = new Miscellaneous();
WeightedGraph weightedGraph = new WeightedGraph();

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
    case nameof(Sorting.SelectionSort):
        output = $"[{string.Join(", ", sorter.SelectionSort(new int[] { 12, -7, 14, 9, -10, 0 }))}]";
        break;
    case nameof(Sorting.InsertionSort):
        output = $"[{string.Join(", ", sorter.InsertionSort(new int[] { 12, -7, 14, 9, -10, 0 }))}]";
        break;
    case nameof(Sorting.MergeSort):
        output = $"[{string.Join(", ", sorter.MergeSort(new int[] { 12, -7, 14, 9, -10, 0 }))}]";
        break;
    case nameof(Sorting.QuickSort):
        output = $"[{string.Join(", ", sorter.QuickSort(new int[] { 9, 7, 5, 11, 12, 2, 14, 3, 10, 4, 6 }))}]";
        break;
    case nameof(Graph<int>.GraphBreadthFirstSearch):
        var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var edges = new[] { Tuple.Create(1, 2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

        var graph = new Graph<int>(vertices, edges);
        output = $"[{string.Join(", ", graph.GraphBreadthFirstSearch(1))}]";
        break;
    case nameof(Graph<int>.GraphShortestPath):
        var verticesI = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var edgesI = new[] { Tuple.Create(1, 2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

        var graphI = new Graph<int>(verticesI, edgesI);
        output = $"[{string.Join(", ", graphI.GraphShortestPath(1, 8))}]";
        break;
    case nameof(Graph<int>.GraphDepthFirstSearch):
        var verticesII = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var edgesII = new[] { Tuple.Create(1, 2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

        var graphII = new Graph<int>(verticesII, edgesII);
        output = $"[{string.Join(", ", graphII.GraphDepthFirstSearch(1))}]";
        break;
    case nameof(Graph<int>.GraphDepthFirstSearchRecursive):
        var verticesIII = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var edgesIII = new[] { Tuple.Create(1, 2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

        var graphIII = new Graph<int>(verticesIII, edgesIII);
        output = $"[{string.Join(", ", graphIII.GraphDepthFirstSearchRecursive(1))}]";
        break;
    case nameof(WeightedGraph.DijkstraShortestPath):
        int[,] graphMatrix = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
        output = $"[{string.Join(", ", weightedGraph.DijkstraShortestPath(graphMatrix, 0))}]";
        break;
    case nameof(LinkedLists.LinkedListInsertAndSort):
        ListNode linkedList = new ListNode(1, new ListNode(2, new ListNode(5)));
        linkedLists.LinkedListInsertAndSort(linkedList, new ListNode(4));
        linkedLists.LinkedListInsertAndSort(linkedList, new ListNode(3));
        linkedLists.LinkedListInsertAndSort(linkedList, new ListNode(9));
        linkedLists.LinkedListInsertAndSort(linkedList, new ListNode(7));
        printListNode(linkedList);
        break;
    case nameof(ArraysLists.MaxSubArraySum):
        output = arraySolutions.MaxSubArraySum(new int[] { -1, -2, -3, -4 }).ToString();
        break;
    case nameof(ArraysLists.TrappingWater):
        output = arraySolutions.TrappingWater(new int[] { 1, 1, 5, 2, 7, 6, 1, 4, 2, 3 }).ToString();
        break;
    case nameof(ArraysLists.SumZeroTriplets):
        output = arraySolutions.SumZeroTriplets(new int[] { 60, -65, 5, -21, 8, 93 }, 6).ToString();
        break;
    case nameof(ArraysLists.MinimumTrainPlatforms):
        output = arraySolutions.MinimumTrainPlatforms(
            new int[] { 1026, 0445, 0145, 0555, 0710, 1712, 1105, 0506, 0531, 1930, 0220, 0611, 0553, 0053, 0401, 2000, 0225, 1359, 1159, 0120, 1857, 0740, 0253, 0303, 0740, 1434, 1407, 0807, 0423, 0500, 0851, 0809, 0527, 0123, 1117, 0023, 1050, 1613, 1025, 1225, 0826, 0422, 0221, 0028, 0515, 0401, 1241, 0038, 0315, 1007, 0508, 1054, 0803, 0333, 0011, 0225, 0137, 0030, 0344, 0036, 0841, 1419, 0552, 0422, 0337, 1222, 1422, 0010, 0258, 1434, 0538, 0153, 0808, 0347, 0104, 1136, 0302, 0357, 0938, 2015, 0403, 0258, 0736, 1057, 1547, 0531, 1642, 2333, 0511, 1301, 1059, 0638, 0117, 0314, 0905, 1314, 1103, 0356, 0006, 0235, 1209, 0849, 0304, 0539, 0921, 0625, 0741, 0047, 0055, 0127, 0003, 0053, 0608, 1725, 1431, 1427, 0814, 0935, 1435, 0938, 0448, 0930, 0549, 1002, 0909, 0329, 1203, 0824, 0212, 0852, 1825, 0541, 1136, 0825, 0110, 1301, 1619, 0031, 0037, 0140, 0443, 0831, 1220, 0346, 1242, 1414, 1702, 0113, 0901, 1221, 0742, 0941, 0711, 0825, 0220, 1526, 0125, 0006, 1418, 1632, 1020, 1957, 0711, 0552, 0430, 0157, 0359, 0212, 1150, 2212, 0857, 1351, 1531, 0219, 0006, 0813, 0141, 1730, 0458, 0911, 1201, 0218, 0441, 1121, 0216, 0501, 0528, 1049, 0158, 0646, 1303, 0018, 0123, 1408, 1750, 0604, 1042, 0001, 1049, 0343, 0821, 0154, 0139, 1138, 1138, 2107, 0318, 0556, 1259, 0044, 0457, 0116, 1555, 1546, 0525, 1648, 1612, 0504, 1218, 2231, 1408, 0922, 1253, 0353, 0759, 0727, 0817, 0015, 0650, 0519, 1723, 1329, 0357, 0839, 0440, 0824, 0805, 1524, 0943, 0116, 0937, 0740, 0357, 1023, 0314, 0931, 1844, 1639, 0232, 0023, 0549, 0028, 1135, 1220, 0449, 0925, 1112, 1652, 0609, 2316, 1205, 0133, 0223, 0543, 1004, 1426, 0814, 0422, 1134, 0228, 0832, 0641, 1643, 1339, 1725, 1023, 1017, 1642, 0627, 0642, 0934, 1349, 0624, 1411, 0246, 0508, 1113, 0955, 0014, 0258, 0502, 0749, 1423, 0400, 0809, 0157, 2100, 0120, 0935, 1417, 1204, 1016, 0144, 0724, 1221, 0207, 1745, 1905, 0333, 0324, 1407, 1537, 1246, 1543, 0226, 1031, 1045, 1325, 0957, 0419, 0528, 0419, 1239, 0131, 0452, 0834, 0003, 0430, 0544, 0348, 0538, 0952, 1956, 0024, 1140, 0407, 0800, 0026, 1101, 1301, 0838, 0555, 0816, 0130, 1645, 0025, 0013, 0136, 0810, 1624, 0819, 0811, 1138, 0622, 1643, 1113, 1434, 1311, 1501, 0847, 0950, 0356, 0305, 1825, 1135, 0946, 1550, 0211, 0835, 0539, 0335, 1123, 0904, 0938, 0812, 1339, 1921, 1511, 0709, 0130, 1222, 0820, 0405, 0330, 1254, 0432, 0130, 0033, 0254, 0826, 0343, 0830, 1708, 0657, 1149, 1148, 0406, 1204, 1253, 1006, 0421, 0258, 2022, 1027, 0110, 1426, 0458, 0128, 0039, 0537, 0737, 1938, 0849, 0424, 1332, 0140, 1123, 0103, 0250, 0600, 0749, 0247, 1243, 0108, 0138, 1119, 0443, 0409, 0343, 0654, 0413, 0658, 0333, 0022, 0739, 0453, 0051, 0104, 0240, 1201, 1328, 0208, 0242, 1020, 1305, 0708, 0630, 1314, 1018, 1104, 2137, 0224, 1051, 0543, 0838, 0539, 0606, 0949, 1435, 1034, 0402, 1105, 0936, 0530, 0946, 1629, 1641, 0744, 0023, 0508, 0036, 0300, 0756, 0302, 0733, 0600, 2009, 0804, 0653, 1312, 0024, 1217, 0345, 0301, 1450, 0103, 1512, 0905, 0000, 0012, 0854, 0451, 0317, 0336, 0125, 0400, 0829, 0202, 0927, 0257, 0511, 0406, 1548, 0453, 1518, 1057, 2016, 0522, 0938, 0346, 0536, 1723, 0531, 0727, 0232, 1050, 0155, 0738, 2012, 0957, 0555, 0504, 0652, 1301, 0522, 0351, 0136, 0511, 0334, 0410, 0933, 0805, 1603, 1808, 0105, 0325, 1814, 0024, 0552, 0401, 0041, 1412, 0800, 0133, 0007, 0755, 2005, 1258, 1034, 1215, 0014, 1553, 0807, 0310, 1416, 0246, 0243, 0026, 0857, 2157, 1605, 0555, 1322, 0253, 1130, 0702, 1350, 0050, 0105, 0345, 0121, 0350, 0300, 1616, 0448, 1008, 0737, 0629, 0700, 0945, 0045, 0817, 1947, 0549, 1451, 1732, 0935, 0135, 0132, 0408, 1407, 1801, 1640, 0050, 0313, 0021, 0308, 1320, 1207, 2216, 1918, 0111, 0348, 0621, 0030, 0842, 0818, 0028, 1056, 1941, 1635, 1111, 0508, 0420, 0139, 1036, 0717, 1250, 0320, 0536, 0018, 0156, 0808, 1754, 0451, 0432, 0236, 1128, 0912, 1326, 1525, 0526, 0355, 0439, 0223, 1702, 2109, 0503, 1629, 0224, 0107, 1649, 1338, 0722, 0840, 0923, 0001, 0144, 0102, 1128, 0839, 0329, 0443, 1402, 1132, 0226, 0422, 0456, 0157, 1126, 0458, 1114, 0600, 0012, 0301, 0313, 1213, 0210, 1110, 0205, 0034, 0042, 0320, 0313, 0101, 0253, 0301, 0311, 1539, 1911, 0835, 1556, 1049, 0017, 0530, 1604, 0002, 0410, 0117, 0428, 1638, 0930, 0349, 0708, 1327, 0118, 0929, 0402, 0437, 2143, 0424, 0751, 0230, 2321, 0030, 1555, 1446, 0404, 1135, 0914, 1305, 0215, 0455, 0356, 1216, 0302, 0815, 1357, 0952, 1051, 0036, 0059, 0030, 0147, 0403, 1720, 0722, 1509, 0423, 0207, 0428, 0214, 1227, 0448, 0111, 0206, 0248, 0313, 0246, 0424, 1416, 0738, 1240, 0558, 1625, 0548, 0739, 0134, 0704, 0656, 0836, 0302, 0553, 0105, 0101, 0115, 1438, 0208, 0244, 1503, 1231, 1619, 0616, 0934, 1524, 0800, 0740, 1146, 0347, 1002, 1550, 0943, 0657, 0256, 0559, 0234, 0745, 1002, 0709, 0801, 0345, 1138, 0536, 2214, 0659, 0427, 0850, 0145, 1938, 0726, 0328, 0407, 1512, 0358, 0439, 0538, 0326, 2305, 0015, 0854, 1636, 0403, 1556, 0218, 1139, 1319, 1042, 0216, 1103, 0206, 1519, 0920, 0228, 0203, 0444, 0911 }, 
            new int[] { 1713, 2242, 1144, 0848, 1941, 1734, 2347, 1726, 2247, 2018, 0355, 2249, 2134, 0758, 2044, 2354, 0237, 2152, 1221, 0532, 2031, 0820, 1013, 2311, 2150, 2321, 1909, 2344, 1732, 2127, 2126, 1602, 0945, 0705, 1632, 1305, 1604, 1639, 1630, 1334, 1858, 2131, 0350, 1625, 1443, 0926, 1245, 1802, 1558, 1406, 1442, 2024, 1450, 0703, 0508, 1341, 1445, 1624, 1414, 2143, 1306, 1808, 0845, 1717, 1928, 1620, 1631, 1101, 2146, 2153, 1524, 2306, 0944, 0702, 1219, 1318, 1431, 2044, 1616, 2106, 1631, 0841, 1128, 1732, 1957, 0719, 2052, 2342, 2016, 1348, 1505, 0957, 1749, 0509, 2140, 1515, 2114, 1245, 1806, 1439, 1951, 2341, 0518, 2315, 2304, 1117, 1701, 1837, 0346, 2200, 0118, 1537, 0714, 1757, 2237, 2139, 2103, 1707, 2031, 1848, 1623, 2105, 2125, 1205, 1730, 0512, 1928, 1816, 2250, 1624, 1828, 1227, 2308, 1044, 0809, 1636, 2101, 0321, 0121, 1237, 1157, 1633, 1731, 2050, 1419, 1724, 2155, 0705, 2109, 2343, 0844, 2246, 2037, 1452, 1131, 2135, 1441, 0549, 1810, 2039, 2306, 2215, 1057, 0739, 2323, 1250, 1024, 1856, 2152, 2238, 2323, 1855, 1920, 0454, 1008, 2059, 1556, 2202, 1645, 2320, 1843, 1812, 1011, 2052, 1639, 1555, 2234, 2025, 1502, 2224, 1742, 0957, 1527, 2110, 1929, 1712, 2159, 0239, 2113, 1841, 2211, 1221, 1028, 2124, 1614, 2139, 2240, 0926, 1527, 1839, 0721, 2316, 1931, 1648, 0817, 1707, 2002, 0921, 2342, 2336, 1842, 2257, 1925, 0827, 1800, 1349, 1949, 1242, 0906, 1954, 1732, 1721, 2010, 2349, 2034, 1527, 1328, 2000, 2130, 1804, 1745, 1105, 1406, 2245, 1649, 1411, 2300, 2330, 0713, 0553, 2329, 0632, 1556, 1942, 1446, 1510, 1253, 2341, 1532, 2322, 1810, 0445, 1953, 1619, 1436, 2145, 1115, 0715, 1245, 2126, 1834, 2101, 2326, 1850, 1736, 1346, 1914, 1806, 0727, 2249, 1611, 1700, 1410, 1910, 1831, 1355, 2136, 2157, 0229, 0446, 1022, 1914, 1709, 1717, 1442, 1748, 2156, 0651, 1424, 1951, 2304, 1154, 2200, 1059, 1510, 2047, 2142, 2013, 1303, 0901, 2134, 1927, 1256, 2205, 0709, 2129, 1602, 1336, 1045, 0821, 2352, 1559, 1626, 1224, 0627, 2134, 1348, 1827, 1508, 1001, 1051, 1546, 2101, 1934, 2011, 2339, 1807, 0953, 2005, 1542, 2144, 1448, 2203, 0452, 1934, 1309, 0622, 0853, 1814, 1812, 1557, 2039, 1920, 1627, 2149, 1955, 1519, 1312, 1702, 2252, 1107, 1049, 0420, 2128, 1717, 2146, 1751, 1413, 2335, 1815, 0817, 1907, 2211, 1023, 2318, 1423, 1957, 1616, 2012, 2308, 1259, 2114, 0808, 1527, 2135, 1638, 1956, 0408, 0655, 1346, 0527, 1248, 2055, 2235, 1358, 1501, 0907, 2101, 2244, 2108, 0929, 2200, 2056, 1532, 0256, 1900, 2218, 1358, 0214, 1414, 1105, 2311, 1232, 0611, 1848, 1543, 1459, 0743, 1143, 1905, 2241, 1758, 1446, 0136, 2323, 1705, 2057, 0504, 2029, 1708, 1642, 1945, 0926, 0802, 1821, 1028, 1145, 1527, 1531, 1419, 1730, 0243, 0324, 2131, 2117, 2022, 1426, 1836, 1540, 1319, 2337, 2304, 1948, 1607, 1220, 1407, 1804, 2209, 2025, 1412, 1729, 2134, 1353, 0905, 1529, 1647, 2345, 0848, 0835, 0947, 1710, 1325, 1519, 2255, 0803, 1008, 2048, 2005, 1952, 2328, 1717, 1523, 2043, 2141, 1711, 1030, 2211, 1522, 0202, 0043, 1022, 1848, 1457, 1313, 0448, 0722, 1601, 2005, 1042, 1802, 2114, 1145, 2253, 2209, 2210, 1705, 2128, 0624, 1345, 1648, 2009, 2242, 1248, 2214, 1019, 2020, 1447, 2144, 2119, 2056, 2356, 1646, 1002, 2331, 0657, 0428, 0422, 0608, 1149, 2047, 1900, 1241, 2358, 2201, 0755, 1351, 2317, 1623, 2205, 1518, 2210, 1518, 1657, 1838, 2026, 0822, 2203, 1449, 1639, 1313, 2241, 1814, 1023, 1611, 1626, 0708, 1743, 0125, 2302, 2254, 2143, 1922, 1710, 0604, 1204, 2020, 1414, 1947, 0409, 1747, 0626, 0751, 1729, 1710, 2334, 2304, 1750, 0839, 1120, 1929, 1640, 1605, 1951, 1433, 1607, 2306, 1343, 2203, 0622, 2341, 1705, 1905, 2318, 1218, 1946, 1354, 0344, 1803, 1858, 2229, 2237, 2303, 0946, 1420, 1956, 1118, 2246, 1957, 1738, 2038, 2217, 1217, 1236, 0836, 1816, 1744, 0832, 1932, 2300, 2037, 1304, 0514, 1004, 2257, 1722, 2112, 1221, 2035, 1956, 1918, 1833, 2225, 1823, 1505, 1952, 2343, 2110, 1611, 2024, 0233, 1220, 1935, 1750, 1457, 1212, 1003, 1126, 1034, 0454, 1922, 1714, 2323, 1619, 1446, 1943, 1543, 2243, 1114, 0840, 2212, 2316, 1258, 1126, 0629, 0514, 1416, 1608, 1821, 1442, 0842, 1554, 1251, 1231, 1030, 1804, 2051, 2339, 0714, 2109, 2232, 1423, 2351, 1853, 1919, 1637, 2250, 1155, 2106, 2029, 1646, 2330, 1719, 2153, 1156, 1925, 0417, 2039, 1118, 2131, 2238, 2355, 1730, 2142, 2357, 1210, 1956, 1626, 0611, 1409, 2256, 2243, 1157, 2324, 1509, 2001, 1022, 1845, 2333, 2255, 1305, 0935, 0646, 0113, 1348, 2333, 2304, 1522, 2207, 2018, 0408, 1657, 1757, 1547, 1404, 0849, 1549, 2102, 0331, 1622, 1827, 2135, 2307, 1635, 1137, 1805, 0945, 1822, 2027, 1657, 0954, 2358, 0340, 0850, 1720, 0811, 0715, 2121, 1826, 1626, 2004, 1405, 1931, 2246, 2047, 2218, 1022, 1439, 1401, 1900, 2130, 2328, 2119, 1851, 0428, 1235, 1811, 1040, 1906, 2212, 1937, 1405, 2210, 0710, 2359, 1021, 0759, 1406, 0312, 2110, 1238, 0839, 2110, 2021, 0854, 0850, 0912, 2329, 2350, 1253, 1802, 2114, 0632, 2350, 0900, 2204, 1853, 1419, 1038, 1556, 0259, 1601, 1738, 1701, 2302, 2140, 1147 }, 
            816).ToString();
        break;
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

void printListNode(ListNode listNode)
{
    ListNode current = listNode;
    if (current != null)
    {
        Console.Write(current.val);
        current = current.next;
        while (current != null)
        {
            Console.Write($"-> {current.val}");
            current = current.next;
        }
        Console.WriteLine();
    }
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