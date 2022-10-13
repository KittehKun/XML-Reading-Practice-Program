using XML_Reading_Practice_Program.src.interfaces;

namespace XML_Reading_Practice_Program.src.classes
{
    internal class Employee : IEmployee
    {
        //Interface Implementation
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"       Name: {Name}" +
                   $"\n        Age: {Age}" +
                   $"\n  Job Title: {Title}" +
                   $"\n     Salary: ${Salary}/yr\n";
        }

        //Constructor
        public Employee(string name, int age, string title, double salary)
        {
            Name = name;
            Age = age;
            Title = title;
            Salary = salary;
        }
    }
}
