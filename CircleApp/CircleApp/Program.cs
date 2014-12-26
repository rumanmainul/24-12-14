using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of circle1 = " + circle.GetArea());
            Console.WriteLine("Perimeter of circle1 = " + circle.GetPerimeter());
            Console.WriteLine("Diameter of circle1 = " + circle.GetDiameter());
            Console.ReadKey();
        }
    }
}
