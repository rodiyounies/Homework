using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    /// <summary>Class member: Ledger (evidenta persoanelor si a calendarelor)
    /// Clasa folosita pt programarea(planificarea) unui eveniment (pt un grup de persoane) intr-un anumit interval de timp.
    /// </summary>
    class GreedyEventScheduler
    {
        private Ledger ledger;
        public GreedyEventScheduler(Ledger ledger)
        {
            this.ledger = ledger;
        }

        //14/04/2020 15:50
        public void ScheduleEvent(List<Person> persons, String eventName, DateTime from, int forHowLongInMinutes)
        {
            DateTime to = from.AddMinutes(forHowLongInMinutes);

            DateTime begin = from;
            DateTime end = to;
            bool foundEmptySlot;
            while (true)
            {
                foundEmptySlot = true;
                foreach (Person person in persons)
                {
                    Calendar c = ledger.getCalendar(person);
                    if(c.isAvailable(begin, end) == false){
                        foundEmptySlot = false;
                        break;
                    }
                }

                if(foundEmptySlot == true)
                {
                    break;
                }

                begin = begin.AddMinutes(15);
                end = begin.AddMinutes(forHowLongInMinutes);
            }

            if (foundEmptySlot == true)
            {
                foreach (Person person in persons)
                {
                    Calendar c = ledger.getCalendar(person);
                    c.AddEvent(eventName, begin, end);
                }
            }
        }


    }
}
