namespace Adapter
{
    class EnglishToLanguageAdapter : ILanguage 
    {
        private English _english;
        
        public EnglishToLanguageAdapter()
        {
            _english = new English();
        }

        public void Speak()
        {
            _english.SpeakEnglish();
        }
    }
}