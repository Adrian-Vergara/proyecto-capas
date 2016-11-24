using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemFactura
    {
        public int ItemFacturaId { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public int Cantidad { get; set; }
        public decimal Iva { get; set; }
        public int FacturaId { get; set; }
        public virtual Facturas Factura { get; set; }
    }
}
