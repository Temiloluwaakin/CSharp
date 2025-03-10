using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionTwo
{
    public static class EnterNumber
    {
        public static void EnterNumbers()
        {

            bool flag = true;

            int sum = 0;

            while (flag)
            {
                Console.Write("Enter number: ");

                string number = Console.ReadLine();

                bool isNumber = int.TryParse(number, out int ConvertedNum);

                if (isNumber)
                {
                    sum += ConvertedNum;
                    Console.WriteLine($"sum: {sum}");
                }
                else
                {
                    if (number.Equals("ok"))
                        flag = false;
                }
            }
        }
    }
}
