
using CONSOLAReporte;
using FastReport.Export.PdfSimple;




//FastReport.Report report = new();
//report.Dictionary.RegisterBusinessObject(new List<Docente>(), "Docentes", 2, true);

//report.Prepare();
//report.Save("reportedocente.frx");

List<Docente> ListadoDocentes = new List<Docente>();
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "2004",
    Nombre = "M.C. ADRIANA RAMÍREZ HERNÁNDEZ",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Clave = "SCB-1001",
                        Nombre = "ADMINISTRACION DE BASE DE DATOS",
                        Grupo = "6.1G"
                    },
                    new Materia() {
                        Clave = "SCB-1001",
                        Nombre = "ADMINISTRACION DE BASE DE DATOS",
                        Grupo = "6.3G"
                    },
                     new Materia() {
                        Clave = "INC-1005",
                        Nombre = "ALGORITMOS Y LENGUAJES DE PROGRAMACIÓN",
                        Grupo = "4.1D"
                    }

                }
});

ListadoDocentes.Add(new Docente()
{
    NumeroControl = "2202",
    Nombre = "M.I. JUAN JOSÉ REYES HERNÁNDEZ",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Clave = "SCD-1015",
                        Nombre = "LENGUAJES Y AUTOMATAS I",
                        Grupo = "6.1G"
                    },
                    new Materia() {
                        Clave = "SCD-1015",
                        Nombre = "LENGUAJES Y AUTOMATAS I",
                        Grupo = "6.3G"
                    },
                     new Materia() {
                        Clave = "ACA-0907",
                        Nombre = "TALLER DE ÉTICA",
                        Grupo = "2.3A"
                    }

                }
});


ListadoDocentes.Add(new Docente()
{
    NumeroControl = "2202",
    Nombre = "M.I. JUAN JOSÉ REYES HERNÁNDEZ",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Clave = "SCD-1015",
                        Nombre = "LENGUAJES Y AUTOMATAS I",
                        Grupo = "6.1G"
                    },
                    new Materia() {
                        Clave = "SCD-1015",
                        Nombre = "LENGUAJES Y AUTOMATAS I",
                        Grupo = "6.3G"
                    },
                     new Materia() {
                        Clave = "ACA-0907",
                        Nombre = "TALLER DE ÉTICA",
                        Grupo = "2.3A"
                    },

                     new Materia() {
                        Clave = "SCD-1015",
                        Nombre = "LENGUAJES Y AUTOMATAS I",
                        Grupo = "6.1G"
                    },

                     new Materia() {
                        Clave = "SCD-1015",
                        Nombre = "LENGUAJES Y AUTOMATAS I",
                        Grupo = "6.1G"
                    }

                }
});


FastReport.Report reporte2 = new();
reporte2.Load("reportedocente.frx");
reporte2.RegisterData(ListadoDocentes, "Docentes");
reporte2.Prepare();

PDFSimpleExport pdf = new();
reporte2.Export(pdf, "reportedocente.pdf");