

namespace StudentSubclassTask
{
    internal class Person
    {
        string name;
        string lastName;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public Person(string personName, string personLastName)
        {
            this.name = personName;
            this.lastName = personLastName;
        }
    }
}
