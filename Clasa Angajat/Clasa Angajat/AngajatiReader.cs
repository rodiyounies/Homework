using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Clasa_Angajat
{
    class AngajatiReader: Angajat
    {
        private String fileName;
        public AngajatiReader(String fileName)
        {
            this.fileName = fileName;
        }

        public List<Angajat> Read()
        {
            Console.WriteLine("Reading from [" + this.fileName + "]");

            List<Angajat> angajat = new List<Angajat>();
            string[] lines = File.ReadAllLines(this.fileName);
            CultureInfo provider = CultureInfo.InvariantCulture;
            foreach (string line in lines)
            {
                string[] tokens = line.Split(' ');
              
                string firstName =tokens[0];
                string lastName = tokens[1];
                DateTime employmentDate = DateTime.ParseExact(tokens[2], "dd/MM/yyyy", provider);

                Angajat a = new Angajat(firstName, lastName, employmentDate);
                angajat.Add(a);

            }

            return angajat;
        }

    }
}
