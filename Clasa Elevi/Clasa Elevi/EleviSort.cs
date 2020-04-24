using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Elevi
{
    class EleviSort
    {
        //met 1 de sortare bubble
        public void BubbleSort(List<Elev> elevi)
        {
            Elev tmp = new Elev();
            for (int j = 0; j <= elevi.Count - 2; j++)
            {
                for (int i = 0; i <= elevi.Count - 2; i++)
                {
                    if (elevi.ElementAt(i).CompareTo(elevi.ElementAt(i + 1)) < 0)
                    {
                        tmp.Copy(elevi.ElementAt(i + 1));
                        elevi.ElementAt(i + 1).Copy(elevi.ElementAt(i));
                        elevi.ElementAt(i).Copy(tmp);
                    }
                }
            }
        }

        //met2 de sortare (implementare diferita)
        public void Sort(List<Elev> elevi)
        {
            string temp_firstName;
            string temp_lastName;
            double temp_gradesArithmeticAverage;
            for (int j = 0; j <= elevi.Count - 2; j++)
            {
                for (int i = 0; i <= elevi.Count - 2; i++)
                {
                    if (elevi.ElementAt(i).CompareTo(elevi.ElementAt(i + 1)) < 0)
                    {
                        temp_firstName = elevi.ElementAt(i + 1).firstName;
                        temp_lastName = elevi.ElementAt(i + 1).lastName;
                        temp_gradesArithmeticAverage = elevi.ElementAt(i + 1).gradesArithmeticAverage;

                        elevi.ElementAt(i + 1).firstName = elevi.ElementAt(i).firstName;
                        elevi.ElementAt(i + 1).lastName = elevi.ElementAt(i).lastName;
                        elevi.ElementAt(i + 1).gradesArithmeticAverage = elevi.ElementAt(i).gradesArithmeticAverage;

                        elevi.ElementAt(i).firstName = temp_firstName;
                        elevi.ElementAt(i).lastName = temp_lastName;
                        elevi.ElementAt(i).gradesArithmeticAverage = temp_gradesArithmeticAverage;
                    }
                }
            }
        }
    }
}
