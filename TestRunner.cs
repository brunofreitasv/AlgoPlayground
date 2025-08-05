using System.Reflection;
using AlgoPlayground.Tests;

namespace AlgoPlayground
{
    public static class TestRunner
    {
        public static void RunAll()
        {
            var testCases = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ITestCase).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => (ITestCase?)Activator.CreateInstance(t));

            foreach (var test in testCases)
            {
                if (test == null)
                    continue;

                Console.WriteLine($"Running: {test.Name}");
                test.Run();
            }
        }
    }
}