using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class FindMissingNumberTests : TestCases<int[], int>
    {
        public override string Name =>"Find the Missing Number";
        public override IAlgorithmImplementation<int[], int> Implementation => new FindMissingNumber();
        public override IEnumerable<(int[] Input, int Expected)> Cases => new List<(int[], int)>
        {
            (new int[] { 8, 2, 4, 5, 3, 7, 1 }, 6),
            (new int[] { 1, 2, 3, 5 }, 4)
        };
    }
}