using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Library_For_Laboration3
{
    public class WordList
    {
        private static string FolderPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Laboration3";
        private List<Word> Words = new();
        public string Name { get; }
        public string[] Languages { get; }

        public WordList(string name, params string[] languages)
        {
            Name = name;    
            Languages = languages;
        }
        
        public static string[] GetList()
        {
            DirectoryInfo FolderContent = new DirectoryInfo(FolderPath);
            string[] FilesNames = FolderContent.GetFiles("*.dat").Select(content => content.Name).ToArray();
            
            return FilesNames;
        }
        public static WordList LoadList(string name)
        {
            string FilePath = $"{FolderPath}\\{name.ToLower()}.dat";
            string[][] FileLines = File.ReadLines(FilePath).Select(LinesArray => LinesArray.Split(';')
                                                                                                .Where(x => !string.IsNullOrEmpty(x))
                                                                                                .ToArray()).ToArray();
            //Here somehow causing to add an empty string into the array  need fix
            string[] Languages = FileLines.First();
            
            WordList SelectedList = new(name, Languages);
            for (int i = 1; i < FileLines.Length; i++)
            {
                string[] WordTranslations = FileLines[i];
                SelectedList.Add(WordTranslations);
            }
            
            return SelectedList;
        }

        public void Save()
        {
            string FilePath = $"{FolderPath}\\{Name.ToLower()}.dat";
            string Content = String.Join(";", Languages)+ ";" + Environment.NewLine;
           
            foreach (Word W in Words)
            {
                Content += W.ToString() + Environment.NewLine;
            }
            File.WriteAllText(FilePath, Content);
        }

        public void Add(params string[] translations)
        {
            if(Languages.Length != translations.Length)
            {
                throw new ArgumentException(String.Format($"You didnt add enough translations, you need to add {Languages.Length} translations"));
            }
            Words.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
            bool FoundWord = false;
            foreach (Word W in Words.ToList())
            {
                if (W.Translation[translation].ToLower() == word.ToLower())
                {
                    Words.Remove(W);
                    FoundWord = true;
                }
            }
            return FoundWord;
        }
        public int Count()
        {
            return Words.Count;
        }
        public void List(int sortByTranslation, Action<string[]> showTranslation)
        {
            List<Word> SortedWords = Words.OrderBy(arr => arr.Translation[sortByTranslation]).ToList();
            List<string[]> AllTranslations = SortedWords.Select(L => L.Translation).Prepend(Languages).ToList();
            
            foreach(string[] Translations in AllTranslations)
            {
                showTranslation(Translations);
            }
        }
        public Word GetWordToPractice()
        {
            int randomWordIndex = new Random().Next(0, Count());
            int randomFromLanguageIndex = new Random().Next(0, Languages.Length); 
            int randomToLanguageIndex = new Random().Next(0, Languages.Length);

            while (randomFromLanguageIndex == randomToLanguageIndex)
            {
                randomToLanguageIndex = new Random().Next(0, Languages.Length);
            }
            Word RandomWord = new Word(randomFromLanguageIndex, randomToLanguageIndex, Words[randomWordIndex].Translation);
            return RandomWord;
        }

    }
}
