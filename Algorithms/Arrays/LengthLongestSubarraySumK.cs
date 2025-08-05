namespace AlgoPlayground.Algorithms.Arrays
{
    public class LengthLongestSubarraySumK : IAlgorithmImplementation<(int[], int), int>
    {
        public int Run((int[], int) input)
        {
            (int[] nums, int k) = input;

            int maxLength = 0;
            int currentSum = 0;
            Dictionary<int, int> sumMapping = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];

                if (currentSum == k)
                    maxLength = i + 1;

                if (sumMapping.ContainsKey(currentSum - k))
                    maxLength = Math.Max(maxLength, i - sumMapping[currentSum - k]);

                if(!sumMapping.ContainsKey(currentSum))
                    sumMapping[currentSum] = i;
            }

            return maxLength;
        }
    }
}
