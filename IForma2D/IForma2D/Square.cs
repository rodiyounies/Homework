using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D
{
    class Square: IForma2D
    {
       private double width;
       
       public string Denumire { get; }

        public Square()
        {
            width = 0;           
        }
        public Square(double width, string Denumire)
        {
            this.width = width;
            this.Denumire = Denumire;
        }
        public double getAria()
        {
            return width * width;
        }

        public  double LungimeaFrontierei()
        {
            return 4 * width;
        }
    }
}
