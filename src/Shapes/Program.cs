using System;

namespace Shapes
{
    public class Program
    {
        static void Main()
        {
            double r = 3.0, h = 5.0;

            var circle = new Circle(r);
            var sphere = new Sphere(r);
            var cylinder = new Cylinder(r, h);

            Console.WriteLine($"Area of Circle = {circle.Area():F2}");
            Console.WriteLine($"Area of Sphere = {sphere.Area():F2}");
            Console.WriteLine($"Area of Cylinder = {cylinder.Area():F2}");
        }
    }
}
