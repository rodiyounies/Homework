using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    class Publisher
    {
        public event Iteration Eveniment;
        public void DeclansareEveniment(int n)
        {
            for(int i=0; i<n; i++)
            {
                if(Eveniment!=null)
                {
                    Eveniment(n);
                }
            }
        }
    }
}
