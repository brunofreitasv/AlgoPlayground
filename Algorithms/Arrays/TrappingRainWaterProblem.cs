namespace AlgoPlayground.Algorithms.Arrays
{
    public class TrappingRainWaterProblem : IAlgorithmImplementation<int[], int>
    {
        public int Run(int[] input)
        {
            int result = 0;

            int leftPointer = 1;
            int rightPointer = input.Length - 2;

            int leftMax = input[0];
            int rightMax = input[input.Length - 1];

            while (leftPointer <= rightPointer)
            {
                if (leftMax < rightMax)
                {
                    if (leftMax > input[leftPointer])
                        result += leftMax - input[leftPointer];
                    else
                        leftMax = input[leftPointer];

                    leftPointer++;
                }
                else
                {
                    if (rightMax > input[rightPointer])
                        result += rightMax - input[rightPointer];
                    else
                        rightMax = input[rightPointer];

                    rightPointer--;
                }
            }

            return result;
        }
    }
}
