
namespace OfficerTask
{
    class Officer
    {
        private string name;
        private string surname;
        private int officerId;
        private string workingDistrict;
        private int crimesSolved;
        public Officer(string objName, string objSurname, int objOfficerId, string objWorkingDistrict, int objCrimesSolved)
        {
            this.name = objName;
            this.surname = objSurname;
            this.officerId = objOfficerId;
            this.workingDistrict = objWorkingDistrict;
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

        public string WorkingDistrict
        {
            get { return this.workingDistrict; }
            set { this.workingDistrict = value; }
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
            string details = "Name: " + name + " ; " + "Surname: " + surname + " ; " + "OfficerID: " + officerId + " ; " + "Working district: " + workingDistrict + " ; " + " Crimes solved:" + crimesSolved;
            return details;
        }

        public static int Lvl1Amount(Officer[] distric99)
        {
            int lvl1amount = 0;
            for (int i = 0; i < distric99.Length; i++)
            {
                if (distric99[i].CalculatedLevel() == 1)
                {
                    lvl1amount++;
                }
            }
            return lvl1amount;
        }

        public static int HigherLvlAmount(Officer[] distric99)
        {
            return distric99.Length - Officer.Lvl1Amount(distric99);
        }

        public static void FindJohn(Officer[] distric99)
        {
            int namedJohn = 0;
            for (int i = 0; i < distric99.Length; i++)
            {
                if (distric99[i].Name == "John")
                {
                    namedJohn++;
                }
            }
            if (namedJohn > 0)
            {
                Console.WriteLine("There is officer named John");
            }
            else
            {
                Console.WriteLine("There is no officer named John");
            }
        }
    }
}