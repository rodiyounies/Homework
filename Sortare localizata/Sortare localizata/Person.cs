using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare_localizata
{
    class Person
    {
        private String FirstName;
        private String MiddleNames;
        private String LastName;

        public Person(String name)
        {
            String[] tokens = name.Split(' ');
            if(tokens.Length > 0)
            {
                this.LastName = tokens[0];
            }
            
            if(tokens.Length > 2)
            {
                this.MiddleNames = "";
                for(int i = 1; i < tokens.Length - 1; i++)
                {
                    this.MiddleNames += tokens[i];
                    if(i < tokens.Length - 2)
                    {
                        this.MiddleNames += " ";
                    }
                }
            }

            if(tokens.Length >= 2)
            {
                this.FirstName = tokens[tokens.Length - 1];
            }
        }

        public void setFirstName(String FirstName)
        {
           this.FirstName = FirstName;
        }
        public String getFirstName()
        {
            return this.FirstName;
        }

        public void setMiddleName(String MiddleNames)
        {
            this.MiddleNames = MiddleNames;
        }
        public String getMiddleName()
        {
            return this.MiddleNames;
        }

        public void setLastName(String LastName)
        {
            this.LastName = LastName;
        }
        public String getLastName()
        {
            return this.LastName;
        }

        public String getName()
        {
            StringBuilder buffer = new StringBuilder();

            if (this.LastName != null && this.LastName.Length > 0)
            {
                buffer.Append(this.LastName);
            }

            if (this.MiddleNames != null && this.MiddleNames.Length > 0)
            {
                buffer.Append(" ").Append(this.MiddleNames);
            }

            if (this.FirstName != null && this.FirstName.Length > 0)
            {
                buffer.Append(" ").Append(this.FirstName);
            }

            return buffer.ToString();
        }
    }
}
