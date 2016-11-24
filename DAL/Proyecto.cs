using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Proyecto
    {
        public Proyecto()
        {
            ProgramacionPagos = new List<ProgramacionPago>();
        }
        
        public int ProyectoId { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaInicio { get; set; }
        public int Plazo { get; set; }
        public string Estado { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual List<ProgramacionPago> ProgramacionPagos { get; set; }
    }
}
