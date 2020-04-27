using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    /// <summary>Class memebers: name, from, to, personID. 
    /// Clasa creata pt gestionarea unui eveniment. 
    /// </summary>
    class CalendarEvent
    {
        private String name;
        private DateTime from;
        private DateTime to;
        private String personId;

        public CalendarEvent()
        {

        }
        
        public void SetName(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return this.name;
        }


        public void SetFrom(DateTime from)
        {
            this.from = from;
        }

        public DateTime GetFrom()
        {
            return this.from;
        }

        public void SetTo(DateTime to)
        {
            this.to = to;
        }

        public DateTime GetTo()
        {
            return this.to;
        }

        public void SetPersonId(String personId)
        {
            this.personId = personId;
        }

        public String GetPersonId()
        {
            return this.personId;
        }

        public override String ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("[");
            buffer.Append("Person Id = ").Append(this.personId).Append(", ");
            buffer.Append("Name = ").Append(this.name).Append(", ");
            buffer.Append("From = ").Append(this.from).Append(", ");
            buffer.Append("To = ").Append(this.to);
            buffer.Append("]");

            return buffer.ToString();
        }
    }
}
