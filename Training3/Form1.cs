namespace Training3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            PromptReader reader = new("prompts.txt");
            ProgressBar.Maximum = reader.GetNumberOfLinesInFile();
            ProgressBar.Value = 0;

            reader.OnAnswerReceived += OnAnswerReceived;
            await reader.ExecutePromptsAsync();
        }

        public void OnAnswerReceived(string answer)
        {
            ProgressBar.Value++;
            OutputTextBox.AppendText(answer + "\n\n");
            OutputTextBox.ScrollToCaret();

        }


    }
}