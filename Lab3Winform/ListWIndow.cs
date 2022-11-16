using Library_For_Laboration3;

namespace Lab3Winform
{
    public partial class ListWIndow : Form
    {
        WordList CurrentList; 
        public ListWIndow(string nameOfList)
        {
            InitializeComponent();
            ListTableConfig(nameOfList);
            AddColumnsToTable(nameOfList);
        }
        public void AddColumnsToTable(string nameOfList)
        {
            ListTable.View = View.Details;
            WordList SelectedList = WordList.LoadList(nameOfList);
            foreach (string Language in SelectedList.Languages)
            {
                ListTable.Columns.Add(Language, 100, HorizontalAlignment.Left);
            }
            ListTable.ColumnClick += OnColumnName_ColumnClick;
        }
        private void OnColumnName_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int ColumnIndex = e.Column;
            ListTable.Items.Clear();
            ListTableConfig(CurrentList.Name, ColumnIndex);
        }
        public void ListTableConfig(string nameOfList, int sortByLangIndex = 0)
        {
            WordList SelectedList = WordList.LoadList(nameOfList);
            Action<string[]> WordsListing = (Translations) =>
            {
                ListViewItem Word = new(Translations[0]);
                for (int i = 1; i < Translations.Length; i++)
                {
                    Word.SubItems.Add(Translations[i]);
                }
                ListTable.Items.Add(Word);
            };
            SelectedList.List(sortByLangIndex, WordsListing);
            CurrentList = SelectedList;
        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            AddWordWindow WindowForAddingWords = new(CurrentList, ListTable.Items.Clear, ListTableConfig);
            WindowForAddingWords.ShowDialog();
        }

        private void BtnCloseListWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRemoveWord_Click(object sender, EventArgs e)
        {
            RemoveWordWindow RWW = new RemoveWordWindow(CurrentList, ListTable.Items.Clear, ListTableConfig);
            RWW.ShowDialog();
        }

        private void BtnPractice_Click(object sender, EventArgs e)
        {
            PracticeWindow PracticeWin = new(CurrentList);
            PracticeWin.ShowDialog();
        }
    }
}
