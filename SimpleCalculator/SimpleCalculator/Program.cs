using SimpleCalculator;

public class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        {
            Console.WriteLine("Enter first number");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = calculator.Calculate(input1, input2, operation);
            Console.WriteLine($"Result: {result}");
           
        }
    }
}
