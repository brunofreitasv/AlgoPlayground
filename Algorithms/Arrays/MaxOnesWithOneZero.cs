namespace AlgoPlayground.Algorithms.Arrays
{
    public class MaxOnesWithOneZero : IAlgorithmImplementation<int[], int>
    {
        public int Run(int[] input)
        {
            int secondPointer = 0;
            int maxSize = 0;
            int currentZeroCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0) currentZeroCount++;
                
                while (currentZeroCount > 1)
                {
                    if (input[secondPointer] == 0) currentZeroCount--;
                    secondPointer++;
                }

                maxSize = Math.Max(maxSize, i - secondPointer + 1);
            }

            return maxSize;
        }
    }
}
