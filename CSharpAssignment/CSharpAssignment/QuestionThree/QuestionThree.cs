using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionThree
{
    public static class QuestionThree
    {

        public static void FacebookLikes()
        {
            List<string> names = new List<string>(); // List to store names

            while (true)
            {
                Console.Write("Enter a name (or press Enter to finish): ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name)) // Stop if input is empty
                    break;

                names.Add(name); // Add name to the list
            }

            // Display message based on the number of likes
            if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post.");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post.");
            }
            else if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
            }

        }

        public static void ReverseName()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // Assume valid name input

            // Convert the name to a character array
            char[] nameArray = name.ToCharArray();

            // Reverse the array
            Array.Reverse(nameArray);

            // Convert the reversed array back to a string
            string reversedName = new string(nameArray);

            // Display the reversed name
            Console.WriteLine("Reversed Name: " + reversedName);
        }


        public static void UniqueSortedNumbers()
        {

            HashSet<int> numbers = new HashSet<int>(); // To store unique numbers
            while (numbers.Count < 5)
            {
                Console.Write($"Enter a unique number ({numbers.Count + 1}/5): ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Error: Number already entered. Try again.");
                    }
                    else
                    {
                        numbers.Add(num);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Convert HashSet to list, sort, and display the numbers
            List<int> sortedNumbers = new List<int>(numbers);
            sortedNumbers.Sort();

            Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));

        }

        public static void UniqueNumbers()
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(); // Stores unique numbers

            while (true)
            {
                Console.Write("Enter a number (or type 'Quit' to exit): ");
                string input = Console.ReadLine();

                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase)) // Check for exit condition
                    break;

                if (int.TryParse(input, out int number)) // Convert input to integer
                {
                    uniqueNumbers.Add(number); // Add to HashSet (automatically removes duplicates)
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Display unique numbers
            Console.WriteLine("Unique Numbers: " + string.Join(", ", uniqueNumbers));
        }


        public static void ThreeSmallestNumbers()
        {
            while (true)
            {
                Console.Write("Enter at least 5 comma-separated numbers (e.g., 5,1,9,2,10): ");
                string input = Console.ReadLine();

                // Split input by commas and convert to a list of integers
                List<int> numbers = input.Split(',')
                                         .Select(num => num.Trim()) // Remove spaces
                                         .Where(num => int.TryParse(num, out _)) // Ensure valid numbers
                                         .Select(int.Parse) // Convert to integers
                                         .ToList();

                // Validate the input
                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                }
                else
                {
                    // Sort and take the smallest 3 numbers
                    numbers.Sort();
                    List<int> smallestNumbers = numbers.Take(3).ToList();

                    Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
                    break; // Exit the loop after successful input
                }
            }
        }
        }
    }
