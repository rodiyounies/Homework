using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare_localizata
{
    class People
    {
        private List<Person> persons;

        public People()
        {
            this.persons = new List<Person>();
        }

        public void add(Person person)
        {
            this.persons.Add(person);
        }

        public List<Person> getPersons()
        {
            return this.persons;
        }
    }
}
