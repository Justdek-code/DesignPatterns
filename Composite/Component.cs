using System;

namespace Composite
{
    public abstract class Component
    {
        protected string _componentName;


        public Component(string componentName)
        {
            _componentName = componentName;
        }

        public abstract void DisplayContent(string tabCount = "");
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
    }
}