using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasa_Angajat
{
    class AngajatiWriter
    {
        private String fileName;
        public AngajatiWriter(String fileName)
        {
            this.fileName = fileName;
        }
        public void WriteNames(List<Angajat> angajati)
        {
            Console.WriteLine("Writing to [" + this.fileName + "]");

            StreamWriter writer = new StreamWriter(this.fileName);
            foreach (Angajat angajat in angajati)
            {
                writer.WriteLine(angajat.firstName + " " + angajat.lastName);
            }

            writer.Close();
        }

        public void WriteEmployment(List<Angajat> angajati)
        {
            Console.WriteLine("Writing to [" + this.fileName + "]");

            StreamWriter writer = new StreamWriter(this.fileName);
            foreach (Angajat angajat in angajati)
            {
                string duration = DateUtils.Duration(angajat.employmentDate);
                writer.WriteLine(angajat.firstName + " " + angajat.lastName + " " + duration);
            }

            writer.Close();
        }
    }
}
