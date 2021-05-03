using NUnit.Framework;
using SimpleSearchCore;

namespace UnitTest
{
    public class Tests
    {
        Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        [TestCase(new int[] {1,3,5,6,7,9,12,30},12,6)]
        [TestCase (new int[] { 2,10,20},10,1)]
        public void BinarySearchTes(int[] nums ,int tarket,int expected)
        {
            int result = solution.BinarySearch(nums,tarket);
            Assert.AreEqual(expected, result);
        }
    }
}