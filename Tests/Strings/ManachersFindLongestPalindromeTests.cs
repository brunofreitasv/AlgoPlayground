using AlgoPlayground.Algorithms;
using AlgoPlayground.Algorithms.Strings;

namespace AlgoPlayground.Tests.Strings
{
    public class ManachersFindLongestPalindromeTests : TestCases<string, string>
    {
        public override string Name =>"Manachers Find Longest Palindrome";
        public override IAlgorithmImplementation<string, string> Implementation => new ManachersFindLongestPalindrome();
        public override IEnumerable<(string Input, string Expected)> Cases => new List<(string, string)>
        {
            ("forgeeksskeegfor", "geeksskeeg"),
            ("Geeks", "ee"),
            ("abc", "a"),
        };
    }
}