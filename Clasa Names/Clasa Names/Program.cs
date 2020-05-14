using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            values.Add("name1");
            values.Add("name2");
            values.Add("name3");
            values.Add("name4");
            values.Add("name5");

            Names names = new Names(values);
            string n1 = names[0];
            Console.WriteLine(n1);

            string n2 = names[10];
            Console.WriteLine(n2);

            string n3 = names["2"];
            Console.WriteLine(n3);

            string n4 = names["7"];
            Console.WriteLine(n4);

            string n5 = names["bla"];
            Console.WriteLine(n5);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }


}
