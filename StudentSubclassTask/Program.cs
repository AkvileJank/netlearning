namespace StudentSubclassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anna", "Person");
            Student student = new Student("Tom", "Student", "University of Oxford" );

            Console.WriteLine(person.Name + person.LastName);
            Console.WriteLine(student.Name + student.LastName + student.Univeristy);
        }
    }
}