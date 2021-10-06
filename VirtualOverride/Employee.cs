namespace OOP.VirtualOverride
{
    public class Employee
    {
        public Employee(string initalFirstName)
        {
            FirstName = initalFirstName;
        }
        public  string FirstName { get; set; }  ="Gaurav";
        public string LastName { get; set; } = "Acharya";
        /*  If a property or method is marked as virtual, we can override it in any class that inherits it 
            using override keyword
        */
        
        //Abstract method of Abstract class can also be overridden
        public virtual int Salary { get; set; } = 10;
        public int YearlySalary { get {
            return Salary* 12;
            }
        }
        public void PrintFullName()
        {
            System.Console.WriteLine("FULLNAME IS "+ FirstName + LastName);
        }
    }
    public class Teacher : Employee
    {
        public Teacher(string initialFirstName) : base(initialFirstName)
        {
            
        }
        //Overriding Salary
        public override int Salary{get;set;}=20;
    }
}