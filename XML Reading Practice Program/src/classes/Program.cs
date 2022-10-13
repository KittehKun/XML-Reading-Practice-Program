// See https://aka.ms/new-console-template for more information
using System.Xml;
using XML_Reading_Practice_Program.src.classes;

//Console.WriteLine(new Employee("Zach", 22, "Software Developer", 20).ToString());

XmlDocument document = new XmlDocument();
try
{
    document.Load(@"../../../data/EmployeeData.xml");
    foreach (XmlNode node in document.DocumentElement)
    {
        string name = node.Attributes[0].Value; //node.Attributes[0] grabs the first attribute of a node
        int age = int.Parse(node["Age"].InnerText);
        string title = node["Title"].InnerText;
        double salary = double.Parse(node["Salary"].InnerText);
        Console.WriteLine(new Employee(name, age, title, salary).ToString());
    }
}
catch (Exception error)
{
    Console.WriteLine($"ERROR: {error.Message}");
    Environment.Exit(0);
}

