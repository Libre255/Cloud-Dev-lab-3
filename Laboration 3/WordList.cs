using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Reflection.Metadata.Ecma335;

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
            string FilePath = $"{FolderPath}\\{name}";
            string[] FileLines = File.ReadLines(FilePath).ToArray();
            string[] Languages = FileLines.First().Split(';').Where(x => !string.IsNullOrEmpty(x)).ToArray();

            WordList SelectedList = new(name, Languages);
            for (int i = 0; i < FileLines.Length; i++)
            {
                if (i != 0)
                {
                    string[] WordTranslations = FileLines[i].Split(';');
                    SelectedList.Words.Add(new Word(WordTranslations));
                }
            }

            return SelectedList;
        }

        public void Save()
        {
            string FilePath = $"{FolderPath}\\{Name}.dat";
            string Content = String.Join(";", Languages) + Environment.NewLine;
           
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
                if (W.Translation[translation] == word)
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
            Words = Words.OrderBy(arr => arr.Translation[sortByTranslation]).ToList();
            showTranslation = (trans) => trans.OrderBy(arr => arr == trans[sortByTranslation]);

            foreach(Word WordContent in Words)
            {
                string ShowCaseWord = "";
                foreach(string Word in WordContent.Translation)
                {
                    ShowCaseWord += $"{Word}";
                    for(int i = ShowCaseWord.Length; i < 15; i++)
                    {
                        ShowCaseWord += " ";
                    }
                    
                }
                WriteLine(ShowCaseWord);   
            }
        }
        public Word GetWordToPractice()
        {
            int randomIndex = new Random().Next(0, Words.Count + 1);
            return Words[randomIndex];
        }

    }
}
