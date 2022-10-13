namespace XML_Reading_Practice_Program.src.interfaces
{
    internal interface IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }
        public string ToString();
    }
}
