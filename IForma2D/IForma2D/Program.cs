using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D
{
    class Program
    {
        static void Main(string[] args)
        {
            //metoda directa
            Circle circle = new Circle(10.0, "cerc");
            Console.WriteLine(circle.getAria());
            Console.WriteLine(circle.LungimeaFrontierei());

            Square square = new Square(4.0, "patrat");
            Console.WriteLine(square.getAria());
            

            
            //prin functia Metoda 
            Metoda(square);
            Metoda(circle);

            Console.ReadKey();
        }

        public static void Metoda( IForma2D id)
        {
            Console.WriteLine("Aria formei geometrice {0} este:{1} ", id.Denumire, id.getAria()); 
            Console.WriteLine("Circumferinta formei geometrice {0} este:{1} ", id.Denumire, id.LungimeaFrontierei()); 

        }
    }
}
