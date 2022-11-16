using Library_For_Laboration3;

namespace Lab3Winform
{
    public partial class PracticeWindow : Form
    {
        WordList CurrentList;
        List<string> AlreadyPracticedWords = new();
        int WrongAnswers = 0;
        string CorrectTranslation = "";
        public PracticeWindow(WordList currentlist)
        {
            InitializeComponent();
            CurrentList = currentlist;
            WordToPractice();
        }
        private void WordToPractice()
        {
            Word WordForPractice = CurrentList.GetWordToPractice();
            //Check the word has not been shown befor
            while (AlreadyPracticedWords.Contains(WordForPractice.Translation[0]))
            {
                WordForPractice = CurrentList.GetWordToPractice();
            }
            AlreadyPracticedWords.Add(WordForPractice.Translation[0]);

            string FromLanguage = CurrentList.Languages[WordForPractice.FromLanguage];
            string ToLanguage = CurrentList.Languages[WordForPractice.ToLanguage];
            string Word = WordForPractice.Translation[WordForPractice.FromLanguage];
            CorrectTranslation = WordForPractice.Translation[WordForPractice.ToLanguage];

            labelPractInstructions.Text = $"Translate the {FromLanguage} word {Word} to {ToLanguage}";
        }
        private void BtnPracticeSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxPractice.Text == "")
            {
                MessageBox.Show("Submit a word first");
            }
            else
            {
                if (AlreadyPracticedWords.Count == CurrentList.Count())
                {
                    FinnishedPractice();
                }
                else
                {
                    if (textBoxPractice.Text.Trim().ToLower() == CorrectTranslation.ToLower())
                    {

                        textBoxPractice.Clear();
                        WordToPractice();
                        MessageBox.Show("Correct answer!");
                    }
                    else
                    {
                        textBoxPractice.Clear();
                        WrongAnswers++;
                        WordToPractice();
                        MessageBox.Show("Wrong answer!");
                    }
                }
            }
        }
        private void btnPracticeCansel_Click(object sender, EventArgs e)
        {
            FinnishedPractice();
        }
        private void FinnishedPractice()
        {//getting worng precent

            double precent = 100f - Math.Round(((float)WrongAnswers / (AlreadyPracticedWords.Count - 1) * 100), 2);
            MessageBox.Show($"You practiced {AlreadyPracticedWords.Count} words."  + Environment.NewLine +
                $"{precent} % of your answers where correct!");
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
