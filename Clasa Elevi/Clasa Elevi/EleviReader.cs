using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Elevi
{
    class EleviReader
    {
        private String fileName;

        public EleviReader(String fileName)
        {
            this.fileName = fileName;
        }

        public List<Elev> Read()
        {
            Console.WriteLine("Reading from [" + this.fileName + "]");

            List<Elev> elevi = new List<Elev>();
            string[] lines = File.ReadAllLines(this.fileName);
            foreach (string line in lines)
            {
                string[] tokens = line.Split(' ');
                double gradesArithmeticAverage = 0;
                int gradesCount = int.Parse(tokens[2]);

                for (int i = 0; i < gradesCount; i++)
                {
                    gradesArithmeticAverage += double.Parse(tokens[3 + i]);
                }
                gradesArithmeticAverage = gradesArithmeticAverage / gradesCount;
                Elev v = new Elev(tokens[0], tokens[1], gradesArithmeticAverage);
                elevi.Add(v);

            }

            return elevi;
        }
    }
}
