using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Facturas
    {
        public Facturas()
        {
            ItemFacturas = new List<ItemFactura>();
        }
        
        public int FacturasId { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroFactura { get; set; }

        // public int ProgramacionPagoId { get; set; }
        // public virtual ProgramacionPago ProgranacionPago { get; set; }
        
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual List<ItemFactura> ItemFacturas { get; set; }
    }
}
