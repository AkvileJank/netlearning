

namespace StudentSubclassTask
{
    internal class Student : Person
    {
        private string university;

        public string Univeristy
        {
            get { return university; }
            set { this.university = value; }
        }

        public Student (string firstName, string lastName, string university) : base (firstName, lastName)
        {
            this.university = university;
        }
    }

}
