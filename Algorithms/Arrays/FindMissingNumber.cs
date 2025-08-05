namespace AlgoPlayground.Algorithms.Arrays
{
    public class FindMissingNumber : IAlgorithmImplementation<int[], int>
    {
        public int Run(int[] input)
        {
            int[] hash = new int[input.Length + 2];

            for (int i = 0; i < input.Length; i++)
            {
                var number = input[i];
                hash[number]++;
            }

            for (int i = 1; i < hash.Length; i++)
            {
                if (hash[i] == 0)
                    return i;
            }

            return -1;
        }
    }
}
