using System;
using System.Collections.Generic;


namespace Composite
{
    
    class Directory : Component
    {
        public List<Component> Components;


        public Directory(string componentName) : base(componentName)
        {
            Components = new List<Component>();
        }

        public override void DisplayContent(string tabCount = "")
        {
            Console.WriteLine($"{tabCount}Directory: {_componentName}");                  
            tabCount = IncreasTab(tabCount);

            foreach (Component component in Components)
            {
                component.DisplayContent(tabCount);
            }
        }

        public override void Add(Component component)
        {
            Components.Add(component);
        }

        public override void Remove(Component component)
        {
            Components.Remove(component);
        }

        private string IncreasTab(string tabCount)
        {
            return (tabCount += "\t");
        }

    }
}