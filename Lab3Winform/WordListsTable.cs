using Library_For_Laboration3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Winform
{
    public partial class Form1
    {
        private static string FolderPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Laboration3";
        public void loadWordsList()
        {
            string[] NameOfLists = WordList.GetList().Select(Name => Name.Replace(".dat", "")).ToArray();

            foreach (string ListName in NameOfLists)
            {
                WordList AList = WordList.LoadList(ListName);

                ListViewItem item = new(AList.Name);
                item.SubItems.Add($"{AList.Count()}");

                ListViewWordLists.Items.Add(item);
            }
        }

        private static void CheckFonderExists()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
        }
    }
}
