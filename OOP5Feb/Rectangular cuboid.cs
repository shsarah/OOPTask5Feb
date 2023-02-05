using System;
namespace OOP5Feb
{
	public class Rectangular_cuboid
	{
        private double width;

        public Rectangular_cuboid(double a, double b, double c)
            : base(a, b)
        {
            this.heigth = a;
            this.length = b;
            this.width = c;
        }

        public override double Area()
        {
            double area = 2 * (heigth * length + length * width + width * heigth);
            return area;
        }
        public override double Volume()
        {
            double volume = heigth * width * length;
            return volume;
        }
    }
}

