using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        public double Calculate(double num1, double num2, char operation)
        {
            if (operation == '+')
            {
                return num1 + num2;
            }
            else if (operation == '-')
            {
                return num1 - num2;
            }
            else if (operation == '*')
            {
                return num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return double.NaN; // Not a number
                }
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operator.");
                return double.NaN;
            }
        }

    }
}
