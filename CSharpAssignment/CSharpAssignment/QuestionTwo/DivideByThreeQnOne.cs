using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.QuestionTwo
{
   
    public static class DivideByThree
    {
        public static void Divideby3()
        {

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
