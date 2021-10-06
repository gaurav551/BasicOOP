/* 
Abstraction is "To represent the essential feature without representing the background details."
Abstraction lets you focus on what the object does instead of how it does it.
Abstraction provides you a generalized view of your classes or objects by providing relevant information.
Abstraction is the process of hiding the working style of an object, and showing the information of an object in an understandable manner. */
using System;
namespace OOP.Abstraction
{
    //The abstract class shape contains the abstract method area(). 
    public abstract class Shape
    {
        public abstract double Area();
    }
    /*
    The class Circle inherits from Shape. It has a private data member radius. 
    The parameterized constructor assigns a value to radius. 
    */

    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            System.Console.WriteLine("Area of Circle");
            return (3.14 * radius * radius);
        }
    }
    /*The class Square inherits from Shape. It has a private data member side. 
    The parameterized constructor assigns a value to side.
    */
    class Square : Shape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double Area()
        {
            System.Console.WriteLine("Area of Square");
            return (side * side);
        }
    }

/*     The class Triangle inherits from Shape. 
       It has private data members tbase and theight. 
       The parameterized constructor assigns a value to tbase and theight.
 */    class Triangle : Shape
    {
        private double base1,height;

        public Triangle(double base1, double height)
        {
            this.base1 = base1;
            this.height = height;
            
        }
        public override double Area()
        {
              return (0.5*base1*height);
        }
    }
}