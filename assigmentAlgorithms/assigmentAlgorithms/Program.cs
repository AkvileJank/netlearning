class Project3
{
    static void Main(string[] args)
    {
    
        double num1 = 0;
        double num2 = 0;
        bool validInputs = true;

            try
            {
                Console.WriteLine("Enter first number:");
                num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                num2 = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input is not valid");
                validInputs = false;
            }

        if (validInputs)
        {
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
}

