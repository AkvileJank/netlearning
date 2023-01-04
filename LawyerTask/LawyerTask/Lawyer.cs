
namespace LawyerTask
{
    class Lawyer : Person
    {
        private int lawyerId;
        private int helpedInCrimesSolving;

        public Lawyer() { }

        public Lawyer(string name, string surname, int lawyerId, int helpedInCrimesSolving) : base(name, surname)
        {
            base.Name = name;
            base.Surname = surname;
            this.lawyerId = lawyerId;
            this.helpedInCrimesSolving = helpedInCrimesSolving;
        }

        public int LawyerId
        {
            get { return this.lawyerId; }
            set { this.lawyerId = value; }
        }
        public int HelpedInCrimesSolving
        {
            get { return this.helpedInCrimesSolving; }
            set { this.helpedInCrimesSolving = value; }
        }

        //public int HelpedInCrimesSolving { get; set; }

        public override string ToString()
        {
            string details = "Name: " + this.Name + " Surname: " + this.Surname + " LawyerId: "
                + this.lawyerId + " Helped in crimes solving: " + this.helpedInCrimesSolving + "\n";
            return details;
        }
    }
}

