using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Strings;

namespace AlgoPlayground.Tests.Strings
{
    public class AlmostAnagramsTests : TestCases<(string, string), bool>
    {
        public override string Name =>"Almost Anagrams";
        public override IAlgorithmImplementation<(string, string), bool> Implementation => new AlmostAnagrams();
        public override IEnumerable<((string, string) Input, bool Expected)> Cases => new List<((string, string), bool)>
        {
            (("heart", "earth"), true),
            (("heart", "earths"), true),
            (("heart", "ears"), false)
        };
    }
}