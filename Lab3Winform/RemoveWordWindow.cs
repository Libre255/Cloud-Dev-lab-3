using Library_For_Laboration3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Winform
{
    public partial class RemoveWordWindow : Form
    {
        WordList CurrentList;
        Action ClearList;
        Action<string, int> ReloadList;
        public RemoveWordWindow(WordList currentList, Action clearlist, Action<string, int> reloadlist)
        {
            InitializeComponent();
            CurrentList = currentList;
            ClearList = clearlist;
            ReloadList = reloadlist;
            LoadLanguages();
        }
        private void LoadLanguages()
        {
            foreach(string Lang in CurrentList.Languages)
            {
                ComboBoxLanguages.Items.Add(Lang);
            }
            ComboBoxLanguages.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnCanselRemoveWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRemoveWord_Click(object sender, EventArgs e)
        {
            int SelectedLang = ComboBoxLanguages.SelectedIndex;
            if(SelectedLang == -1)
            {
                MessageBox.Show("Select a language");
            }else if(TextBoxRemoveWord.Text == "")
            {
                MessageBox.Show("Write the word that shall be deleted");
            }
            else
            {
                bool RemovedSuccesfully = CurrentList.Remove(SelectedLang, TextBoxRemoveWord.Text);

                if (RemovedSuccesfully)
                {
                    MessageBox.Show($"The word {TextBoxRemoveWord.Text} has been succesfully removed");
                    CurrentList.Save();
                    ClearList();
                    ReloadList(CurrentList.Name, 0);
                    Close();
                }
                else
                {
                    MessageBox.Show($"That word does'nt exist in the list, try again.");
                }
            }
        }
    }
}
