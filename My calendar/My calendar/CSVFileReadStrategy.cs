using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace My_calendar
{
    /// <summary>Parcing din fisiere de tip CVS. 
    /// Clasa creata pt parcingul datelor sursa (din fisiere diferite) pt persoane si evenimente. 
    /// </summary>
    class CSVFileReadStrategy
    {
        public CSVFileReadStrategy()
        {

        }
 
        public List<Person> ReadPeopleFile(String fileName)
        {
            ObjectsFactory factory = new ObjectsFactory();
            List<Person> persons = new List<Person>();

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines) {
                string[] tokens = line.Split(',');
                if(tokens == null || tokens.Length != 5)
                {
                    Console.WriteLine("Failed to parse line: " + line);
                    continue;
                }

                String id = tokens[0];
                String firstName = tokens[1];
                String lastName = tokens[2];
                String dob = tokens[3];
                String email = tokens[4];

                Person person = factory.CreatePerson(id, firstName, lastName, email, dob);
                persons.Add(person);
            }

            //
            Console.WriteLine("Successfully Parsed [" + persons.Count() + "] Persons");
            return persons;
        }

        public List<CalendarEvent> ReadEventsFile(String fileName)
        {
            ObjectsFactory factory = new ObjectsFactory();
            List<CalendarEvent> events = new List<CalendarEvent>();

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] tokens = line.Split(',');
                if (tokens == null || tokens.Length != 4)
                {
                    Console.WriteLine("Failed to parse line: " + line);
                    continue;
                }

                String personId = tokens[0];
                String name = tokens[1];
                String from = tokens[2];
                String to = tokens[3];

                CalendarEvent ce = factory.CreateEvent(personId, name, from, to);
                events.Add(ce);
            }

            //
            Console.WriteLine("Successfully Parsed [" + events.Count() + "] Events");
            return events;
        }
    }
}
