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

        Console.WriteLine("Negative numbers of this array:");
        bool isNegative = false;
        foreach (int negativenumber in numbers)
        {
            if (negativenumber < 0)
            {
                isNegative = true;
                Console.WriteLine(negativenumber);
            }
        }
        if (!isNegative)
        {
            Console.WriteLine("-");
        }

        Console.WriteLine("Odd numbers of this array:");
        bool isOdd = false;
        int oddamount = 0;
        foreach (int oddnumber in numbers)
        {
            if (oddnumber % 2 != 0)
            {
                isOdd = true;
                Console.WriteLine(oddnumber);
                oddamount++;
            }
        }

        if(!isOdd)
        {
            Console.WriteLine("-");
        }
        Console.WriteLine($"The amount of odd numbers is: {oddamount}");

        if (numbers.Length != numbers.Distinct().Count())
        {
            Console.WriteLine("There are multiple elements with the same value");
        }
        else
        {
            Console.WriteLine("There are no elements with the same value");
        }

        int index = 0;
        Console.WriteLine("Every second element of this array:");
        while (index<arraySize)
        {
            Console.WriteLine(numbers.GetValue(index));
            index += 2;
        }
        double sum = 0;
        foreach (int element in numbers)
        {
            sum+=element; 
        }
        double average = sum / arraySize;
        Console.WriteLine($"Average value of this array is: {average}");

        int smallernum = 0;
        foreach (int smaller in numbers)
        {
            if (smaller < average)
            {
                smallernum++;
            }
        }
        Console.WriteLine($"Number of elements smaller than average value: {smallernum}");


    }
}
