using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Names
{
    class Names
    {
        private string[] names;
        public int dimensiune;
        public bool err;
        public Names(List<string> values)
        {
            dimensiune = values.Count();
            names = new string[values.Count()];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = values.ElementAt(i);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < dimensiune)
                {
                    err = false;
                    return names[index];
                }
                else
                {
                    err = true;
                    return index + ": Index out of range";
                }
            }
            set
            {
                if (index >= 0 && index < dimensiune)
                {
                    names[index] = value;
                    err = false;
                }
                else
                    err = true;
            }
        }
        public string this[string index]
        {
            get
            {
                int i = 0;
                try
                {
                    i=int.Parse(index);
                }
                catch(FormatException)
                {
                    err = true;
                    return index + ": Number format exception!";
                }
                catch (ArgumentNullException)
                {
                    err = true;
                    return index + ": Argument Null Exception!";
                }
                catch (OverflowException)
                {
                    err = true;
                    return index + ": Overflow Exception!";
                }

                if (i >= 0 && i < dimensiune)
                {
                    err = false;
                    return names[i];                       
                }
                else
                {
                    err = true;
                    return i + ": Index out of range";
                }
            }
        }
    }
}
