using Library_For_Laboration3;

namespace Lab3Winform
{
    public partial class Form1
    {
        private void showLanguages() {

            if(ListViewWordLists.SelectedItems.Count > 0)
            {
                var NameOfSelectedList = ListViewWordLists.SelectedItems[0];
                WordList SelectedList = WordList.LoadList(NameOfSelectedList.Text);

                foreach(string Language in SelectedList.Languages)
                {
                    ListViewItem NameOfLanguage = new(Language);
                    ListOfLanguages.Items.Add(NameOfLanguage);
                }

            }
        }
    }
}
