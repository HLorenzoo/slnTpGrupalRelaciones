using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnTpGrupalRelaciones
{
    public class Clase
    {
        public Clase() { }
        public Clase(DateTime fin, DateTime inicio) 
        {
            Fin= fin;
            Inicio= inicio;
        }
        public DateTime Fin { get; set; }
        public DateTime Inicio { get; set; }
        public Aula Aula { get; set; }

    }
}
