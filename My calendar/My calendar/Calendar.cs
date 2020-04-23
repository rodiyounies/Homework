using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    class Calendar
    {
        private Person person;
        private List<CalendarEvent> events;

        public Calendar(Person person, List<CalendarEvent> events)
        {
            this.person = person;
            this.events = events;
        }

        public Person GetPerson()
        {
            return this.person;
        }

        public List<CalendarEvent> GetEvents()
        {
            return this.events;
        }

        public bool isAvailable(DateTime from, DateTime to)
        {
            Console.WriteLine("There are [" + events.Count() + "] events");
            foreach (CalendarEvent ce in this.events)
            {                
                if (ce.GetFrom().Year == from.Year && 
                    ce.GetFrom().Month == from.Month &&
                    ce.GetFrom().Day == from.Day)
                {
                    Console.WriteLine("Testing for " + ce.GetFrom() + ", " + ce.GetTo());
                    Console.WriteLine("from/to " + from + "/" + to);
                    // Less than zero : If this instance is earlier than value.
                    // Zero: If this instance is the same as value.
                    // Greater than zero : If this instance is later than value.
                    if (from.CompareTo(ce.GetFrom()) == 0 && to.CompareTo(ce.GetTo()) == 0 )
                    {
                        return false;
                    } else if (from.CompareTo(ce.GetFrom()) > 0 && from.CompareTo(ce.GetTo()) < 0 ||
                        to.CompareTo(ce.GetFrom()) > 0 && to.CompareTo(ce.GetTo()) < 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
