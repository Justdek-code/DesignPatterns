using System;

namespace AbstractFactory
{
    public class HondaEngine : IEngine
    {

        public HondaEngine()
        {
            Console.WriteLine("Honda Engine created");
        }
    }
}