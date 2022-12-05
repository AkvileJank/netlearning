using System.Text.RegularExpressions;

class PhoneNumberTask
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter your phone number:");
        string phoneNum = Console.ReadLine();
        //var match = Regex.Match(phoneNum, ((@"\+370[0-9]{8}$") || (@"\+370 [0-9]{8}$") || (@"[0-9]{8}$"));

        bool match = true;

        if(match)
        {
            match = Regex.Match(phoneNum, @"\+370[0-9]{8}$").Success || Regex.Match(phoneNum, @"\+370 [0-9]{8}$").Success || Regex.Match(phoneNum, @"\[0-9]{8}$").Success;
            Console.WriteLine("Phone number provided is correct");
        }

        else
        {
            Console.WriteLine("Phone number provided not correct");
        }
        






    }
}
