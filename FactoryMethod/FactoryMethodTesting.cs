using System;

namespace FactoryMethod
{
    class FactoryMethodTesting
    {
        static void Main(string[] args)
        {
            IDeveloper developer = new DataScientist();
            IProgram program = developer.CreateProgram();
        }
    }
}
