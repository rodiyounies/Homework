using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    class EventScheduler
    {
        private Ledger ledger;
        public EventScheduler(Ledger ledger)
        {
            this.ledger = ledger;
        }

        //14/04/2020 15:50
        public void ScheduleEvent(List<Person> persons, DateTime from, int forHowLong)
        {
            //for (increment every 30 min) {
            //    //DateTime to = add forHowLong to from;

            //    bool available = true;
            //    foreach (Person person in persons)
            //    {
            //        Calendar c = this.ledger.getCalendar(person);
            //        if (c.isAvailable(from, to) == false)
            //        {
            //            available = false;
            //            break;
            //        }
            //    }
            //}
        }


    }
}
