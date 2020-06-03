using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    class SubscriberA
    {
        public void ASubsHandler(int n)
        {
            Console.Write("Subscriber A received notification for the event" + n);
        }
    }
}
