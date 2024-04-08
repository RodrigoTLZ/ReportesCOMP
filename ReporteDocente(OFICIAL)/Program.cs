
using FastReport.Export.PdfSimple;
using ReporteDocente_OFICIAL_;



//FastReport.Report report = new();
//report.Dictionary.RegisterBusinessObject(new List<Docente>(), "Docentes", 2, true);

//report.Prepare();
//report.Save("ReporteOficialDocente.frx");


List<Docente> ListadoDocentes = new List<Docente>();
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "1234",
    Nombre = "M.C. ADRIANA RAMÍREZ HERNÁNDEZ",
    Especialiad = "Sistemas",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "ADMINISTRACION DE BASE DE DATOS",
                        Grupo = "6.1G",
                        Aula= "CCA1",
                        FechaComplementario = "21-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "ADMINISTRACION DE BASE DE DATOS",
                        Grupo = "2.1G",
                        Aula= "CCA1",
                        FechaComplementario = "24-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});

ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. JUAN EDUARDO MEDRANO MENDOZA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});

ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. BRISEIDA GARCIA ESPINOZA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});


ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. RODRIGO ELIAS CASTILLO",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});



ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});

ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});
ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});

ListadoDocentes.Add(new Docente()
{
    NumeroControl = "7234",
    Nombre = "M.C. MARIO BROS HERNANDEZ GARCIA",
    Especialiad = "Administración",
    ListadoMaterias = new List<Materia>()
                {
                    new Materia() {
                        Nombre = "GRAFICACION",
                        Grupo = "4.1G",
                        Aula= "CCA2",
                        FechaComplementario = "25-Abr-22",
                        HoraInicio = "12:00",
                        HoraFinal = "16:00"
                    },
                    new Materia() {
                        Nombre = "SISTEMAS OPERATIVOS",
                        Grupo = "5.1G",
                        Aula= "CCA6",
                        FechaComplementario = "27-Abr-22",
                        HoraInicio = "13:00",
                        HoraFinal = "17:00"
                    },
                    new Materia() {
                        Nombre = "FUNDAMENTOS DE BASE DE DATOS",
                        Grupo = "7.1G",
                        Aula= "CCA5",
                        FechaComplementario = "26-Abr-22",
                        HoraInicio = "10:00",
                        HoraFinal = "14:00"
                    },

                }
});



FastReport.Report reporte2 = new();
reporte2.Load("ReporteOficialDocente.frx");
reporte2.RegisterData(ListadoDocentes, "Docentes");
reporte2.Prepare();

PDFSimpleExport pdf = new();
reporte2.Export(pdf, "ReporteOficialDocente.pdf");