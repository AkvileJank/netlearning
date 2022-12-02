using System.Globalization;
using System.Security.Cryptography;
using System.Transactions;

class UserInput
{
    public static int EnterIntiger()
    {
        int input = 0;
        while (true)
        {
            try
            {
                input = Int32.Parse(Console.ReadLine());
                break;
            }

            catch
            {
                Console.WriteLine("The provided input is not valid. Try again.");
            }
        }
        return input;
    }
}
class Practical5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("To create new array, please enter the size of the array");
        int arraySize = UserInput.EnterIntiger();
        int[] numbers = new int[arraySize];
        int number = 0;
        
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine($"Enter the number {i}");
            number = UserInput.EnterIntiger();
            numbers[i] = number;
        }

        Console.WriteLine("Negative numbers of this array are:");
        foreach (int negativenumber in numbers)
        {
          
           if (negativenumber < 0)
            {
                Console.WriteLine(negativenumber);
            }
          
        }
        Console.WriteLine("Odd numbers of this array are:");
        int oddamount = 0;
        foreach (int oddnumber in numbers)
        {
            if (oddnumber % 2 == 0)
            {
                Console.WriteLine(oddnumber);
                oddamount++;
            }
        }
        Console.WriteLine($"The amount of odd numbers is: {oddamount}");

        
        







    }
}
