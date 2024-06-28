using System;

namespace Day06_assignment._4BasicPrinciple;

//Encapsulation and Inheritance
public class Rectangle : Shape
{
    private double length;
    private double width;

    public double Length {  get { return length; } set { length = value; } }
    public double Width { get { return width; } set { width = value; } }

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Polymorphism: Overriding abstract methods
    public override double Area()
    {
        return length * width;
    }

    public override double Perimeter()
    {
        return 2*(length+width);
    }
}

