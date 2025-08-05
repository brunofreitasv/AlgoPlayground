using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class LengthLongestSubarraySumKTests : TestCases<(int[], int), int>
    {
        public override string Name =>"Length of the Longest Subarray Sum K";
        public override IAlgorithmImplementation<(int[], int), int> Implementation => new LengthLongestSubarraySumK();
        public override IEnumerable<((int[], int) Input, int Expected)> Cases => new List<((int[], int), int)>
        {
            ((new int[] { 1, -1, 5, -2, 3 }, 5), 4),
            ((new int[] { -2, -1, 2, 1 }, 1), 2),
            ((new int[] { 1,2,3 }, 7), 0),
        };
    }
}