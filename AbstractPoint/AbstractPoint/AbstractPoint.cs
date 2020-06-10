using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    public abstract class AbstractPoint
    {
        //membrul data public de tip enum
        public enum PointRepresentation
        {
            Polar,
            Rectangular
        }

        //4 proprietati abstracte pt coord. carteziene si polare
        public abstract double a { get; set; }
        public abstract double b { get; set; }
        public abstract double r { get; set; }
        public abstract double A { get; set; }

        //metoda publica Move cu doi parametri
        public void Move(double dX, double dY)
        {
            a += dX;
            b += dY;
        }

        //metoda publica Rotate pt rotatia punctului cu un singur parametru 
        public void Rotate(double angle)
        {
            A += angle;
        }

        //4 metode protejate statice 
        protected static double RadiusR(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        protected static double AngleA(double a, double b)
        {
            return Math.Atan2(b, a);
        }

        protected static double ARadiusAngle(double r, double A)
        {
            return r * Math.Cos(A);
        }

        protected static double BRadiusAngle(double r, double A)
        {
            return r * Math.Sin(A);
        }

        //suprascrierea metodei ToString pt afisarea dorita 
        public override string ToString()
        {
            return string.Format($"({a},{b}) : [{r},{A}]");
        }

                     
    }

}
