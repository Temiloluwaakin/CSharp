using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionTwo
{
    public static class FactorialThree
    {
        public static void FactoialShell()
        {

            Console.Write("Enter number: ");

            string number = Console.ReadLine();

            bool isNumber = int.TryParse(number, out int ConvertedNum);

            if (isNumber)
            {
                int res = Factoial(ConvertedNum);
                Console.WriteLine($"{number}!: {res}");
            }
            else
            {
                Console.Write("You have an invalid entered number");
            }

        }

        public static int Factoial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            return number * Factoial(number - 1);
        }
    }
}
