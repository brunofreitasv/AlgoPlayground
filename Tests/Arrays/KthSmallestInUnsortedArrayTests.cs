using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class KthSmallestInUnsortedArrayTests : TestCases<(int[], int), int>
    {
        public override string Name =>"K'th Smallest Element in Unsorted Array";
        public override IAlgorithmImplementation<(int[], int), int> Implementation => new KthSmallestInUnsortedArray();
        public override IEnumerable<((int[], int) Input, int Expected)> Cases => new List<((int[], int), int)>
        {
            ((new int[] { 7, 10, 4, 3, 20, 15 }, 3), 7),
            ((new int[] { 7, 10, 4, 3, 20, 15 }, 4), 10),
        };
    }
}