using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare_localizata
{
    //input- text file, 
    //output- another  file 
    //that will contain the names of the persons in lexicographic order.
    // we need to add classes: Person(People) , List of Person (People), etc
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name (Example: C:\\temp): ");
            string filename = Console.ReadLine();
            Console.WriteLine();

            Program p = new Program();
            PeopleTraverse pt = new PeopleTraverse();
            NameTransformer nt = new NameTransformer();
            People people = new People();
            String[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            foreach (String line in lines)
            {
                String TitledLine = nt.toTitle(line);
                Person person = new Person(TitledLine);
                people.add(person);
            }
            pt.print(people);

            PeopleSort ps = new PeopleSort(people);
            People sortedPeople = ps.sort();

            
            pt.write(sortedPeople, filename);
            Console.ReadKey();
        }

        
    }
}
