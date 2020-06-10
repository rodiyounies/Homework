using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class DateUtils
    {
        public static string Duration(DateTime date)
        {
            DateTime now = DateTime.Now;
            int yearsDifference = now.Year - date.Year;
            int monthsDifference = MonthDifference(now, date) - (12 * yearsDifference);
            if(monthsDifference < 0)
            {
                --yearsDifference;
                monthsDifference += 12;
            }

            return yearsDifference + " " + "Years & " + monthsDifference + " " + "Months";
        }

        public static int MonthDifference(DateTime a, DateTime b)
        {
            var yearDifferenceInMonths = (a.Year - b.Year) * 12;
            var monthDifference = a.Month - b.Month;
            return yearDifferenceInMonths + monthDifference + ((a.Day > b.Day)? 1 : 0); 
        }
    }
}
