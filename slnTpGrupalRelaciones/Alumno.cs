using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnTpGrupalRelaciones
{
    public class Alumno:Persona
    {
        public Alumno(string apellido, string nombre, bool regular):base(apellido, nombre) 
        {
            Regular = regular;
        }
        public bool Regular { get; set; }
        public Curso Curso { get; set; }

    }
}
