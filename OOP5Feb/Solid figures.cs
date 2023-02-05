using System;
namespace OOP5Feb
{
	public abstract class Solid_figures
	{
        protected double length;
        protected double heigth;
        public Solid_figures(double length, double heigth)
        {
        }
        public abstract double Area();
        public abstract double Volume();
    }
    
}

