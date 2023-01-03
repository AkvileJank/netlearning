using System;

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
        public string Title { get; set; }
        public string City { get; set; }
        public string DistrictId { get; set; }
        public Officer[] OfficersInTheDistrict { get; set; }

        public override string ToString()
        {
            string details = "Title:\n" + title + "\n" + "City:\n" + city + "\n" + "DistrictID:\n" + districtId
                + "\n" + "Officers:\n";

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

        public bool AddOfficer()
        {
            for (int i = 0; i < officersInTheDistrict.Length; i++)
            {
                if (officersInTheDistrict[i] == null)
                {
                    Officer addedOfficer = new Officer("Mike", "Solovan", 0004, 60);
                    officersInTheDistrict[i] = addedOfficer;
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

        public float AverageLvl()
        {
            float averageLvl = this.LvlSum() / officersInTheDistrict.Length;
            return averageLvl;
        }

        public static void AverageBoth(District district1, District district2, float bothDistrictsLenght)
        {
            float averageOfBoth = (district1.LvlSum() + district2.LvlSum()) / bothDistrictsLenght;
            Console.WriteLine("Average level of both districts: " + averageOfBoth);

            if (district1.AverageLvl() > district2.AverageLvl())
            {
                Console.WriteLine("District 1 officers' level is higher. District 1 is better");
            }
            else
            {
                Console.WriteLine("District 2 officers' level is higher. District 2 is better");
            }
        }
    }
}

