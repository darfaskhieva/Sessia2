using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТелекомНеваСвязь
{
    public partial class Subscriber
    {
        public string FIO
        {
            get
            {
                return SubscriberSurname + " " + SubscriberName + " " + SubscriberPatronymic;
            }
        }
        
    }
}
