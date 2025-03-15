using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImplementacao2._0
{
    public class WorkshopFactory : IEventFactory
    {
        public IEvent CreateEvent(string titulo, DateTime data)
        {
            return new Workshop(titulo, data);
        }
    }
}
