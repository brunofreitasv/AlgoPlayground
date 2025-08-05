namespace AlgoPlayground.Algorithms.Arrays
{
    public class KadanesFindMaximumSubarraySum : IAlgorithmImplementation<int[], int>
    {
        public int Run(int[] input)
        {
            int maxSum = input[0];
            int result = input[0];

            for (int i = 1; i <= input.Length-1; i++)
            {
                if (maxSum + input[i] < input[i])
                    maxSum = input[i];
                else
                    maxSum += input[i];

                if (maxSum > result)
                    result = maxSum;
            }

            return result;
        }
    }
}
