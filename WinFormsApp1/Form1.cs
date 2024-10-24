using static WinFormsApp1.Form1;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMetric_Click(object sender, EventArgs e)
        {
            var wordOne = Word1.Text.Trim();
            var wordTwo = Word2.Text.Trim();

            if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
            {
                NullLabel.Text = "Cannot be null. Both words required.";
                label1.Text = "";
                Output.Text = "";
                return;
            }

            WordFun wordFun = new WordFun(wordOne, wordTwo);
            Output.Text = wordFun.GenerateMetrics();
            NullLabel.Text = "";
        }


        private void buttonSquare_Click(object sender, EventArgs e)
       { 
           var wordOne = Word1.Text.Trim();
           var wordTwo = Word2.Text.Trim();

           if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
           {
               NullLabel.Text = "Cannot be null. Both words required.";
               label1.Text = "";
               Output.Text = "";
               return;
           }

           WordFun wordFun = new WordFun(wordOne, wordTwo);
           Output.Text = wordFun.GenerateSquare(wordFun.Word1) + "\n" + wordFun.GenerateSquare(wordFun.Word2);
           NullLabel.Text = "";
        }

        private void buttonPyramid_Click(object sender, EventArgs e)
        {
            string wordOne = Word1.Text.Trim();
            string wordTwo = Word2.Text.Trim();

            if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
            {
                NullLabel.Text = "Cannot be null. Both words required.";
                label1.Text = "";
                Output.Text = "";
                return;
            }

            WordFun wordFun = new WordFun(wordOne, wordTwo);
            Output.Text = wordFun.GeneratePyramid(wordFun.Word1) + "\n" + wordFun.GeneratePyramid(wordFun.Word2);
            NullLabel.Text = "";
        }


        private void buttonPalindrome_Click(object sender, EventArgs e)
        {
            var wordOne = Word1.Text.Trim();
            var wordTwo = Word2.Text.Trim();

            if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
            {
                NullLabel.Text = "Cannot be null. Both words required.";
                label1.Text = "";
                Output.Text = "";
                return;
            }

            WordFun wordFun = new WordFun(wordOne, wordTwo);
            Output.Text = wordFun.GetPalindromeResult();
            NullLabel.Text = "";
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            var wordOne = Word1.Text.Trim();
            var wordTwo = Word2.Text.Trim();

            if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
            {
                NullLabel.Text = "Cannot be null. Both words required.";
                label1.Text = "";
                Output.Text = "";
                return;

            }

            WordFun wordFun = new WordFun(wordOne, wordTwo);
            Output.Text = wordFun.CompareLetters();
            NullLabel.Text = "";
        }


        private void buttonConversion_Click(object sender, EventArgs e)
        {
            var wordOne = Word1.Text.Trim();
            var wordTwo = Word2.Text.Trim();

            if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
            {
                NullLabel.Text = "Cannot be null. Both words required.";
                label1.Text = "";
                Output.Text = "";
                return;
            }

            WordFun wordFun = new WordFun(wordOne, wordTwo);
            Output.Text = wordFun.MultiplyNumbers();
            NullLabel.Text = "";

        }
    }
}