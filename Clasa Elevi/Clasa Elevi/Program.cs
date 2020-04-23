using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasa_Elevi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elev> elevi = new List<Elev>();
            string[] lines = File.ReadAllLines("C:\\development\\strudents.txt");
            foreach (string line in lines)
            {
                string[] tokens = line.Split(' ');
                double gradesArithmeticAverage = 0;
                int gradesCount = int.Parse(tokens[2]);

                for (int i=0; i< gradesCount; i++)
                {
                    gradesArithmeticAverage += double.Parse(tokens[3 + i]);
                }
                gradesArithmeticAverage = gradesArithmeticAverage / gradesCount;
                Elev v = new Elev(tokens[0], tokens[1], gradesArithmeticAverage);
                elevi.Add(v);

            }

            Console.WriteLine("Elevi before sorting");
            foreach (Elev v in elevi)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            Console.WriteLine();

            //sort students 
            string temp_firstName;
            string temp_lastName;
            double temp_gradesArithmeticAverage;
            for (int j = 0; j <= elevi.Count - 2; j++)
            {
                for (int i = 0; i <= elevi.Count - 2; i++)
                {
                    if (elevi.ElementAt(i).CompareTo(elevi.ElementAt(i+1)) < 0) 
                    {
                        temp_firstName = elevi.ElementAt(i+1).firstName;
                        temp_lastName = elevi.ElementAt(i+1).lastName;
                        temp_gradesArithmeticAverage = elevi.ElementAt(i+1).gradesArithmeticAverage;

                        elevi.ElementAt(i+1).firstName = elevi.ElementAt(i).firstName;
                        elevi.ElementAt(i+1).lastName = elevi.ElementAt(i).lastName;
                        elevi.ElementAt(i+1).gradesArithmeticAverage = elevi.ElementAt(i).gradesArithmeticAverage;

                        elevi.ElementAt(i).firstName = temp_firstName;
                        elevi.ElementAt(i).lastName = temp_lastName;
                        elevi.ElementAt(i).gradesArithmeticAverage = temp_gradesArithmeticAverage;
                    }
                }
            }

            Console.WriteLine("Elevi after sorting");
            foreach (Elev v in elevi)
            {
                Console.WriteLine(v);
            }

            Console.ReadKey();
        }
    }
}
