class Project3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        double num1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double num2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter math operation symbol (* - multiplication, / - division, % - modulo, + - addition, - - subtraction)");
        string symbol = Console.ReadLine();

        double result = 0;

        if (symbol == "*")
            result = num1 * num2;
        else if (symbol == "/")
        {
            if (num2 == 0)
                Console.WriteLine("Operation is not valid");
            else
                result = num1 / num2;
        }
        else if (symbol == "%")
        {
            if (num2 == 0)
                Console.WriteLine("Operation is not valid");
            else
                result = num1 % num2;
        }
        else if (symbol == "+")
            result = num1 + num2;
        else if (symbol == "-")
            result = num1 - num2;
        else
            Console.WriteLine("Operation symbol is not valid");

        Console.WriteLine(num1 + symbol + num2 + "=" + result);






    }
}

