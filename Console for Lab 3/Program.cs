using static System.Console;
using Library_For_Laboration3;
using System.Data;

namespace ConsoleLab3
{
    public class Program { 
        private static string FolderPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Laboration3";

        private static string Instructions = @"Use any of the following parameters" + Environment.NewLine +
                @"-lists" + Environment.NewLine +
                @"-new <listname> <language 1> <language 2> .. <language n>" + Environment.NewLine +
                @"-add <list name>" + Environment.NewLine +
                @"-remove <list name> <language> <word 1> <word 2> .. <word n>" + Environment.NewLine +
                @"-words <list name> <sortByLanguage>" + Environment.NewLine +
                @"-count <list name>" + Environment.NewLine +
                @"-practice <list name>";
        public static void Main(string[] commands)
        {
            if(commands.Length == 0)
            {
                WriteLine(Instructions);
            }
            else
            {
                switch (commands[0].ToLower())
                {
                    case "-list": ShowAllList();
                        break;
                    case "-new":CreateNewList(commands);
                        break;
                    case "-add": AddWordToList(commands);
                        break;
                    case "-remove":RemoveWordFromList(commands);
                        break;
                    case "-words":ListAllWords(commands);
                        break;
                    case "-count":CountList(commands);
                        break;
                    case "-practice":PracticeAWord(commands);
                        break;
                    default: WriteLine("add a command");
                        break;
                }
            }
            
        }
        private static void PracticeAWord(string[] commands)
        {
            if(commands.Length == 1)
            {
                WriteLine("Please also insert <list name> ");
            }
            else
            {
                WordList SelectedList = WordList.LoadList(commands[1]);
                Word PracticeWord = SelectedList.GetWordToPractice();


            }
        }
        private static void CountList(string[] commands)
        {
            if(commands.Length == 1)
            {
                WriteLine("Please also insert <list name> ");
            }
            else
            {
                WordList SelectedList = WordList.LoadList(commands[1]);
                WriteLine($"Amount of words in the list {commands[1]} is {SelectedList.Count()}");
            }
        }
        private static void ListAllWords(string[] commands)
        {
            WordList SelectedList = WordList.LoadList(commands[1]);

            if (commands.Length == 1)
            {
                WriteLine("Please also insert <list name> (optional: <sortByLanguage>) ");
            }else
            {
                Action<string[]> Myaction = (WordTranslations) =>
                {
                    string ShowCaseWord = "";
                    foreach (string Word in WordTranslations)
                    {

                        ShowCaseWord += $"{Word}";
                        for (int i = ShowCaseWord.Length; i < 15; i++)
                        {
                            ShowCaseWord += " ";
                        }
                    }
                    WriteLine(ShowCaseWord);
                };
                if(commands.Length == 3)
                {
                    int LanguageIndex = SelectedList.Languages.ToList().FindIndex(L => L == commands[2]);
                    SelectedList.List(LanguageIndex, Myaction);
                }
                else
                {
                    SelectedList.List(0, Myaction);
                }
            }
        }
        private static void RemoveWordFromList(string[] commands)
        {
            if(commands.Length == 1)
            {
                WriteLine("Please also insert <list name> <language> <word 1> <word 2> .. <word n> ");
            }else if (commands.Length == 2)
            {
                WriteLine("Please also insert <language> <word 1> <word 2> .. <word n> ");
            }else if(commands.Length == 3)
            {
                WriteLine("Please also insert <word 1> <word 2> .. <word n> ");
            }
            else
            {
                string WordsDeleted = "";
                WordList SelectedList = WordList.LoadList(commands[1]);
                for(int i = 3; i < commands.Length; i++)
                {
                    int LanguageIndex = SelectedList.Languages.ToList().FindIndex(L => L == commands[2]);
                    SelectedList.Remove(LanguageIndex, commands[i]);
                    WordsDeleted += $"{commands[i]} ";
                }
                SelectedList.Save();
                WriteLine($"The following words has been deleted: {WordsDeleted}");
            }
        }

        private static void AddWordToList(string[]comands)
        {
            if(comands.Length == 1)
            {
                WriteLine("Please insert list name after -add");
            }
            else
            {
                List<string> userTranslations = new();
                WordList SelectedList = WordList.LoadList(comands[1]);
                WriteLine("Press enter (empty line) to stop input of new words");
                for(int i = 0; i < SelectedList.Languages.Length; i++)
                {
                    string Word;
                    if(i == 0)
                    {
                        Write($"Add new word ({SelectedList.Languages[i]}): ");
                    }
                    else
                    {
                        Write($"Add {SelectedList.Languages[i]} translation: ");
                    }
                    Word = ReadLine();
                    userTranslations.Add(Word);
                }

                SelectedList.Add(userTranslations.ToArray());
                SelectedList.Save();
                WriteLine($"1 word was added to list {comands[1]}");
            }
        }

        private static void ShowAllList()
        {
            string[] NameOfTheLists = WordList.GetList();
            foreach (string List in NameOfTheLists)
            {
                WriteLine(List);
            }
        }
        private static void CreateNewList(string[]comands)
        {
            if(comands.Length == 1)
            {
                WriteLine("Please also insert the following comands <list name> <language 1> <language 2> .. <langauge n>");
            }else if(comands.Length == 2)
            {
                WriteLine("Please also insert the following comands <language 1> <language 2> .. <langauge n>");
            }else if(comands.Length == 3)
            {
                WriteLine("Please inser at least 2 or more languages");
            }
            else
            {
                string ListName = comands[1];
                List<string> Languages = new();
                for(int i = 0; i < comands.Length; i++)
                {
                    if(i > 1)
                    {
                        Languages.Add(comands[i]);
                    }
                }
                WordList NewList = new WordList(ListName, Languages.ToArray());
                NewList.Save();
                WriteLine($"Your list {ListName} has been succesfully created!");
            }
        }
        private void CheckFonderExists()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
        }
    }

}