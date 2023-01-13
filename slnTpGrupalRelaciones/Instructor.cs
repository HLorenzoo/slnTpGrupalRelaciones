using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnTpGrupalRelaciones
{
    public class Instructor: Persona
    {
        public Instructor(string nombre, string apellido): base(nombre, apellido)
        {
            
        }

        public List<Materia> Materias { get; set; }
        public Curso Curso { get; set; }
    }
}
