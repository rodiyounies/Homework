using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class AngajatiSorting
    {
        public static int CompareByNames(Angajat angajat1, Angajat angajat2)
        {
            if (angajat2.firstName.Equals(angajat1.firstName))
            {
                int ret = angajat1.lastName.CompareTo(angajat2.lastName);
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
                return angajat1.firstName.CompareTo(angajat2.firstName);
            }
        }

        public static int CompareByEmploymentDate(Angajat angajat1, Angajat angajat2)
        {
            return angajat1.employmentDate.CompareTo(angajat2.employmentDate);
        }
    }
}
