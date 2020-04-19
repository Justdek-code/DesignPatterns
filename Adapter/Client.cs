using System;

namespace Adapter
{
    class Client
    {
        static void Main(string[] args)
        {
            Translator translator = new Translator();
            ILanguage nativ = new NativLanguage();
            ILanguage english = new EnglishToLanguageAdapter();

            translator.Speak(nativ);
            translator.Speak(english);
        }
    }
}
