using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatii_cu_nr_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            // obiectele c1,c2,c3 de tip complex initializate cu nr diferiti de parametri. 
            Complex c1 = new Complex();
            c1.setReal(0);
            c1.setImg(0);
            
            Complex c2 = new Complex(2);
            c2.setImg(0);
            
            Complex c3 = new Complex(8, 9);
            Complex c4 = new Complex(4, 5);

            Complex c5 = c3.Add(c4);
            Console.WriteLine($"{c3} + {c4} = {c5}");

            Complex c6 = c3.Subtract(c4);
            Console.WriteLine($"{c3} - {c4} = {c6}");

            Complex c7 = c3.Multiply(c4);
            Console.WriteLine($"{c3} * {c4} = {c7}");

            int k = 2;
            Complex c8 = c3.Power(k);
            Console.WriteLine($"{c3} ^ {k} = {c8}");

            //afisare forma trigonometrica 
            //c= r(cos fi + i sin fi),   r=radical din  a^2 + b^2;  fi=arctg b/a; ==> 
            //==> x^n= r^n(cod(n fi) + i sin (n fi))

            Complex c9 = new Complex(2);
            c9.GetTrigonometricForm();




            Console.ReadKey();

        }
    }
}
