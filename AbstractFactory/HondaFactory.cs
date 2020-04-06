namespace AbstractFactory
{
    public class HondaFactory : ICarFactory
    {
        public ICorpus MakeCorpus()
        {
            return new HondaCorpus();
        }

        public IEngine MakeEngine()
        {
            return new HondaEngine();
        }
    }
}