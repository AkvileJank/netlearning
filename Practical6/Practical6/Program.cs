class StringsDemo
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] arraySplit = str.Split(" ");
        int arraySize = arraySplit.Length;
        int element = 0;
        int[] arrayOfInt = new int[arraySize];
        int i = 0;

        foreach (string str2 in arraySplit)
        {
            bool rightInput = Int32.TryParse(str2, out element);
            
            if (!rightInput)
            {
                Console.WriteLine("Input is not valid. Further actions are not possible");
                break;
            }
            arrayOfInt[i] = element;
            i++;
        }
        Console.WriteLine(arrayOfInt[1]);


        //how to create array of intigers from element?? 
        //for (int i = 0; i < arraySize; i++)
        //{
        //    arrayOfInt[i] = element;
        //}

        //Console.WriteLine(arrayOfInt[1]);



    }
}
