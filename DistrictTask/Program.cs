namespace DistrictTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Officer officer1 = new Officer("John", "Hill", 1234, 50);
            Officer officer2 = new Officer("Tom", "Jonson", 1235, 20);
            Officer officer3 = new Officer("Max", "Still", 1236, 90);
            Officer officer4 = new Officer("Kendra", "Miles", 1237, 38);
            Officer officer5 = new Officer("Sam", "Nielsen", 1238, 76);
            Officer officer6 = new Officer("Jill", "Rives", 1239, 12);
            Officer officer7 = new Officer("Juliet", "Nest", 1240, 8);

            Officer[] district1arr = new Officer[3];
            district1arr[0] = officer1;
            district1arr[1] = officer2;
            district1arr[2] = officer3;

            Officer[] district2arr = new Officer[4];
            district2arr[0] = officer4;
            district2arr[1] = officer5;
            district2arr[2] = officer6;
            district2arr[3] = officer7;

            District district1 = new District("District 1", "New York", 001, district1arr);
            District district2 = new District("District 2", "San Francisco", 002, district2arr);


            Console.WriteLine(district1.ToString());
            Console.WriteLine(district2.ToString());


            district2.RemoveOfficer();
            Console.WriteLine("Officer Kendra in district 2 was removed. Updated District 2:");
            Console.WriteLine(district2.ToString());

            Console.WriteLine("District 1 average level: " + district1.AverageLvl());
            Console.WriteLine("District 2 average level: " + district2.AverageLvl());

            District[] arrOfDistricts = new District[2];
            arrOfDistricts[0] = district1;
            arrOfDistricts[1] = district2;

            float bothDistrictsLenght = district1arr.Length + district1arr.Length;
            Console.WriteLine("Total number of officers in both districts: " + bothDistrictsLenght);

            float averageOfBoth = district1.LvlSum() + district2.LvlSum() / bothDistrictsLenght;
            Console.WriteLine("Average level of both districts: " + averageOfBoth);


            if (district1.AverageLvl() > district2.AverageLvl())
            {
                Console.WriteLine("District 1 officers' level is higher. District 1 is better");
            }
            else
            {
                Console.WriteLine("District 2 officers' level is higher. District 2 is better");
            }

            district1 = null;
            Console.WriteLine(district1);















        }
    }
}