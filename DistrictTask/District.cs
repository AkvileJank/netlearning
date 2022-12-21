namespace DistrictTask
{
    internal class District
    {
        private string title;
        private string city;
        private int districtId;
        private Officer[] officersInTheDistrict = new Officer[0];

        public District(string title, string city, int districtId, Officer[] officersInTheDistrict)
        {
            this.title = title;
            this.city = city;
            this.districtId = districtId;
            this.officersInTheDistrict = officersInTheDistrict;
        }


    }
}
