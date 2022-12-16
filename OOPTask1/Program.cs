using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

class OOPTask1
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = InputValidation.NameValidation(person.Name);
        person.Surname = InputValidation.SurnameValidation(person.Surname);
        Date date = new Date();
        date.DateValidation();
        person.PrintDetails(date);
    }
}

class Person
{
    private string name;
    private string surname;
    

    public string Name
    {
        get {return this.name;}
        set {this.name = value;}
    }
    public string Surname
    {
        get {return this.surname;}
        set {this.surname = value;}
    }

    public string CalculateFullName()
    {

        string fullName = this.Name + " " + this.Surname;
        return fullName;
    }

    public void PrintDetails(Date date)
    {
        Console.WriteLine("Person's full name: " + this.CalculateFullName());
        Console.WriteLine("Person's date of birth: " + date.Year + "/" + date.Month + "/" + date.Day);
        Console.WriteLine("Person's age is: " + date.GetAge());
    }
}
class Date
{
    private int day, month, year;

    public int Day
    {
        get { return this.day; }
        set { this.day = value; }
    }
    public int Month
    {
        get { return this.month; }
        set { this.month = value; }
    }
    public int Year
    {
        get { return this.year; }
        set { this.year = value; }
    }
    public void DateValidation()
    {
        while (true)
        {
            Console.WriteLine("Enter your birth date in this format yyyy/mm/dd : ");
            string dateBirth = Console.ReadLine();
            string[] arrDate = dateBirth.Split("/");
            int year, month, day;
            try
            {
                year = Int32.Parse(arrDate[0]);
                month = Int32.Parse(arrDate[1]);
                day = Int32.Parse(arrDate[2]);
            }
            catch
            {
                Console.WriteLine("Provided input is not valid.");
                continue;
            }
            if ((year <= 0) || (month <= 0) || (month > 12) || (day <= 0) || (day > 31))
            {
                Console.WriteLine("Input provided is not valid");
                continue;
            }

            this.Year = year;
            this.Month = month;
            this.Day = day;
            break;
        }
    }
    public int GetAge()
    {
        DateTime dateOfBirth = new DateTime(this.Year, this.Month, this.Day);
        DateTime today = DateTime.Today;

        int age = today.Year - this.Year;
        if (today.Month < this.Month)
        {
            age--;

        }
        else if (today.Month == this.Month)
        {
            if (today.Day < this.Day)
            {
                age--;
            }
        }
        return age;
    }
}

class InputValidation
{
    public static string NameValidation(string inputName)
    {
        while (true)
        {
            Console.WriteLine("Please enter your name:");
            string nameCheck = Console.ReadLine();

            if (Regex.Match(nameCheck, @"^[a-zA-Z]{2,}$").Success)
            {
                return nameCheck;
            }
            else
            {
                Console.WriteLine("Provided input is not valid.");
            }
        }
    }

    public static string SurnameValidation(string inputSurname)
    {
        while (true)
        {
            Console.WriteLine("Please enter your surname:");
            string surnameCheck = Console.ReadLine();

            if (Regex.Match(surnameCheck, @"^[a-zA-Z]{2,}$").Success)
            {
                return surnameCheck;
            }
            else
            {
                Console.WriteLine("Provided input is not valid.");
            }
        }
    }




}

