using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasa_Angajat
{
    class Program
    {
        static void Main(string[] args)
        {
            Angajati angajati = new Angajati();
            AngajatiReader reader = new AngajatiReader(@"..\..\data.txt");
            List<Angajat> data = reader.Read();
            for(int i=0; i<data.Count; i++)
            {
                angajati.Add(data.ElementAt(i));
            }
            Console.WriteLine("Before Sorting");
            angajati.Print();


            angajati.Sort(AngajatSortEnum.ALPHABETICAL);
            Console.WriteLine("After Sorting By First/Last Names");
            angajati.Print();

            AngajatiWriter writer1 = new AngajatiWriter(@"..\..\data-output-sorted-by-name.txt");
            writer1.WriteNames(angajati.getList());

            angajati.Sort(AngajatSortEnum.EMPLOYMENT_DATE);
            Console.WriteLine("After Sorting By Employment Date");
            angajati.Print();

            AngajatiWriter writer2 = new AngajatiWriter(@"..\..\data-output-sorted-by-employment.txt");
            writer2.WriteEmployment(angajati.getList());

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
