using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImplementacao2._0
{
    public class Workshop : IWorkshop
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public List<string> Atividades { get; set; }

        public Workshop(string titulo, DateTime data)
        {
            Titulo = titulo;
            Data = data;
            Atividades = new List<string>();
        }
        public override string ToString()
        {
            return $"{Titulo} - {Data.ToShortDateString()} (Workshop)";
        }
    }
}
