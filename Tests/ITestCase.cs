namespace AlgoPlayground.Tests
{
    public interface ITestCase
    {
        string Name { get; }
        bool Run();
    }
}