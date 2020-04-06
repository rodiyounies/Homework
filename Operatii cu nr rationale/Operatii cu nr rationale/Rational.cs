using System;

namespace Operatii_cu_nr_rationale
{
    internal class Rational
    {
        private int numarator;
        private int numitor;

        public object Util { get; private set; }

        public Rational()
        {
            this.numarator =0;
            this.numitor = 0;
        }

        public Rational(int numarator)
        {
            this.numarator = numarator;
            this.numitor = 0;
        }

        public Rational (int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
        }
        public static bool operator == (Rational a, Rational b)
        {
            if(a.numarator*b.numitor ==  a.numitor*b.numarator)
            {
                return true;
            }

            return false;
        }
        public static bool operator != (Rational a, Rational b)
        {
            if (a.numarator * b.numitor == a.numitor * b.numarator)
            {
                return false;
            }

            return true;
        }

        public static bool operator >(Rational a, Rational b)
        {
            if (a.numarator * b.numitor > a.numitor * b.numarator)
            {
                return true;
            }

            return false;
        }
        public static bool operator < (Rational a, Rational b)
        {
            if (a.numarator * b.numitor < a.numitor * b.numarator)
            {
                return true;
            }

            return false; ;
        }

        public static bool operator <= (Rational a, Rational b)
        {
            if (a.numarator * b.numitor <= a.numitor * b.numarator)
            {
                return true;
            }

            return false; ;
        }
        public static bool operator >=(Rational a, Rational b)
        {
            if (a.numarator * b.numitor >= a.numitor * b.numarator)
            {
                return true;
            }

            return false; ;
        }
        internal Rational Add(Rational r4)
        {
            Console.Write("Add--->");
            Rational result = new Rational();

            result.numitor = numitor * r4.numitor;
            result.numarator = numarator * r4.numitor + r4.numarator * numitor;


            return result.Reduce();
        }

        internal Rational Divide(Rational r4)
        {
            Console.Write("Divide--->");
            return this.Multiply(r4.Inverse()).Reduce();
        }

        internal Rational Power(int k)
        {
            Console.Write("Power--->");
            return new Rational((int)Math.Pow(numarator, k), (int)Math.Pow(numitor, k)).Reduce();
        }

        private Rational Inverse()
        {
            return new Rational(numitor, numarator);
        }

        internal Rational Multiply(Rational r4)
        {
            Console.Write("Multiply--->");
            Rational result = new Rational();

            result.numitor = numitor * r4.numitor;
            result.numarator = numarator * r4.numitor;


            return result.Reduce();
        }

        internal Rational Subtract(Rational r4)
        {
            Console.Write("Subtract--->");
            Rational result = new Rational();

            result.numitor = numitor * r4.numitor;
            result.numarator = numarator * r4.numitor - r4.numarator * numitor;


            return result.Reduce();
        }

        private Rational Reduce()
        {
            int d = Rational.gcd(Math.Abs(numarator), (numitor));

            return new Rational(numarator / d, numitor / d);
        }

        public static int gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        public void setNumarator(int numarator)
        {
            this.numarator = numarator;
        }

        public int getNumarator()
        {
            return this.numarator;
        }

        public void setNumitor(int numitor)
        {
            this.numitor = numitor;
        }

        public int getNumitor()
        {
            return this.numitor;
        }
        public override string ToString()
        {
            return string.Format("[{0} / {1}]", numarator, numitor);
        }
    }
}