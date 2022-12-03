using System.Xml.Linq;


// First attempt without multiple classes

//class StringsTask
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter chosen numbers with space between them (example: 87 65 42 90):");
//        string str = Console.ReadLine();
//        string[] arraySplit = str.Split(" ");
//        int arraySize = arraySplit.Length;
//        int element = 0;
//        int[] arrayOfInt = new int[arraySize];
//        int i = 0;
//        bool correctInput = true;
//        foreach (string str2 in arraySplit)
//        {
//            bool rightInput = Int32.TryParse(str2, out element);

//            if (!rightInput)
//            {
//                Console.WriteLine("Input is not valid. Further actions are not possible");
//                correctInput = false;
//                break;
//            }
//            arrayOfInt[i] = element;
//            i++;
//        }

//        int index = 0;
//        if (correctInput)
//        {
//            Console.WriteLine("These numbers are now in intiger array:");
//            while (index<arraySize)
//            {
//                Console.WriteLine(arrayOfInt[index]);
//                index++;
//            }
//        }


//    }

// Attempt with classes and created functions


class StringsTask
{
    public static void Main(string[] args)
    {
        string[] arraySplit = UserInput.StringInputArray();
        UserInput.StringToIntArray(arraySplit);
    }

}
class UserInput
{
    public static string[] StringInputArray()
    {
        Console.WriteLine("Enter chosen numbers with space between them (example: 87 65 42 90):");
        string str = Console.ReadLine();
        string[] arraySplit = str.Split(" ");
        int arraySize = arraySplit.Length;
        return arraySplit;
    }

    public static void StringToIntArray(string[] arraySplit)
    {
        int arraySize = arraySplit.Length;
        int element = 0;
        int i = 0;
        int[] arrayOfInt = new int[arraySize];
        bool correctInput = true;
        foreach (string str2 in arraySplit)
        {
            bool rightInput = Int32.TryParse(str2, out element);

            if (!rightInput)
            {
                Console.WriteLine("Input is not valid. Further actions are not possible");
                correctInput = false;
                break;
            }
            arrayOfInt[i] = element;
            i++;
        }
        int index = 0;
        if (correctInput)
        {
            Console.WriteLine("These numbers are now in intiger array:");
            while (index < arraySize)
            {
                Console.WriteLine(arrayOfInt[index]);
                index++;
            }
        }
    }
}

