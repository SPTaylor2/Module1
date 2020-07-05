using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_Events.Model
{
        public class deliveryInfo : EventArgs
        {
            public Person person;
            DateTime TimeReached;

            public deliveryInfo(Person deliverPerson)
            {
                person = deliverPerson;
                TimeReached = DateTime.Now;
            }
        }
}
