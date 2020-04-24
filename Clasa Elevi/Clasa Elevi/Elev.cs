using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Elevi
{

    class Elev: IComparable
    {
        public Elev()
        {

        }

        public Elev (string firstName, string lastName, double gradesArithmeticAverage)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gradesArithmeticAverage = gradesArithmeticAverage;
        }
        
        public string firstName {set; get; }
        public string lastName {set; get; }
        public double gradesArithmeticAverage { set; get; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Elev elev1 = obj as Elev;
            if (this.gradesArithmeticAverage == elev1.gradesArithmeticAverage)
            {
                int ret= elev1.firstName.CompareTo(this.firstName);
                if (ret == 0)
                {
                    return elev1.lastName.CompareTo(this.lastName);

                }
                else
                    return ret;
            }
           
            else if (this.gradesArithmeticAverage > elev1.gradesArithmeticAverage)
            {
                return 1;
            }
            else return -1;

        }


        public void Copy(Elev a)
        {
            this.firstName = a.firstName;
            this.lastName = a.lastName;
            this.gradesArithmeticAverage = a.gradesArithmeticAverage;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + gradesArithmeticAverage;
        }

    }
}
