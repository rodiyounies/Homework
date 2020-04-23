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
            CSVFileReadStrategy cSVFileReadStrategy = new CSVFileReadStrategy();
            List<Person> persons = cSVFileReadStrategy.ReadPeopleFile("C:\\development\\people.csv");
            //foreach(Person p in persons)
            //{
            //    Console.WriteLine(p);
            //}

            List<CalendarEvent> events = cSVFileReadStrategy.ReadEventsFile("C:\\development\\events.csv");
            //foreach (CalendarEvent ce in events)
            //{
            //    Console.WriteLine(ce);
            //}

            Ledger ledger = new Ledger();
            LedgerPopulator ledgerPopulator = new LedgerPopulator(ledger);
            ledgerPopulator.populate(persons, events);

            Calendar c = ledger.getCalendar("1");
            if (c != null)
            {
                Console.WriteLine("Found : " + c.GetPerson());

                // 1,Birthday Party,13/04/2020 11:00,13/04/2020 12:00
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

            
            Console.ReadKey();
        }
    }
}
