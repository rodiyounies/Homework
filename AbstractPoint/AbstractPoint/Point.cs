using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
   public class Point : AbstractPoint
    {
        //membrii data r si A;
        private double raza;
        private double unghiul;

        
        // Constructorul cu cei 3 parametri        
        public Point(PointRepresentation pr, double a, double b)
        {
            if (pr == PointRepresentation.Polar)
            {
                raza = a;
                unghiul = b;
            }

            if (pr == PointRepresentation.Rectangular)
            {
                raza = RadiusR(a, b);
                unghiul = AngleA(a, b);
            }
        }

        //suprascrierea celor 4 propiretati din clasa de baza
        public override double a
        {
            get { return ARadiusAngle(raza, unghiul); }

            set
            {
                double InitialB = BRadiusAngle(raza, unghiul);

                unghiul = AngleA(value, InitialB);
                raza = RadiusR(value, InitialB);
            }
        }
        public override double b
        {
            get { return BRadiusAngle(raza, unghiul); }

            set
            {
                double InitialA = ARadiusAngle(raza, unghiul);

                unghiul = AngleA(InitialA, value);
                raza = RadiusR(InitialA, value);
            }

        }
        public override double r
        {
            get { return raza; }
            set { raza = value; }
        }
        public override double A
        {
            get { return unghiul; }
            set { unghiul = value; }
        }


    }
}
