using System;

public class MainClass
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        string c = Console.ReadLine();
        int b = Convert.ToInt32(Console.ReadLine());


        int d;


        switch (c)
        {
            case "+":
                d = a + b;
                Console.WriteLine(d);
                break;
            case "-":
                d = a - b;
                Console.WriteLine(d);
                break;
            case "*":
                d = a * b;
                Console.WriteLine(d);
                break;
            case "/":
                d = a / b;
                Console.WriteLine(d);
                break;
            default:
                Console.WriteLine(" ");
                break;

        }
    }
}