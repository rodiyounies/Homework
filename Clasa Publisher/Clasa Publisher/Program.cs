using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    public delegate void Iteration(int n);
    class Program
    {  
        static void HandlerEv(int n)
        {
            Console.WriteLine("The event has happened! ");
        }
        static void Main(string[] args)
        {
            //Iteration handler = DelegateMethod;
            
            //// Call the delegate.
            //handler(5);

            Publisher publ = new Publisher();
            SubscriberA subsA = new SubscriberA();
            SubscrieberB subsB = new SubscrieberB();

            publ.Eveniment += HandlerEv;
            
            publ.Eveniment += subsA.ASubsHandler;
            publ.Eveniment += subsB.BSubsHandler;
            publ.DeclansareEveniment(7);
            

        }
        //public static void DelegateMethod(int n)
        //{
        //    Console.WriteLine(n);
        //}
    }
}
