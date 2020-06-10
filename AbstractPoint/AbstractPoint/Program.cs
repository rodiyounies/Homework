using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point (AbstractPoint.PointRepresentation.Polar, 10, 45);
            Console.WriteLine($"Punctul p cu coordonatele:  {p1}");

            Point p2 = new Point(AbstractPoint.PointRepresentation.Rectangular, 10, 45);
            Console.WriteLine($"Punctul p cu coordonatele:  {p2}");
        }
    }
}
