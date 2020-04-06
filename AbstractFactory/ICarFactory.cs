namespace AbstractFactory
{
    public interface ICarFactory
    {
        ICorpus MakeCorpus();
        IEngine MakeEngine();
    }
}