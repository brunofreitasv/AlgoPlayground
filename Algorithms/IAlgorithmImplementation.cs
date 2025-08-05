namespace AlgoPlayground.Algorithms
{
    public interface IAlgorithmImplementation<TInput, TOutput>
    {
        public TOutput Run(TInput input);
    }
}