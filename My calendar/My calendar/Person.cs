using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    /// <summary>Class members: id, firstName, lastName, dob(date of birth), email. 
    /// Entity class- reprezinta abstractizarea persoanei (se pot adauga oricati membri dorim sau de cati avem nevoie)
    /// </summary>
    class Person
    {
        private String id;
        private String firstName;
        private String lastName;
        private DateTime dob;
        private String email;

        public Person()
        {
            this.id = "";
            this.firstName = "";
            this.lastName = "";
            this.email = "";
        }

        public void SetId(String id)
        {
            this.id = id;
        }

        public String GetId()
        {
            return this.id;
        }

        public void SetFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String GetFirstName()
        {
            return this.firstName;
        }

        public void SetLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String GetLastName()
        {
            return this.lastName;
        }

        public String GetName()
        {
            return this.firstName + " " + this.lastName;
        }

        public void SetEmail(String email)
        {
            this.email = email;
        }

        public String GetEmail()
        {
            return this.email;
        }

        public void SetDOB(DateTime dob)
        {
            this.dob = dob;
        }

        public DateTime GetDOB()
        {
            return this.dob;
        }

        public override String ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("[");
            buffer.Append("First Name = ").Append(this.firstName).Append(", ");
            buffer.Append("Last Name = ").Append(this.lastName).Append(", ");
            buffer.Append("Email = ").Append(this.email).Append(", ");
            buffer.Append("DOB = ").Append(this.dob.ToString("d/M/yyyy"));
            buffer.Append("]");

            return buffer.ToString();
        }
    }
}
