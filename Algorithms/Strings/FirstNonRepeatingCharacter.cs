namespace AlgoPlayground.Algorithms.Strings
{
    public class FirstNonRepeatingCharacter : IAlgorithmImplementation<string, char>
    {
        public char Run(string input)
        {
            var frequencyMap = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (!frequencyMap.ContainsKey(c))
                    frequencyMap[c] = 0;

                frequencyMap[c]++;
            }

            foreach (char c in input)
            {
                if (frequencyMap[c] == 1)
                    return c;
            }

            return '-';
        }
    }
}
