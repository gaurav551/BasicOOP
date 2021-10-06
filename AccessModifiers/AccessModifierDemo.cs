namespace OOP.AccessModifiers
{
    public  class AccessModifierDemo
    {
        //if we make Private constructor inside a class than this class cannot be instantiated
        // private AccessModifierDemo()
        // {
            
        // }

        //Protected can only be accessed to derived class
        protected void SayHello()
        {
             System.Console.WriteLine("HELLO");
             MyNestedClass myNestedClass = new MyNestedClass();
              myNestedClass.SayHelloNested();
        }
        // private  int val = 0;
        //A class can only be marked private inside nested class
       /*  Private classes are allowed, but only as inner or nested classes. If you have a private inner or nested class, then access is restricted to the scope of that outer class.

          If you have a private class on its own as a top-level class, then you can't get access to it from anywhere. So it does not make sense to have a top level private class. */
        public class MyNestedClass
        {
        public void SayHelloNested()
        {
            
           // SayHello();
            System.Console.WriteLine("HELLO From NESTED CLASS");
        }
              
        }
        
    }
    public class AccessModifierDemo2 : AccessModifierDemo
    {
        public void MethodName(){
           
         SayHello();
        }

    }
    public class AccessModifierDemo3 : AccessModifierDemo
    {
        public void SomeMethod()
        {
            MyNestedClass m = new MyNestedClass();
            
        }
        
    }
}