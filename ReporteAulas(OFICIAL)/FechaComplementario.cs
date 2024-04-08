using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteAulas_OFICIAL_
{
    public class FechaComplementario
    {
        public string Dia { get; set; } = null!;
        public List<ExamenCalendarizado> ListadoExamenes { get; set; } = null!;
    }
}
