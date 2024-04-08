using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteGrupos_OFICIAL_
{
    public class Grupo
    {
        public string Nombre { get; set; } = null!;
        public string Carrera { get; set; } = null!;

        public List<Materia> ListadoMaterias { get; set; } = null!;
    }
}
