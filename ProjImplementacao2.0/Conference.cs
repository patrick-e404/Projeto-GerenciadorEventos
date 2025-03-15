using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImplementacao2._0
{
    public class Conference : IConference
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public List<string> Participantes { get; set; }

        public Conference(string titulo, DateTime data)
        {
            Titulo = titulo;
            Data = data;
            Participantes = new List<string>();
        }
        public override string ToString()
        {
            return $"{Titulo} - {Data.ToShortDateString()} (Conference)";
        }
    }
}
