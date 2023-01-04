namespace LawyerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of districts: ");
            int numDistricts = Int32.Parse(Console.ReadLine());
            District[] allDistricts = new District[numDistricts];
            for (int i = 0; i < numDistricts; i++)
            {
                Console.WriteLine("\nDistrict's title: ");
                string title = Console.ReadLine();
                Console.WriteLine("City: ");
                string city = Console.ReadLine();
                Console.WriteLine("DistrictId: ");
                int districtId = Int32.Parse(Console.ReadLine());

                Officer[] districtArray = new Officer[5];
                District district = new District(title, city, districtId, districtArray);
                allDistricts[i] = district;
            }

            Console.WriteLine("\nEnter the number of officers: ");
            int numOfficers = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numOfficers; i++)
            {
                Console.WriteLine("\nOfficer's name: ");
                string ofName = Console.ReadLine();
                Console.WriteLine("Surname: ");
                string offSurname = Console.ReadLine();
                Console.WriteLine("Officer Id: ");
                int officerId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Crimes solved: ");
                int crimesSolved = Int32.Parse(Console.ReadLine());

                Officer officer = new Officer(ofName, offSurname, officerId, crimesSolved);

                allDistricts[i % numDistricts].AddCreatedOfficer(officer);
            }

            Console.WriteLine("\nInformation about the entered districts:");
            for (int i = 0; i < numDistricts; i++)
            {
                Console.WriteLine(allDistricts[i].ToString());
            }

            Console.WriteLine("\nEnter the number of lawyers:");
            int numLawyers = Int32.Parse(Console.ReadLine());
            var lawyerList = new List<Lawyer>();
            int totalCrimesHelped = 0;
            int maxNumCrimes = 1;

            for (int i = 0; i < numLawyers; i++)
            {
                Console.WriteLine("\nLawyer's name: ");
                string lName = Console.ReadLine();
                Console.WriteLine("Surname: ");
                string lSurname = Console.ReadLine();
                Console.WriteLine("Lawyer's Id: ");
                int lawyerId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Helped in crimes solving: ");
                int helpedInCrimesSolving = Int32.Parse(Console.ReadLine());
                totalCrimesHelped += helpedInCrimesSolving;

                Lawyer lawyer = new Lawyer(lName, lSurname, lawyerId, helpedInCrimesSolving);
                lawyerList.Add(lawyer);
            }
            Console.WriteLine("\nThese are the entered lawyers:");
            foreach (Lawyer lawyer in lawyerList)
            {
                Console.WriteLine(lawyer.ToString());
            }

            Console.WriteLine("\nTotal amount of crimes solved with lawyers help: " + totalCrimesHelped);

            Lawyer maxLawyer = new Lawyer();

            foreach (Lawyer lawyer in lawyerList)
            {
                if (lawyer.HelpedInCrimesSolving > maxNumCrimes)
                {
                    maxNumCrimes = lawyer.HelpedInCrimesSolving;
                    maxLawyer = lawyer;
                }
            }
            Console.WriteLine("\nLawyer who solved the most crimes:\n" + maxLawyer.ToString());
        }
    }
}

