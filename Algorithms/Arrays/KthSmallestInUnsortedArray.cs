namespace AlgoPlayground.Algorithms.Arrays
{
    public class KthSmallestInUnsortedArray : IAlgorithmImplementation<(int[], int), int>
    {
        public int Run((int[], int) input)
        {
            (int[] arr, int k) = input;

            return FindKthElement(arr, 0, arr.Length - 1, k - 1);
        }

        private int FindKthElement(int[] arr, int low, int high, int k)
        {
            int partition = partitions(arr, low, high);

            if (partition == k)
                return arr[k];
            else if (partition > k)
                return FindKthElement(arr, low, partition - 1, k);
            else
                return FindKthElement(arr, partition + 1, high, k);
        }
        
        private int partitions(int[] arr, int low, int high)
        {
            int pivot = arr[high], pivotloc = low, temp;
            for (int i = low; i <= high; i++)
            {
                if (arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotloc];
                    arr[pivotloc] = temp;
                    pivotloc++;
                }
            }

            temp = arr[high];
            arr[high] = arr[pivotloc];
            arr[pivotloc] = temp;

            return pivotloc;
        }
    }
}
