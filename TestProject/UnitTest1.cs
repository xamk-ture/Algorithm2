using Algorithm2;

namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TestTwoSum(int[] nums, int target, int[] expected)
        {
            int[] result = Algorithms.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 3, 2, 4 }, new int[] { 1, 4 })]
        [InlineData(new int[] { -10, -20, 5, 1 }, new int[] { 0, 1 })]
        [InlineData(new int[] { 0, 2, 0, 2 }, new int[] { 1, 3 })]
        [InlineData(new int[] { -1, -3, -4, 2, 0 }, new int[] { 1, 2 })]
        public void TestMaxProduct(int[] nums, int[] expected)
        {
            int[] result = Algorithms.MaxProduct(nums);
            Assert.Equal(expected, result);
        }
    }
}