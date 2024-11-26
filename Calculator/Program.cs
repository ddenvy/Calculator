using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                double result = op switch
                {
                    "+" => Add(num1, num2),
                    "-" => Subtract(num1, num2),
                    "*" => Multiply(num1, num2),
                    "/" => Divide(num1, num2),
                    _ => throw new InvalidOperationException("Invalid operator")
                };
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
