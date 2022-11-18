
class Project2
{

    static void Main(string[] args)
    {
        //string str1 = "Hello";
        //string str2 = "World";
        //int number = 2121;
        //int number2 = 134;

        //int modResult = 10 % 3; // 10 - 3 * [10/3] = 1
        //int modResult2 = 16 % 7; //16 - 7 * [16/7] = 2
        //Console.WriteLine(modResult);
        //Console.WriteLine(modResult2);

        // Logical values
        bool answer;
        //answer = 13 > 7;//true
        //answer = 19 < 7;//true
        //answer = 13 >= 7;//true
        //answer = 13 > 13;//false
        //answer = 13 >= 13;//true
        //answer = 13 == 13;//true
        //answer = 13 != 13;//false != means NOT Equal to
        //answer = !true;//false (the opossite of true)
        //answer = !false;//true (the opposite of false)
        //answer = true && true;//true
        //answer = (13 >= 13) && (13 == 13);//would be the same as true && true


        //answer = 13 == 13;//true
        //answer = 13 != 13;//false, != means not equal

        //answer = !true;//false
        //answer = !false;//true

        //answer = true && true;//true
        //answer = (13 >= 13) && (13 == 13);

        //answer = true && false; //false
        //answer = false && false;//false - true is when both sides are true

        //double val = 23.6543;
        //double val2 = 56.56565;
        //answer = ++val == 21 && ++val2 == 57.56565;// if the first part is false the second one is not executed
        //Console.WriteLine(answer);
        //Console.WriteLine(val);
        //Console.WriteLine(val2);

        //answer = true || true;//true
        //answer = true || false;//true
        //answer = false || false;//false


        //Random rand = new Random();

        //double randomResult = rand.NextDouble();// returns the random value from 0 to 1
        ////int oneToTen = (int) (randomResult)
        //Console.WriteLine(oneToTen);

        //bool isMorning = true;


        //if(isMorning)
        //{
        //    Console.WriteLine("Wake up!");
        //}

        //string time = Console.ReadLine();
        //if (time == "Morning")
        //{
        //    Console.WriteLine("Good morning!");
        //}
        //else if (time == "Afternoon")
        //{
        //    Console.WriteLine("Good afternoon!");
        //}
        //else if (time == "Evening")
        //{
        //    Console.WriteLine("Good evening!");
        //}

        int time = Int32.Parse(Console.ReadLine());
        if (time >= 5 && time < 9)
        {
            Console.WriteLine("Good morning!");
        }
        else if (time >= 9 && time < 16)
        {
            Console.WriteLine("Good afternoon!");
        }
        else if (time < 24 && time >= 0)
        {
            Console.WriteLine("Good evening!");
        }
        else
        {
            Console.WriteLine("Input is not valid");
        }


    }
}

