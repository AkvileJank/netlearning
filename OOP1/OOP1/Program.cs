class OOP
{
    static void Main(string[] args)
    {
        Computer computer = new Computer(); // created object computer
        computer = Computer.GetInstance();
        computer.Turnon();
        //computer.SetPrice(300);
        //double price = computer.GetPrice();
        computer.Price = 300;// set called
        double price = computer.Price;
        // computer.price = 300, double price = computer.price


    }
}

class Computer
{
    // properties of the computer, defined directly inside the class
    private double price, weightKg;
    private string color;
    private bool on; // will indicate if computer is on or off
    


        public static Computer GetInstance()
    {
        return new Computer();
    }

    public void Turnon() // function specifically used for computer objects
    {
        on = true;
    }

    //shorter syntax for getters and setters

    public double Price
    {
        get {
            //any logic can be written
            return this.price;
        }
        set {
            //any logic
            this.price = value;
        }
    }

    //getters and setters
    //public double GetPrice()
    //{
    //    return price;
    //}

    //public void SetPrice(double price)
    //{
    //    this.price = price; // if we want to access current object, use this keyword, pointing to a parameter of this object
    //}


    public void RandomFunction()
    {
        //this - if we want to refer to this object
        Computer computer = new Computer();// absolutely different object, this keyword refers to the current compue=ter you are working from
    }
}


