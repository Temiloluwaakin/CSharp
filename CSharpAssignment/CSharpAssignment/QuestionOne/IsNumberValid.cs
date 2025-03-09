using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionOne
{
    //make it public
    public static class IsNumberValid
    {
        //method
        public static void IsInputValidNumber()
        {
            Console.WriteLine("Enter a number btw 1-10: ");

            string input = Console.ReadLine();

            bool isNumber = int.TryParse(input, out int ConvertedVal);

            if (isNumber)
            {
                if (ConvertedVal > 0 && ConvertedVal <= 10)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Not Valid");
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }
        }
    }
}
