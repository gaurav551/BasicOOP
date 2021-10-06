namespace OOP.Static
{
    //Non static class can have static method they do not require initialization
    public class StaticDemo
    {
        //Static ctor must be parameterless
        static StaticDemo()
        {
            System.Console.WriteLine("COnsturctor called");
            someText = "FROM SICK";
        }
/*        When a variable is declared as static, then a single copy of the variable is created and shared among all objects at the class level. 
 */        private static string someText = "Static Variable From  NON Static Class";
        public static void CheckIt()
        {
            System.Console.WriteLine(someText);
            System.Console.WriteLine("From Static Method and NOn Static CLass");
        }
        public void CheckIt2()
        {
            System.Console.WriteLine("From NON Static Method and NOn Static CLass");
        }
        ~StaticDemo(){
            System.Console.WriteLine("DESCTUCTOR CALLED");
        }
    }
    //Static Class Must have all static members
     public static class StaticDemo2
    {
        public static string someText = "Static Variable From  Static Class";
        public static void CheckIt()
        {
            System.Console.WriteLine("From Static Method and  Static CLass");
        }
        public static void CheckIt2()
        {
            System.Console.WriteLine("From NON Static Method and  Static CLass");
        }
    }
}