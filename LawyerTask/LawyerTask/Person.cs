using System;
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

        public string Name { get; set; }
        public string Surname { get; set; }


        public virtual string ToString()
        {
            string details = "Name: " + this.name + "Surname: " + this.surname;
            return details;
        }

    }
}

