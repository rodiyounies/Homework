using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class Angajat :IComparable

    {
        public string firstName;
        public string lastName;
        public DateTime employmentDate;

        public Angajat()
        {

        }

        public Angajat(string firstName, string lastName, DateTime employmentDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employmentDate = employmentDate;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Angajat angajat1 = obj as Angajat;
            if (this.firstName.Equals(angajat1.firstName))
            {
                int ret = angajat1.lastName.CompareTo(this.lastName);
                if (ret == 0)
                {
                    return 0;

                }
                else
                {
                    return ret;
                }
            }
            else 
            {
                return angajat1.firstName.CompareTo(this.firstName);
            }
        }


        public override string ToString()
        {
            return firstName + " " + lastName + " " + employmentDate;
        }
    }
}
