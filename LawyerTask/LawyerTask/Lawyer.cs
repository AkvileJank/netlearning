using System;
namespace LawyerTask
{
    class Lawyer : Person
    {
        private int lawyerId;
        private int helpedInCrimesSolving;

        public Lawyer()
        {
        }

        public Lawyer(string name, string surname, int lawyerId, int helpedInCrimesSolving) : base(name, surname)
        {
            this.lawyerId = lawyerId;
            this.helpedInCrimesSolving = helpedInCrimesSolving;
        }

        public int LawyerId { get; set; }
        public int HelpedInCrimesSolving { get; set; }

        public override string ToString()
        {
            string details = "Name: " + this.Name + "Surname: " + this.Surname +
                "LawyerId: " + this.LawyerId + "Helped in crimes solving: " + helpedInCrimesSolving;
            return details;
        }
    }
}

