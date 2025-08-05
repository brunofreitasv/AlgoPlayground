namespace AlgoPlayground.Algorithms.Arrays
{
    public class MinPlatformRequiredArrivalAndDeparture : IAlgorithmImplementation<(int[], int[]), int>
    {
        public int Run((int[], int[]) input)
        {
            (int[] arrivals, int[] departures) = input;

            Array.Sort(arrivals);
            Array.Sort(departures);

            int arrPointer = 0;
            int depPointer = 0;

            int maxPlatforms = 1;
            int trainCount = 0;

            while (arrPointer < arrivals.Length - 1 || depPointer < departures.Length - 2)
            {
                if (arrivals[arrPointer] < departures[depPointer])
                {
                    trainCount++;
                    arrPointer++;

                    if (trainCount > maxPlatforms)
                        maxPlatforms = trainCount;
                }
                else
                {
                    if(trainCount > 0)
                        trainCount--;
                    depPointer++;
                }
            }

            return maxPlatforms;
        }
    }
}
