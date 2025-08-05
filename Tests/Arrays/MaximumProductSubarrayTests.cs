using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class MaximumProductSubarrayTests : TestCases<int[], int>
    {
        public override string Name =>"Maximum Product Subarray";
        public override IAlgorithmImplementation<int[], int> Implementation => new MaximumProductSubarray();
        public override IEnumerable<(int[] Input, int Expected)> Cases => new List<(int[], int)>
        {
            (new int[] { -2, 6, -3, -10, 0, 2 }, 180),
            (new int[] { -1, -3, -10, 0, 6 }, 30),
            (new int[] { 2, 3, 4 }, 24)
        };
    }
}