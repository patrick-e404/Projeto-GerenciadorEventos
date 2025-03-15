using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImplementacao2._0
{
    public class Participante : IEventObserver
    {
        public string Name { get; set; }

        public Participante(string name)
        {
            Name = name;
        }

        public void Update(List<IEvent> events)
        {
            Console.WriteLine($"Participante {Name} foi notificado do seguinte evento: ");
            foreach (var ev in events)
            {
                Console.WriteLine($"- {ev.Titulo} - {ev.Data}");
            }
        }
    }
}
