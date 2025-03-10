using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionFive
{
    public static class QuestionFive
    {
        public static void CountWordsInFile()
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            // Check if file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            try
            {
                // Read the file content
                string text = File.ReadAllText(filePath);

                // Split words by whitespace and count them
                int wordCount = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

                Console.WriteLine("Number of words: " + wordCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file: " + ex.Message);
            }
        }


        public static void FindLongestWordInFile()
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            // Check if file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            try
            {
                // Read the file content
                string text = File.ReadAllText(filePath);

                // Split words using non-letter characters as delimiters
                string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                // Find the longest word
                string longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();

                Console.WriteLine("Longest word: " + (longestWord ?? "No words found"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file: " + ex.Message);
            }
        }

    }
}
