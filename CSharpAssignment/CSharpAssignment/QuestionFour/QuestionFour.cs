using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionFour
{
    public class QuestionFour
    {
        public static void CheckConsecutiveNumbers()
        {
            Console.Write("Enter numbers separated by a hyphen (e.g., 5-6-7-8-9): ");
            string input = Console.ReadLine();

            // Convert input into a list of integers
            List<int> numbers = input.Split('-')
                                     .Select(num => num.Trim()) // Remove spaces
                                     .Where(num => int.TryParse(num, out _)) // Ensure valid numbers
                                     .Select(int.Parse) // Convert to integers
                                     .ToList();


            // Check if the numbers are consecutive
            bool isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i] - numbers[i - 1]) != 1) // Difference must be 1
                {
                    isConsecutive = false;
                    break;
                }
            }


            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }



        public static void CheckForDuplicate()
        {

            Console.Write("Enter numbers separated by a hyphen (or press Enter to exit): ");
            string input = Console.ReadLine();

            // Exit if the user presses Enter without input
            if (string.IsNullOrWhiteSpace(input))
                return;

            // Convert input into a list of integers
            List<int> numbers = input.Split('-')
                                     .Select(num => num.Trim()) // Remove spaces
                                     .Where(num => int.TryParse(num, out _)) // Ensure valid numbers
                                     .Select(int.Parse) // Convert to integers
                                     .ToList();

            // Check for duplicates using a HashSet
            HashSet<int> uniqueNumbers = new HashSet<int>();
            bool hasDuplicate = numbers.Any(num => !uniqueNumbers.Add(num));

            // Display result
            Console.WriteLine(hasDuplicate ? "Duplicate" : "No Duplicates");

        }



        public static void TimeValidation()
        {
            Console.Write("Enter a time in 24-hour format (HH:mm): ");
            string input = Console.ReadLine();

            // Validate input format
            if (string.IsNullOrWhiteSpace(input) || !TimeSpan.TryParse(input, out TimeSpan time))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            // Extract hours and minutes
            int hours = time.Hours;
            int minutes = time.Minutes;

            // Validate range (00:00 to 23:59)
            if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
        }



        public static void ConvertToPascalCase()
        {
            Console.Write("Enter words separated by spaces: ");
            string input = Console.ReadLine();

            // Check if input is empty
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            // Convert input into PascalCase
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string pascalCase = string.Join("", input.Split(' ')
                                                     .Where(word => !string.IsNullOrWhiteSpace(word)) // Remove empty entries
                                                     .Select(word => textInfo.ToTitleCase(word.ToLower()))); // Capitalize first letter

            Console.WriteLine("PascalCase Variable Name: " + pascalCase);

        }



        public static void CountNumberOfVowels() {
            Console.Write("Enter an English word: ");
            string input = Console.ReadLine();

            // Check for empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            // Define vowels and count occurrences in input
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = input.ToLower().Count(c => vowels.Contains(c));

            Console.WriteLine("Number of vowels: " + vowelCount);
        }
    }
}
