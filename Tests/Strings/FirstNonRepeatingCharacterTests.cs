using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Strings;

namespace AlgoPlayground.Tests.Strings
{
    public class FirstNonRepeatingCharacterTests : TestCases<string, char>
    {
        public override string Name =>"First Non-Repeating Character";
        public override IAlgorithmImplementation<string, char> Implementation => new FirstNonRepeatingCharacter();
        public override IEnumerable<(string Input, char Expected)> Cases => new List<(string, char)>
        {
            ("leetcode", 'l'),
            ("aabbccd", 'd'),
            ("aabbcc", '-'),
        };
    }
}