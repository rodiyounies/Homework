using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    /// <summary>
    /// Clasa folosita pt crearea persoanelor 
    /// </summary>
    class ObjectsFactory
    {
        public ObjectsFactory()
        {

        }

        public Person CreatePerson(String id, String firstName, String lastName, String email, String dob)
        {
            Person p = new Person();

            DateTime dt = DateTime.ParseExact(dob, "d/M/yyyy", CultureInfo.InvariantCulture);

            p.SetId(id);
            p.SetFirstName(firstName);
            p.SetLastName(lastName);
            p.SetEmail(email);
            p.SetDOB(dt);

            return p;
        }

        public CalendarEvent CreateEvent(String personId, String name, String from, String to)
        {
            CalendarEvent ce = new CalendarEvent();

            DateTime dtFrom = DateTime.ParseExact(from, "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
            DateTime dtTo = DateTime.ParseExact(to, "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);

            ce.SetPersonId(personId);
            ce.SetName(name);
            ce.SetFrom(dtFrom);
            ce.SetTo(dtTo);
            
            return ce;
        }

        public CalendarEvent CreateEvent(String personId, String name, DateTime dtFrom, DateTime dtTo)
        {
            CalendarEvent ce = new CalendarEvent();

            ce.SetPersonId(personId);
            ce.SetName(name);
            ce.SetFrom(dtFrom);
            ce.SetTo(dtTo);

            return ce;
        }
    }
}
