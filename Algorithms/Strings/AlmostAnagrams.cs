namespace AlgoPlayground.Algorithms.Strings
{
    public class AlmostAnagrams : IAlgorithmImplementation<(string, string), bool>
    {
        public bool Run((string, string) input)
        {
            (string firstWord, string secondWord) = input;

            var frequencyMap = new Dictionary<char, int>();

            foreach (char c in firstWord.ToCharArray())
            {
               frequencyMap[c] = frequencyMap.ContainsKey(c) ? frequencyMap[c] + 1 : 1;
            }

            foreach (char c in secondWord.ToCharArray())
            {
                frequencyMap[c] = frequencyMap.ContainsKey(c) ? frequencyMap[c] - 1 : -1;
            }

            int diffSum = 0;
            foreach (var c in frequencyMap)
            {
                diffSum += Math.Abs(c.Value);
            }

            return diffSum <= 2;
        }
    }
}
