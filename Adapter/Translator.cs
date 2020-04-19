namespace Adapter
{
    class Translator
    {
        public void Speak(ILanguage language)
        {
            language.Speak();
        }
    }
}