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

        public void RemoveCalendar(Calendar calendar)
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
    }
}
