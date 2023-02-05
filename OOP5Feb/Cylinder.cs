using System;
namespace OOP5Feb
{
	public class Cylinder:Cone
	{
        public Cylinder(double radius, double heigth, double length)
            : base(length, heigth)
        {
            this.radius = radius;
            this.heigth = heigth;
            this.length = length;
        }


        public override double Volume()
        {
            return base.Area() * length;
        }
        public override double Area()
        {
            double area = 2 * base.Area() + 2 * Math.Round(Math.PI, 2) * radius * length;
            return area;
        }
    }
}

