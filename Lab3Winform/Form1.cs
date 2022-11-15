using Library_For_Laboration3;

namespace Lab3Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckFonderExists();
            loadWordsList();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOfLanguages.Items.Clear();
            showLanguages();
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var SelectedList = ListViewWordLists.SelectedItems[0].Text;
                ListWIndow WindowOfaList = new(SelectedList);
                WindowOfaList.ShowDialog();
            }
            catch
            {
                MessageBox.Show("[Select a list]");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewList_Click(object sender, EventArgs e)
        {
            NewListWindow WindowOfNewList = new(ListViewWordLists.Items, loadWordsList);
            WindowOfNewList.ShowDialog();
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRefreshWordsList_Click(object sender, EventArgs e)
        {
            ListViewWordLists.Items.Clear();
            loadWordsList();
        }
    }
}