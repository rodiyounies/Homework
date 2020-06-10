using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class Angajati : IAngajat
    {
        private List<Angajat> listaAngajati;

        public Angajati ()
        {
            this.listaAngajati = new List<Angajat>();
        }

        public List<Angajat> getList()
        {
            return this.listaAngajati;
        }
        public void Add(Angajat angajat)
        {
            this.listaAngajati.Add(angajat);
        }

        public void Remove(Angajat angajat)
        {
            this.listaAngajati.Remove(angajat);
        }

        public List<Angajat> Sort(AngajatSortEnum angajatSortEnum)
        {
            if(angajatSortEnum == AngajatSortEnum.ALPHABETICAL)
            {
                this.listaAngajati.Sort(AngajatiSorting.CompareByNames);
            } else if (angajatSortEnum == AngajatSortEnum.EMPLOYMENT_DATE)
            {
                this.listaAngajati.Sort(AngajatiSorting.CompareByEmploymentDate);
            }

            return this.listaAngajati;
        }
        public List<Angajat> Sort(Comparison<Angajati> comparison)
        {
            return null;
        }

        public void Print()
        {
            for (int i = 0; i < listaAngajati.Count; i++)
            {
                Console.WriteLine(listaAngajati.ElementAt(i));
            }

            Console.WriteLine();
        }
    }
}
