using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImplementacao2._0
{
    public interface IEvent
    {
        string Titulo { get; set; }
        DateTime Data { get; set; }
    }
}
