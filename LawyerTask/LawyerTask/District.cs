
namespace LawyerTask
{
    class District
    {
        private string title;
        private string city;
        private int districtId;
        private Officer[] officersInTheDistrict;

        public District() { }
        public District(string title, string city, int districtId, Officer[] officersInTheDistrict)
        {
            this.title = title;
            this.city = city;
            this.districtId = districtId;
            this.officersInTheDistrict = officersInTheDistrict;
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public int DistrictId
        {
            get { return this.districtId; }
            set { this.districtId = value; }
        }
        public Officer[] OfficersInTheDistrict
        {
            get { return this.officersInTheDistrict; }
            set { this.officersInTheDistrict = value; }
        }

        public override string ToString()
        {
            string details = "Title:\n" + title + "\n" + "City:\n" + city + "\n" +
                "DistrictID:\n" + districtId + "\n" + "Officers:\n";

            foreach (Officer officer in officersInTheDistrict)
            {
                if (officer == null)
                {
                    Console.WriteLine("");
                }
                else
                {
                    details += officer.ToString();
                }

            }
            return details;
        }

        public bool RemoveOfficer()
        {
            for (int i = officersInTheDistrict.Length - 1; i > -1; i--)

                if (officersInTheDistrict[i] != null)
                {
                    officersInTheDistrict[i] = null;
                    break;
                }
            return true;
        }

        public bool AddCreatedOfficer(Officer officer)
        {
            for (int i = 0; i < officersInTheDistrict.Length; i++)
            {
                if (officersInTheDistrict[i] == null)
                {
                    officersInTheDistrict[i] = officer;
                    break;
                }
            }
            return true;
        }


        public float LvlSum()
        {
            float lvlSum = 0;
            foreach (Officer officer in officersInTheDistrict)
            {
                if (officer == null)
                {
                    continue;
                }
                else
                {
                    lvlSum += officer.CalculatedLevel();
                }
            }
            return lvlSum;
        }

        public float AvgLevelInDistrict()
        {
            float averageLvl = this.LvlSum() / officersInTheDistrict.Length;
            return averageLvl;
        }

    }
}

