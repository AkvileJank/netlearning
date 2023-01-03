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
            Console.WriteLine(district2.ToString());

            district2.AddOfficer();
            Console.WriteLine(district2.ToString());

            Console.WriteLine("District 1 average level: " + district1.AverageLvl());
            Console.WriteLine("District 2 average level: " + district2.AverageLvl());

            District.CreateDistrictArray(district1, district2);

            float bothDistrictsLenght = district1arr.Length + district2arr.Length;
            Console.WriteLine("Total number of officers in both districts: " + bothDistrictsLenght);

            District.AverageBoth(district1, district2, bothDistrictsLenght);

            district1 = null;
            Console.WriteLine(district1);















        }
    }
}