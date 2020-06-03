using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    class SubscrieberB
    {
        public void BSubsHandler(int n)
        {
            Console.Write("Subscriber B received notification for the event" + n);
        }
    }
}
