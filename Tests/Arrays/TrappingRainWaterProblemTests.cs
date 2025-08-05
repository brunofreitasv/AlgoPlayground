using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class TrappingRainWaterProblemTests : TestCases<int[], int>
    {
        public override string Name =>"Trapping Rain Water Problem";
        public override IAlgorithmImplementation<int[], int> Implementation => new TrappingRainWaterProblem();
        public override IEnumerable<(int[] Input, int Expected)> Cases => new List<(int[], int)>
        {
            (new int[] { 3, 0, 1, 0, 4, 0, 2 }, 10),
            (new int[] { 3, 0, 2, 0, 4 }, 7),
            (new int[] { 1, 2, 3, 4 }, 0)
        };
    }
}