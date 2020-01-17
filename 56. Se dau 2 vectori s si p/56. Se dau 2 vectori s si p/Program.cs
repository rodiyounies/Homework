using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Se_dau_2_vectori_s_si_p
{
    class Program
    {
        static void Main(string[] args)
        {
            //56. Se dau 2 vectori s si p. Sa se det de cate ori apare p in s. 
            //(substring search cautam sol eficienta. rezolvarea liniara e grea, solutia patratica e simpla.) 
            //ex: daca s = 121213121 si p= 121 ---> de 3 ori apare, afisam si daca se suprapun
                                  
            
            
            int[] s = new int[9] { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
            PrintVector("Primul vector: ", s);

            int[] p = new int[3] { 1, 2, 1 };
            PrintVector("Al doilea vector: ", p);

            // convert vector to string
            string sString = createStringFromVector(s);
            string pString = createStringFromVector(p);

            bool found = sString.Contains(pString);
            if (found == false)
            {
                Console.WriteLine("{0} is not found", pString);
            } else
            {
                int count = 0;
                int i = sString.IndexOf(pString, 0);
                if(i >= 0)
                {
                    ++count;
                }

                while (i >= 0 && i <= pString.Length)
                {
                    i = sString.IndexOf(pString, i);
                    if(count >= 0)
                    {
                        ++count;
                    }

                    i = i + pString.Length;
                }
                Console.WriteLine("{0} is found {1} times", pString, count);
            }

            Console.ReadKey();
        }

        private static void PrintVector(string msg, int[] v)
        {
            Console.Write(msg);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
        }

        private static string createStringFromVector(int[] v)
        {
            StringBuilder buffer = new StringBuilder();
            for (int i = 0; i < v.Length; i++)
            {
                buffer.Append(v[i]);
            }

            return buffer.ToString();
        }
    }
}
