using System.Text.RegularExpressions;

class PhoneNumberTask
{
    public static void Main(string[] args)
    {

       Console.WriteLine("Enter your phone number:");
       string phoneNum = Console.ReadLine();
       bool match = Regex.Match(phoneNum, @"(\+370){0,1} {0,1}[0-9]{8}$").Success;
        if (match)
        {
            Console.WriteLine("Phone number provided is correct");
        }
        else
        {
            Console.WriteLine("Phone number provided is not correct");
        }
    }
}
