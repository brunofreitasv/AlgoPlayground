using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class EquilibriumIndexTests : TestCases<int[], int>
    {
        public override string Name =>"Equilibrium Index";
        public override IAlgorithmImplementation<int[], int> Implementation => new EquilibriumIndex();
        public override IEnumerable<(int[] Input, int Expected)> Cases => new List<(int[], int)>
        {
            (new int[] { 1, 2, 0, 3 }, 2),
            (new int[] { 1, 1, 1, 1 }, -1),
            (new int[] { -7, 1, 5, 2, -4, 3, 0 }, 3)
        };
    }
}