using FastReport.Export.PdfSimple;
using ReporteAulas_OFICIAL_;




//FastReport.Report report = new();
//report.Dictionary.RegisterBusinessObject(new List<FechaComplementario>(), "FechaComplementario", 2, true);

//report.Prepare();
//report.Save("ReporteOficialAulas.frx");




List<FechaComplementario> ListadoComplementarios = new List<FechaComplementario>();
ListadoComplementarios.Add(new FechaComplementario()
{
    Dia = "14 Feb 2014",
    ListadoExamenes = new List<ExamenCalendarizado>()
                {
                    new ExamenCalendarizado() {
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANA EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANE EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANI EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANU EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANW EDUARDO MEDRANO MENDOZA"
                    }
                }
});




ListadoComplementarios.Add(new FechaComplementario()
{
    Dia = "15 Feb 2014",
    ListadoExamenes = new List<ExamenCalendarizado>()
                {
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANA EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANE EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANI EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANU EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANW EDUARDO MEDRANO MENDOZA"
                    },
                    
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANA EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANE EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANI EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANU EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANW EDUARDO MEDRANO MENDOZA"
                    },

                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANA EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANE EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANI EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANU EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANW EDUARDO MEDRANO MENDOZA"
                    },

                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANA EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANE EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANI EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANU EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANW EDUARDO MEDRANO MENDOZA"
                    },

                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANA EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANE EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANI EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANO EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANU EDUARDO MEDRANO MENDOZA"
                    },
                    new ExamenCalendarizado() {
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00",
                        Docente = "M.C JUANW EDUARDO MEDRANO MENDOZA"
                    }
                }
});



FastReport.Report reporte2 = new();
reporte2.Load("ReporteOficialAulas.frx");
reporte2.RegisterData(ListadoComplementarios, "FechaComplementario");
reporte2.Prepare();

PDFSimpleExport pdf = new();
reporte2.Export(pdf, "ReporteOficialAulas.pdf");