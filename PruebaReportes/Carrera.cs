using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaReportes
{
    public class Carrera
    {
        public string Nombre { get; set; } = "";
        public List<Alumno> ListaAlumnos { get; set; } = null!;
    }
}
