using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteDocente_OFICIAL_
{
    public class Docente
    {
        public string NumeroControl { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Especialiad {  get; set; } = null!;  

        public List<Materia> ListadoMaterias { get; set; } = null!;
    }
}
