using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_curs_10_12_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            // pt n=4 afisez 
            //1
            //1 2
            //1 2 3
            //1 2 3 4 

            int n = 4;
            
            T1(n);

            //pt n=4 afisez
            // 1
            // 2 3
            // 3 4 5
            // 4 5 6 7
            T2(n);
            Tmod1(8);
            Tmod2(8);

            //TODO: facem o clona, punem pe giyhub si facem un pull request 
            //pt n=8 afisez:
            // 1 1 2 1 2 3 1 2 
            //T3(8);

            // pt n= 8 afisez :
            // 1 2 3 3 4 5 4 5
            //T4(n);
            Console.ReadLine();
        }
              
        private static void T2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= 2 * i - 1; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

        }

        private static void T1(int n)
        {
            for(int i=1; i<= n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        private static void Tmod1(int n)
        {
            Console.WriteLine();
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i && count < n; j++)
                {
                    ++count;
                    Console.Write($"{j} ");
                }
            }
        }

     
        private static void Tmod2(int n)
        {
            Console.WriteLine();
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= 2 * i - 1 && count < n; j++)
                {
                    ++count;
                    Console.Write($"{j} ");
                }
            }
        }
    }
}
