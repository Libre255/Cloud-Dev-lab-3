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
    public partial class ListWIndow : Form
    {
        public ListWIndow(string nameOfList)
        {
            InitializeComponent();
            ListTableConfig(nameOfList);
        }

        private void ListTableConfig(string nameOfList)
        {
            ListTable.View = View.Details;

            WordList SelectedList = WordList.LoadList(nameOfList);
            foreach (string Language in SelectedList.Languages)
            {
                ListTable.Columns.Add(Language, 100, HorizontalAlignment.Left);
            }

            Action<string[]> WordsListing = (Translations) =>
            {
                ListViewItem Word = new(Translations[0]);
                for (int i = 1; i < Translations.Length; i++)
                {
                    Word.SubItems.Add(Translations[i]);
                }
                ListTable.Items.Add(Word);
            };
            SelectedList.List(0, WordsListing);
        }
    }
}
