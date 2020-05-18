using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D
{
    class Circle : IForma2D
    {
        private double radius;
        public string Denumire { get; }

        public double Radius
        {
            get { return radius; }
        }

        public Circle(double radius, string Denumire)
        {
            this.radius = radius;
            this.Denumire = Denumire;
        }
       
        public double getAria()
        {
            return radius * radius * Math.PI;
        }
        public double LungimeaFrontierei()
        {
            return 2 * radius * Math.PI;
        }
    }
}
