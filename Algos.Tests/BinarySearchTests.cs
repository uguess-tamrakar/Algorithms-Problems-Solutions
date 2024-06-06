using Algorithms;

namespace Algos.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        public required BinarySearch _search;

        [TestInitialize]
        public void Initialize()
        {
            _search = new();
        }

        [TestMethod]
        public void BinarySearch_ReturnsTargetIndex()
        {
            int[] arr = [5, 6, 7, 8, 9];
            int target = 9;
            int result = BinarySearch.SearchRecursive(0, arr.Length - 1, arr, target);
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void FindMinimumInRotatedSortedArrayRecursive_ReturnsMinimum()
        {
            List<int> arr = [3, 5, 7, 11, 13, 17, 19, 2];
            int result = BinarySearch.FindMinimumInRotatedSortedArray(arr);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void FindPeakInMountainArray_ReturnsIdx()
        {
            List<int> arr = [10, 10, 10, 100, 10, 5, 3, 1];
            int result = BinarySearch.PeakOfMountainArray(arr);
            Assert.AreEqual(result, 1);
        }
    }
}