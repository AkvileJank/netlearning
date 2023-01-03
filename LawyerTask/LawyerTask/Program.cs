namespace LawyerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of districts: ");
            int numDistricts = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numDistricts; i++)
            {
                Console.WriteLine("\n Title: ");
                string title = Console.ReadLine();
                Console.WriteLine("City: ");
                string city = Console.ReadLine();
                Console.WriteLine("DistrictId: ");
                int districtId = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of officers: ");
            int numOfficers = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numDistricts; i++)
            {
                Officer[] districtArr = new Officer[numOfficers / numDistricts];
                // ?? look how to crate n amount of districts?? for each district need to hav separate array with officer, so no w I am creating that array of officers empty;
            }
            for (int i = 0; i<numOfficers; i++)
            {
                Console.WriteLine("\n Name: ");
                string ofName= Console.ReadLine();
                Console.WriteLine("Surname: ");
                string offSurname = Console.ReadLine();
                Console.WriteLine("Officer Id: ");
                int officerId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Crimes solved: ");
                int crimesSolved = Int32.Parse(Console.ReadLine());

                Officer officer = new Officer(ofName, offSurname, officerId, crimesSolved);
                //districtArr[i] = officer;  Need to figure out how to add officers to that district array.
        }
    }
}

