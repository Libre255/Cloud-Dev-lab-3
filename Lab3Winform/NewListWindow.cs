using Library_For_Laboration3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Winform
{
    public partial class NewListWindow : Form
    {
        public string ListName { get; set; }
        Action AddLists;
        ListView.ListViewItemCollection WordsListTable;
        public NewListWindow(ListView.ListViewItemCollection wordslisttable, Action addWordsLists)
        {
            InitializeComponent();
            WordsListTable = wordslisttable;
            AddLists = addWordsLists;
        }

        private void btnNewListCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxListName_TextChanged(object sender, EventArgs e)
        {
            ListName = textBoxListName.Text;
        }

        private void BtnAddLanguage_Click(object sender, EventArgs e)
        {
            if(textBoxLanguageInput.Text != "")
            {
                updateLanguageTable(textBoxLanguageInput.Text);
                textBoxLanguageInput.Clear();
            }
        }

        private void updateLanguageTable(string LanguageName)
        {
            ListViewItem Language = new(LanguageName.ToLower());
            if (!NewListLanguages.Items.Cast<ListViewItem>().Any(i => i.Text == LanguageName.ToLower()))
            {
                NewListLanguages.Items.Add(Language);
            }
            else
            {
                MessageBox.Show("Cant add the same language twice");
            }
        }

        private void BtnCreateList_Click(object sender, EventArgs e)
        {
            if(ListName == null || ListName == "")
            {
                MessageBox.Show("Insert List name");
            }else if(NewListLanguages.Items.Count <= 1)
            {
                MessageBox.Show("Insert at least 2 languages");
            }
            else
            {
                List<string> LanguagesArray = new();
                foreach(ListViewItem language in NewListLanguages.Items)
                {
                    LanguagesArray.Add(language.Text);
                }
                WordList CreatingNewList = new(ListName, LanguagesArray.ToArray());
                CreatingNewList.Save();
                MessageBox.Show("You have succesfully created a new list!");
                WordsListTable.Clear();
                AddLists();
                Close();
            }
        }
    }
}
