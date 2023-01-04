
namespace LawyerTask
{
    class Person
    {
        private string name;
        private string surname;

        public Person()
        {
        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }


        public virtual string ToString()
        {
            string details = "Name: " + this.name + " Surname: " + this.surname;
            return details;
        }

    }
}

