using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatii_cu_matrici
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(2,2);
            m1.Print();
            Console.WriteLine();

            Matrix m2 = new Matrix(2, 2);
            m2.Print();
            Console.WriteLine();

            Matrix m3 = m1.Add(m2);
            Console.WriteLine("Suma matricelor este: ====>");
            m3.Print();
            Console.WriteLine();

            Matrix m4 = m1.Multiply(m2);
            Console.WriteLine("Inmultirea matricelor este: ====>");
            m4.Print();
            Console.WriteLine();

            Matrix m5 = m1.Subtract(m2);
            Console.WriteLine("Diferenta matricelor este: ====>");
            m5.Print();
            Console.WriteLine();

            int k = 3;
            Matrix m6 = m1.Power(k);
            Console.WriteLine($"Matricea la puterea {k} este: ====>");
            m6.Print();

            Matrix m7 = new Matrix(3, 3);
            m7.Print();
            Console.WriteLine("Inversa matricei este: ====>");
            Matrix im7 = m7.Inversa();
            im7.Print();

            Console.ReadKey();

        }
    }
}
