using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasa_Elevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            EleviReader reader = new EleviReader("C:\\development\\strudents.txt");
            List<Elev> elevi = reader.Read();
            p.debug(elevi);
           
            

            //sort students 
            EleviSort sorter = new EleviSort();
            sorter.BubbleSort(elevi);

            // print sorted students
            p.debug(elevi);
            

            // write elevi to file
            EleviWriter writer = new EleviWriter("C:\\development\\sorted-strudents.txt");
            writer.Write(elevi);



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private void debug(List<Elev> elevi)
        {
            Console.WriteLine();

            foreach (Elev v in elevi)
            {
                Console.WriteLine(v);
            }
            
            Console.WriteLine();
        }
    }
}
