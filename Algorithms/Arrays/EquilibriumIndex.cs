namespace AlgoPlayground.Algorithms.Arrays
{
    public class EquilibriumIndex : IAlgorithmImplementation<int[], int>
    {
        public int Run(int[] input)
        {
            int leftSum = 0;
            int totalSum = 0;

            foreach (int item in input)
                totalSum += item;

            for (int i = 0; i < input.Length; i++)
            {
                int rightSum = totalSum - input[i] - leftSum;

                if (leftSum == rightSum)
                    return i;

                leftSum += input[i];
            }

            return -1;
        }
    }
}
