namespace OOP.Encapsulation
{
/*     As in encapsulation, the data in a class is hidden from other classes, 
       so it is also known as data-hiding.
     
       Encapsulation can be achieved by: 
       Declaring all the variables in the class as private and using C# Properties in the class to set and get the values of variables.
 */    public class EncapsulationDemo
    {
    // private variables declared
    // these can only be accessed by
    // public methods of class
       private string name = "";
       private int age;
       private double height;
       private bool isAdult()
       {
        if(this.Age<=0) return false;
          return this.Age<18 && this.Age>10? true:false;
       }
       // using accessors to get and 
        // set the value of Name
        public string Name { get {return name;} set{ name = value; } }
        public int Age { get{return age;} set{age = value;} }
        public double Height { get{return height<=1? -1 : height ;} set{height = value;} }
        public bool IsAdult { get {return isAdult();} }

        
    }

}