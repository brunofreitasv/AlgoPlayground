using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class MaxOnesWithOneZeroTests : TestCases<int[], int>
    {
        public override string Name =>"Max Ones With One Zero";
        public override IAlgorithmImplementation<int[], int> Implementation => new MaxOnesWithOneZero();
        public override IEnumerable<(int[] Input, int Expected)> Cases => new List<(int[], int)>
        {
            (new int[] { 1,1,0,1,1,1,0,1 }, 6),
            (new int[] { 1, 1, 1, 1 }, 4),
            (new int[] {1, 1, 0, 1 }, 4),
            (new int[] {0, 1, 1, 1 }, 4),
            (new int[] {1, 1, 0, 0, 1, 1 }, 3),
            (new int[] {1, 1, 1, 0 }, 4),
            (new int[] {1, 0, 1, 0, 1, 1 }, 4)
        };
    }
}