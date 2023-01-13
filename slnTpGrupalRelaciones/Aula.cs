using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnTpGrupalRelaciones
{
    public class Aula
    {
        public Aula() { }
        public Aula(int capacidad, string codigo)
        {
           Capacidad= capacidad;
           Codigo= codigo;  
        }
        public int Capacidad { get; set; }
        public string Codigo { get; set; }
        public Clase Clase { get; set; }

    }
}
