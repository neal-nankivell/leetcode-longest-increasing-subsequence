using Answer;
using NUnit.Framework;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase(10, 9, 2, 5, 3, 7, 101, 18, ExpectedResult = 4)]
        [TestCase(ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(3, 2, ExpectedResult = 1)]
        [TestCase(10, 5, 11, ExpectedResult = 2)]
        public int LengthOfLIS(params int[] nums)
        {
            var sut = new Solution();
            return sut.LengthOfLIS(nums);
        }
    }
}