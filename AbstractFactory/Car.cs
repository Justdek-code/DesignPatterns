using System;

namespace AbstractFactory
{
    public class Car
    {
        private IEngine _engine;
        private ICorpus _corpus;

        public Car(ICarFactory factory)
        {
            _engine = factory.MakeEngine();
            _corpus = factory.MakeCorpus();

            Console.WriteLine("Honda created");
        }
    }
}