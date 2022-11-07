namespace Library_For_Laboration3
{
    public class Word
    {
        public string[] Translation { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] translations)
        {
            Translation = translations;
        }
        public Word (int fromLanguage, int toLanguage, params string[] translation)
        {
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
            Translation = translation;
        }
        public override string ToString()
        {
            string WordsTranslation = "";
            
            foreach(string trans in Translation)
            { 
                if(trans != "")
                {
                    WordsTranslation += $"{trans};";
                }
            }
            return WordsTranslation;
        }
    }
}