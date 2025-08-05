namespace AlgoPlayground.Algorithms.Arrays
{
    public class LeadersInAnArray : IAlgorithmImplementation<int[], int[]>
    {
        public int[] Run(int[] input)
        {
            int size = input.Length;
            int currentSum = input[size - 1];
            List<int> result = new List<int> { currentSum };

            for (int i = size - 2; i >= 0; i--)
            {
                int currentValue = input[i];
                if (currentValue >= currentSum)
                {
                    result.Insert(0, currentValue);
                }

                currentSum += currentValue;
            }

            return result.ToArray();
        }
    }
}
