using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteDocente_OFICIAL_
{
    public class Materia
    {
        public string Nombre { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public string Aula { get; set;} = null!;
        public string FechaComplementario { get; set; } = null!;
        public string HoraInicio { get; set; } = null!;
        public string HoraFinal {  get; set; } = null!;
    }
}
