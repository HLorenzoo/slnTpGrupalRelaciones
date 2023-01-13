using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnTpGrupalRelaciones
{
    public class Materia
    {
        public Materia(string nombre, string programa)
        {
            Nombre = nombre;
            Programa = programa;
        }

        public string Nombre { get; set; }
        public string Programa { get; set; }
    }
}
