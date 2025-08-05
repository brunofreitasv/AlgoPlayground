using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Arrays;

namespace AlgoPlayground.Tests.Arrays
{
    public class MinPlatformRequiredArrivalAndDepartureTests : TestCases<(int[], int[]), int>
    {
        public override string Name =>"Minimum Platforms Required for Given Arrival and Departure Times";
        public override IAlgorithmImplementation<(int[], int[]), int> Implementation => new MinPlatformRequiredArrivalAndDeparture();
        public override IEnumerable<((int[], int[]) Input, int Expected)> Cases => new List<((int[], int[]), int)>
        {
            ((new int[] { 900, 940, 950, 1100, 1500, 1800 }, new int[] { 910, 1200, 1120, 1130, 1900, 2000 }), 3),
            ((new int[] { 1,  5 }, new int[] { 3, 7 }), 1)
        };
    }
}