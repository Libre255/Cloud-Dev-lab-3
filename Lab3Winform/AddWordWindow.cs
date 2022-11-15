using Library_For_Laboration3;
using System.Data;

namespace Lab3Winform
{
    public partial class AddWordWindow : Form
    {
        WordList Currentlist;
        Action ClearList;
        Action<string, int> Reloadlist;
        public AddWordWindow(WordList currentList, Action clearlist, Action<string, int> reloadlist)
        {
            InitializeComponent();
            ClearList = clearlist;
            Reloadlist = reloadlist;
            Currentlist = currentList;
            CreatingTextBoxs();

        }
        private void CreatingTextBoxs()
        {
            int TopLabel = 60;
            int TopInputBox = 83;
            for(int i = 0; i < Currentlist.Languages.Length; i++)
            {
                string Lang = Currentlist.Languages[i];

                Label LanguageName = new();
                LanguageName.Text = Lang;
                LanguageName.Location = new Point(372, i == 0 ? TopLabel : TopLabel += 50);
                TextBox inputBox = new();
                inputBox.Location = new Point(346, i == 0 ? TopInputBox : TopInputBox += 50);
                inputBox.Name = "TextBox" + Lang;
                Controls.Add(LanguageName);
                Controls.Add(inputBox);
            }
        }

        private void BtnCloseAddAWord_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            var ListOfInputBoxes = Controls.OfType<TextBox>();
            if (ListOfInputBoxes.Any(input => input.Text == "")){
                MessageBox.Show("Need to fill all the languages");
            }
            else
            {
                string[] Translations = Controls.OfType<TextBox>().Select(item => item.Text.ToLower()).ToArray();
                Currentlist.Add(Translations);
                Currentlist.Save();
                MessageBox.Show("You succesfully added a new word to the list");
                ClearList();
                Reloadlist(Currentlist.Name, 0);
                Close();
            }
        }
    }
}
