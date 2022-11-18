using System;
using System.Windows.Forms;
using System.IO;

namespace DoBetter
{
    public partial class FormDoBetter : Form
    {
        public FormDoBetter()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\better.txt";
            StreamReader streamReader = new StreamReader(path);

            string line1 = "";
            string line = "";
            int linesCount = 0;
            int lines = 0;


            line1 = streamReader.ReadLine();
            lines = Convert.ToInt32(line1);

            while (linesCount < lines)
            {
                line = streamReader.ReadLine();

                TxtResult.Text += TransformWord(line) + Environment.NewLine;

                linesCount++;
            }
        }

        private string TransformWord(string word)
        {
            string newWord = "";

            if (word.Substring(word.Length - 2, 2) == "er")
            {
                for (int i = 0; i < word.Length - 2; i++)
                {
                    newWord += word.Substring(i, 1);
                }
                newWord += "est";
            }
            else if (word.Substring(word.Length - 1, 1) == "e")
            {
                for (int i = 0; i <word.Length; i++)
                {
                    newWord += word.Substring(i, 1);
                }
                newWord += "r";
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    newWord += word.Substring(i, 1);
                }
                newWord += "er";
            }

            return newWord;
        }
    }
}
