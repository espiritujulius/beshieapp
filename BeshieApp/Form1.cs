using System.Text;

namespace BeshieApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblOutput.Text);
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            string inputText = tbText.Text;

            string[] words = inputText.Split(' ');

            StringBuilder stringBuilder = new StringBuilder();

            int wordCount = 0;
            int maxWordsPerLine = 6; // NEW LINE

            foreach (string word in words)
            {
                stringBuilder.Append("🤸" + word);
                wordCount++;

                if (wordCount % maxWordsPerLine == 0)
                {
                    stringBuilder.AppendLine();
                }

            }

            string modifiedText = stringBuilder.ToString().Trim();

            lblOutput.Text = modifiedText;
        }
    }
}