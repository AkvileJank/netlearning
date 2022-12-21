

namespace DistrictTask
{
    class Officer
    {
        private string name;
        private string surname;
        private int officerId;
        private int crimesSolved;
        public Officer(string objName, string objSurname, int objOfficerId, int objCrimesSolved)
        {
            this.name = objName;
            this.surname = objSurname;
            this.officerId = objOfficerId;
            this.crimesSolved = objCrimesSolved;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
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
            string details = "Name: " + name + " ; " + "Surname: " + surname + " ; " + "OfficerID: " + officerId
                + " ; " + " ; " + " Crimes solved:" + crimesSolved;
            return details;
        }
    }
}
