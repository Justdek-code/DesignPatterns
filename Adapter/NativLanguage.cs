using System;

namespace Adapter
{
    class NativLanguage : ILanguage
    {
        public void Speak()
        {
            Console.WriteLine("Speaking nativ language...");
        }
    }
}