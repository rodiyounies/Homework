using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare_localizata
{
    class PeopleTraverse
    {
        public PeopleTraverse()
        {
        }

        public void write(People people, string orgFilename)
        {
            FileInfo fi = new FileInfo(orgFilename);
            DirectoryInfo di = fi.Directory;
            string sortedFileName = di.FullName + "\\sorted_" + fi.Name;
            Console.WriteLine("Saving Sorted names to [" + sortedFileName + "]");

            StreamWriter writer = new StreamWriter(sortedFileName);
            List<Person> sortedPersons = people.getPersons();
            foreach (Person person in sortedPersons)
            {
                writer.WriteLine(person.getName());
            }

            writer.Flush();
            writer.Close();
        }

        public void print(People people)
        {
            List<Person> sortedPersons = people.getPersons();
            foreach (Person person in sortedPersons)
            {
                Console.WriteLine(person.getName());
            }
        }
    }
}
