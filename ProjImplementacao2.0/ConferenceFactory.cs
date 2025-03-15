using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImplementacao2._0
{
    public class ConferenceFactory : IEventFactory
    {
        public IEvent CreateEvent(string titulo, DateTime data)
        {
            return new Conference(titulo, data);
        }
    }
}
