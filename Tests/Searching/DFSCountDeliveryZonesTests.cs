using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Searching;

namespace AlgoPlayground.Tests.Searching
{
    public class DFSCountDeliveryZonesTests : TestCases<int[,], int>
    {
        public override string Name =>" DFS - Count Delivery Zones";
        public override IAlgorithmImplementation<int[,], int> Implementation => new DFSCountDeliveryZones();
        public override IEnumerable<(int[,] Input, int Expected)> Cases => new List<(int[,], int)>
        {
            (new int[,] {
                {1, 1, 0},
                {0, 1, 0},
                {1, 0, 1}
            }, 3),
            (new int[,] {
                {0, 0, 0},
                {0, 0, 0},
                {0, 0, 0}
            }, 0),
            (new int[,] {
                {1, 0, 1, 0},
                {0, 1, 0, 1},
                {1, 0, 1, 0}
            }, 6),
            (new int[,] {
                {1, 0, 0, 1},
                {0, 0, 0, 0},
                {1, 0, 0, 1}
            }, 4),
            (new int[,] {
                {0, 1, 0},
                {0, 1, 0},
                {1, 1, 0}
            }, 1),
            (new int[,] {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            }, 3),
             (new int[,] {
                {1, 1},
                {1, 1}
            }, 1),
        };
    }
}