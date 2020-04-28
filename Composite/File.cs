using System;


namespace Composite
{
    public class File : Component
    {

        public File(string componentName) : base (componentName)
        {
        }

        public override void DisplayContent(string tabCount = "")
        {
            Console.WriteLine($"{tabCount}File: {_componentName}");
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}