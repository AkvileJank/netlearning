namespace OfficerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total number of officers:");
            int arrSize = Int32.Parse(Console.ReadLine());
            Officer[] distric99 = new Officer[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine("Enter officer's details \n Name:");
                //string name = null;
                string name = Console.ReadLine();

                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("OfficerID:");
                int officerID = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Working district:");
                string workingDistrict = Console.ReadLine();

                Console.WriteLine("Number of crimes solved:");
                int crimesSolved = Int32.Parse(Console.ReadLine());
                Officer officer = new Officer(name, surname, officerID, workingDistrict, crimesSolved);
                Console.WriteLine("\n");
                distric99[i] = officer;
            }
            Console.WriteLine("Submitted officer(s) details");
            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine("Officer " + (i + 1) + ": " + distric99[i].ToString());
            }
            Console.WriteLine("Number of level 1 officers: " + Officer.Lvl1Amount(distric99));
            Console.WriteLine("Number of officers with higher level: " + Officer.HigherLvlAmount(distric99));
            Officer.FindJohn(distric99);
        }
    }
}