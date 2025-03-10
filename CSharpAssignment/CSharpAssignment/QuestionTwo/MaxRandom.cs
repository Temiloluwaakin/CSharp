using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionTwo
{
    public static class MaxRandom
    {
        public static void MaxRandomNumber()
        {
            Console.Write("Enter a list of numbers: ");

            string Numbers = Console.ReadLine();

            string[] holder = Numbers.Split(',');

            int[] intConvertedString = new int[holder.Length];

            for (int i = 0; i < holder.Length; i++)
            {
                bool isNumber = int.TryParse(holder[i], out int ConvertedNum);
                //by defualt non numbers will be 0
                //doesnt matter since we are looking for max
                if (isNumber)
                {
                    intConvertedString[i] = ConvertedNum;
                }
            }

            Console.WriteLine("The max number is: " + intConvertedString.Max());
        }
    }
}
