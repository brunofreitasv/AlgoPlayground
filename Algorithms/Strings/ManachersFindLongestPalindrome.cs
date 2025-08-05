

namespace AlgoPlayground.Algorithms.Strings
{
    public class ManachersFindLongestPalindrome : IAlgorithmImplementation<string, string>
    {
        public string Run(string input)
        {
            string preprocessed = ManacherPreprocess(input);
            int[] radiusArray = RunManacher(preprocessed);

            int maxLen = 1;
            int startIndex = 0;

            for (int i = 0; i < input.Length; ++i) {
                int oddLen = GetLongest(radiusArray, i, 1);
                if (oddLen > maxLen) {
                    startIndex = i - (oddLen - 1) / 2;
                }

                int evenLen = GetLongest(radiusArray, i, 0);
                if (evenLen > maxLen) {
                    startIndex = i - (evenLen - 1) / 2;
                }

                maxLen = Math.Max(maxLen, Math.Max(oddLen, evenLen));
            }

            return input.Substring(startIndex, maxLen);
        }

        private string ManacherPreprocess(string input)
        {
            string result = "@";
            foreach (char c in input)
            {
                result += "#" + c;
            }
            result += "#$";
            return result;
        }

        private int[] RunManacher(string preprocessed)
        {
            int[] p = new int[preprocessed.Length];
            int l = 0;
            int r = 0;

            for (int i = 1; i < preprocessed.Length - 1; i++)
            {
                int mirror = l + r - i;

                if (i < r)
                    p[i] = Math.Min(r - i, p[mirror]);

                while (preprocessed[i + 1 + p[i]] == preprocessed[i - 1 - p[i]])
                {
                    p[i]++;
                }

                if (i + p[i] > r)
                {
                    l = i - p[i];
                    r = i + p[i];
                }
            }

            return p;
        }
        
        private int GetLongest(int[] p, int cen, int odd) {
            int pos = 2 * cen + 2 + (odd == 0 ? 1 : 0);
            return p[pos];
        }
    }
}
