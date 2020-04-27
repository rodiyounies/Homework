using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    /// <summary>Class members: CalendarId(Id-ul calendarului unei persoane coincide cu ID-ul persoanei), Person, List <CalendarEvent>.
    /// Clasa responsabila cu crearea evenimentelor, returnarea evenimentelor, returnarea evenimentelor dintr-un interval de timp specific, returnarea unui eveniment dupa nume, determinarea disponibilitatii intr-un anumit interval de timp. 
    /// </summary>

    class Calendar
    {
        private String calendarId;
        private Person person;
        private List<CalendarEvent> events;

        public Calendar(Person person, List<CalendarEvent> events)
        {
            calendarId = Guid.NewGuid().ToString();
            this.person = person;
            this.events = events;
        }

        public Person GetPerson()
        {
            return this.person;
        }

        public void AddEvent(String eventName, DateTime from, DateTime to)
        {
            ObjectsFactory objectsFactory = new ObjectsFactory();
            CalendarEvent ce = objectsFactory.CreateEvent(this.person.GetId(), eventName, from, to);

            this.events.Add(ce);
        }

        public List<CalendarEvent> GetEvents()
        {
            return this.events;
        }

        public String GetCalendarId()
        {
            return this.calendarId;
        }

        public List<CalendarEvent> GetEvents(String name)
        {
            List<CalendarEvent> matchEvents = new List<CalendarEvent>();
            foreach(CalendarEvent ce in events)
            {
                if(ce.GetName().Equals(name))
                {
                    matchEvents.Add(ce);
                }
            }

            return matchEvents;
        }

        // CompareTo()
        // Less than zero : If this instance is earlier than value.
        // Zero: If this instance is the same as value.
        // Greater than zero : If this instance is later than value.
        public List<CalendarEvent> GetEvents(DateTime from, DateTime to)
        {
            List<CalendarEvent> matchEvents = new List<CalendarEvent>();
 
            foreach (CalendarEvent ce in this.events)
            {
                if (ce.GetFrom().CompareTo(from) >= 0 && ce.GetFrom().CompareTo(to) <= 0 ||
                    ce.GetTo().CompareTo(from) >= 0 && ce.GetTo().CompareTo(to) <= 0)
                {
                    matchEvents.Add(ce);
                }
            }

            return matchEvents;
        }

        // Less than zero : If this instance is earlier than value.
        // Zero: If this instance is the same as value.
        // Greater than zero : If this instance is later than value.
        public bool isAvailable(DateTime from, DateTime to)
        {
            foreach (CalendarEvent ce in this.events)
            {                
                if (ce.GetFrom().Year == from.Year && 
                    ce.GetFrom().Month == from.Month &&
                    ce.GetFrom().Day == from.Day)
                {                    
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
