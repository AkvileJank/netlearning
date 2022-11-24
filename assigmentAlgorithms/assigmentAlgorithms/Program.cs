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


        if (symbol == "*")
        {
            double multipl = num1 * num2;
            Console.WriteLine(num1 + "*" + num2 + "=" + multipl);
        }

        else if (symbol == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Operation is not valid");
            }
            else
            {
                double divis = num1 / num2;
                Console.WriteLine(num1 + "/" + num2 + "=" + divis);
            }

        }

        else if (symbol == "%")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Operation is not valid");
            }
            else
            {
                double mod = num1 % num2;
                Console.WriteLine(num1 + "%" + num2 + "=" + mod);
            }
        }

        else if (symbol == "+")
        {
            double add = num1 + num2;
            Console.WriteLine(num1 + "+" + num2 + "=" + add);

        }

        else if (symbol == "-")
        {
            double sub = num1 - num2;
            Console.WriteLine(num1 + "-" + num2 + "=" + sub);
        }

        else
        {
            Console.WriteLine("Operation symbol is not valid");
        }




    }
}

