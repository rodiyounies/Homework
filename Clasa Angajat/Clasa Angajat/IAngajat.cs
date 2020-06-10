using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    interface IAngajat
    {
        void Add(Angajat angajat);
        void  Remove(Angajat angajat);
        List<Angajat>  Sort(Comparison<Angajati> comparison);
    }
}
