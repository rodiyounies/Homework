using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stiva cu valori int:");

            Stiva<int> st = new Stiva<int>(4);
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);

           Console.WriteLine( st.Pop());
           Console.WriteLine( st.Pop());
           Console.WriteLine( st.Pop());
           Console.WriteLine( st.Pop());
           
            Stiva<int> st1 = new Stiva<int>(4);
            st1.Push(1);
            st1.Push(2);
            st1.Push(3);
            st1.Push(4);

           // st1.Clear();
           // st1.Pop();

            Console.WriteLine("Stiva cu valori string:");
            Stiva<string> ststr = new Stiva<string>(4);
            ststr.Push("1");
            ststr.Push("2");
            ststr.Push("3");
            ststr.Push("4");

           // ststr.Clear();
            Console.WriteLine(ststr.Pop());
            Console.WriteLine(ststr.Pop());
            Console.WriteLine(ststr.Pop());
            Console.WriteLine(ststr.Pop());
            


        }
    }
}
