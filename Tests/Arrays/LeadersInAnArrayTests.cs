using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class LeadersInAnArrayTests : TestCases<int[], int[]>
    {
        public override string Name => "Leaders In An Array";
        public override IAlgorithmImplementation<int[], int[]> Implementation => new LeadersInAnArray();
        public override IEnumerable<(int[] Input, int[] Expected)> Cases => new List<(int[], int[])>
        {
            (new int[] { 16, 17, 4, 3, 5, 2 }, new int[] { 17, 5, 2}),
            (new int[] { 1, 2, 3, 4, 5, 2 }, new int[] {5,2})
        };
    }
}