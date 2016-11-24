using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProgramacionPago
    {
        public int ProgramacionPagoId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Valor { get; set; }
        public string Estado { get; set; }

        public int ProyectoId { get; set; }
        public virtual Proyecto Proyecto { get; set; }
        
        public int FacturaId { get; set; }
        public virtual Facturas Factura { get; set; }
    }
}
