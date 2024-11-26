using System;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator App");
            Console.WriteLine($"2 + 3 = {Calculator.Add(2, 3)}");
        }
    }
}
