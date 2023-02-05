namespace OOP5Feb;
class Program
{
    static void Main(string[] args)
    {
    l1:
        Console.Write("Enter the radius: ");
        double radius;
        if (double.TryParse(Console.ReadLine(), out radius) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        double heigth;
    l2:
        Console.Write("Enter the heigth: ");
        if (double.TryParse(Console.ReadLine(), out heigth) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l2;
        }
        var cone = new Cone(radius, heigth);
        Console.WriteLine($"Area of cone : {cone.Area()}");
        Console.WriteLine($"Volume of cone : {cone.Volume()}");
    l3:
        Console.Write("Enter the length: ");
        double length;
        if (double.TryParse(Console.ReadLine(), out length) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }
        var cylinder = new Cylinder(radius, heigth, length);
        Console.WriteLine($"Area of cylinder: {cylinder.Area()}");
        Console.WriteLine($"Volume of cylinder: {cylinder.Volume()}");
        var cuboid = new Rectangular_cuboid(radius, heigth, length);
        Console.WriteLine($"Area of cuboid: {cuboid.Area()}");
        Console.WriteLine($"Volume of cuboid: {cuboid.Volume()}");
    }
}

