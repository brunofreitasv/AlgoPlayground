using System.Collections;
using System.Runtime.CompilerServices;
using AlgoPlayground.Algorithms;

namespace AlgoPlayground.Tests
{
    public abstract class TestCases<TInput, TOutput> : ITestCase
    {
        public abstract string Name { get; }
        public abstract IEnumerable<(TInput Input, TOutput Expected)> Cases { get; }
        public abstract IAlgorithmImplementation<TInput, TOutput> Implementation { get; }

        public virtual bool Run()
        {
            var impl = Implementation;
            int index = 0;
            int passed = 0;
            int failed = 0;

            foreach (var (input, expected) in Cases)
            {
                index++;
                var result = impl.Run(input);
                bool isOk = Equals(FormatValue(result), FormatValue(expected));

                if (isOk)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Case #{index}: Passed");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Case #{index}: Failed");
                    Console.WriteLine($"   Input:    {FormatValue(input)}");
                    Console.WriteLine($"   Expected: {FormatValue(expected)}");
                    Console.WriteLine($"   Got:      {FormatValue(result)}");
                }

                Console.ResetColor();

                if (isOk) passed++; else failed++;
            }

            Console.WriteLine($"-> {Name}: {passed} passed, {failed} failed");
            return failed == 0;
        }

        string FormatValue(object? value)
        {
            if (value == null) return "null";
            if (value is string s) return $"\"{s}\"";
            if (value is ITuple tuple)
            {
                var items = new List<string>();
                for (int i = 0; i < tuple.Length; i++)
                    items.Add(FormatValue(tuple[i]));
                return $"({string.Join(", ", items)})";
            }
            if (value is IEnumerable enumerable && value is not string)
                return "[" + string.Join(", ", enumerable.Cast<object>().Select(FormatValue)) + "]";
            return value.ToString() ?? "null";
        }
    }
}