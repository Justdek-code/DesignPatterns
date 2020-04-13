using System;

namespace Prototype
{
    class PrototypeTesting
    {
        static void Main(string[] args)
        {
            IPhone phone = new Samsung(10);
            IPhone clonePhone = phone.Clone();
            phone.PrintModelInfo();
            clonePhone.PrintModelInfo();
        }
    }
}
