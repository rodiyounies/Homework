using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatii_cu_nr_rationale
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational();
            r1.setNumarator(0);
            r1.setNumitor(0);

            Rational r2 = new Rational(4);
            r2.setNumitor(0);

            Rational r3 = new Rational(3,2);
            Rational r4 = new Rational(1,2);
            Rational r5 = r3.Add(r4);

            Console.WriteLine($"{r3} + {r4} = {r5}");

            Rational r6 = r3.Subtract(r4);
            Console.WriteLine($"{r3} - {r4} = {r6}");

            Rational r7 = r3.Multiply(r4);
            Console.WriteLine($"{r3} * {r4} = {r7}");

            Rational r8 = r3.Divide(r4);
            Console.WriteLine($"{r3} / {r4} = {r8}");

            int k = 3;
            Rational r9 = r3.Power(k);
            Console.WriteLine($"{r3} ^ {k} = {r9}");

            Rational r10 = new Rational(1,2);
            Rational r11 = new Rational(5,8);
            if (r10 > r11)
                Console.WriteLine("1/2 is greater than 5/8");
            else
                Console.WriteLine("1/2 is smaller than 5/8");

            Rational r12 = new Rational(4, 8);
            Rational r13 = new Rational(9, 18);
            if (r12 == r13)
                Console.WriteLine("4/8 is equal to 9/18");
            else
                Console.WriteLine("4/8 is not equal to 9/18");

            Rational r14 = new Rational(4, 8);
            Rational r15 = new Rational(9, 18);
            if (r14 >= r15)
                Console.WriteLine("4/8 is greater or equal to 9/18");
            else
                Console.WriteLine("4/8 is not greater or equal to 9/18");


        }
    }

   
}
