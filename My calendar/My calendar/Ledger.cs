using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    class Ledger
    {
        private List<Calendar> calendars;

        public Ledger()
        {
            this.calendars = new List<Calendar>();
        }

        public void AddCalendar(Calendar calendar)
        {
            this.calendars.Add(calendar);
        }

        public void Delete(Calendar calendar)
        {
            this.calendars.Remove(calendar);
        }

        public Calendar getCalendar(Person person)
        {
            Calendar calendar = null;
            foreach (Calendar c in calendars)
            {
                if (person.GetId().Equals(c.GetPerson().GetId()))
                {
                    calendar = c;
                    break;
                }
            }

            return calendar;
        }

        public Calendar getCalendar(String personId)
        {
            Calendar calendar = null;
            foreach (Calendar c in calendars)
            {
                if (personId.Equals(c.GetPerson().GetId()))
                {
                    calendar = c;
                    break;
                }
            }

            return calendar;
        }

        public List<CalendarEvent> GetEvents(String name)
        {
            List<CalendarEvent> matchEvents = new List<CalendarEvent>();
            foreach (Calendar calendar in calendars)
            {
                List<CalendarEvent>  cevents = calendar.GetEvents(name);
                if (cevents != null && cevents.Count() > 0) {
                    //Console.WriteLine("calendar of [" + calendar.GetPerson().GetId() + "] has: " + cevents.Count() + "events");
                    matchEvents.AddRange(cevents);
                }
            }

            return matchEvents;
        }

        public List<CalendarEvent> GetEvents(Person person, DateTime from, DateTime to)
        {
            List<CalendarEvent> matchEvents = new List<CalendarEvent>();
            Calendar calendar = getCalendar(person);
            if(calendar != null)
            {
                return calendar.GetEvents(from, to);
            }

            return matchEvents;
        }
    }
}
