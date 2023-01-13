using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnTpGrupalRelaciones
{
    public abstract class Persona
    {
        public Persona(string apellido, string nombre) 
        {
            Nombre = nombre;
            Apellido= apellido;

        }
        public string Apellido { get; set; }
        public string Nombre { get; set;}
    }
}
