using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// This class compiles executes the word fun functions :metrics, word squares, 
    /// pyramids, palindrome , letter comparisons,and word-to-number conversions.
    /// </summary>
    public class WordFun(string word1, string word2)
    {
        public string Word1 { get; set; } = word1;
        public string Word2 { get; set; } = word2;

        /// <summary>
        /// Generates a square from a word.
        /// </summary>
        /// <param name="word">The word to generate a square from.</param>
        /// <returns>A string representing the square.</returns>
        public string GenerateSquare(string word)
        {
            string wordSquare = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                wordSquare += word + "\n";
            }

            return wordSquare;
        }

        /// <summary>
        /// Generates a pyramid  from a word.
        /// </summary>
        /// <param name="word">The word to generate a pyramid from.</param>
        /// <returns>A string representing the pyramid.</returns>
        public string GeneratePyramid(string word)
        {
            string pyramid = string.Empty;

            // Ascending
            for (int i = 1; i <= word.Length; i++)
            {
                pyramid += word.Substring(0, i) + "\n";
            }

            // Descending
            for (int i = word.Length - 1; i >= 1; i--)
            {
                pyramid += word.Substring(0, i) + "\n";
            }

            return pyramid;
        }

        public string GenerateMetrics()
        {
            int word1Length = Word1.Length;
            int word2Length = Word2.Length;
            string message = string.Empty;

            if (word1Length > word2Length)
            {
                int difference = word1Length - word2Length;
                message = $"{Word1} has {difference} more character(s) than {Word2}.";
            }
            else if (word1Length < word2Length)
            {
                int difference = word2Length - word1Length;
                message = $"{Word2} has {difference} more character(s) than {Word1}.";
            }
            else
            {
                message = $"{Word1} and {Word2} have the same number of characters.";
            }

            return message;
        }

        public bool PalindromeTest(string word)
        {
            string reversedWord = new string(word.Reverse().ToArray());
            return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
        }

        public string GetPalindromeResult()
        {
            bool word1IsPalindrome = PalindromeTest(Word1);
            bool word2IsPalindrome = PalindromeTest(Word2);

            if (word1IsPalindrome && word2IsPalindrome)
            {
                return $"{Word1} and {Word2} are both palindromes.";
            }
            else if (word1IsPalindrome)
            {
                return $"{Word1} is a palindrome. {Word2} is not palindrome.";
            }
            else if (word2IsPalindrome)
            {
                return $"{Word2} is a palindrome. {Word1} is not a palindrome.";
            }
            else
            {
                return "Neither word is a palindrome.";
            }
        }

        public string CompareLetters()
        {
            var comparingWords = Word1.ToUpper().Intersect(Word2.ToUpper().Distinct());

            if (comparingWords.Any())
            {
                return "Letters found in both words: " + string.Join(", ", comparingWords);
            }
            else
            {
                return $"No letters shared between {Word1} and {Word2}.";
            }
        }

        public int? NumberFromWord(string word)
        {
            switch (word.ToLower())
            {
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                default: return null;
            }
        }

        public string MultiplyNumbers()
        {
            int? num1 = NumberFromWord(Word1);
            int? num2 = NumberFromWord(Word2);

            if (num1.HasValue && num2.HasValue)
            {
                return $"{num1} * {num2} = {num1 * num2}";
            }
            else
            {
                return "Invalid input for number conversion.Must be numbers 1-9.";
            }
        }
    }
}

