using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare_localizata
{
    class PeopleSort
    {
        private People people;

        public PeopleSort(People people)
        {
            this.people = people;
        }

       
        public People sort()
        {
            List<Person> persons = this.people.getPersons();
            int l = persons.Count();

            String temp1, temp2, temp3;
            var comparer = StringComparer.Create(new CultureInfo("ro-RO"), true);
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if(comparer.Compare(persons.ElementAt(j).getName(), persons.ElementAt(j + 1).getName()) > 0)
                    {
                        temp1 = persons.ElementAt(j).getFirstName();
                        temp2 = persons.ElementAt(j).getMiddleName();
                        temp3 = persons.ElementAt(j).getLastName();

                        persons.ElementAt(j).setFirstName(persons.ElementAt(j+1).getFirstName());
                        persons.ElementAt(j).setMiddleName(persons.ElementAt(j+1).getMiddleName());
                        persons.ElementAt(j).setLastName(persons.ElementAt(j+1).getLastName());

                        persons.ElementAt(j+1).setFirstName(temp1);
                        persons.ElementAt(j+1).setMiddleName(temp2);
                        persons.ElementAt(j+1).setLastName(temp3);
                    }
                }
            }

            return people;
        }
    }
}
