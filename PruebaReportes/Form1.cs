using FastReport.Export.PdfSimple;

namespace PruebaReportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FastReport.Report report = new FastReport.Report();

            //report.Dictionary.RegisterBusinessObject(new List<Carrera>(), "Carreras", 2, true);

            //report.Prepare();
            //report.Save("carrera.frx");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Carrera> ListadoCarreras = new List<Carrera>();
            ListadoCarreras.Add(new Carrera()
            {
                Nombre = "Sistemas Computacionales",
                ListaAlumnos = new List<Alumno>() 
                {
                    new Alumno() {
                        Nombre = "Briseida",
                        NumeroControl = "123"
                    },
                    new Alumno() 
                    {
                        Nombre = "Jozelyn",
                        NumeroControl = "456"
                    }

                }
            });

            ListadoCarreras.Add(new Carrera()
            {
                Nombre = "Mecatronica",
                ListaAlumnos = new List<Alumno>()
                {
                    new Alumno() {
                        Nombre = "Eduardo",
                        NumeroControl = "643"
                    },
                    new Alumno()
                    {
                        Nombre = "ector",
                        NumeroControl = "942"
                    }

                }
            });

            FastReport.Report reporte2 = new();
            reporte2.Load("carrera.frx");
            reporte2.RegisterData(ListadoCarreras, "Carreras");
            reporte2.Prepare();

            PDFSimpleExport pdf = new();
            reporte2.Export(pdf,"reporte.pdf");

        }
    }
}
