namespace AlgoPlayground.Algorithms.Arrays
{
    public class MaximumProductSubarray : IAlgorithmImplementation<int[], int>
    {
        public int Run(int[] input)
        {
            int currentMax = 1;
            int currentMin = 1;
            int maxProduct = 1;

            for (int i = 0; i < input.Length; i++)
            {
                int tempMax = Math.Max(input[i], Math.Max(currentMax * input[i], currentMin * input[i]));
                currentMin = Math.Min(input[i], Math.Min(currentMax * input[i], currentMin * input[i]));
                currentMax = tempMax;
                maxProduct = Math.Max(currentMax, maxProduct);
            }

            return maxProduct;
        }
    }
}
