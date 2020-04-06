using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumarMare_Clasa
{
    class Program
    {
        static void Main(string[] args)
        {
            NumarMare n1 = new NumarMare("5");
            n1.Init(2);
            n1.Print();

            NumarMare n2 = new NumarMare("8");
            n2.Init(3);
            n2.Print();

            NumarMare n3 = n1.Add(n2);
            n3.Print();            

            NumarMare n4 = n1.Multiply(n2);
            n4.Print();
            
            Fibonacci f = new Fibonacci();
            //f.generate ne genereaza tot sirul fibonacci pana la elementul dorit.
            f.generate(100);

            int term = 100;
            NumarMare n5 = f.GetTerm(term);
            //f.GetTerm ne va genera  elementul dorit. 
            Console.Write("Fibonacci " + term + "th term is: ");
            n5.PrintSimple();

            Factorial fact = new Factorial();
            NumarMare n6 = fact.GetFactorial(14);
            n6.PrintSimple();

            Console.ReadKey();
        }
    }
}
