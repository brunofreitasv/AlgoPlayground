
namespace AlgoPlayground.Algorithms.Searching
{
    public class DFSCountDeliveryZones : IAlgorithmImplementation<int[,], int>
    {
        public int Run(int[,] input)
        {
            int[,] map = new int[input.GetLength(0), input.GetLength(1)];
            Array.Copy(input, map, input.Length);

            int deliveryZones = 0;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 1)
                    {
                        deliveryZones++;
                        Search(map, i, j);
                    }
                }
            }

            return deliveryZones;
        }

        private void Search(int[,] map, int i, int j)
        {
            map[i, j] = 0; //mark as visited

            int[] dx = new int[] { -1, 1, 0, 0 };
            int[] dy = new int[] { 0, 0, -1, 1 };

            for (int z = 0; z < dx.Length; z++)
            {
                int rowIndex = Math.Max(0, Math.Min(i + dx[z], map.GetLength(0) -1));
                int columnIndex = Math.Max(0, Math.Min(j + dy[z], map.GetLength(1) -1));

                if (map[rowIndex, columnIndex] == 1)
                    Search(map, rowIndex, columnIndex);
            }
        }
    }
}
