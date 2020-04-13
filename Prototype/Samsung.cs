using System;

namespace Prototype
{
    class Samsung : IPhone
    {
        private int _modelNumber;

        public Samsung(int model)
        {
            _modelNumber = model;
        }

        public IPhone Clone()
        {
            return new Samsung(_modelNumber);
        }

        public void PrintModelInfo()
        {
            Console.WriteLine($"Samsung model number: {_modelNumber}");
        }
    }
}