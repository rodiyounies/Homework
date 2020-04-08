using System;

namespace Operatii_cu_nr_complexe
{
    internal class Complex
    {
        private int real;
        private int img;

        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        public Complex(int real)
        {
            this.real = real;
            this.img = 0;
        }
        public Complex()
        {
            this.real = 0;
            this.img = 0;
        }

        public void setReal(int real)
        {
            this.real = real;
        }
        public int getReal()
        {
            return this.real;
        }

        internal Complex Add(Complex c4)
        {
            Console.Write("Add--->");
            Complex result = new Complex();
            result.real = real + c4.real;
            result.img = img + c4.img;

            return result;
        }

        internal Complex Multiply(Complex c4)
        {
            Console.Write("Multiply--->");
            Complex result = new Complex();
            result.real = (real * c4.real) - (img*c4.img);
            result.img =( real*c4.img) + (img*c4.real);

            return result;

        }

        internal Complex Power(int k)
        {
            Console.Write("Power--->");
            return new Complex((int)Math.Pow(real, k), (int)Math.Pow(img, k));
        }

        internal void GetTrigonometricForm()
        {
            double r = Math.Sqrt(Math.Pow(this.real, 2) + Math.Pow(this.img, 2));
            double argz;
            try
            {
                argz = Math.Atan(this.img / this.real);
            }
            catch (Exception)
            {
                throw new DenominatorIsZero(this.real);
            }


            Console.WriteLine($"z = {r} (cos({argz}) + isin({argz})");
        }
    

        internal Complex Subtract(Complex c4)
        {
            Console.Write("Subtract--->");
            Complex result = new Complex();
            result.real = real - c4.real;
            result.img = img - c4.img;

            return result;

        }

        public void setImg(int img)
        {
            this.img = img;
        }
        public int getImg()
        {
            return this.img;
        }

        public override string ToString()
        {
            return string.Format("[{0} + i{1}]", real, img);
        }

    }
}