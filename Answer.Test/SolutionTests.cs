using Answer;
using NUnit.Framework;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase(10, 9, 2, 5, 3, 7, 101, 18, ExpectedResult = 4)]
        public int LengthOfLIS(params int[] nums)
        {
            var sut = new Solution();
            return sut.LengthOfLIS(nums);
        }
    }
}