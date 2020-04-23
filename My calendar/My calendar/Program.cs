using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            CSVFileReadStrategy cSVFileReadStrategy = new CSVFileReadStrategy();
            List<Person> persons = cSVFileReadStrategy.ReadPeopleFile("C:\\development\\people.csv");
            List<CalendarEvent> events = cSVFileReadStrategy.ReadEventsFile("C:\\development\\events.csv");
            Console.WriteLine();
            Console.WriteLine();


            Ledger ledger = new Ledger();
            LedgerPopulator ledgerPopulator = new LedgerPopulator(ledger);
            ledgerPopulator.populate(persons, events);

            // Search Events by name
            program.SearchEventsByName(ledger);

            // Retrieving Events for a person or calendar using from/to limits
            program.RetrievingEvents(ledger);


            //Retrieving Person's Calendar
            program.RetrievingCalendar4Person(ledger);


            // delete Calendar
            program.DeleteCalendar(ledger);
            

            Console.ReadKey();
        }

        private void SearchEventsByName(Ledger ledger)
        {
            Console.WriteLine("Search Events for " + "`Birthday Party`");
            List<CalendarEvent> matchEvents = ledger.GetEvents("Birthday Party");
            Console.WriteLine("Found [" + matchEvents.Count() + "] events");
            foreach (CalendarEvent ce in matchEvents)
            {
                Console.WriteLine(ce);
            }
            Console.WriteLine();
        }

        
        private void RetrievingEvents(Ledger ledger)
        {
            Console.Write("Retrieving Events for person with id `3` - method #1 (match found) - ");
            Calendar c3 = ledger.getCalendar("3");
            DateTime from1 = DateTime.ParseExact("15/04/2020 08:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
            DateTime to1 = DateTime.ParseExact("15/04/2020 17:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("from/to: " + from1 + " - " + to1);
            List<CalendarEvent> windowEvents1 = ledger.GetEvents(c3.GetPerson(), from1, to1);
            foreach (CalendarEvent ce in windowEvents1)
            {
                Console.WriteLine(ce);
            }
            Console.WriteLine();
            ////////////////////////////////////////////////////////////////////////

            Console.Write("Retrieving Events for person with id `3` - method #2 (match found) - ");
            Calendar c4 = ledger.getCalendar("3");
            DateTime from2 = DateTime.ParseExact("15/04/2020 08:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
            DateTime to2 = DateTime.ParseExact("15/04/2020 11:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("from/to: " + from2 + " - " + to2);
            List<CalendarEvent> windowEvents2 = c4.GetEvents(from2, to2);
            foreach (CalendarEvent ce in windowEvents2)
            {
                Console.WriteLine(ce);
            }
            Console.WriteLine();

            Console.Write("Retrieving Events for person with id `3` - method #2 (NO match found) - ");
            Calendar c5 = ledger.getCalendar("3");
            DateTime from3 = DateTime.ParseExact("15/04/2020 12:01", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
            DateTime to3 = DateTime.ParseExact("15/04/2020 20:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("from/to: " + from3 + " - " + to3);
            List<CalendarEvent> windowEvents3 = c4.GetEvents(from3, to3);
            foreach (CalendarEvent ce in windowEvents3)
            {
                Console.WriteLine(ce);
            }
            Console.WriteLine();
        }

        private void RetrievingCalendar4Person(Ledger ledger)
        {
            Console.WriteLine("Retrieving Calendar for person with id `1`");
            Calendar c = ledger.getCalendar("1");
            if (c != null)
            {
                Console.WriteLine("Calendar Owner is : " + c.GetPerson());
                Console.WriteLine("Calendar has : " + c.GetEvents().Count() + " events");

                //1,Birthday Party,13 / 04 / 2020 11:00,13 / 04 / 2020 12:00
                DateTime from1 = DateTime.ParseExact("13/04/2020 08:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                DateTime to1 = DateTime.ParseExact("13/04/2020 09:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                bool isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);

                from1 = DateTime.ParseExact("13/04/2020 13:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                to1 = DateTime.ParseExact("13/04/2020 14:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);

                from1 = DateTime.ParseExact("13/04/2020 11:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                to1 = DateTime.ParseExact("13/04/2020 12:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);

                from1 = DateTime.ParseExact("13/04/2020 10:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                to1 = DateTime.ParseExact("13/04/2020 11:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);

                from1 = DateTime.ParseExact("13/04/2020 13:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                to1 = DateTime.ParseExact("13/04/2020 14:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);

                from1 = DateTime.ParseExact("13/04/2020 09:00", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                to1 = DateTime.ParseExact("13/04/2020 11:30", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);

                from1 = DateTime.ParseExact("13/04/2020 11:30", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                to1 = DateTime.ParseExact("13/04/2020 12:30", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);

                from1 = DateTime.ParseExact("13/04/2020 11:30", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                to1 = DateTime.ParseExact("13/04/2020 11:45", "d/M/yyyy HH:mm", CultureInfo.InvariantCulture);
                isAvailable = c.isAvailable(from1, to1);
                Console.WriteLine("isAvailable : " + isAvailable);
            }
            Console.WriteLine();
        }

        private void DeleteCalendar(Ledger ledger)
        {
            Console.WriteLine("Removing Calendar of Person with id 3");
            Calendar cdelete = ledger.getCalendar("3");
            if (cdelete != null)
            {
                ledger.Delete(cdelete);
            }
            cdelete = ledger.getCalendar("3");
            if (cdelete == null)
            {
                Console.WriteLine("Calendar is deleted");
            }
        }
    }
}
