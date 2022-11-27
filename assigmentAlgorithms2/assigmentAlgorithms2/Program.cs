using System;

class assigmentAlgorithms2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your birth year:");
        int year = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter your birth month in numbers:");
        int month = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter your birth day:");
        int day = Int32.Parse(Console.ReadLine());


        if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            Console.WriteLine("Your zodiac sign is AQUARIUS.");
        else if (month == 2 || (month == 3 && day <= 20))
            Console.WriteLine("Your zodiac sign is PISCES.");
        else if (month == 3 || (month == 4 && day <= 19))
            Console.WriteLine("Your zodiac sign is ARIES.");
        else if (month == 4 || (month == 5 && day <= 20))
            Console.WriteLine("Your zodiac sign is TAURUS.");
        else if (month == 5 || (month == 6 && day <= 20))
            Console.WriteLine("Your zodiac sign is GEMINI.");
        else if (month == 6 || (month == 7 && day <= 22))
            Console.WriteLine("Your zodiac sign is CANCER.");
        else if (month == 7 || (month == 8 && day <= 22))
            Console.WriteLine("Your zodiac sign is LEO.");
        else if (month == 8 || (month == 9 && day <= 22))
            Console.WriteLine("Your zodiac sign is VIRGO.");
        else if (month == 9 || (month == 10 && day <= 22))
            Console.WriteLine("Your zodiac sign is LIBRA.");
        else if (month == 10 || (month == 11 && day <= 21))
            Console.WriteLine("Your zodiac sign is SCORPIO.");
        else if (month == 11 || (month == 12 && day <= 21))
            Console.WriteLine("Your zodiac sign is SAGITTARIUS.");
        else
            Console.WriteLine("Your zodiac sign is CAPRICORN.");
        
    }
}

