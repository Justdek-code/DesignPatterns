using System;

namespace AbstractFactory
{
    class AbstractFactoryTesting
    {
        static void Main(string[] args)
        {
            ICarFactory factory = new HondaFactory();
            Car honda = new Car(factory);
        }
    }
}
