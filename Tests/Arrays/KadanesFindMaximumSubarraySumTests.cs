using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class KadanesFindMaximumSubarraySumTests : TestCases<int[], int>
    {
        public override string Name =>"Maximum Subarray Sum - Kadane's Algorithm";
        public override IAlgorithmImplementation<int[], int> Implementation => new KadanesFindMaximumSubarraySum();
        public override IEnumerable<(int[] Input, int Expected)> Cases => new List<(int[], int)>
        {
            (new int[] { 2, 3, -8, 7, -1, 2, 3 }, 11),
            (new int[] { -2, -4 }, -2),
            (new int[] { 5, 4, 1, 7, 8 }, 25)
        };
    }
}