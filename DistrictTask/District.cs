
namespace DistrictTask
{
    internal class District
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
            this.officersInTheDistrict[0] = null;
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
    }
}
