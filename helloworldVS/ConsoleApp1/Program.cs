
class Consoleapp1
{

    public static void Main(string[] args)
    {
        //int intvariable = 20;
        ////// See https://aka.ms/new-console-template for more information
        ////Console.WriteLine("Hello, World 12345!");
        ////Console.WriteLine("Hello, World 2!");
        //Console.WriteLine(intvariable);
        //intvariable = 18;
        //Console.WriteLine(intvariable);
        //intvariable = 27;
        //Console.WriteLine(intvariable);

        string name = "John";
        byte age = 18;///unsigned integer - age can not be negative, byte is i nteger from 0 to 256
        //sbyte age = 18;///intiger
        char gender = 'M';
        float height = 1.87f;
        bool underaged, smoking;
        //Console.WriteLine(name);
        //Console.WriteLine(age);
        //Console.WriteLine(gender);
        //Console.WriteLine(height);
        //Console.WriteLine(name + " " + age + " " + gender + " " + height);
        Console.WriteLine(name + '\n' + age + '\n' + gender + '\n' + height);
    }
}