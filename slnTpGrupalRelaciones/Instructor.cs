using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnTpGrupalRelaciones
{
    public class Instructor: Persona
    {
        public Instructor(string nombre, string apellido, List<Materia> materias): base(nombre, apellido)
        {
            Materias = materias;
        }

        public List<Materia> Materias { get; set; }
    }
}
