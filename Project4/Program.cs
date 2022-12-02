class Calculations
{
    public static int Multiply(int val1, int val2)
    {
        int result = val1 * val2; // doesn't have to be called element, can be called whatever, the type matters
        return result;
    }
}

class UserInput
{
    public static int EnterIntNumber()
    {
        int input = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Enter the intiger number");
                input = Int32.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Value provided is wrong try again")


        }
        }
        return input;

    }
}
class Functions
{
    public static void Main(string[] args)
    {
        int element1 = UserInput.EnterIntNumber();
        int element2 = UserInput.EnterIntNumber();
        int result = Calculations.Multiply(element1, element2);
        Console.WriteLine(element1 + "*" + element2 + "=" + result);
    }
    




 

