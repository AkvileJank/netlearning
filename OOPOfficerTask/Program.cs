namespace OOPOfficerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                Console.WriteLine("Enter officer's details \n Name:");
                //string name = null;
                string name = Console.ReadLine();
                //if (name == "")
                //{
                //    break;
                //}
                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("OfficerID:");
                int officerID = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Working district:");
                string workingDistrict = Console.ReadLine();
                Console.WriteLine("Number of crimes solved:");
                int crimesSolved = Int32.Parse(Console.ReadLine());
                Officer officer = new Officer(name, surname, officerID, workingDistrict, crimesSolved);
                Console.WriteLine("Create another officer? Type no");
                string stop = Console.ReadLine();
                if (stop == "no")
                {
                    break;
                }
                Console.WriteLine("\n");

            }
        }
          
         public Officer[] toArray = new Officer[0];
         // add new element to the array with each iteration? 


        //how many with level 1 - call function to return level, already created

        // how many above level 1 - maybe divide lvl 1 from total array lengtht?

        // Officer named John - if name == "John" check all array elements, when found print "Yes", return.
    } 
    }