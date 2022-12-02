class Project1
{

    static void Main(string[] args)
    {
        //int valInt = 7;
        //double valDob = valInt;//casting done automatically because there is no potential data lose
        //Console.WriteLine(valDob);
        //valDob = 10.56;
        //valInt = (int)valDob;//casting done manually because there is potential data lose
        //Console.WriteLine(valInt);
        //char charVar = 'A';
        //valInt= (int)charVar;
        //Console.WriteLine(valInt);
        //char unicodeVar = '\u0023';// can check unicode characters on google
        //Console.WriteLine(unicodeVar);// characters can be shown in hexadecimal numbers

        //string str1 = ""
        //string str2 = @""

        //Console.WriteLine("Please enter something");
        //string input = Console.ReadLine();
        //Console.WriteLine("Write something again");
        //string input2 = Console.ReadLine();
        //string result = input + input2;
        //Console.WriteLine(result);

        //Console.WriteLine("You entered" + input);// can write and input anything in cmd
        //Console.WriteLine("You entered: {0}", input); //another way to write

        //string numb1str = Console.ReadLine();
        //string numb2str = Console.ReadLine();
        //int number1 = Int32.Parse(numb1str);
        //int number2 = Int32.Parse(numb2str);
        //int result = number1 + number2;
        //Console.WriteLine(result);


        //Console.WriteLine("Enter the first number:");
        //string num1 = Console.ReadLine();
        //Console.WriteLine("Enter the second number:");
        //string num2 = Console.ReadLine();
        //int number1 = Int32.Parse(num1);
        //int number2 = Int32.Parse(num2);
        //int addition = number1 + number2;
        //Console.WriteLine("Addition: " + addition);
        //int subtraction = number1 - number2;
        //Console.WriteLine("Subtraction: " + subtraction);
        //int multipliation = number1 * number2;
        //Console.WriteLine("Multiplication: " + multipliation);
        //double division = number1 / number2;
        //Console.WriteLine("Division: " + division);



//////Practical task:
//With full numbers:

        //Console.WriteLine("Enter the first number:");
        //string num1 = Console.ReadLine();
        //Console.WriteLine("Enter the second number:");
        //string num2 = Console.ReadLine();

        //int number1 = Int32.Parse(num1);
        //int number2 = Int32.Parse(num2);

        //int addition = number1 + number2;
        //Console.WriteLine("Addition: " + addition);

        //int subtraction = number1 - number2;
        //Console.WriteLine("Subtraction: " + subtraction);

        //int multiplication = number1 * number2;
        //Console.WriteLine("Multiplication: " + multiplication);

        ////double numb1 = number1;
        ////double numb2 = number2;
        //double division = numb1 / numb2;
        //Console.WriteLine("Division: " + division);

        //if want to make all number with . (ex 3.45), then instead int use double:

        Console.WriteLine("Enter the first number:");
        string num1 = Console.ReadLine();
        Console.WriteLine("Enter the second number:");
        string num2 = Console.ReadLine();

        double numb1 = Double.Parse(num1);
        double numb2 = Double.Parse(num2);

        double addition = numb1 + numb2;
        Console.WriteLine(numb1 + "+" + numb2 + "=" + addition);

        double subtraction = numb1 - numb2;
        Console.WriteLine(numb1 + "-" + numb2 + "=" + subtraction);

        double multipliation = numb1 * numb2;
        Console.WriteLine(numb1 + "*" + numb2 + "=" + multipliation);

        double division = numb1 / numb2;
        division = Math.Round(division, 2);// round in two decimal numbers
        Console.WriteLine(numb1 + "/" + numb2 + "=" + division);

        






    }
}

