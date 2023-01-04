
namespace LawyerTask
{
    class Officer : Person
    {
        private int officerId;
        private int crimesSolved;

        public Officer() { }
        public Officer(string name, string surname, int officerId, int crimesSolved) : base(name, surname)
        {
            base.Name = name;
            base.Surname = surname;
            this.officerId = officerId;
            this.crimesSolved = crimesSolved;
        }

        public int OfficerId
        {
            get { return this.officerId; }
            set { this.officerId = value; }
        }

        public int CrimesSolved
        {
            get { return this.crimesSolved; }
            set { this.crimesSolved = value; }
        }

        public int CalculatedLevel()
        {
            if (this.crimesSolved < 20)
            {
                return 1;
            }
            else if (this.crimesSolved > 20 && this.crimesSolved < 40)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        public override string ToString()
        {
            string details = "Name: " + this.Name + " Surname: " + this.Surname +
                " OfficerID: " + this.officerId + " Crimes solved: " + this.crimesSolved + "\n";
            return details;
        }


    }
}


