using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorHorarios
{
    public class pdfParser
    {
        public int SisMat { get; set; }
        public string NombreMateria { get; set; }
        public int Grupo { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }
    }
}
