using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Elevi
{
    class EleviWriter
    {
        private String fileName;
        public EleviWriter(String fileName)
        {
            this.fileName = fileName;
        }
        public void Write(List<Elev> elevi)
        {
            Console.WriteLine("Writing to [" + this.fileName + "]");

            StreamWriter writer = new StreamWriter(this.fileName);
            foreach(Elev elev in elevi)
            {
                writer.WriteLine(elev);
            }

            writer.Close();
        }
    }
}
